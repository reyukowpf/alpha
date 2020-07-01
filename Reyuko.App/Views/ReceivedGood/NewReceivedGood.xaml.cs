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
using Reyuko.App.Views.Document;
using DevExpress.Xpf.Editors.Helpers;

namespace Reyuko.App.Views.ReceivedGood
{
    /// <summary>

    /// </summary>
    public partial class NewReceivedGood : UserControl
    {
        public NewReceivedGood()
        {
            InitializeComponent();
            Switcher.pageSwitcherNewreceived = this;
            this.Init();
        }



        private void Clearform()
        {
            dtDelivery.Text = DateTime.Now.ToShortDateString();
            dtReceived.Text = DateTime.Now.ToShortDateString();
            dtAnnual.Text = DateTime.Now.ToShortDateString();
        }

        public IEnumerable<Receivedgood> receivedGoods { get; set; }
        private IEnumerable<Kontak> kontaks { get; set; }
        public Kontak kontakSelected { get; set; }
        private IEnumerable<DataMataUang> dataMataUangs { get; set; }
        private DataMataUang DataMataUangSelected { get; set; }
        public IEnumerable<Dokumen> dokumens { get; set; }
        public Dokumen dokumenSelected { get; set; }
        public IEnumerable<Lokasi> lokasis { get; set; }
        public IEnumerable<produk> produks { get; set; }
        public produk produkSelected;
        public Lokasi lokasiSelected;
        public IEnumerable<OptionAnnual> optionAnnuals { get; set; }
        public OptionAnnual optionAnnualSelected;
        public IEnumerable<OrderProdukBeli> orderProdukBelis { get; set; }
        public IEnumerable<Termspembayaran> termspembayarans { get; set; }
        public Termspembayaran termspembayaranSelected;
        public IEnumerable<DataDepartemen> dataDepartemens { get; set; }
        public DataDepartemen dataDepartemenSelected;
        public IEnumerable<DataProyek> dataProyeks { get; set; }
        public DataProyek dataProyekSelected;
        public IEnumerable<DropdownBankKas> dropdownBankKas { get; set; }
        public DropdownBankKas dropdownBankKasSelected;
        public IEnumerable<PurchaseOrder> purchaseOrders { get; set; }
        public PurchaseOrder purchaseOrderSelected { get; set; }
        public IEnumerable<Purchasedelivery> purchasedeliveries { get; set; }
        public IEnumerable<ListOrderBeli> listOrderBelis { get; set; }
        public Purchasedelivery purchaseDeliverySelected { get; set; }
        public Kontak petugasSelected;

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        private void Init()
        {
            this.LoadVendor();
            this.LoadNoDokumen();
            this.LoadCurrency();
            this.LoadLokasi();
            this.LoadAnnual();
            this.LoadStaff();
            this.LoadCash();
            this.Clearform();
            this.Loadproduk();
            // this.LoadPO();
            //   this.LoadPD();
        }

