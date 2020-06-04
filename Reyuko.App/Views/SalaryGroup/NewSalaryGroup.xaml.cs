using Reyuko.DAL.Domain;
using Reyuko.BLL.Core;
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
    public partial class NewSalaryGroup : Window
    {
        public NewSalaryGroup(SalaryGroup SalaryGroupFrom)
        {
            InitializeComponent();
            this.SalaryGroupForm = SalaryGroupFrom;
            this.Init();
        }

        public object UserControl { get; internal set; }
        private SalaryGroup SalaryGroupForm;
        private void ClearForm()
        {
            txtPositionGroupName.Text = "";
            txtBasicSalary.Text = "0";
            txtAllowance.Text = "0";
            txtOvertime.Text = "0";
            chkTax.IsChecked = false;
        }

        private void Init()
        {
            this.ClearForm();
            if (this.SalaryGroupForm.isEdit == true)
                this.LoadGolonganKontak();
        }

        private void LoadGolonganKontak()
        {
            this.ClearForm();
            if (this.SalaryGroupForm != null && this.SalaryGroupForm.GolonganKontakSelected != null)
            {
                txtPositionGroupName.Text = this.SalaryGroupForm.GolonganKontakSelected.NamaGolongan;
                txtBasicSalary.Text = this.SalaryGroupForm.GolonganKontakSelected.GajiPokok.GetValueOrDefault(0).ToString();
                txtAllowance.Text = this.SalaryGroupForm.GolonganKontakSelected.Tunjangan.GetValueOrDefault(0).ToString();
                txtOvertime.Text = this.SalaryGroupForm.GolonganKontakSelected.OvertimeHour.GetValueOrDefault(0).ToString();
                chkTax.IsChecked = this.SalaryGroupForm.GolonganKontakSelected.IncludeExcludePajak;
            }
        }

        private GolonganKontak GetData()
        {
            GolonganKontak oData = new GolonganKontak();
            oData.NamaGolongan = txtPositionGroupName.Text;
            oData.GajiPokok = int.Parse(txtBasicSalary.Text);
            oData.Tunjangan = int.Parse(txtAllowance.Text);
            oData.OvertimeHour = int.Parse(txtOvertime.Text);
            oData.IncludeExcludePajak = chkTax.IsChecked;
            if (this.SalaryGroupForm.GolonganKontakSelected != null)
                oData.Id = this.SalaryGroupForm.GolonganKontakSelected.Id;

            return oData;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtPositionGroupName.Text == "" || txtBasicSalary.Text == "" || txtAllowance.Text == "" || txtOvertime.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            GolonganKontakBLL GolonganKontakBLL = new GolonganKontakBLL();
            if (this.SalaryGroupForm.isEdit == false)
            {
                if (GolonganKontakBLL.AddGolonganKontak(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Salary Group successfully added !");
                    this.SalaryGroupForm.LoadGolonganKontak("");
                }
                else
                {
                    MessageBox.Show("Salary Group failed to add !");
                }
            }
            else
            {
                if (GolonganKontakBLL.EditGolonganKontak(this.GetData()) == true)
                {
                    this.ClearForm();
                    MessageBox.Show("Salary Group successfully changed !");
                    this.SalaryGroupForm.LoadGolonganKontak("");
                }
                else
                {
                    MessageBox.Show("Salary Group failed to change !");
                }
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.ClearForm();
            this.Close();
        }

        private void TxtOvertime_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtOvertime.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtOvertime.Text = "";
                    return;
                }

            }
        }

        private void TxtBasicSalary_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtBasicSalary.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtBasicSalary.Text = "";
                    return;
                }

            }
        }

        private void TxtAllowance_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtAllowance.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtAllowance.Text = "";
                    return;
                }

            }
        }

        private void TxtPositionGroupName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtPositionGroupName.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtPositionGroupName.Text = "";
                    return;
                }

            }
        }
    }
}
