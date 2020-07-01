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
using Reyuko.BLL.Core;

namespace Reyuko.App.Views.Project
{
    /// <summary>
    /// </summary>
    public partial class Project : UserControl
    {
        public Project()
        {
            InitializeComponent();
            Switcher.pageSwitchproject = this;
            this.Init();

        }
        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        public IEnumerable<DataProyek> DataProyeks { get; set; }
        public DataProyek DataProyekSelected { get; set; }
        public bool isEdit = false;
        private int pageIndex = 1;
        private int pageSize = 10;

        private void Init()
        {
            this.ClearForm();
            this.LoadDataProyek("");
        }

        private void ClearForm()
        {
            this.DataProyekSelected = null;
            txtProjectNo.Text = "";
            txtProjectName.Text = "";
            txtCustomer.Text = "";
            txtPIC.Text = "";
            txtCurrency.Text = "";
            txtContractprice.Text = "";
            txtStartProject.Text = "";
            txtEndProject.Text = "";
            txtStatus.Text = "";
            txtRemarks.Text = "";
        }

        public void LoadDataProyek(string NamaProyek)
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.DataProyeks = uow.DataProyek.GetAll();
                List<DataProyek> itemSource = new List<DataProyek>();
                if (!string.IsNullOrEmpty(NamaProyek))
                    itemSource = this.DataProyeks.Where(m => m.NamaProyek.Contains(NamaProyek)).ToList();
                else
                    itemSource = this.DataProyeks.ToList();
                LIProject.ItemsSource = itemSource;
            }
        }

        private void BtnNewProject_Click(object sender, RoutedEventArgs e)
        {
            this.isEdit = false;
            NewProject v = new NewProject(this);
            Switcher.Switchproject(v);
        }
        private void BtnEditProject_Click(object sender, RoutedEventArgs e)
        {
            this.isEdit = true;
            NewProject v = new NewProject(this);
            Switcher.Switchproject(v);
        }
        private void Print_Clicks(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is Print.Print)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                Print.Print print = new Print.Print();
                print.Show();
            }
        }
        private void NewDocument_Click(object sender, RoutedEventArgs e)
        {

        }
        private void NewInternalNotes_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ViewInactived_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataProyekSelected == null)
            {
                MessageBox.Show("Project not selected !");
            }
            else
            {
                DataProyekBLL DataProyekBLL = new DataProyekBLL();
                this.DataProyekSelected.CheckboxInAtive = true;
                if (DataProyekBLL.EditDataProyek(this.DataProyekSelected) == true)
                {
                    MessageBox.Show("Project successfully deleted");
                    this.LoadDataProyek("");
                    this.DataProyekSelected = null;
                }
            }

        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LIProject_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.ClearForm();
            if (LIProject.SelectedItem != null)
            {
                this.DataProyekSelected = (DataProyek)LIProject.SelectedItem;
                if (this.DataProyekSelected != null)
                {
                    txtProjectNo.Text = this.DataProyekSelected.NomorProyek;
                    txtProjectName.Text = this.DataProyekSelected.NamaProyek;
                    txtCustomer.Text = this.DataProyekSelected.PemesanKontak;
                    txtPIC.Text = this.DataProyekSelected.PICKontak;
                    txtCurrency.Text = this.DataProyekSelected.MataUang;
                    txtContractprice.Text = this.DataProyekSelected.NilaiProyek.ToString();
                    txtStartProject.Text = this.DataProyekSelected.TanggalMulai.ToString();
                    txtEndProject.Text = this.DataProyekSelected.TanggalBerakhir.ToString();
                    txtStatus.Text = this.DataProyekSelected.Status;
                    txtRemarks.Text = this.DataProyekSelected.Keterangan;

                    using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
                    {
                        var teams = uow.Kontak.Find(m => m.TypeKontak.ToLower() == "employee" && m.IdProyek == this.DataProyekSelected.Id).ToList();
                        DGTeam.ItemsSource = teams;
                    }
                }
            }
        }
    }
}

