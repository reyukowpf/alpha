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

namespace Reyuko.App.Views.ReceivableAndPayable
{
    /// <summary>
    
    /// </summary>
    public partial class NewReceivableAndPayable : UserControl
    {
        public NewReceivableAndPayable()
        {
            InitializeComponent();
            Switcher.pageSwitchNewReceivableAndPayable = this;
            this.Init();
        }
        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
        public IEnumerable<Kontak> kontaks { get; set; }
        public Kontak kontakSelected { get; set; }
        public IEnumerable<Dokumen> dokumens { get; set; }
        public Dokumen dokumenSelected { get; set; }
        public IEnumerable<DropdownPaymentCashActivity> dropdownPaymentCashActivities { get; set; }
        public DropdownPaymentCashActivity dropdownPaymentCashActivitySelected;
        public IEnumerable<DropdownBankKas> dropdownBankKas { get; set; }
        public DropdownBankKas dropdownBankKasSelected;
        public Kontak kontakpetugasSelected;
        private void Init()
        {
            this.ClearForm();
            this.LoadCustomer();
            this.LoadStaff();
            this.LoadNoDokumen();
            this.LoadPaymenttype();
            this.LoadCash();
        }
        private void ClearForm()
        {
            cbPaymentType.SelectedIndex = -1;
            srcustomer.Text = "";
            txtemail.Text = "";
            txthp.Text = "";
            dtPayment.Text = DateTime.Now.ToShortDateString();
            srnodokumen.Text = "";
            txtPaymentNumber.Text = "";
            cbCash.SelectedIndex = -1;
            txtNote.Text = "";
            srstaff.Text = "";
            Postdate.IsChecked = false;
            txtTotalPaymentValue.Text = "";
        }
        public void LoadPaymenttype()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dropdownPaymentCashActivities = uow.DropdownPaymentCashActivity.GetAll();
                cbPaymentType.ItemsSource = this.dropdownPaymentCashActivities;
                cbPaymentType.SelectedValuePath = "Id";
                cbPaymentType.DisplayMemberPath = "KategoriTransaksi";
            }
        }
        public void LoadCash()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dropdownBankKas = uow.DropdownBankKas.GetAll();
                cbCash.ItemsSource = this.dropdownBankKas;
                cbCash.SelectedValuePath = "Id";
                cbCash.DisplayMemberPath = "DropdownBankkas";
            }
        }
        public void LoadCustomer()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kontaks = uow.Kontak.GetAll().Where(m => m.TypeKontak.ToLower() == "pelanggan");
                srcustomer.ItemsSource = this.kontaks;
            }
        }
        public void LoadStaff()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kontaks = uow.Kontak.GetAll().Where(m => m.TypeKontak.ToLower() == "employee");
                srstaff.ItemsSource = this.kontaks;
            }
        }
        public void LoadNoDokumen()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dokumens = uow.Dokumen.GetAll();
                srnodokumen.ItemsSource = this.dokumens;
            }
        }
        private void customer_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.kontakSelected = null;
            if (srcustomer.SelectedItem != null)
            {
                this.kontakSelected = (Kontak)srcustomer.SelectedItem;
                txtemail.Text = this.kontakSelected.EmailA;
                txthp.Text = this.kontakSelected.NoHPA;
            }

        }
        private void dokumen_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.dokumenSelected = null;
            if (srnodokumen.SelectedItem != null)
            {
                this.dokumenSelected = (Dokumen)srnodokumen.SelectedItem;
            }
        }
        private void staff_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.kontakpetugasSelected = null;
            if (srstaff.SelectedItem != null)
            {
                this.kontakpetugasSelected = (Kontak)srstaff.SelectedItem;
            }
        }
        private void Savereceivable_Click(object sender, RoutedEventArgs e)
        {
            if (cbPaymentType.Text == "" || srcustomer.Name == "" || txtemail.Name == "" || txthp.Name == "" || dtPayment.Text == "" || srnodokumen.Name == "" || txtPaymentNumber.Text == "" || cbCash.Text == "" ||  txtValue.Text == "" || srstaff.Name == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            RppBLL rppBLL = new RppBLL();
            RppBLL RppBLL = new RppBLL();
            Rpp rpp = new Rpp();
            OrderTransaksiCash ordercash = new OrderTransaksiCash();
            if (this.dropdownPaymentCashActivitySelected != null)
            {
                rpp.PulldownRpp = this.dropdownPaymentCashActivitySelected.Id;
                rpp.IdKodeTransaksi = this.dropdownPaymentCashActivitySelected.IdKodeTransaksi;
                rpp.KodeTransaksi = this.dropdownPaymentCashActivitySelected.KodeTransaksi;
            }
            if (this.kontakSelected != null)
            {
                rpp.IdPelanggan = this.kontakSelected.Id;
                rpp.NamaPelanggan = this.kontakSelected.NamaA;
            }
            rpp.Email = txtemail.Text;
            rpp.NoHp = double.Parse(txthp.Text);
            rpp.TanggalTransaksi = DateTime.Parse(dtPayment.Text);
            if (this.dokumenSelected != null)
            {
                rpp.IdNoReferensiDokumen = this.dokumenSelected.Id;
                rpp.NoReferensiDokumen = this.dokumenSelected.NoReferensiDokumen;
            }
            rpp.NoPembayaran = double.Parse(txtPaymentNumber.Text);
            if (this.dropdownBankKasSelected != null)
            {
                rpp.IdAkunKas = this.dropdownBankKasSelected.Id;
                rpp.NamaAkunKas = this.dropdownBankKasSelected.DropdownBankkas;
            }
            rpp.Keterangan = txtNote.Text;
            if (this.kontakpetugasSelected != null)
            {
                rpp.IdPetugas = this.kontakpetugasSelected.Id;
                rpp.NamaPetugas = this.kontakpetugasSelected.NamaA;
            }
          //  rpp.TotalPembayaran = double.Parse(txtTotalPaymentValue.Text);
            rpp.IdPeriodeAkuntansi = 1;
            rpp.RealRecordingTime = DateTime.Now;
            if (RppBLL.AddRpp(rpp) > 0)
            {
                //  this.ClearForm();
                MessageBox.Show("Receivable And Payable Payment successfully added !");
            }
            else
            {
                MessageBox.Show("Receivable And Payable Payment failed to add !");
            }
            if (DGReceivablePayment.Items.Count > 0)
            {
                foreach (var item in DGReceivablePayment.Items)
                {
                    if (item is OrderTransaksiCash)
                    {
                        OrderTransaksiCash oNewData1 = (OrderTransaksiCash)item;
           /*             oNewData1.NoReferensiTransaksi = double.Parse(txtPaymentNumber.Text);
                        if (this.dropdownBankKasSelected != null)
                        {
                            oNewData1.IdAkunHutangPiutangReferensi = this.dropdownBankKasSelected.Id;
                        }
                        if (this.dropdownCashActivitySelected != null)
                        {
                            oNewData1.IdDropdownPaymentCashActivity = this.dropdownCashActivitySelected.Id;
                            oNewData1.IdKodeTransaksi = this.dropdownCashActivitySelected.IdKodeTransaksi;
                            oNewData1.KodeTransaksi = this.dropdownCashActivitySelected.KodeTransaksi;
                        }
                        if (this.kontakSelected != null)
                        {
                            oNewData1.IdPelanggan = this.kontakSelected.Id;
                            oNewData1.NamaPelanggan = this.kontakSelected.NamaA;
                        }
                        oNewData1.Email = txtemail.Text;
                        oNewData1.NoHp = double.Parse(txthp.Text);
                        if (this.dataMataUangSelected != null)
                        {
                            oNewData1.IdMataUang = this.dataMataUangSelected.Id;
                            oNewData1.MataUang = this.dataMataUangSelected.NamaMataUang;
                            oNewData1.KursTukar = this.dataMataUangSelected.KursTukar;
                        }
                        if (this.dokumenSelected != null)
                        {
                            oNewData1.IdNoReferensiDokumen = this.dokumenSelected.Id;
                            oNewData1.NoReferensiDokumen = this.dokumenSelected.NoReferensiDokumen;
                        }
                        oNewData1.TanggalTransaksi = DateTime.Parse(tgl.Text);
                        if (this.kontakSelecteds != null)
                        {
                            oNewData1.IdPetugas = this.kontakSelecteds.Id;
                            oNewData1.NamaPetugas = this.kontakSelecteds.NamaA;
                        }
                        oNewData1.RealRecordingTime = DateTime.Now;
                        oNewData1.IdPeriodeTransaksi = cash.IdPeriodeAkuntansi;
                        oNewData1.Checkboxaktif = false;
                        if (cashBLL.Edittranscash(oNewData1, cash) == true)
                        {
                        }*/
                    }

                }
                ReceivableAndPayable v = new ReceivableAndPayable();
                Switcher.SwitchNewReceivableAndPayable(v);
            }        
    }

        private void Print_Click(object sender, RoutedEventArgs e)
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

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            ReceivableAndPayable v = new ReceivableAndPayable();
            Switcher.SwitchNewReceivableAndPayable(v);
        }
        private void saveasdraft_Click(object sender, RoutedEventArgs e)
        {

        }
        private void saveaspdf_Click(object sender, RoutedEventArgs e)
        {

        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TxtPaymentNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtPaymentNumber.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Harus Diisi Numerik");
                    txtPaymentNumber.Text = "";
                    return;
                }

            }
        }

        private void TxtValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtValue.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Harus Diisi Numerik");
                    txtValue.Text = "";
                    return;
                }

            }
        }
    }
}
             
    

