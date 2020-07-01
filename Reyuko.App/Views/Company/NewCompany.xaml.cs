using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Reyuko.App.Views.Company
{
    /// <summary>
    
    /// </summary>
    public partial class NewCompany : UserControl
    {
        public NewCompany()
        {
            InitializeComponent();
            Switcher.pageSwitchNewCompany = this;
        }
        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
        public object UserControl { get; internal set; }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            if (cbClasification.Text == "" || txtCustomerID.Text == "" || txtName.Text == "" || txtPhone.Text == "" || txtEmail.Text == "" || cbCountry.Text == "" || txtAddress.Text == "" || txtCity.Text == "" || cbState.Text == "" || txtZip.Text == "" || txtMap.Text == "" || txtPosition.Text == "" || txtTaxID.Text == "" || txtBankName.Text == "" || txtBankAccount.Text == "" || txtAccountName.Text == "" || txtRemarks.Text == ""
                || txtNamePIC1.Text == "" || txtPhonePIC1.Text == "" || txtEmailPIC1.Text == "" || cbCountryPIC1.Text == "" || txtAddressPIC1.Text == "" || txtCityPIC1.Text == "" || cbStatePIC1.Text == "" || txtZipPIC1.Text == "" || txtMapPIC1.Text == "" || txtPositionPIC1.Text == "" || txtRemarksPIC1.Text == "" || txtNamePIC2.Text == "" || txtPhonePIC2.Text == "" || txtEmailPIC2.Text == "" || cbCountryPIC2.Text == "" || txtAddressPIC2.Text == ""
                || txtCityPIC2.Text == "" || cbStatePIC2.Text == "" || txtZipPIC2.Text == "" || txtMapPIC2.Text == "" || txtPositionPIC2.Text == "" || txtRemarksPIC2.Text == "" || txtNamePIC3.Text == "" || txtPhonePIC3.Text == "" || txtEmailPIC3.Text == "" || cbCountryPIC3.Text == "" || txtAddressPIC3.Text == "" || txtCityPIC3.Text == "" || cbStatePIC3.Text == "" || txtZipPIC3.Text == "" || txtMapPIC3.Text == "" || txtPositionPIC3.Text == "" || txtRemarksPIC3.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Company v = new Company();
            Switcher.SwitchNewCompany(v);
        }

        private void TxtCustomerID_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TxtPhone_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtPhone.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtPhone.Text = "";
                    return;
                }

            }
        }

        private void TxtTaxID_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtTaxID.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtTaxID.Text = "";
                    return;
                }

            }
        }

        private void TxtPhonePIC1_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtPhonePIC1.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtPhonePIC1.Text = "";
                    return;
                }

            }
        }

        private void TxtZip_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtZip.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtZip.Text = "";
                    return;
                }

            }
        }

        private void TxtZipPIC1_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtZipPIC1.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtZipPIC1.Text = "";
                    return;
                }

            }
        }

        private void TxtPhonePIC2_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtPhonePIC2.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtPhonePIC2.Text = "";
                    return;
                }

            }
        }

        private void TxtZipPIC2_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtZipPIC2.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtZipPIC2.Text = "";
                    return;
                }

            }
        }

        private void TxtPhonePIC3_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtPhonePIC3.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtPhonePIC3.Text = "";
                    return;
                }

            }
        }

        private void TxtZipPIC3_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtZipPIC3.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtZipPIC3.Text = "";
                    return;
                }

            }
        }

        private void TxtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtName.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtName.Text = "";
                    return;
                }

            }
        }

        private void TxtCity_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtCity.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtCity.Text = "";
                    return;
                }

            }
        }

        private void TxtBankName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtBankName.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtBankName.Text = "";
                    return;
                }

            }
        }

        private void TxtBankAccount_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtBankAccount.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtBankAccount.Text = "";
                    return;
                }

            }
        }

        private void TxtAccountName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtAccountName.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtAccountName.Text = "";
                    return;
                }

            }
        }

        private void TxtRemarks_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtNamePIC1_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtNamePIC1.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtNamePIC1.Text = "";
                    return;
                }

            }
        }

        private void TxtCityPIC1_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtCityPIC1.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtCityPIC1.Text = "";
                    return;
                }

            }
        }

        private void TxtNamePIC2_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtNamePIC2.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtNamePIC2.Text = "";
                    return;
                }

            }
        }

        private void TxtCityPIC2_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtCityPIC2.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtCityPIC2.Text = "";
                    return;
                }

            }
        }

        private void TxtNamePIC3_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtNamePIC3.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtNamePIC3.Text = "";
                    return;
                }

            }
        }

        private void TxtCityPIC3_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtCityPIC3.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtCityPIC3.Text = "";
                    return;
                }

            }
        }

        private void CbCountry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CbCountryPIC2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TxtPosition_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtPosition.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtPosition.Text = "";
                    return;
                }

            }
        }

        private void TxtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtAddress_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtMap_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtMap.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtMap.Text = "";
                    return;
                }

            }
        }

        private void TxtAddressPIC1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtMapPIC1_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtMapPIC1.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtMapPIC1.Text = "";
                    return;
                }

            }
        }

        private void TxtPositionPIC1_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtPositionPIC1.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtPositionPIC1.Text = "";
                    return;
                }

            }
        }

        private void TxtEmailPIC2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtAddressPIC2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtMapPIC2_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtMapPIC2.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtMapPIC2.Text = "";
                    return;
                }

            }
        }

        private void TxtPositionPIC2_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtPositionPIC2.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtPositionPIC2.Text = "";
                    return;
                }

            }
        }

        private void TxtEmailPIC3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtMapPIC3_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtMapPIC3.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtMapPIC3.Text = "";
                    return;
                }

            }
        }

        private void TxtPositionPIC3_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtPositionPIC3.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtPositionPIC3.Text = "";
                    return;
                }

            }
        }

        private void TxtEmail_OnLostFocus(object sender, RoutedEventArgs e)
        {
            // Baca inputan email menggunakan Lost Focus
            if (txtEmail.Text.Length == 0)
            {
                InfoMail.Content = "Empty";
            }
            else if (!Regex.IsMatch(txtEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                InfoMail.Content = "Invalid";
                txtEmail.Select(0, txtEmail.Text.Length);
            }

            else
            {
                InfoMail.Content = "OK";
            }
        }

        private void TxtEmail1_OnLostFocus(object sender, RoutedEventArgs e)
        {
            // Baca inputan email menggunakan Lost Focus
            if (txtEmailPIC1.Text.Length == 0)
            {
                InfoMail1.Content = "Empty";
            }
            else if (!Regex.IsMatch(txtEmailPIC1.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                InfoMail1.Content = "Invalid";
                txtEmailPIC1.Select(0, txtEmailPIC1.Text.Length);
            }

            else
            {
                InfoMail1.Content = "OK";
            }
        }

        private void TxtEmail2_OnLostFocus(object sender, RoutedEventArgs e)
        {
            // Baca inputan email menggunakan Lost Focus
            if (txtEmailPIC2.Text.Length == 0)
            {
                InfoMail2.Content = "Empty";
            }
            else if (!Regex.IsMatch(txtEmailPIC2.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                InfoMail2.Content = "Invalid";
                txtEmailPIC2.Select(0, txtEmailPIC2.Text.Length);
            }

            else
            {
                InfoMail2.Content = "OK";
            }
        }

        private void TxtEmail3_OnLostFocus(object sender, RoutedEventArgs e)
        {
            // Baca inputan email menggunakan Lost Focus
            if (txtEmailPIC3.Text.Length == 0)
            {
                InfoMail3.Content = "Empty";
            }
            else if (!Regex.IsMatch(txtEmailPIC3.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                InfoMail3.Content = "Invalid";
                txtEmailPIC3.Select(0, txtEmailPIC3.Text.Length);
            }

            else
            {
                InfoMail3.Content = "OK";
            }
        }
    }
}
