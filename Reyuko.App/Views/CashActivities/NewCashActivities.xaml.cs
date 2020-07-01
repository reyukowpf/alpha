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

namespace Reyuko.App.Views.CashActivities
{
    /// <summary>
    
    /// </summary>
    public partial class NewCashActivities : UserControl
    {
        public NewCashActivities()
        {
            InitializeComponent();            
            Switcher.pageSwitcherNewcash = this;
            this.Init();
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
        private IEnumerable<DropdownPaymentCashActivity> dropdownPaymentCashActivities { get; set; }
        private DropdownPaymentCashActivity dropdownCashActivitySelected;
        private IEnumerable<Kontak> kontaks { get; set; }
        private Kontak kontakSelected;
        public Kontak kontakSelecteds;
        private IEnumerable<DataMataUang> dataMataUangs { get; set; }
        private DataMataUang dataMataUangSelected;
        private IEnumerable<Dokumen> dokumens { get; set; }
        private Dokumen dokumenSelected;
        private IEnumerable<RekeningPerkiraan> rekeningPerkiraans { get; set; }
        private RekeningPerkiraan rekeningPerkiraanSelected;
        public IEnumerable<OrderTransaksiCash> orderTransaksiCashes { get; set; }
        public OrderTransaksiCash orderTransaksiCashSelected;
        private void Init()
        {        
            this.LoadComboTypeCash();
            this.LoadKontak();
            this.LoadCurrency();
            this.LoadDokumen();
            this.LoadCashAkun();
            this.LoadStaff();
        }

        private void LoadComboTypeCash()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dropdownPaymentCashActivities = uow.DropdownPaymentCashActivity.GetAll();
                cbActivitiesType.ItemsSource = this.dropdownPaymentCashActivities;
                cbActivitiesType.SelectedValuePath = "Id";
                cbActivitiesType.DisplayMemberPath = "KategoriTransaksi";
            }
        }
        private void LoadCurrency()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dataMataUangs = uow.DataMataUang.GetAll().Where(m => m.CheckBoxAktif == true);
                cbCurrency.ItemsSource = this.dataMataUangs;
                cbCurrency.SelectedValuePath = "Id";
                cbCurrency.DisplayMemberPath = "NamaMataUang";
            }
        }
        public void LoadDataAccount()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.orderTransaksiCashes = uow.OrderTransaksiCash.GetAll().Where(m => m.Checkboxaktif == true);
                DGCashActivities.ItemsSource = this.orderTransaksiCashes;
                int sum = 0;
                for (int i = 0; i < DGCashActivities.Items.Count; i++)
                {
                    sum += Convert.ToInt32((DGCashActivities.Items[i] as OrderTransaksiCash).Debit1);
                }
                txtTotalPaymentValue.Text = sum.ToString();
            }
        }
        private void LoadCashAkun()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.rekeningPerkiraans = uow.RekeningPerkiraan.GetAll();
                cbCash.ItemsSource = this.rekeningPerkiraans;
                cbCash.SelectedValuePath = "Id";
                cbCash.DisplayMemberPath = "NamaRekeningPerkiraan";
            }
        }
        public void LoadKontak()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kontaks = uow.Kontak.GetAll();
                srkontak.ItemsSource = this.kontaks;
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
        public void LoadDokumen()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dokumens = uow.Dokumen.GetAll();
                srdokumen.ItemsSource = this.dokumens;
            }
        }
        private void Cbtypeactivies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.dropdownCashActivitySelected = null;
            if (cbActivitiesType.SelectedItem != null)
            {
                this.dropdownCashActivitySelected = (DropdownPaymentCashActivity)cbActivitiesType.SelectedItem;
            }
        }
        private void Cbcurrency_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.dataMataUangSelected = null;
            if (cbCurrency.SelectedItem != null)
            {
                this.dataMataUangSelected = (DataMataUang)cbCurrency.SelectedItem;
            }
        }
        private void Cbkontak_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.kontakSelected = null;
            if (srkontak.SelectedItem != null)
            {
                this.kontakSelected = (Kontak)srkontak.SelectedItem;
                txtemail.Text = this.kontakSelected.EmailA;
                txthp.Text = this.kontakSelected.NoHPA;
            }
        }
        private void staff_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.kontakSelecteds = null;
            if (srstaff.SelectedItem != null)
            {
                this.kontakSelecteds = (Kontak)srstaff.SelectedItem;
            }
        }
        private void Cbdokumen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.dokumenSelected = null;
            if (srdokumen.SelectedItem != null)
            {
                this.dokumenSelected = (Dokumen)srdokumen.SelectedItem;
            }
        }
        private void Cbcashakun_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.rekeningPerkiraanSelected = null;
            if (cbCash.SelectedItem != null)
            {
                this.rekeningPerkiraanSelected = (RekeningPerkiraan)cbCash.SelectedItem;
            }
        }
        
        private void Saveactivities_Click(object sender, RoutedEventArgs e)
        {
            if (cbActivitiesType.Text == "" || cbCurrency.Text == "" || tgl.Text == "" || txtCashActivitiesNo.Text == "" || cbCash.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            CashActivityBLL cashBLL = new CashActivityBLL();
            CashActivityBLL CashBLL = new CashActivityBLL();
            CashActivity cash = new CashActivity();
            OrderTransaksiCash ordercash = new OrderTransaksiCash();
            if (this.dropdownCashActivitySelected != null)
            {
                cash.PulldownCashActivities = this.dropdownCashActivitySelected.Id;
                cash.IdKodeTransaksi = this.dropdownCashActivitySelected.IdKodeTransaksi;
                cash.KodeTransaksi = this.dropdownCashActivitySelected.KodeTransaksi;
                cash.KategoriTransaksi = this.dropdownCashActivitySelected.KategoriTransaksi;
            }           
            if (this.kontakSelected != null)
            {
                cash.IdKontak = this.kontakSelected.Id;
                cash.NamaKontak = this.kontakSelected.NamaA;
            }
            cash.Email = txtemail.Text;
            cash.NoHp = double.Parse(txthp.Text);
            if (this.dataMataUangSelected != null)
            {
                cash.IdMataUang = this.dataMataUangSelected.Id;
                cash.MataUang = this.dataMataUangSelected.NamaMataUang;
                cash.KursTukar = this.dataMataUangSelected.KursTukar;
            }
            cash.Tanggal = DateTime.Parse(tgl.Text);
            if (this.dokumenSelected != null)
            {
                cash.IdNoReferensiDokumen = this.dokumenSelected.Id;
                cash.NoReferensiDokumen = this.dokumenSelected.NoReferensiDokumen;
            }
            cash.NoCashActivities = double.Parse(txtCashActivitiesNo.Text);
            if (this.rekeningPerkiraanSelected != null)
            {
                cash.IdAkunKas = this.rekeningPerkiraanSelected.Id;
                cash.NamaAkunKas = this.rekeningPerkiraanSelected.NamaRekeningPerkiraan;
            }           
            if (this.kontakSelecteds != null)
            {
                cash.IdPetugas = this.kontakSelecteds.Id;
                cash.NamaPetugas = this.kontakSelecteds.NamaA;
            }
            cash.Nilai = double.Parse(txtTotalPaymentValue.Text);
            cash.IdPeriodeAkuntansi = 1;            
            cash.RealRecordTime = DateTime.Now;
            if (CashBLL.AddCashActivity(cash) > 0)
            {
                //  this.ClearForm();
                MessageBox.Show("Cash Activity successfully added !");
            }
            else
            {
                MessageBox.Show("Cash Activity failed to add !");
            }
            if (DGCashActivities.Items.Count > 0)
            {
                foreach (var item in DGCashActivities.Items)
                {
                    if (item is OrderTransaksiCash)
                    {
                        OrderTransaksiCash oNewData1 = (OrderTransaksiCash)item;
                        oNewData1.NoReferensiTransaksi = double.Parse(txtCashActivitiesNo.Text);
                        if (this.rekeningPerkiraanSelected != null)
                        {
                            oNewData1.IdAkunHutangPiutangReferensi = this.rekeningPerkiraanSelected.Id;
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
                        }
                    }

                }
                CashActivities v = new CashActivities();
                Switcher.Switchnewcash(v);
            }

  }
        private void btnaccount(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is Account)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                Account account = new Account(this);
                account.Show();
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
            CashActivities v = new CashActivities();
            Switcher.Switchnewcash(v);
        }
        public void dokumen_Click(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is Document.Documentcashactivity)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                Document.Documentcashactivity newDokumen = new Document.Documentcashactivity(this);
                newDokumen.Show();
            }
        }
        private void saveasdraft_Click(object sender, RoutedEventArgs e)
        {

        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TxtCashActivitiesNo_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtCashActivitiesNo.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Harus Diisi Numerik");
                    txtCashActivitiesNo.Text = "";
                    return;
                }

            }
        }

        private void CbCash_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is Giro)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                Giro newGiro = new Giro();
                newGiro.Show();
            }
        }
    }
}
             
    

