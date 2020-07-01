using Reyuko.BLL.Core;
using Reyuko.DAL.Domain;
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
    public partial class NewCustomerGroup : Window
    {
        public NewCustomerGroup(CustomerGroup customerGroupForm)
        {
            InitializeComponent();
            this.customerGroupForm = customerGroupForm;
            this.Init();
        }

        public object UserControl { get; internal set; }
        private CustomerGroup customerGroupForm;
        private void ClearForm()
        {
            txtGroupName.Text = "";
            txtDiscount.Text = "0";
            txtNote.Text = "";           
        }

        private void Init()
        {
            this.ClearForm();
            if (this.customerGroupForm.isEdit == true)
                this.LoadGrupDiskon();
        }

        private void LoadGrupDiskon()
        {
            this.ClearForm();
            if (this.customerGroupForm != null && this.customerGroupForm.GrupDiskonSelected != null)
            {

                txtGroupName.Text = this.customerGroupForm.GrupDiskonSelected.NamaGroupDiskon;
                txtDiscount.Text = this.customerGroupForm.GrupDiskonSelected.Diskon.GetValueOrDefault(0).ToString();
                txtNote.Text = this.customerGroupForm.GrupDiskonSelected.Keterangan;

            }
        }

        private GrupDiskon GetData()
        {
            GrupDiskon oData = new GrupDiskon();
            oData.NamaGroupDiskon = txtGroupName.Text;
            oData.Diskon = double.Parse(txtDiscount.Text);
            oData.Keterangan = txtNote.Text;
            if (this.customerGroupForm.GrupDiskonSelected != null)
                oData.Id = this.customerGroupForm.GrupDiskonSelected.Id;

            return oData;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtGroupName.Text == "" || txtDiscount.Text == "" || txtNote.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            GrupDiskonBLL GrupDiskonBLL = new GrupDiskonBLL();
            if (this.customerGroupForm.isEdit == false)
            {
                if (GrupDiskonBLL.AddGrupDiskon(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Customer Group successfully added !");
                    this.customerGroupForm.LoadGrupDiskon("");
                }
                else
                {
                    MessageBox.Show("Customer Group failed to add !");
                }
            }
            else
            {
                if (GrupDiskonBLL.EditGrupDiskon(this.GetData()) == true)
                {
                    this.ClearForm();
                    MessageBox.Show("Customer Group successfully changed !");
                    this.customerGroupForm.LoadGrupDiskon("");
                }
                else
                {
                    MessageBox.Show("Customer Group failed to change !");
                }
            }
            this.Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.ClearForm();
            this.Close();
        }

        private void TxtDiscount_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtDiscount.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtDiscount.Text = "";
                    return;
                }

            }
        }

       
    }
}
