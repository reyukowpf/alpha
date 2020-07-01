using DevExpress.Mvvm.Native;
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

namespace Reyuko.App.Views.PurchaseDocument
{
    /// <summary>

    /// </summary>
    public partial class NewQuotationRequest : UserControl
    {
        public NewQuotationRequest()
        {
            InitializeComponent();
            Switcher.pageSwitchNewQuotationRequest = this;
            this.Init();
        }
        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
        public IEnumerable<Kontak> kontaks { get; set; }
        public Kontak kontakSelected { get; set; }
        private IEnumerable<DataMataUang> dataMataUangs { get; set; }
        private DataMataUang DataMataUangSelected { get; set; }
        public IEnumerable<Dokumen> dokumens { get; set; }
        public Dokumen dokumenSelected { get; set; }
        public IEnumerable<Lokasi> lokasi { get; set; }
        public Lokasi lokasiSelected { get; set; }
        public IEnumerable<OptionAnnual> optionAnnuals { get; set; }
        public OptionAnnual optionAnnualSelected { get; set; }
        public IEnumerable<produk> produks { get; set; }
        public produk produkSelected;
        public IEnumerable<DataDepartemen> dataDepartemens { get; set; }
        public IEnumerable<DataProyek> dataProyeks { get; set; }
        public IEnumerable<Termspembayaran> termspembayarans { get; set; }
        public Termspembayaran termspembayaranSelected;
        public Kontak petugasSelected;
        public DataDepartemen dataDepartemenSelected;
        public IEnumerable<ListOrderBeli> listOrderBelis { get; set; }
        public IEnumerable<Quotationrequest> quotationrequests { get; set; }
        public DataProyek dataProyekSelected;
        public IEnumerable<Shopingchart> shopingcharts { get; set; }
        public Shopingchart shopingchartSelected;
        public bool isEdit = false;
        private void Init()
        {
            this.ClearForm();
            this.LoadVendor();
            this.LoadStaff();
            this.Loadproduk();
            this.LoadNoDokumen();
            this.LoadCurrency();
            this.LoadLokasi();
            this.LoadAnnual();
            this.LoadShopingchart();
        }
        private void ClearForm()
        {
            srvendor.Text = "";
            txtemail.Text = "";
            txthp.Text = "";
            dtQuotation.Text = DateTime.Now.ToShortDateString();
            cbCurrency.SelectedIndex = -1;
            srnodokumen.Text = "";
            txtQuotationNo.Text = "";
            cbRequestNo.SelectedIndex = -1;
            txtNote.Text = "";
            cbLocation.SelectedIndex = -1;
            cbDepartment.SelectedIndex = -1;
            cbProyek.SelectedIndex = -1;
            chkhide.IsChecked = false;
            chkcomplete.IsChecked = false;
            chkinclusive.IsChecked = false;
            rbdepartmen.IsChecked = false;
            rbprojec.IsChecked = false;
            dtValidaty.Text = DateTime.Now.ToShortDateString();
            chkannual.IsChecked = false;
            cbAnnual.SelectedIndex = -1;
            srstaff.Text = "";
            txtAnnualFrequency.Text = "";
            dtAnnual.Text = DateTime.Now.ToShortDateString();
            txtTotalTax.Text = "";
            txtAfterTotalTax.Text = "";
            txtPaid.Text = "";
            txtInstallments.Text = "";
            txtDuedate.Text = "";
            cbRequestNo.SelectedIndex = -1;
        }
        public void LoadVendor()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kontaks = uow.Kontak.GetAll().Where(m => m.TypeKontak.ToLower() == "vendor");
                srvendor.ItemsSource = this.kontaks;
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
        public void LoadShopingchart()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.shopingcharts = uow.Shopingchart.GetAll().Where(m => m.Checkaktif == true);
                cbRequestNo.ItemsSource = this.shopingcharts;
                cbRequestNo.SelectedValuePath = "IdPermintaanBarang";
                cbRequestNo.DisplayMemberPath = "NoPermintaanBarang";
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
        private void Loadproduk()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.produks = uow.produk.GetAll();
                srsku.ItemsSource = this.produks;
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
        private void wat(object sender, RoutedEventArgs e)
        {
            totall.Visibility = Visibility.Collapsed;
            txttotal.Visibility = Visibility.Visible;
            txttotal.Focus();
        }
        private void wata(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txttotal.Text))
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

