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

namespace Reyuko.App.Views.AccountData
{
    /// <summary>
    /// </summary>
    public partial class NewAccounLevel4 : Window
    {
        public NewAccounLevel4(AccountData AccountDataForm)
        {
            InitializeComponent();
            this.AccountDataForm = AccountDataForm;
            this.Init();
        }

        public object UserControl { get; internal set; }
        public AccountData AccountDataForm { get; set; }
        private RekeningPerkiraan RekeningPerkiraan { get; set; }
        private IEnumerable<ListDataDepartemen> ListDataDepartments { get; set; }
        private ListDataDepartemen ListDataDepartmentSelected { get; set; }
        private IEnumerable<ListDataMataUang> ListDataMataUangs { get; set; }
        private ListDataMataUang ListDataMataUangSelected { get; set; }
        private IEnumerable<Radiobuttonrekper> radiobuttonrekpers { get; set; }
        private Radiobuttonrekper radiobuttonrekperselected { get; set; }
        private void Init()
        {
            this.ClearForm();
            this.LoadListDataDepartment();
            this.LoadListDataMataUang();
            this.LoadKlasifikasiAkun();
        }

        private void ClearForm()
        {
            txtAccountcode.Text = "";
            txtAccountName.Text = "";
            cbDepartment.SelectedIndex = -1;
            cbCurrency.SelectedIndex = -1;
            rdStandard.IsChecked = true;
            rdCashBank.IsChecked = false;
            rdDebtLoan.IsChecked = false;
            chkNotActive.IsChecked = false;
            chkPasswordLock.IsChecked = false;

            this.RekeningPerkiraan = null;
            this.ListDataDepartmentSelected = null;
            this.ListDataMataUangSelected = null;
        }

        private void LoadListDataDepartment()
        {
            this.ListDataDepartments = null;
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.ListDataDepartments = uow.ListDataDepartemen.GetAll();
                cbDepartment.ItemsSource = this.ListDataDepartments;
                cbDepartment.DisplayMemberPath = "NamaDepartemen";
                cbDepartment.SelectedValuePath = "Id";
            }
        }

