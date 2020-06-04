using Reyuko.BLL.Core;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Reyuko.App.Views.SalaryGroup
{
    /// <summary>
    /// </summary>
    public partial class SalaryGroup : UserControl
    {
        public SalaryGroup()
        {
            InitializeComponent();
            this.Init();
        }

        public IEnumerable<GolonganKontak> GolonganKontaks { get; set; }
        public GolonganKontak GolonganKontakSelected { get; set; }
        public bool isEdit = false;
        private IEnumerable<GolonganKontak> GolonganKontakChilds { get; set; }
        private int pageIndex = 1;
        private int pageSize = 10;

        private void Init()
        {
            this.ClearForm();
            this.LoadGolonganKontak("");
        }

        private void ClearForm()
        {
            this.GolonganKontakSelected = null;
            txtPositionGroupName.Text = "";
            txtBasicSalary.Text = "0";
            txtAllowance.Text = "0";
            txtOvertime.Text = "0";
            txtTax.Text = "";
        }

        public void LoadGolonganKontak(string groupName)
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.GolonganKontaks = uow.GolonganKontak.GetAll();
                List<GolonganKontak> itemSource = new List<GolonganKontak>();
                if (!string.IsNullOrEmpty(groupName))
                    itemSource = this.GolonganKontaks.Where(m => m.NamaGolongan.Contains(groupName)).ToList();
                else
                    itemSource = this.GolonganKontaks.ToList();
                LISalaryGroup.ItemsSource = this.GolonganKontaks;
            }
        }


        private void BtnNewSalaryGroup_Clicks(object sender, RoutedEventArgs e)
        {
            this.isEdit = false;
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is NewSalaryGroup)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                NewSalaryGroup period = new NewSalaryGroup(this);
                period.Show();
            }
        }

        private void BtnEditSalaryGroup_Clicks(object sender, RoutedEventArgs e)
        {
            this.isEdit = true;
            NewSalaryGroup v = new NewSalaryGroup(this);
            v.Show();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (this.GolonganKontakSelected == null)
            {
                MessageBox.Show("Salary Group has not been selected !");
            }
            else
            {
                GolonganKontakBLL GolonganKontakBLL = new GolonganKontakBLL();
                if (GolonganKontakBLL.RemoveGolonganKontak(this.GolonganKontakSelected.Id) == true)
                {
                    MessageBox.Show("Salary Group was deleted successfully");
                    this.LoadGolonganKontak("");
                    this.GolonganKontakSelected = null;
                }
            }
        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LISalaryGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.ClearForm();
            if (LISalaryGroup.SelectedItem != null)
            {
                this.GolonganKontakSelected = (GolonganKontak)LISalaryGroup.SelectedItem;
                txtPositionGroupName.Text = this.GolonganKontakSelected.NamaGolongan;
                txtBasicSalary.Text = this.GolonganKontakSelected.GajiPokok.GetValueOrDefault(0).ToString();
                txtAllowance.Text = this.GolonganKontakSelected.Tunjangan.GetValueOrDefault(0).ToString();
                txtOvertime.Text = this.GolonganKontakSelected.OvertimeHour.GetValueOrDefault(0).ToString();
                txtTax.Text = "Exclude";
                if (this.GolonganKontakSelected.IncludeExcludePajak.GetValueOrDefault() == true)
                    txtTax.Text = "Include";
            }
        }

        private void TxtSearch_FocusableChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.LoadGolonganKontak(txtSearch.SearchText);
        }
    }
}

