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

namespace Reyuko.App.Views.CustomerGroup
{
    /// <summary>
    /// </summary>
    public partial class CustomerGroup : UserControl
    {
        public CustomerGroup()
        {
            InitializeComponent();
            this.Init();
        }

        public IEnumerable<GrupDiskon> GrupDiskons { get; set; }
        public GrupDiskon GrupDiskonSelected { get; set; }
        public bool isEdit = false;
        private IEnumerable<GrupDiskon> GrupDiskonChilds { get; set; }
        private int pageIndex = 1;
        private int pageSize = 10;

        private void Init()
        {
            this.ClearForm();
            this.LoadGrupDiskon("");
        }

        private void ClearForm()
        {
            this.GrupDiskonSelected = null;
            txtIDCustomerGroup.Text = "";
            txtGroupName.Text = "";
            txtDiscount.Text = "0";
            txtNote.Text = "";
        }

        public void LoadGrupDiskon(string groupName)
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.GrupDiskons = uow.GrupDiskon.GetAll();
                List<GrupDiskon> itemSource = new List<GrupDiskon>();
                if (!string.IsNullOrEmpty(groupName))
                    itemSource = this.GrupDiskons.Where(m => m.NamaGroupDiskon.Contains(groupName)).ToList();
                else
                    itemSource = this.GrupDiskons.ToList();
                LICustomerGroup.ItemsSource = this.GrupDiskons;
            }
        }


        private void BtnNewCustomerGroup_Clicks(object sender, RoutedEventArgs e)
        {
            this.isEdit = false;
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is NewCustomerGroup)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                NewCustomerGroup period = new NewCustomerGroup(this);
                period.Show();
            }
        }

        private void BtnEditCustomerGroup_Clicks(object sender, RoutedEventArgs e)
        {
            this.isEdit = true;
            NewCustomerGroup v = new NewCustomerGroup(this);
            v.Show();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (this.GrupDiskonSelected == null)
            {
                MessageBox.Show("Customer Group not yet selected !");
            }
            else
            {
                GrupDiskonBLL GrupDiskonBLL = new GrupDiskonBLL();
                if (GrupDiskonBLL.RemoveGrupDiskon(this.GrupDiskonSelected.Id) == true)
                {
                    MessageBox.Show("Customer Group successfully deleted");
                    this.LoadGrupDiskon("");
                    this.GrupDiskonSelected = null;
                }
            }
        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LICustomerGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.ClearForm();
            if (LICustomerGroup.SelectedItem != null)
            {
                this.GrupDiskonSelected = (GrupDiskon)LICustomerGroup.SelectedItem;
                txtIDCustomerGroup.Text = this.GrupDiskonSelected.Id.ToString();
                txtGroupName.Text = this.GrupDiskonSelected.NamaGroupDiskon;
                txtDiscount.Text = this.GrupDiskonSelected.Diskon.GetValueOrDefault(0).ToString();
                txtNote.Text = this.GrupDiskonSelected.Keterangan;
            }
        }

        
    }
}

