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

namespace Reyuko.App.Views.Department
{
    /// <summary>
    /// </summary>
    public partial class Department : UserControl
    {
        public Department()
        {
            InitializeComponent();
            this.Init();
        }


        public IEnumerable<ListDataDepartemen> ListDataDepartemens { get; set; }
        public ListDataDepartemen ListDataDepartemenSelected { get; set; }
        public DataDepartemen DataDepartemen { get; set; }
        public bool isEdit = false;
        private int pageIndex = 1;
        private int pageSize = 10;

        private void Init()
        {
            this.ClearForm();
            this.LoadDataDepartemen("");
        }

        private void ClearForm()
        {
            this.ListDataDepartemenSelected = null;
            txtDepartmentCode.Text = "";
            txtDepartmentName.Text = "";
            txtSubDepartment.Text = "";
            txtPIC.Text = "";
            txtRemarks.Text = "";
        }

        public void LoadDataDepartemen(string NamaDepartemen)
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.ListDataDepartemens = uow.ListDataDepartemen.GetAll();
                List<ListDataDepartemen> itemSource = new List<ListDataDepartemen>();
                if (!string.IsNullOrEmpty(NamaDepartemen))
                    itemSource = this.ListDataDepartemens.Where(m => m.NamaDepartemen.Contains(NamaDepartemen)).ToList();
                else
                    itemSource = this.ListDataDepartemens.ToList();
                LIDepartment.ItemsSource = itemSource;
            }
        }


        private void BtnNewDepartment_Clicks(object sender, RoutedEventArgs e)
        {
            this.isEdit = false;
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is NewDepartment)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                NewDepartment period = new NewDepartment(this);
                period.Show();
            }
        }

        private void BtnEditDepartment_Clicks(object sender, RoutedEventArgs e)
        {
            this.isEdit = true;
            NewDepartment v = new NewDepartment(this);
            v.Show();
        }

        private void LIDepartment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.ClearForm();
            if (LIDepartment.SelectedItem != null)
            {
                this.ListDataDepartemenSelected = (ListDataDepartemen)LIDepartment.SelectedItem;
                if (this.ListDataDepartemenSelected != null)
                {
                    using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
                    {
                        this.DataDepartemen = uow.DataDepartemen.Get(this.ListDataDepartemenSelected.IdDepartemen.GetValueOrDefault(0));
                        txtDepartmentCode.Text = this.DataDepartemen.KodeDepartemen;
                        txtDepartmentName.Text = this.DataDepartemen.NamaDepartemen;
                        txtSubDepartment.Text = this.DataDepartemen.SubDepartemenDari;
                        txtPIC.Text = this.DataDepartemen.PenanggungJawab;
                        txtRemarks.Text = this.DataDepartemen.Deskripsi;
                    }
                }
            }
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

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataDepartemen == null)
            {
                MessageBox.Show("Department not selected !");
            }
            else
            {
                DataDepartemenBLL DataDepartemenBLL = new DataDepartemenBLL();
                this.DataDepartemen.CheckboxInActive = true;
                if (DataDepartemenBLL.EditDataDepartemen(this.DataDepartemen) == true)
                {
                    MessageBox.Show("Department successfully deleted");
                    this.LoadDataDepartemen("");
                    this.ListDataDepartemenSelected = null;
                    this.DataDepartemen = null;
                }
            }
        }
        private void Viewinactived_Click(object sender, RoutedEventArgs e)
        {

        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