        private void LoadPD()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.purchasedeliveries = uow.PurchaseDelivery.GetAll().Where(m => m.IdVendor == this.kontakSelected.Id).Where(m => m.Checkboxaktif == true);
                cbPurchasedelivery.ItemsSource = this.purchasedeliveries;
                cbPurchasedelivery.SelectedValuePath = "IdPengirimanBarangPembelian";
                cbPurchasedelivery.DisplayMemberPath = "NoPengirimanBarangPembelian";
            }
        }
        private void wat(object sender, RoutedEventArgs e)
        {
            totall.Visibility = Visibility.Collapsed;
            txttotal.Visibility = Visibility.Visible;
            txttotal.Focus();
        }
        private void wata(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(txttotal.Text))
            {
                totall.Visibility = Visibility.Visible;
                txttotal.Visibility = Visibility.Collapsed;
            }
        }
        private void watkustom(object sender, RoutedEventArgs e)
        {
            namakustom.Visibility = Visibility.Collapsed;
            txtnamacustom.Visibility = Visibility.Visible;
            txtnamacustom.Focus();
        }
        private void watakustom(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtnamacustom.Text))
            {
                namakustom.Visibility = Visibility.Visible;
                txtnamacustom.Visibility = Visibility.Collapsed;
            }
        }
        private void orderkustoma(object sender, RoutedEventArgs e)
        {
            orderkustom.Visibility = Visibility.Collapsed;
            txttotalordercustom.Visibility = Visibility.Visible;
            txttotalordercustom.Focus();
        }
        private void totalorderkustom(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txttotalordercustom.Text))
            {
                orderkustom.Visibility = Visibility.Visible;
                txttotalordercustom.Visibility = Visibility.Collapsed;
            }
        }
        private void pricekustomaa(object sender, RoutedEventArgs e)
        {
            pricekustom.Visibility = Visibility.Collapsed;
            txtpricecustom.Visibility = Visibility.Visible;
            txtpricecustom.Focus();
        }
        private void pricekustoma(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txttotalordercustom.Text))
            {
                pricekustom.Visibility = Visibility.Visible;
                txtpricecustom.Visibility = Visibility.Collapsed;
            }
        }
        private void sku2(object sender, RoutedEventArgs e)
        {
          }
        private void sku1(object sender, RoutedEventArgs e)
        {
          }
        private void PD_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.purchaseDeliverySelected = null;
            if (cbPurchasedelivery.SelectedItem != null)
            {
                this.purchaseDeliverySelected = (Purchasedelivery)cbPurchasedelivery.SelectedItem;
                this.LoadDataSku();
                this.LoadPO();
                txtNote.Text = this.purchaseDeliverySelected.Keterangan;
                cbLocation.SelectedValue = this.purchaseDeliverySelected.IdLokasi;
                dtReceived.Text = this.purchaseDeliverySelected.TanggalPengantaran.GetValueOrDefault().ToShortDateString();
                cbCurrency.SelectedValue = this.purchaseDeliverySelected.IdMataUang;
                srnodokumen.Text = this.purchaseDeliverySelected.NoReferensiDokumen.ToString();
                cbPurchaseorder.SelectedValue = this.purchaseDeliverySelected.IdOrderPembelian;
                cbDepartment.SelectedValue = this.purchaseDeliverySelected.IdDepartemen;
                cbProyek.SelectedValue = this.purchaseDeliverySelected.IdProyek;
                txttax1.Text = this.purchaseDeliverySelected.IdTransaksi.GetValueOrDefault().ToString();
                chktax.IsChecked = this.purchaseDeliverySelected.CheckboxInclusiveTax.GetValueOrDefault();
                dtDelivery.Text = this.purchaseDeliverySelected.TanggalPengirimanBarangPembelian.GetValueOrDefault().ToShortDateString();
                dtAnnual.Text = this.purchaseDeliverySelected.TanggalBerulang.GetValueOrDefault().ToShortDateString();
                srstaff.Text = this.purchaseDeliverySelected.NamaPetugas;
                chkannual.IsChecked = this.purchaseDeliverySelected.CheckboxBerulang.GetValueOrDefault();
                cbAnnual.SelectedValue = this.purchaseDeliverySelected.IdOpsiAnnual.ToString();
                txtAnnualFrequency.Text = this.purchaseDeliverySelected.DurationBerulang.ToString();
    
            }
        }
        private void txttax_TextChanged(object sender, TextChangedEventArgs e)
        {
            txttota.Text = txttax1.Text;
        }
        public void LoadDataSku()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.listOrderBelis = uow.ListOrderBeli.GetAll().Where(m => m.IdTransaksi == this.purchaseDeliverySelected.IdTransaksi);
                DGSKUReceivedGood.ItemsSource = this.listOrderBelis;
                int sum = 0;
                for (int i = 0; i < DGSKUReceivedGood.Items.Count; i++)
                {
                    sum += Convert.ToInt32((DGSKUReceivedGood.Items[i] as ListOrderBeli).TotalPajakProduk);
                }
                txtTotalprodukTax.Text = sum.ToString();
                int sum1 = 0;
                for (int i = 0; i < DGSKUReceivedGood.Items.Count; i++)
                {
                    sum1 += Convert.ToInt32((DGSKUReceivedGood.Items[i] as ListOrderBeli).TotalPajakJasa);
                }
                txtTotaljasaTax.Text = sum1.ToString();
                int sum2 = 0;
                for (int i = 0; i < DGSKUReceivedGood.Items.Count; i++)
                {
                    sum2 += Convert.ToInt32((DGSKUReceivedGood.Items[i] as ListOrderBeli).TotalPajak);
                }
                txtTotalTax.Text = sum2.ToString();
                int sumar = 0;
                for (int i = 0; i < DGSKUReceivedGood.Items.Count; i++)
                {
                    sumar += Convert.ToInt32((DGSKUReceivedGood.Items[i] as ListOrderBeli).TotalOrderProduk);
                }
                txttotalprodukbeforetax.Text = sumar.ToString();
                int sumar1 = 0;
                for (int i = 0; i < DGSKUReceivedGood.Items.Count; i++)
                {
                    sumar1 += Convert.ToInt32((DGSKUReceivedGood.Items[i] as ListOrderBeli).TotalOrderJasa);
                }
                txttotaljasabeforetax.Text = sumar1.ToString();
                int sumar2 = 0;
                for (int i = 0; i < DGSKUReceivedGood.Items.Count; i++)
                {
                    sumar2 += Convert.ToInt32((DGSKUReceivedGood.Items[i] as ListOrderBeli).TotalOrder);
                }
                txttotalbeforetax.Text = sumar2.ToString();
                txtAfterTotalTax.Text = (float.Parse(sumar2.ToString()) + float.Parse(txtTotalTax.Text)).ToString();
            }
        }

        public void LoadDataSku1()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.listOrderBelis = uow.ListOrderBeli.GetAll().Where(m => m.Checkboxaktif == true);
                DGSKUReceivedGood.ItemsSource = this.listOrderBelis;
                int sum = 0;
                for (int i = 0; i < DGSKUReceivedGood.Items.Count; i++)
                {
                    sum += Convert.ToInt32((DGSKUReceivedGood.Items[i] as ListOrderBeli).TotalPajakProduk);
                }
                txtTotalprodukTax.Text = sum.ToString();
                int sum1 = 0;
                for (int i = 0; i < DGSKUReceivedGood.Items.Count; i++)
                {
                    sum1 += Convert.ToInt32((DGSKUReceivedGood.Items[i] as ListOrderBeli).TotalPajakJasa);
                }
                txtTotaljasaTax.Text = sum1.ToString();
                int sum2 = 0;
                for (int i = 0; i < DGSKUReceivedGood.Items.Count; i++)
                {
                    sum2 += Convert.ToInt32((DGSKUReceivedGood.Items[i] as ListOrderBeli).TotalPajak);
                }
                txtTotalTax.Text = sum2.ToString();
                int sumar = 0;
                for (int i = 0; i < DGSKUReceivedGood.Items.Count; i++)
                {
                    sumar += Convert.ToInt32((DGSKUReceivedGood.Items[i] as ListOrderBeli).TotalOrderProduk);
                }
                txttotalprodukbeforetax.Text = sumar.ToString();
                int sumar1 = 0;
                for (int i = 0; i < DGSKUReceivedGood.Items.Count; i++)
                {
                    sumar1 += Convert.ToInt32((DGSKUReceivedGood.Items[i] as ListOrderBeli).TotalOrderJasa);
                }
                txttotaljasabeforetax.Text = sumar1.ToString();
                int sumar2 = 0;
                for (int i = 0; i < DGSKUReceivedGood.Items.Count; i++)
                {
                    sumar2 += Convert.ToInt32((DGSKUReceivedGood.Items[i] as ListOrderBeli).TotalOrder);
                }
                txttotalbeforetax.Text = sumar2.ToString();
                txtAfterTotalTax.Text = (float.Parse(sumar2.ToString()) + float.Parse(txtTotalTax.Text)).ToString();

            }
        }
        private void LoadPO()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.purchaseOrders = uow.PurchaseOrder.GetAll().Where(m => m.IdTransaksi == this.purchaseDeliverySelected.IdTransaksi);
                cbPurchaseorder.ItemsSource = this.purchaseOrders;
                cbPurchaseorder.SelectedValuePath = "IdOrderPembelian";
                cbPurchaseorder.DisplayMemberPath = "NoOrderPembelian";
            }
        }
        private void PO_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.purchaseOrderSelected = null;
            if (cbPurchaseorder.SelectedItem != null)
            {
                this.purchaseOrderSelected = (PurchaseOrder)cbPurchaseorder.SelectedItem;
                txtNote.Text = this.purchaseOrderSelected.Keterangan;
            }
        }
        public void LoadPaymentTerms()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.termspembayarans = uow.Termspembayaran.GetAll();
                cbPayment.ItemsSource = this.termspembayarans;
                cbPayment.SelectedValuePath = "Id";
                cbPayment.DisplayMemberPath = "NamaSkema";
            }
        }
        private void payment_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.termspembayaranSelected = null;
            if (cbPayment.SelectedItem != null)
            {
                termspembayaranSelected = (Termspembayaran)cbPayment.SelectedItem;
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
        private void LoadLokasi()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.lokasis = uow.Lokasi.GetAll();
                cbLocation.ItemsSource = this.lokasis;
                cbLocation.SelectedValuePath = "Id";
                cbLocation.DisplayMemberPath = "NamaTempatLokasi";
            }
        }
        private void LoadCash()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dropdownBankKas = uow.DropdownBankKas.GetAll();
                cbCash.ItemsSource = this.dropdownBankKas;
                cbCash.SelectedValuePath = "Id";
                cbCash.DisplayMemberPath = "DropdownBankkas";
            }
        }


        private void LoadAnnual()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.optionAnnuals = uow.OptionAnnual.GetAll();
                cbAnnual.ItemsSource = this.optionAnnuals;
                cbAnnual.SelectedValuePath = "IdOptionAnnual";
                cbAnnual.DisplayMemberPath = "Annual";
            }
        }
        public void LoadVendor()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kontaks = uow.Kontak.GetAll().Where(m => m.TypeKontak.ToLower() == "vendor");
                srvendor.ItemsSource = this.kontaks;
            }
        }
        private void vendor_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.kontakSelected = null;
            if (srvendor.SelectedItem != null)
            {
                this.kontakSelected = (Kontak)srvendor.SelectedItem;
                txtemail.Text = this.kontakSelected.EmailA;
                txthp.Text = this.kontakSelected.NoHPA;
                this.LoadPD();
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
        public void LoadDepartmen()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dataDepartemens = uow.DataDepartemen.GetAll();
                cbDepartment.ItemsSource = this.dataDepartemens;
                cbDepartment.SelectedValuePath = "Id";
                cbDepartment.DisplayMemberPath = "NamaDepartemen";
            }
        }

        public void LoadProyek()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dataProyeks = uow.DataProyek.GetAll();
                cbProyek.ItemsSource = this.dataProyeks;
                cbProyek.SelectedValuePath = "Id";
                cbProyek.DisplayMemberPath = "NamaProyek";
            }
        }
        private void staff_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.petugasSelected = null;
            if (srstaff.SelectedItem != null)
            {
                this.petugasSelected = (Kontak)srstaff.SelectedItem;
            }
        }
        private void cash_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.dropdownBankKasSelected = null;
            if (cbCash.SelectedItem != null)
            {
                this.dropdownBankKasSelected = (DropdownBankKas)cbCash.SelectedItem;
            }
        }
        private void currency_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.DataMataUangSelected = null;
            if (cbCurrency.SelectedItem != null)
            {
                this.DataMataUangSelected = (DataMataUang)cbCurrency.SelectedItem;
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
        private void lokasi_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.lokasiSelected = null;
            if (cbLocation.SelectedItem != null)
            {
                this.lokasiSelected = (Lokasi)cbLocation.SelectedItem;
            }
        }
        private void department_selectionchange(object sender, SelectionChangedEventArgs e)
        {
            this.dataDepartemenSelected = null;
            if (cbDepartment.SelectedItem != null)
            {
                dataDepartemenSelected = (DataDepartemen)cbDepartment.SelectedItem;
            }
        }
        private void proyek_selectionchange(object sender, SelectionChangedEventArgs e)
        {
            this.dataProyekSelected = null;
            if (cbProyek.SelectedItem != null)
            {
                dataProyekSelected = (DataProyek)cbProyek.SelectedItem;
            }
        }
        private void annual_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.optionAnnualSelected = null;
            if (cbAnnual.SelectedItem != null)
            {
                this.optionAnnualSelected = (OptionAnnual)cbAnnual.SelectedItem;
            }
        }

        private void vendor_Click(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is Vendor.Vendorsgood)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                Vendor.Vendorsgood newVendor = new Vendor.Vendorsgood(this);
                newVendor.Show();
            }
        }
        public void dokumen_Click(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is Document.Documentgood)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                Document.Documentgood newdokumen = new Document.Documentgood(this);
                newdokumen.Show();
            }
        }

        private void Savereceivedgood_Click(object sender, RoutedEventArgs e)
        {
            if (dtReceived.Text == "" || cbCurrency.Text == "" || txtReceivedNumber.Text == "" || cbCash.Text == "" || cbLocation.Text == "" || dtDelivery.Text == "" || cbAnnual.Text == "" || txtAnnualFrequency.Text == "" || dtAnnual.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            ReceivedGoodsBLL goodBLL = new ReceivedGoodsBLL();
            Receivedgood receivedgood = new Receivedgood();
            PurchasedeliveryBLL purchasedeliveryBLL = new PurchasedeliveryBLL();
            receivedgood.IdKodeTransaksi = 8;
            receivedgood.KodeTransaksi = "PJ";
            receivedgood.IdPeriodeAkutansi = 1;
            receivedgood.NoOrder = txtReceivedNumber.Text;
            if (this.kontakSelected != null)
            {
                receivedgood.IdVendor = this.kontakSelected.Id;
                receivedgood.NamaVendor = this.kontakSelected.NamaA;
            }
            receivedgood.Email = txtemail.Text;
            receivedgood.NoHp = txthp.Text;
            receivedgood.TanggalOrder = DateTime.Parse(dtReceived.Text);
            if (this.DataMataUangSelected != null)
            {
                receivedgood.IdMataUang = this.DataMataUangSelected.Id;
                receivedgood.MataUang = this.DataMataUangSelected.KodeMataUang;
                receivedgood.KursTukar = this.DataMataUangSelected.KursTukar;
            }
            if (this.dokumenSelected != null)
            {
                receivedgood.IdNoReferensiDokumen = this.dokumenSelected.Id;
                receivedgood.NoReferensiDokumentNi = this.dokumenSelected.NoReferensiDokumen;
            }
            receivedgood.NoOrderPembeliaan = double.Parse(txtReceivedNumber.Text);
            if (this.purchaseDeliverySelected != null)
            {
                receivedgood.IdPD = this.purchaseDeliverySelected.IdPengirimanBarangPembelian;
                receivedgood.NoPD = this.purchaseDeliverySelected.NoPengirimanBarangPembelian;
            }
            if (this.purchaseDeliverySelected != null)
            {
                receivedgood.IdTransaksi = this.purchaseDeliverySelected.IdTransaksi;
            }
            if (this.purchaseOrderSelected != null)
            {
                receivedgood.IdOrderPembeliaan = this.purchaseOrderSelected.IdOrderPembelian;
                receivedgood.NoOrderPembeliaan = this.purchaseOrderSelected.NoOrderPembelian;
            }
            if (this.dropdownBankKasSelected != null)
            {
                receivedgood.IdBankCash = this.dropdownBankKasSelected.Id;
                receivedgood.BankCash = this.dropdownBankKasSelected.DropdownBankkas;
            }
            if (this.lokasiSelected != null)
            {
                receivedgood.IdLokasi = this.lokasiSelected.Id;
                receivedgood.NamaLokasi = this.lokasiSelected.NamaTempatLokasi;
            }
            receivedgood.Keterangan = txtNote.Text;
            if (this.dataDepartemenSelected != null)
            {
                receivedgood.IdDepartmen = this.dataDepartemenSelected.Id;
            }
            if (this.dataProyekSelected != null)
            {
                receivedgood.IdProyek = this.dataProyekSelected.Id;
            }
            receivedgood.CheckboxInclusiveTax = chktax.IsChecked;
            receivedgood.TanggalPengiriman = DateTime.Parse(dtDelivery.Text);
            receivedgood.CheckboxBerulang = chkannual.IsChecked;
            if (this.optionAnnualSelected != null)
            {
                receivedgood.IdOptionAnnual = this.optionAnnualSelected.IdOptionAnnual;
                receivedgood.Annual = this.optionAnnualSelected.Annual;
            }
            if (this.petugasSelected != null)
            {
                receivedgood.IdPetugas = this.petugasSelected.Id;
                receivedgood.NamaPetugas = this.petugasSelected.NamaA;
            }
            receivedgood.CicilanPerbulan = double.Parse(txtAnnualFrequency.Text);
            receivedgood.TanggalBerulang = DateTime.Parse(dtAnnual.Text);
            receivedgood.TotalSebelumPajak = double.Parse(txttotalbeforetax.Text);
            receivedgood.TotalPajak = double.Parse(txtTotalTax.Text);
            receivedgood.TotalDebitAkunPajakProduk = double.Parse(txtTotalTax.Text);
            receivedgood.TotalDebitAkunPersediaanProduk = double.Parse(txttotalbeforetax.Text);
            receivedgood.TotalSetelahPajak = double.Parse(txtAfterTotalTax.Text);
            //receivedgood.SaldoTerhutang = double.Parse(txtoutstanding.Text);

            receivedgood.RealRecordingTime = DateTime.Now;
            receivedgood.Checkboxaktif = true;
            if (goodBLL.AddReceivedGoods(receivedgood) > 0)
            {
                //  this.ClearForm();
                MessageBox.Show("Received Good successfully added !");
            }
            else
            {
                MessageBox.Show("Received Good failed to add !");
            }
            if (DGSKUReceivedGood.Items.Count > 0)
            {
                foreach (var item1 in DGSKUReceivedGood.Items)
                {
                    if (item1 is ListOrderBeli)
                    {
                        ListOrderBeli oNewData1 = (ListOrderBeli)item1;
                        oNewData1.Tanggal = DateTime.Parse(dtReceived.Text);
                        if (this.lokasiSelected != null)
                        {
                            oNewData1.IdLokasi = this.lokasiSelected.Id;
                            oNewData1.NamaLokasi = this.lokasiSelected.NamaTempatLokasi;
                        }
                        if (this.dataDepartemenSelected != null)
                        {
                            oNewData1.IdDepartemen = this.dataDepartemenSelected.Id;
                        }
                        if (this.dataProyekSelected != null)
                        {
                            oNewData1.IdProyek = this.dataProyekSelected.Id;
                        }
                        if (int.Parse(txttota.Text) == 0)
                        {
                            oNewData1.IdTransaksi = receivedgood.IdOrder;
                        }
                        if (this.purchaseDeliverySelected != null)
                        {
                            oNewData1.IdTransaksi = this.purchaseDeliverySelected.IdTransaksi;
                        }
                        oNewData1.Checkboxaktif = false;
                        if (goodBLL.EditOrderProdukbeli(oNewData1, receivedgood) == true)
                        {
                        }
                    }
                }
            }
            if (cbPurchasedelivery.Items.Count > 0)
            {
                foreach (var item in cbPurchasedelivery.Items)
                {
                    if (item is Purchasedelivery)
                    {
                        Purchasedelivery oNewData2 = (Purchasedelivery)item;
                        oNewData2.Checkboxaktif = false;
                        if (purchasedeliveryBLL.EditPurchasedelivery(oNewData2) == true)
                        {
                        }
                    }
                }
            }
            ReceivedGood v = new ReceivedGood();
            Switcher.Switchnewreceived(v);
        }
        private void Loadproduk()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.produks = uow.produk.GetAll();
                srsku.ItemsSource = this.produks;
            }
        }
        private void produk_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.produkSelected = null;
            if (srsku.SelectedItem != null)
            {
                this.produkSelected = (produk)srsku.SelectedItem;
                txtunit.Text = this.produkSelected.SatuanDasar;
                txtprice.Text = this.produkSelected.HargaBeli.ToString();
                txtdiskon.Text = this.produkSelected.DiskonProdukPersen;
                txttax.Text = this.produkSelected.PersentasePajak.ToString();
                txtdiskon1.Text = ((float.Parse(txtprice.Text.ToString()) * float.Parse(txtdiskon.Text.ToString()) / 100)).ToString();
            }
        }
        public OrderProdukBeli GetData()
        {
            OrderProdukBeli oData = new OrderProdukBeli();
            if (this.produkSelected != null)
            {
                oData.IdProduk = this.produkSelected.IdProduk;
                oData.ProdukKategori = this.produkSelected.ProdukKategori;
                oData.Sku = this.produkSelected.SKU;
                oData.SatuanDasar = this.produkSelected.SatuanDasar;
                oData.IdPajak = this.produkSelected.IdPajak;
                oData.NamaPajak = this.produkSelected.Pajak;
                oData.PersentasePajak = this.produkSelected.PersentasePajak;
                oData.HargaBeli = this.produkSelected.HargaBeli;
                oData.IdAkunPajakProduk = this.produkSelected.IdAkunPajak;
                oData.NamaProduk = this.produkSelected.NamaProduk;
                oData.IdTypeProduk = this.produkSelected.IdTipeProduk;
                oData.TypeProduk = this.produkSelected.TipeProduk;
                oData.AkunPersediaan = this.produkSelected.IdAkunPersediaan;
                oData.AkunPengirimanBeli = this.produkSelected.IdAkunPengirimanBeli;
            }
            oData.TotalPajakProduk = double.Parse(txttotaltax.Text);
            oData.IdTransaksi = int.Parse(txttota.Text);
            oData.DiskonProduk = double.Parse(txtdiskon1.Text);
            oData.TotalProduk = int.Parse(txttotal.Text);
            oData.TotalOrderProduk = double.Parse(txttotal1.Text);
            oData.Checkboxaktif = true;
            return oData;
        }
        public OrderJasaBeli GetData3()
        {
            OrderJasaBeli oData = new OrderJasaBeli();
            if (this.produkSelected != null)
            {
                oData.IdProduk = this.produkSelected.IdProduk;
                oData.Sku = this.produkSelected.SKU;
                oData.NamaJasa = this.produkSelected.NamaProduk;
                oData.HargaJasa = this.produkSelected.HargaBeli;
                oData.PersentasePajak = this.produkSelected.PersentasePajak;
                oData.IdAkunPajakJasa = this.produkSelected.IdAkunPajak;
                oData.IdPajak = this.produkSelected.IdPajak;
                oData.NamaPajak = this.produkSelected.Pajak;
                oData.IdAkunJasa = this.produkSelected.IdAkunJasa;
            }
            oData.DiskonJasa = double.Parse(txtdiskon1.Text);
            oData.TotalJasa = int.Parse(txttotal.Text);
            oData.IdTransaksi = int.Parse(txttota.Text);
            oData.TotalOrderJasa = double.Parse(txttotal1.Text);
            oData.TotalPajakJasa = double.Parse(txttotaltax.Text);
            oData.Checkboxaktif = true;
            return oData;
        }
        private void txtprice_change(object sender, TextChangedEventArgs e)
        {
            string tString = txtpricecustom.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtpricecustom.Text = "";
                    return;
                }
            }
            txttotal1.Text = ((float.Parse(txttotalordercustom.Text.ToString()) * float.Parse(txtpricecustom.Text.ToString()))).ToString();
        }
        public OrderCustomBeli GetData1()
        {
            OrderCustomBeli oData = new OrderCustomBeli();
            oData.NamaCustom = txtnamacustom.Text;
            oData.HargaCustom = double.Parse(txtpricecustom.Text);
            oData.IdTransaksi = int.Parse(txttota.Text);
            //oData.DiskonProduk = double.Parse(txtdiskon1.Text);
            oData.JumlahCustom = int.Parse(txttotalordercustom.Text);
            oData.TotalCustom = double.Parse(txttotal1.Text);
            oData.Checkboxaktif = true;
            return oData;
        }

        private void txttotal_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txttotal.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txttotal.Text = "";
                    return;
                }
            }
            txttotal1.Text = ((float.Parse(txttotal.Text.ToString()) * float.Parse(txtprice.Text.ToString())) - (float.Parse(txtdiskon.Text.ToString()) / 100 * float.Parse(txtprice.Text.ToString())) * float.Parse(txttotal.Text.ToString())).ToString();
            txttotaltax.Text = (float.Parse(txttotal1.Text.ToString()) * float.Parse(txttax.Text.ToString())).ToString();
        }
        private void produk_Click(object sender, RoutedEventArgs e)
        {
            txttotal.Visibility = Visibility.Visible;
            totall.Visibility = Visibility.Visible;
            srsku.Visibility = Visibility.Visible;
            gg.Visibility = Visibility.Visible;
            /*ShopingchartBLL shopingBLL = new ShopingchartBLL();
            if (shopingBLL.AddOrderProdukbeli(this.GetData()) > 0)
            {
                this.ClearForm1();
                MessageBox.Show("Add Order Buy Product successfully added !");
                if (int.Parse(txttota.Text) != 0)
                {
                    this.LoadDataSku();
                }
                else if (int.Parse(txttota.Text) == 0)
                {
                    this.LoadDataSku1();
                }
            }
            else
            {
                MessageBox.Show("Add Order Buy Product failed to add !");
            }*/
        }

        private void ClearForm1()
        {
            txttotal.Text = "";
            srsku.Text = "";
            txtunit.Text = "";
            txtprice.Text = "";
            txtdiskon.Text = "";
            txttax.Text = "";
            txttotaltax.Text = "";
            txttotal1.Text = "";
            txtdiskon1.Text = "";
        }

        private void ClearForm2()
        {
            txtnamacustom.Text = "";
            txttotalordercustom.Text = "";
            txtpricecustom.Text = "";
            txttotal1.Text = "";
        }
        private void service_Click(object sender, RoutedEventArgs e)
        {
            txttotal.Visibility = Visibility.Visible;
            totall.Visibility = Visibility.Visible;
            srsku.Visibility = Visibility.Visible;
            gg.Visibility = Visibility.Visible;
          /*  ShopingchartBLL shopingBLL = new ShopingchartBLL();
            if (shopingBLL.AddOrderJasabeli(this.GetData3()) > 0)
            {
                this.ClearForm1();
                MessageBox.Show("Add Order Buy Service successfully added !");
                if (int.Parse(txttota.Text) != 0)
                {
                    this.LoadDataSku();
                }
                else if (int.Parse(txttota.Text) == 0)
                {
                    this.LoadDataSku1();
                }
            }
            else
            {
                MessageBox.Show("Add Order Buy Service failed to add !");
            }*/
        }
        private void custom_Click(object sender, RoutedEventArgs e)
        {
            ShopingchartBLL shopingBLL = new ShopingchartBLL();
            if (shopingBLL.AddOrderCustombeli(this.GetData1()) > 0)
            {
                 this.ClearForm2();
                MessageBox.Show("Add Order Buy Custom successfully added !");
                if (int.Parse(txttota.Text) != 0)
                {
                    this.LoadDataSku();
                }
                else if (int.Parse(txttota.Text) == 0)
                {
                    this.LoadDataSku1();
                }
            }
            else
            {
                MessageBox.Show("Add Order Buy Custom failed to add !");
            }
        }
        private void StockList_Click(object sender, RoutedEventArgs e)
        {

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
            ReceivedGood v = new ReceivedGood();
            Switcher.Switchnewreceived(v);
        }


        private void Custom_Click(object sender, RoutedEventArgs e)
        {

        }
        private void notes_Click(object sender, RoutedEventArgs e)
        {

        }
        private void saveasdraft_Click(object sender, RoutedEventArgs e)
        {

        }
        private void saveaspdf_Click(object sender, RoutedEventArgs e)
        {

        }
        private void duplicate_Click(object sender, RoutedEventArgs e)
        {

        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TxtReceivedNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtReceivedNumber.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtReceivedNumber.Text = "";
                    return;
                }

            }
        }

        private void TxtAnnualFrequency_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtAnnualFrequency.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtAnnualFrequency.Text = "";
                    return;
                }

            }

        }
        private void rbPayment_Checked(object sender, RoutedEventArgs e)
        {
            this.rbPayment.IsChecked = true;
            {
                cbPayment.Visibility = Visibility.Visible;
                cbCash1.Visibility = Visibility.Hidden;
                cbCash1.SelectedIndex = -1;
                this.LoadPaymentTerms();
            }
        }

        private void rbCash_Checked(object sender, RoutedEventArgs e)
        {
            this.rbCash.IsChecked = true;
            {
                cbCash1.Visibility = Visibility.Visible;
                cbPayment.Visibility = Visibility.Hidden;
                cbPayment.SelectedIndex = -1;
                //    this.lo();
            }
        }
        private void Rbdepartmen_Checked(object sender, RoutedEventArgs e)
        {
            this.rbdepartmen.IsChecked = true;
            {
                cbDepartment.Visibility = Visibility.Visible;
                cbProyek.Visibility = Visibility.Hidden;
                cbProyek.SelectedIndex = -1;
                this.LoadDepartmen();
            }
        }

        private void Rbproyek_Checked(object sender, RoutedEventArgs e)
        {
            this.rbproyek.IsChecked = true;
            {
                cbProyek.Visibility = Visibility.Visible;
                cbDepartment.Visibility = Visibility.Hidden;
                cbDepartment.SelectedIndex = -1;
                this.LoadProyek();
            }
        }

    }
}