        private void LoadListDataMataUang()
        {
            this.ListDataMataUangs = null;
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.ListDataMataUangs = uow.ListDataMataUang.GetAll();
                cbCurrency.ItemsSource = this.ListDataMataUangs;
                cbCurrency.DisplayMemberPath = "NamaMataUang";
                cbCurrency.SelectedValuePath = "Id";
            }
        }

        private void LoadKlasifikasiAkun()
        {
            this.ClearForm();
            if (this.AccountDataForm != null && this.AccountDataForm.KlasifikasiAkunSelected != null)
            {
                if (this.AccountDataForm.isEdit == true)
                {
                    using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
                    {
                        this.RekeningPerkiraan = uow.RekeningPerkiraan.SingleOrDefault(m => m.IdKlasifikasiRekeningPerkiraan == this.AccountDataForm.KlasifikasiAkunSelected.Id);
                        if (this.RekeningPerkiraan != null)
                        {
                            txtAccountName.Text = this.RekeningPerkiraan.NamaRekeningPerkiraan;
                            txtAccountcode.Text = this.RekeningPerkiraan.KodeRekening;
                            cbDepartment.SelectedValue = this.RekeningPerkiraan.IdDepartemen;
                            cbCurrency.SelectedValue = this.RekeningPerkiraan.IdMataUang;
                            if (this.RekeningPerkiraan.RadioButtonStandarKasBankDebtLoan.ToString() == "D")
                                rdDebtLoan.IsChecked = true;
                            else if (this.RekeningPerkiraan.RadioButtonStandarKasBankDebtLoan.ToString() == "K")
                                rdCashBank.IsChecked = true;
                            else
                                rdStandard.IsChecked = true;
                            chkNotActive.IsChecked = this.RekeningPerkiraan.CheckboxTidakAktif;
                            chkPasswordLock.IsChecked = this.RekeningPerkiraan.CheckboxPasswordLock;
                        }
                    }
                }
                else
                {
                    var child = this.AccountDataForm.KlasifikasiAkuns.Where(m => m.IdParentKategoriKA == this.AccountDataForm.KlasifikasiAkunSelected.Id).OrderByDescending(m => m.Kode).FirstOrDefault();
                    if (child == null)
                    {
                        txtAccountcode.Text = this.AccountDataForm.KlasifikasiAkunSelected.Kode + ".100";
                    }
                    else
                    {
                        var arKode = child.Kode.Split('.');
                        var lastKode = int.Parse(arKode[arKode.Length - 1]) + 100;
                        txtAccountcode.Text = this.AccountDataForm.KlasifikasiAkunSelected.Kode + "." + lastKode.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("The Account Has Not Been Selected \n");
            }
        }

        private RekeningPerkiraan GetData()
        {
            RekeningPerkiraan oData = new RekeningPerkiraan();
            oData.NamaRekeningPerkiraan = txtAccountName.Text;
            oData.KodeRekening = txtAccountcode.Text;
            if (this.ListDataDepartmentSelected != null)
            {
                oData.IdDepartemen = this.ListDataDepartmentSelected.IdDepartemen;
                oData.NamaDepartemen = this.ListDataDepartmentSelected.NamaDepartemen;
            }
            if (this.ListDataMataUangSelected != null)
            {
                oData.IdMataUang = this.ListDataMataUangSelected.IdDataMataUang;
                oData.MataUang = this.ListDataMataUangSelected.NamaMataUang;
            }
            oData.RadioButtonStandarKasBankDebtLoan = "";
            if (rdCashBank.IsChecked == true)
                oData.RadioButtonStandarKasBankDebtLoan = "2";
            else if (rdDebtLoan.IsChecked == true)
                oData.RadioButtonStandarKasBankDebtLoan = "3";
            else
                oData.RadioButtonStandarKasBankDebtLoan = "1";
            oData.CheckboxTidakAktif = chkNotActive.IsChecked;
            oData.CheckboxPasswordLock = chkPasswordLock.IsChecked;
            if (this.AccountDataForm.isEdit == true)
            {
                oData.Id = this.RekeningPerkiraan.Id;
                oData.IdKlasifikasiRekeningPerkiraan = this.RekeningPerkiraan.IdKlasifikasiRekeningPerkiraan;
                oData.KlasifikasiRekeningPerkiraan = this.RekeningPerkiraan.KlasifikasiRekeningPerkiraan;
            }
            return oData;
        }

        private void savelevel_Click(object sender, RoutedEventArgs e)
        {
            string message = "";
            if (string.IsNullOrEmpty(txtAccountName.Text))
                message += "Account Name cannot be empty \n";
            if (string.IsNullOrEmpty(txtAccountcode.Text))
                message += "Account Code cannot be empty \n";
            if (string.IsNullOrEmpty(cbDepartment.Text))
                message += "Department cannot be empty \n";
            if (string.IsNullOrEmpty(cbCurrency.Text))
                message += "Currency cannot be empty \n";
            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message);
                return;
            }


            RekeningPerkiraanBLL RekeningPerkiraanBLL = new RekeningPerkiraanBLL();
            if (this.AccountDataForm.isEdit == false)
            {
                if (RekeningPerkiraanBLL.AddRekeningPerkiraan(this.GetData(), this.AccountDataForm.KlasifikasiAkunSelected) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Account Successfully Added !");
                    this.AccountDataForm.LoadKlasifikasiAkun();
                }
                else
                {
                    MessageBox.Show("Account Failed to Added !");
                }
            }
            else
            {
                if (RekeningPerkiraanBLL.EditRekeningPerkiraan(this.GetData()) == true)
                {
                    this.ClearForm();
                    MessageBox.Show("Account Successfully Change !");
                    this.AccountDataForm.LoadKlasifikasiAkun();
                }
                else
                {
                    MessageBox.Show("Account Failed to Change !");
                }
            }
            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CbDepartment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.ListDataDepartmentSelected = null;
            if (cbDepartment.SelectedItem != null)
            {
                this.ListDataDepartmentSelected = (ListDataDepartemen)cbDepartment.SelectedItem;
            }
        }

        private void CbCurrency_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.ListDataMataUangSelected = null;
            if (cbCurrency.SelectedItem != null)
            {
                this.ListDataMataUangSelected = (ListDataMataUang)cbCurrency.SelectedItem;
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

        private void TxtAccountcode_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
