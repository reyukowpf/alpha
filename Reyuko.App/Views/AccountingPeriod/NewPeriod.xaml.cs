using Reyuko.BLL.Core;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
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

namespace Reyuko.App.Views.AccountingPeriod
{
    /// <summary>
    /// Interaction logic for NewCurrency.xaml
    /// </summary>
    public partial class NewPeriod : Window
    {
        public NewPeriod(AccountingPeriod accountingPeriodeForm)
        {
            InitializeComponent();
            this.accountingPeriodeForm = accountingPeriodeForm;
            this.Init();
        }

        private AccountingPeriod accountingPeriodeForm;
        private void Init()
        {
            this.ClearForm();
            if (this.accountingPeriodeForm.isEdit == true)
                this.LoadPeriodeAkuntansi();
        }
        private void ClearForm()
        {
            DtTahunBukuAwal.Text = DateTime.Now.ToShortDateString();
            DtTahunBukuAkhir.Text = DateTime.Now.ToShortDateString();
            ChkAktif.IsChecked = false;
        }

        private void LoadPeriodeAkuntansi()
        {
            this.ClearForm();
            if (this.accountingPeriodeForm != null && this.accountingPeriodeForm.periodeAkuntansiSelected != null)
            {
                DtTahunBukuAwal.Text = this.accountingPeriodeForm.periodeAkuntansiSelected.TahunBukuAwal.GetValueOrDefault().ToShortDateString();
                DtTahunBukuAkhir.Text = this.accountingPeriodeForm.periodeAkuntansiSelected.TahunBukuAkhir.GetValueOrDefault().ToShortDateString();
                ChkAktif.IsChecked = this.accountingPeriodeForm.periodeAkuntansiSelected.CheckboxAktif;
            }
        }

        private PeriodeAkuntansi GetData()
        {
            PeriodeAkuntansi oData = new PeriodeAkuntansi();
            oData.TahunBukuAwal = DateTime.Parse(DtTahunBukuAwal.Text);
            oData.TahunBukuAkhir = DateTime.Parse(DtTahunBukuAkhir.Text);
            oData.CheckboxAktif = !ChkAktif.IsChecked;
            if (this.accountingPeriodeForm.isEdit == true)
                oData.Id = this.accountingPeriodeForm.periodeAkuntansiSelected.Id;

            return oData;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (DtTahunBukuAwal.Text == "" || DtTahunBukuAkhir.Text == "")
            {
                MessageBox.Show("Please Select a Date", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            PeriodeAkuntansiBLL periodeAkuntansiBLL = new PeriodeAkuntansiBLL();
            if (periodeAkuntansiBLL.AddPeriodeAkuntansi(this.GetData()) > 0)
            {
                this.ClearForm();
                MessageBox.Show("Accounting period successfully added !");
                this.accountingPeriodeForm.LoadPeriodeAkuntansi();
            }
            else
            {
                MessageBox.Show("Accounting Period failed to add !");
            }
            this.Close();
        }
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            PeriodeAkuntansiBLL periodeAkuntansiBLL = new PeriodeAkuntansiBLL();
            if (periodeAkuntansiBLL.EditPeriodeAkuntansi(this.GetData()) == true)
            {
                this.ClearForm();
                MessageBox.Show("The accounting period was successfully changed !");
                this.accountingPeriodeForm.LoadPeriodeAkuntansi();
            }
            else
            {
                MessageBox.Show("Accounting period failed to change !");
            }
            this.Close();
        }

    }
}
