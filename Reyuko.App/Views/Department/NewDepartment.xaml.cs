using Reyuko.BLL.Core;
using Reyuko.DAL.Domain;
using Reyuko.DAL;
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
using Reyuko.Utils;

namespace Reyuko.App.Views.Department
{
    /// <summary>
    /// </summary>
    public partial class NewDepartment : Window
    {
        public NewDepartment(Department DepartmentForm)
        {
            InitializeComponent();
            this.DepartmentForm = DepartmentForm;
            this.Init();
        }

        public object UserControl { get; internal set; }
        private Department DepartmentForm;
        private IEnumerable<ListKontak> ListKontaks { get; set; }
        private ListKontak ListKontakSelected { get; set; }
        private IEnumerable<ListDataDepartemen> ListDataDepartemens { get; set; }
        private ListDataDepartemen ListDataDepartemenSelected { get; set; }

        private void ClearForm()
        {
            txtDepartmentCode.Text = "";
            txtDepartmentName.Text = "";
            CbSubDepartment.SelectedIndex = -1;
            CbPIC.SelectedIndex = -1;
            txtRemarks.Text = "";
        }

        private void Init()
        {
            this.ClearForm();
            this.LoadComboDepartemen();
            this.LoadComboKontak();
            if (this.DepartmentForm.isEdit == true)
                this.LoadDataDepartemen();
        }

        private void LoadComboKontak()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.ListKontaks = uow.ListKontak.GetAll().Where(m => m.TypeKontak.ToLower() == "employee");
                CbPIC.ItemsSource = this.ListKontaks;
                CbPIC.DisplayMemberPath = "NamaA";
                CbPIC.SelectedValuePath = "IdKontak";
            }
        }

        private void LoadComboDepartemen()
        {
            this.ListDataDepartemens = this.DepartmentForm.ListDataDepartemens;
            CbSubDepartment.ItemsSource = this.ListDataDepartemens;
            CbSubDepartment.DisplayMemberPath = "NamaDepartemen";
            CbSubDepartment.SelectedValuePath = "IdDepartemen";
        }

        private void LoadDataDepartemen()
        {
            this.ClearForm();
            if (this.DepartmentForm != null && this.DepartmentForm.DataDepartemen != null)
            {

                txtDepartmentCode.Text = this.DepartmentForm.DataDepartemen.KodeDepartemen;
                txtDepartmentName.Text = this.DepartmentForm.DataDepartemen.NamaDepartemen;
                CbSubDepartment.SelectedValue = this.DepartmentForm.DataDepartemen.IdSubDepartemen;
                CbPIC.SelectedValue = this.DepartmentForm.DataDepartemen.IdKontak;
                txtRemarks.Text = this.DepartmentForm.DataDepartemen.Deskripsi;

                this.ListDataDepartemenSelected = this.ListDataDepartemens.Where(m => m.IdDepartemen == this.DepartmentForm.DataDepartemen.IdSubDepartemen).FirstOrDefault();
                this.ListKontakSelected = this.ListKontaks.Where(m => m.IdKontak == this.DepartmentForm.DataDepartemen.IdKontak).FirstOrDefault();
            }
        }

        private DataDepartemen GetData()
        {
            DataDepartemen oData = new DataDepartemen();
            oData.KodeDepartemen = txtDepartmentCode.Text;
            oData.NamaDepartemen = txtDepartmentName.Text;
            if (this.ListDataDepartemenSelected != null)
            {
                oData.IdSubDepartemen = this.ListDataDepartemenSelected.IdDepartemen;
                oData.SubDepartemenDari = this.ListDataDepartemenSelected.NamaDepartemen;
            }
            if (this.ListKontakSelected != null)
            {
                oData.IdKontak = this.ListKontakSelected.IdKontak;
                oData.PenanggungJawab = this.ListKontakSelected.NamaA;
            }
            oData.Deskripsi = txtRemarks.Text;
            if (this.DepartmentForm.DataDepartemen != null)
                oData.Id = this.DepartmentForm.DataDepartemen.Id;

            return oData;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtDepartmentCode.Text == "" || txtDepartmentName.Text == "" || CbSubDepartment.Text == "" || CbPIC.Text == "" || txtRemarks.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            DataDepartemenBLL DataDepartemenBLL = new DataDepartemenBLL();
            if (this.DepartmentForm.isEdit == false)
            {
                if (DataDepartemenBLL.AddDataDepartemen(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Department successfully added !");
                    this.DepartmentForm.LoadDataDepartemen("");
                }
                else
                {
                    MessageBox.Show("Department failed to add !");
                }
            }
            else
            {
                if (DataDepartemenBLL.EditDataDepartemen(this.GetData()) == true)
                {
                    this.ClearForm();
                    MessageBox.Show("Department successfully changed !");
                    this.DepartmentForm.LoadDataDepartemen("");
                }
                else
                {
                    MessageBox.Show("Department failed to change !");
                }
            }
            this.Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.ClearForm();
            this.Close();
        }

        private void CbSubDepartment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.ListDataDepartemenSelected = null;
            if (CbSubDepartment.SelectedItem != null)
            {
                this.ListDataDepartemenSelected = (ListDataDepartemen)CbSubDepartment.SelectedItem;
            }
        }

        private void CbPIC_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.ListKontakSelected = null;
            if (CbPIC.SelectedItem != null)
            {
                this.ListKontakSelected = (ListKontak)CbPIC.SelectedItem;
            }
        }

        private void TxtDepartmentCode_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtDepartmentCode.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtDepartmentCode.Text = "";
                    return;
                }

            }
        }

        private void TxtDepartmentName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtDepartmentName.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtDepartmentName.Text = "";
                    return;
                }

            }
        }

        private void TxtRemarks_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
