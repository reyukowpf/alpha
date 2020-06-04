using Reyuko.BLL.Core;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Reyuko.App.Views.GeneralJournal
{
    /// <summary>

    /// </summary>
    public partial class NewGeneralJournal : UserControl
    {
        public NewGeneralJournal(GeneralJournal generalForm)
        {
            InitializeComponent();
            this.generalForm = generalForm;
            Switcher.pageSwitcherNewjurnal = this;
            this.Init();
        }
        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        private IEnumerable<DataMataUang> dataMataUangs { get; set; }
        public DataMataUang dataMataUangselected;
        public IEnumerable<OrderJurnalUmum> orderJurnalUmums { get; set; }
        private IEnumerable<TransaksiJurnalUmum> transaksiJurnalUmums { get; set; }
        private IEnumerable<Dokumen> dokumens { get; set; }
        public Dokumen dokumenSelected;
        private IEnumerable<BukuBesar> bukuBesars { get; set; }
        public IEnumerable<RekeningPerkiraan> rekeningPerkiraans { get; set; }
        private IEnumerable<Kontak> kontaks { get; set; }
        public Kontak kontakSelected;
        public GeneralJournal generalForm;
        private void Init()
        {
            this.ClearForm();
            this.LoadComboCurrency();
            this.LoadSrnodokumen();
            this.LoadSrKontak();
        }

        private void ClearForm()
        {
            Tanggaljurnalumum.Text = DateTime.Now.ToShortDateString();
            this.dokumenSelected = null;
            srnodokumen.Text = "";
            nojurnal.Text = "";
            this.dataMataUangselected = null;
            cbcurrency.SelectedIndex = -1;
            txtnote.Text = "";
            txttotaldebit.Text = "0";
            txttotalkredit.Text = "0";
            txtbalance.Text = "0";
            this.kontakSelected = null;
            srstaff.Text = "";
        }


        public void LoadSrnodokumen()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dokumens = uow.Dokumen.GetAll();
                srnodokumen.ItemsSource = this.dokumens;
            }
        }
        public void LoadSrKontak()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kontaks = uow.Kontak.GetAll().Where(m => m.TypeKontak.ToLower() == "employee");
                srstaff.ItemsSource = this.kontaks;
            }
        }
        public void LoadDataAccount()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.orderJurnalUmums = uow.OrderJurnalUmum.GetAll().Where(m => m.Chkaktif == true);
                DGJurnal.ItemsSource = this.orderJurnalUmums;
                int sum = 0;
                for (int i = 0; i < DGJurnal.Items.Count; i++)
                {
                    sum += Convert.ToInt32((DGJurnal.Items[i] as OrderJurnalUmum).Debit);
                }
                txttotaldebit.Text = sum.ToString();
                int suma = 0;
                for (int i = 0; i < DGJurnal.Items.Count; i++)
                {
                    suma += Convert.ToInt32((DGJurnal.Items[i] as OrderJurnalUmum).Kredit);
                }
                txttotalkredit.Text = suma.ToString();
                txtbalance.Text = (float.Parse(txttotalkredit.Text) - float.Parse(txttotaldebit.Text)).ToString();
            }
        }
        private void LoadComboCurrency()
        {
            this.dataMataUangs = new List<DataMataUang>();
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dataMataUangs = uow.DataMataUang.GetAll();
                cbcurrency.DisplayMemberPath = "KodeMataUang";
                cbcurrency.SelectedValuePath = "Id";
                cbcurrency.ItemsSource = this.dataMataUangs;
            }
        }

        private void cbkontak_Change(object sender, SelectionChangedEventArgs e)
        {
            this.kontakSelected = null;
            if (srstaff.SelectedItem != null)
            {
                this.kontakSelected = (Kontak)srstaff.SelectedItem;
            }
        }
        private void cbdokumen_Change(object sender, SelectionChangedEventArgs e)
        {
            this.dokumenSelected = null;
            if (srnodokumen.SelectedItem != null)
            {
                this.dokumenSelected = (Dokumen)srnodokumen.SelectedItem;
            }
        }


        private void cbcurrency_Change(object sender, SelectionChangedEventArgs e)
        {
            this.dataMataUangselected = null;
            if (cbcurrency.SelectedItem != null)
            {
                this.dataMataUangselected = (DataMataUang)cbcurrency.SelectedItem;
            }

        }

        private void ComboBox_KeyUp(object sender, KeyEventArgs e)
        {
            cbcurrency.IsDropDownOpen = true;
        }

        private void dgvitemdetails_CurrentCellChanged(object sender, EventArgs e)
        {
     
        }
   
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (Tanggaljurnalumum.Text == "" || nojurnal.Text == "" || cbcurrency.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            TransaksiJurnalUmumBLL transaksiJurnalUmumBLL = new TransaksiJurnalUmumBLL();
            TransaksiJurnalUmumBLL TransaksiJurnalUmumBLL = new TransaksiJurnalUmumBLL();
            TransaksiJurnalUmum transaksiJurnal = new TransaksiJurnalUmum();
            OrderJurnalUmum jurnalUmum = new OrderJurnalUmum();
            BukuBesar bukubesar = new BukuBesar();
            transaksiJurnal.TotalDebit = double.Parse(txttotaldebit.Text);
            transaksiJurnal.TotalKredit = double.Parse(txttotalkredit.Text);
            transaksiJurnal.Balance = double.Parse(txtbalance.Text);
            transaksiJurnal.NoTransaksiJurnalUmum = double.Parse(nojurnal.Text);
            transaksiJurnal.Keterangan = txtnote.Text;
            transaksiJurnal.Tanggal = DateTime.Parse(Tanggaljurnalumum.Text);
            transaksiJurnal.IdKodeTransaksi = 1;
            transaksiJurnal.IdReferalTransaksi = 1;
            transaksiJurnal.IdPeriodeAkuntasi = 1;
            if (this.dataMataUangselected != null)
            {
                transaksiJurnal.IdMataUang = this.dataMataUangselected.Id;
                transaksiJurnal.MataUang = this.dataMataUangselected.KodeMataUang;
                transaksiJurnal.Kurs = this.dataMataUangselected.KursTukar;
            }
            if (this.kontakSelected != null)
            {
                transaksiJurnal.IdPetugas = this.kontakSelected.Id;
                transaksiJurnal.NamaPetugas = this.kontakSelected.NamaA;
            }
            if (double.Parse(txtbalance.Text) != 0)
            {
                MessageBox.Show("Total Balance Must 0 !");
                return;
            }
            if (this.dokumenSelected != null)
            {
                transaksiJurnal.IdNoRefensiDokumen = this.dokumenSelected.Id;
                transaksiJurnal.NoRefensiDokumen = this.dokumenSelected.NoReferensiDokumen;
            }
            transaksiJurnal.RealRecordingTime = DateTime.Now;
            if (TransaksiJurnalUmumBLL.AddTransaksiJurnalUmum(transaksiJurnal) > 0)
            {
                //  this.ClearForm();
                MessageBox.Show("General Journal successfully added !");
            }
            else
            {
                MessageBox.Show("General Journal failed to add !");
            }
            if (DGJurnal.Items.Count > 0)
                {
                    foreach (var item in DGJurnal.Items)
                    {
                        if (item is OrderJurnalUmum)
                        {
                            OrderJurnalUmum oNewData1 = (OrderJurnalUmum)item;
                            oNewData1.IdKodeTransaksi = 1;
                            oNewData1.IdReferalTransaksi = 1;
                            oNewData1.IdPeriodeAkuntasi = 1;
                            oNewData1.Tanggal = DateTime.Parse(Tanggaljurnalumum.Text);
                            oNewData1.NoTransaksiJurnalUmum = double.Parse(nojurnal.Text);
                            oNewData1.Keterangan = txtnote.Text;
                            if (this.dataMataUangselected != null)
                            {
                                oNewData1.IdMataUang = this.dataMataUangselected.Id;
                                oNewData1.MataUang = this.dataMataUangselected.KodeMataUang;
                                oNewData1.Kurs = this.dataMataUangselected.KursTukar;
                            }
                            if (this.kontakSelected != null)
                            {
                                oNewData1.IdPetugas = this.kontakSelected.Id;
                                oNewData1.NamaPetugas = this.kontakSelected.NamaA;
                            }
                            oNewData1.IdTransaksiJurnalUmum = transaksiJurnal.IdTransaksiJurnalUmum;
                            oNewData1.Chkaktif = false;
                            if (transaksiJurnalUmumBLL.EditJurnalUmum(oNewData1, transaksiJurnal) == true)
                            {
                            }
                        }
                   
                }
                  GeneralJournal v = new GeneralJournal();
                  Switcher.Switchnewjurnal(v);
            }
        }

        private void Btncancel_Click(object sender, RoutedEventArgs e)
        {
            this.ClearForm();
            GeneralJournal v = new GeneralJournal();
            Switcher.Switchnewjurnal(v);
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
      
        private void Nojurnal_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = nojurnal.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    InfoMail.Content = "Must Have Numeric!!!";
                    nojurnal.Text = "";
                    return;
                }
                else
                {
                    InfoMail.Content = "Ok";
                }

            }
        }

      
    }
}
