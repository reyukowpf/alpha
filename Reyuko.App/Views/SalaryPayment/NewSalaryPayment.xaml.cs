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

namespace Reyuko.App.Views.SalaryPayment
{
    /// <summary>
    
    /// </summary>
    public partial class NewSalaryPayment : UserControl
    {
        public NewSalaryPayment()
        {
            InitializeComponent();
            Switcher.pageSwitchernewsalary = this;
            this.Init();
        }
        
        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        public IEnumerable<OrderPembayaranGaji> orderPembayaranGajis { get; set; }
        public OrderPembayaranGaji orderPembayaranGajiSelected;
        private IEnumerable<DropdownBankKas> dropdownBankkas { get; set; }
        private DropdownBankKas dropdownBankkasSelected;
        private IEnumerable<DataPajak> dataPajaks { get; set; }
        private DataPajak dataPajakSelected;
        private IEnumerable<KodeTransaksi> kodeTransaksis { get; set; }
        private KodeTransaksi kodeTransaksiSelected;
        private IEnumerable<RekeningPerkiraan> rekeningPerkiraans { get; set; }
        private RekeningPerkiraan rekeningPerkiraanSelected;
        private IEnumerable<Kontak> kontaks { get; set; }
        private Kontak kontakSelected;
        private void Init()
        {
            this.ClearForm();
            this.LoadComboAkunGaji();
            this.LoadComboPajak();
            this.LoadComboAkunbiayagaji();
            this.LoadPetugas();
      //     this.Loadkode();
        }