        private void LoadLokasi()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.lokasi = uow.Lokasi.GetAll();
                cbLocation.ItemsSource = this.lokasi;
                cbLocation.SelectedValuePath = "Id";
                cbLocation.DisplayMemberPath = "NamaTempatLokasi";
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
                txtuangmuka.Text = this.termspembayaranSelected.UangMuka.ToString();
                txtPaid.Text = (float.Parse(txtuangmuka.Text) * float.Parse(txtAfterTotalTax.Text)).ToString();
                txtInstallments.Text = this.termspembayaranSelected.TermPembayaran.ToString();
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
        private void shoping_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.shopingchartSelected = null;
            if (cbRequestNo.SelectedItem != null)
            {
                this.shopingchartSelected = (Shopingchart)cbRequestNo.SelectedItem;
                this.LoadDataSku();
                txtNote.Text = this.shopingchartSelected.Keterangan;
                txttax1.Text = this.shopingchartSelected.IdPermintaanBarang.ToString();
                cbLocation.SelectedValue = this.shopingchartSelected.IdLokasi;
                dtQuotation.Text = this.shopingchartSelected.TanggaldiBuat.GetValueOrDefault().ToShortDateString();
                cbCurrency.SelectedValue = this.shopingchartSelected.IdMataUang;
                srnodokumen.Text = this.shopingchartSelected.NoReferensiDokumen.ToString();
                cbDepartment.SelectedValue = this.shopingchartSelected.IdDepartemen;
                cbProyek.SelectedValue = this.shopingchartSelected.IdProyek;
                chkcomplete.IsChecked = this.shopingchartSelected.CheckboxSelesai.GetValueOrDefault();
                dtValidaty.Text = this.shopingchartSelected.TanggalDigunakan.GetValueOrDefault().ToShortDateString();
                dtAnnual.Text = this.shopingchartSelected.TanggalBerulang.GetValueOrDefault().ToShortDateString();
                srstaff.Text = this.shopingchartSelected.NamaPetugas;
                chkannual.IsChecked = this.shopingchartSelected.CheckboxBerulang.GetValueOrDefault();
                cbAnnual.SelectedValue = this.shopingchartSelected.IdOpsiAnnual.ToString();
                txtAnnualFrequency.Text = this.shopingchartSelected.DurasiBerulang.ToString();
            }

        }
        public void LoadDataSku()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.listOrderBelis = uow.ListOrderBeli.GetAll().Where(m => m.IdTransaksi == this.shopingchartSelected.IdPermintaanBarang);
                DGSKUQuota.ItemsSource = this.listOrderBelis;
                int sum = 0;
                for (int i = 0; i < DGSKUQuota.Items.Count; i++)
                {
                    sum += Convert.ToInt32((DGSKUQuota.Items[i] as ListOrderBeli).TotalPajakProduk);
                }
                txtTotalprodukTax.Text = sum.ToString();
                int sum1 = 0;
                for (int i = 0; i < DGSKUQuota.Items.Count; i++)
                {
                    sum1 += Convert.ToInt32((DGSKUQuota.Items[i] as ListOrderBeli).TotalPajakJasa);
                }
                txtTotaljasaTax.Text = sum1.ToString();
                int sum2 = 0;
                for (int i = 0; i < DGSKUQuota.Items.Count; i++)
                {
                    sum2 += Convert.ToInt32((DGSKUQuota.Items[i] as ListOrderBeli).TotalPajak);
                }
                txtTotalTax.Text = sum2.ToString();
                int sumar = 0;
                for (int i = 0; i < DGSKUQuota.Items.Count; i++)
                {
                    sumar += Convert.ToInt32((DGSKUQuota.Items[i] as ListOrderBeli).TotalOrderProduk);
                }
                txttotalprodukbeforetax.Text = sumar.ToString();
                int sumar1 = 0;
                for (int i = 0; i < DGSKUQuota.Items.Count; i++)
                {
                    sumar1 += Convert.ToInt32((DGSKUQuota.Items[i] as ListOrderBeli).TotalOrderJasa);
                }
                txttotaljasabeforetax.Text = sumar1.ToString();
                int sumar2 = 0;
                for (int i = 0; i < DGSKUQuota.Items.Count; i++)
                {
                    sumar2 += Convert.ToInt32((DGSKUQuota.Items[i] as ListOrderBeli).TotalOrder);
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
                DGSKUQuota.ItemsSource = this.listOrderBelis;
                int sum = 0;
                for (int i = 0; i < DGSKUQuota.Items.Count; i++)
                {
                    sum += Convert.ToInt32((DGSKUQuota.Items[i] as ListOrderBeli).TotalPajakProduk);
                }
                txtTotalprodukTax.Text = sum.ToString();
                int sum1 = 0;
                for (int i = 0; i < DGSKUQuota.Items.Count; i++)
                {
                    sum1 += Convert.ToInt32((DGSKUQuota.Items[i] as ListOrderBeli).TotalPajakJasa);
                }
                txtTotaljasaTax.Text = sum1.ToString();
                int sum2 = 0;
                for (int i = 0; i < DGSKUQuota.Items.Count; i++)
                {
                    sum2 += Convert.ToInt32((DGSKUQuota.Items[i] as ListOrderBeli).TotalPajak);
                }
                txtTotalTax.Text = sum2.ToString();
                int sumar = 0;
                for (int i = 0; i < DGSKUQuota.Items.Count; i++)
                {
                    sumar += Convert.ToInt32((DGSKUQuota.Items[i] as ListOrderBeli).TotalOrderProduk);
                }
                txttotalprodukbeforetax.Text = sumar.ToString();
                int sumar1 = 0;
                for (int i = 0; i < DGSKUQuota.Items.Count; i++)
                {
                    sumar1 += Convert.ToInt32((DGSKUQuota.Items[i] as ListOrderBeli).TotalOrderJasa);
                }
                txttotaljasabeforetax.Text = sumar1.ToString();
                int sumar2 = 0;
                for (int i = 0; i < DGSKUQuota.Items.Count; i++)
                {
                    sumar2 += Convert.ToInt32((DGSKUQuota.Items[i] as ListOrderBeli).TotalOrder);
                }
                txttotalbeforetax.Text = sumar2.ToString();
                txtAfterTotalTax.Text = (float.Parse(sumar2.ToString()) + float.Parse(txtTotalTax.Text)).ToString();
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
        private void txttax_TextChanged(object sender, TextChangedEventArgs e)
        {
            txttota.Text = txttax1.Text;
        }
        private void annual_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.optionAnnualSelected = null;
            if (cbAnnual.SelectedItem != null)
            {
                this.optionAnnualSelected = (OptionAnnual)cbAnnual.SelectedItem;
            }
        }


        private void SaveQuotationrequest_Click(object sender, RoutedEventArgs e)
        {
            if (srvendor.Name == "" || txtemail.Name == "" || txthp.Name == "" || dtQuotation.Text == "" || cbCurrency.Text == "" || srnodokumen.Name == "" || txtQuotationNo.Text == "" || cbRequestNo.Name == "" || cbLocation.Text == "" || dtValidaty.Text == "" || cbAnnual.Text == "" || srstaff.Name == "" || txtAnnualFrequency.Text == "" || dtAnnual.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            QuotationrequestBLL quotationrequestBLL = new QuotationrequestBLL();
            ShopingchartBLL shopingchartBLL = new ShopingchartBLL();
            Quotationrequest oNewData1 = new Quotationrequest();
            oNewData1.KodeTransaksi = "RQ";
            oNewData1.IdKodeTransaksi = 16;
            if (this.kontakSelected != null)
            {
                oNewData1.IdVendor = this.kontakSelected.Id;
                oNewData1.NamaVendor = this.kontakSelected.NamaA;
            }
            oNewData1.Email = txtemail.Text;
            oNewData1.Nohp = txthp.Text;
            oNewData1.TanggalPermintaanPenawaranHarga = DateTime.Parse(dtQuotation.Text);
            if (this.DataMataUangSelected != null)
            {
                oNewData1.IdMataUang = this.DataMataUangSelected.Id;
                oNewData1.MataUang = this.DataMataUangSelected.NamaMataUang;
                oNewData1.KursTukar = this.DataMataUangSelected.KursTukar;
            }
            if (this.dokumenSelected != null)
            {
                oNewData1.IdNoReferensiDokumen = this.dokumenSelected.Id;
                oNewData1.NoReferensiDokumen = this.dokumenSelected.NoReferensiDokumen;
            }
            oNewData1.NoPemintaanPenawaranHarga = double.Parse(txtQuotationNo.Text);
            if (this.shopingchartSelected != null)
            {
                oNewData1.IdPermitaanBarang = this.shopingchartSelected.IdPermintaanBarang;
                oNewData1.NoPermintaanBarang = this.shopingchartSelected.NoPermintaanBarang;
            }
            oNewData1.Keterangan = txtNote.Text;
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
            if (this.shopingchartSelected != null)
            {
                oNewData1.IdTransaksi = this.shopingchartSelected.IdPermintaanBarang;
            }
            oNewData1.CheckboxHidePrice = chkhide.IsChecked;
            oNewData1.CheckboxSelesai = chkcomplete.IsChecked;
            oNewData1.CheckboxInclusiveTax = chkinclusive.IsChecked;
            oNewData1.CheckboxBerulang = chkannual.IsChecked;
            oNewData1.TanggalPenutupan = DateTime.Parse(dtValidaty.Text);
            oNewData1.DurasiBerulang = double.Parse(txtAnnualFrequency.Text);
            oNewData1.TanggalBerulang = DateTime.Parse(dtAnnual.Text);
            if (this.optionAnnualSelected != null)
            {
                oNewData1.IdOpsiAnnual = this.optionAnnualSelected.IdOptionAnnual;
                oNewData1.Annual = this.optionAnnualSelected.Annual;
            }
            if (this.petugasSelected != null)
            {
                oNewData1.IdPetugas = this.petugasSelected.Id;
                oNewData1.NamaPetugas = this.petugasSelected.NamaA;
            }
            if (this.termspembayaranSelected != null)
            {
                oNewData1.IdTermPembayaran = this.termspembayaranSelected.IdTermPembayaran;
                oNewData1.TermPembayaran = this.termspembayaranSelected.NamaSkema;
            }
            oNewData1.TotalOrderProduk = double.Parse(txttotalprodukbeforetax.Text);
            oNewData1.TotalOrderJasa = double.Parse(txttotaljasabeforetax.Text);
            oNewData1.TotalPajakJasa = double.Parse(txtTotaljasaTax.Text);
            oNewData1.TotalPajakProduk = double.Parse(txtTotalprodukTax.Text);
            oNewData1.TotalSebelumPajak = double.Parse(txttotalbeforetax.Text);
            oNewData1.TotalPajak = double.Parse(txtTotalTax.Text);
            oNewData1.TotalSetelahPajak = double.Parse(txtAfterTotalTax.Text);
            oNewData1.RealRecordingTime = DateTime.Now;
            oNewData1.Checkboxaktif = true;
            if (quotationrequestBLL.AddQuotationrequests(oNewData1) > 0)
            {
                //  this.ClearForm();
                MessageBox.Show("Quotation Request successfully added !");
            }
            else
            {
                MessageBox.Show("Quotation Request failed to add !");
            }
            if (cbRequestNo.Items.Count > 0)
            {
                foreach (var item in cbRequestNo.Items)
                {
                    if (item is Shopingchart)
                    {
                        Shopingchart oNewData2 = (Shopingchart)item;
                        oNewData2.Checkaktif = false;
                        if (shopingchartBLL.EditShopingcharts(oNewData2) == true)
                        {
                        }
                    }
                }
            }
            if (DGSKUQuota.Items.Count > 0)
            {
                foreach (var item in DGSKUQuota.Items)
                {
                    if (item is ListOrderBeli)
                    {
                        ListOrderBeli oNewData3 = (ListOrderBeli)item;
                        oNewData3.Tanggal = DateTime.Parse(dtQuotation.Text);
                        if (this.lokasiSelected != null)
                        {
                            oNewData3.IdLokasi = this.lokasiSelected.Id;
                            oNewData3.NamaLokasi = this.lokasiSelected.NamaTempatLokasi;
                        }
                        if (this.dataDepartemenSelected != null)
                        {
                            oNewData3.IdDepartemen = this.dataDepartemenSelected.Id;
                        }
                        if (int.Parse(txttota.Text) == 0)
                        {
                            oNewData3.IdTransaksi = oNewData1.IdPermintaanPenawaranHarga;
                        }
                        if (this.dataProyekSelected != null)
                        {
                            oNewData3.IdProyek = this.dataProyekSelected.Id;
                        }
                        oNewData3.Checkboxaktif = false;
                        if (quotationrequestBLL.EditOrderProdukBeli(oNewData3, oNewData1) == true)
                        {
                        }
                    }
                }
            }
            PurchaseDocument v = new PurchaseDocument();
            Switcher.SwitchNewQuotationRequest(v);
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
            PurchaseDocument v = new PurchaseDocument();
            Switcher.SwitchNewQuotationRequest(v);
        }

        private void Vendor_Click(object sender, RoutedEventArgs e)
        {
            {
                bool isWindowOpen = false;

                foreach (Window w in Application.Current.Windows)
                {
                    if (w is Vendor.Vendorsquot)
                    {
                        isWindowOpen = true;
                        w.Activate();
                    }
                }

                if (!isWindowOpen)
                {
                    Vendor.Vendorsquot Customer = new Vendor.Vendorsquot(this);
                    Customer.Show();
                }

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
            ShopingchartBLL shopingBLL = new ShopingchartBLL();
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
            }
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
            ShopingchartBLL shopingBLL = new ShopingchartBLL();
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
            }
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
        public void Document_Click(object sender, RoutedEventArgs e)
        {
            {
                bool isWindowOpen = false;

                foreach (Window w in Application.Current.Windows)
                {
                    if (w is Document.Documentquota)
                    {
                        isWindowOpen = true;
                        w.Activate();
                    }
                }

                if (!isWindowOpen)
                {
                    Document.Documentquota document = new Document.Documentquota(this);
                    document.Show();
                }

            }
        }

        private void Paymenterm_Click(object sender, RoutedEventArgs e)
        {
            {
                bool isWindowOpen = false;

                foreach (Window w in Application.Current.Windows)
                {
                    if (w is PaymentTerm)
                    {
                        isWindowOpen = true;
                        w.Activate();
                    }
                }

                if (!isWindowOpen)
                {
                    PaymentTerm paymentTerm = new PaymentTerm(this);
                    paymentTerm.Show();
                }

            }
        }
        private void Product_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Service_Click(object sender, RoutedEventArgs e)
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

        private void TxtQuotationNo_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtQuotationNo.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtQuotationNo.Text = "";
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
                    MessageBox.Show("Must be Numeric");
                    txtAnnualFrequency.Text = "";
                    return;
                }

            }
        }

        private void rbdepartmen_Checked(object sender, RoutedEventArgs e)
        {
            this.rbdepartmen.IsChecked = true;
            {
                cbDepartment.Visibility = Visibility.Visible;
                cbProyek.Visibility = Visibility.Hidden;
                cbProyek.SelectedIndex = -1;
                this.LoadDepartmen();
            }
        }

        private void rbprojec_Checked(object sender, RoutedEventArgs e)
        {
            this.rbprojec.IsChecked = true;
            {
                cbProyek.Visibility = Visibility.Visible;
                cbDepartment.Visibility = Visibility.Hidden;
                cbDepartment.SelectedIndex = -1;
                this.LoadProyek();
            }
        }

        private void rbpayment_Checked(object sender, RoutedEventArgs e)
        {
            this.rbpayment.IsChecked = true;
            {
                cbPayment.Visibility = Visibility.Visible;
                cbCash.Visibility = Visibility.Hidden;
                cbCash.SelectedIndex = -1;
                this.LoadPaymentTerms();
            }
        }
    }
}