        private void ClearForm()
        {
            tgl.Text = DateTime.Now.ToShortDateString();
            cbCashAccount.SelectedIndex = -1;
            cbSalaryAccount.SelectedIndex = -1;
            chktax.IsChecked = false;
            cbTaxAccount.SelectedIndex = -1;
            txtTotalPaymentValue.Text = "";
            this.kontakSelected = null;
            srkontak.Text = "";
        }
        public void Loadkode()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kodeTransaksis = uow.KodeTransaksi.GetAll().Where(m => m.Kode.ToLower() == "SP"); ;
            }
        }
        public void LoadPetugas()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kontaks = uow.Kontak.GetAll().Where(m => m.TypeKontak.ToLower() == "employee");
                srkontak.ItemsSource = this.kontaks;
            }
        }
        public void LoadComboAkunGaji()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dropdownBankkas = uow.DropdownBankKas.GetAll();
                cbCashAccount.ItemsSource = this.dropdownBankkas;
                cbCashAccount.SelectedValuePath = "Id";
                cbCashAccount.DisplayMemberPath = "DropdownBankkas";
            }
        }
        public void LoadComboPajak()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dataPajaks = uow.DataPajak.GetAll();
                cbTaxAccount.ItemsSource = this.dataPajaks;
                cbTaxAccount.SelectedValuePath = "Id";
                cbTaxAccount.DisplayMemberPath = "NamaPajak";
            }
        }
        public void LoadComboAkunbiayagaji()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.rekeningPerkiraans = uow.RekeningPerkiraan.GetAll().Where(m => m.NamaRekeningPerkiraan == "gaji"); ;
                cbSalaryAccount.ItemsSource = this.rekeningPerkiraans;
                cbSalaryAccount.SelectedValuePath = "Id";
                cbSalaryAccount.DisplayMemberPath = "NamaRekeningPerkiraan";
            }
        }
        public void LoadOrderPembayaranGaji()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {             
               this.orderPembayaranGajis = uow.OrderPembayaranGaji.GetAll().Where(m => m.CheckboxAktif == true);
                DGSalaryPayment.ItemsSource = this.orderPembayaranGajis;
               int sum = 0;
                for (int i = 0; i < DGSalaryPayment.Items.Count; i++)
                {
                    sum += Convert.ToInt32((DGSalaryPayment.Items[i] as OrderPembayaranGaji).Total);
                }
                txtTotalPaymentValue.Text = sum.ToString();
            }
        }
        private void cbcash_change(object sender, SelectionChangedEventArgs e)
        {
            this.dropdownBankkasSelected = null;
            if (cbCashAccount.SelectedItem != null)
            {
                this.dropdownBankkasSelected = (DropdownBankKas)cbCashAccount.SelectedItem;
            }
        }
        private void cbsalaryakun_change(object sender, SelectionChangedEventArgs e)
        {
            this.rekeningPerkiraanSelected = null;
            if (cbSalaryAccount.SelectedItem != null)
            {
                this.rekeningPerkiraanSelected = (RekeningPerkiraan)cbSalaryAccount.SelectedItem;
            }
        }
        private void cbpajak_change(object sender, SelectionChangedEventArgs e)
        {
            this.dataPajakSelected = null;
            if (cbTaxAccount.SelectedItem != null)
            {
                this.dataPajakSelected = (DataPajak)cbTaxAccount.SelectedItem;
            }
        }
        private void cbkontak_change(object sender, SelectionChangedEventArgs e)
        {
            this.kontakSelected = null;
            if (srkontak.SelectedItem != null)
            {
                this.kontakSelected = (Kontak)srkontak.SelectedItem;
            }
        }
        private void btnemployee(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is Employees)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                Employees employees = new Employees(this);
                employees.Show();
            }
        }
        private void SaveNewsalaryPayment_Click(object sender, RoutedEventArgs e)
        {
            if (tgl.Text == "" || cbCashAccount.Text == "" || cbSalaryAccount.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            PembayaranGajiBLL pembayaranBLL = new PembayaranGajiBLL();
            PembayaranGajiBLL PembayarabBLL = new PembayaranGajiBLL();
            PembayaranGaji pembayaran = new PembayaranGaji();
            pembayaran.IdKodeTransaksi = 29;
            pembayaran.Tanggal = DateTime.Parse(tgl.Text);
            if (this.dropdownBankkasSelected != null)
            {
                pembayaran.IdAkunPembGaji = this.dropdownBankkasSelected.Id;
            }
            if (this.rekeningPerkiraanSelected != null)
            {
                pembayaran.IdAkunBiayaGaji = this.rekeningPerkiraanSelected.Id;
            }
            pembayaran.CheckboxPajakGaji = chktax.IsChecked;
            if (this.dataPajakSelected != null)
            {
                pembayaran.IdAkunPajakGaji = this.dataPajakSelected.Id;
            }
            if (this.kontakSelected != null)
            {
                pembayaran.IdKontak = this.kontakSelected.Id;
                pembayaran.NamaPetugas = this.kontakSelected.NamaA;
            }
            pembayaran.TotalSalaryPayment = double.Parse(txtTotalPaymentValue.Text);
            pembayaran.UserId = 1;
            pembayaran.RealRecordingTime = DateTime.Now;
            if (PembayarabBLL.AddPembayaranGaji(pembayaran) > 0)
            {
                //  this.ClearForm();
                MessageBox.Show("Salary Payment successfully added !");
            }
            else
            {
                MessageBox.Show("Salary Payment failed to add !");
            }
            if (DGSalaryPayment.Items.Count > 0)
            {
                foreach (var item in DGSalaryPayment.Items)
                {
                    if (item is OrderPembayaranGaji)
                    {
                        OrderPembayaranGaji oNewData1 = (OrderPembayaranGaji)item;
                        oNewData1.IdPembayaranGaji = pembayaran.IdPembayaranGaji;
                        oNewData1.Tanggal = DateTime.Parse(tgl.Text);
                        if (this.dropdownBankkasSelected != null)
                        {
                            oNewData1.IdAkunPembGaji = this.dropdownBankkasSelected.Id;
                        }
                        if (this.rekeningPerkiraanSelected != null)
                        {
                            oNewData1.IdAkunBiayaGaji = this.rekeningPerkiraanSelected.Id;
                        }
                        if (this.kontakSelected != null)
                        {
                            oNewData1.NamaPetugas = this.kontakSelected.NamaA;
                        }
                        oNewData1.UserId = pembayaran.UserId;
                        oNewData1.IdPeriodeAkuntasi = pembayaran.IdPeriodeAkuntasi;
                        oNewData1.IdKodeTransaksi = pembayaran.IdKodeTransaksi;
                        oNewData1.CheckboxAktif = false;
                        if (pembayaranBLL.EditOrderPembayaranGaji(oNewData1, pembayaran) == true)
                        {
                        }
                    }
                }

                SalaryPayment v = new SalaryPayment();
                Switcher.Switchnewsalary(v);
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.ClearForm();
            SalaryPayment v = new SalaryPayment();
            Switcher.Switchnewsalary(v);
        }
        private void saveasdraft_Click(object sender, RoutedEventArgs e)
        {

        }
        private void importfile_Click(object sender, RoutedEventArgs e)
        {

        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
             
    

