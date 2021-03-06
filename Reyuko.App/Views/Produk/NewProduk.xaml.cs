﻿using Reyuko.BLL.Core;
using Reyuko.DAL.Domain;
using Reyuko.DAL;
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
using Microsoft.Win32;
using System.IO;
using Path = System.IO.Path;
using Reyuko.Utils.Common;
using System.Runtime.CompilerServices;

namespace Reyuko.App.Views.Produk
{
    /// <summary>

    /// </summary>
    public partial class NewProduk : UserControl
    {
        public NewProduk(Produk produkForm)
        {
            InitializeComponent();
            this.produkForm = produkForm;
            Switcher.pageSwitchernewproduk = this;
            this.Init();
        }

        public NewProduk(string kiriman)
        {
            this.kiriman = kiriman;
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
        public StockReceivedName stockReceived;

        public object UserControl { get; internal set; }
        private Produk produkForm;
       // public IEnumerable<ReceivedProduk> receivedProduks { get; set; }
        public IEnumerable<KategoriProduk> kategoriProduks { get; set; }
        public KategoriProduk kategoriProdukSelected { get; set; }
        private IEnumerable<DataMataUang> dataMataUangs { get; set; }
        private DataMataUang DataMataUangSelected { get; set; }
        private IEnumerable<SatuanDasar> satuanDasars { get; set; }
        private SatuanDasar satuanDasarSelected { get; set; }
        private IEnumerable<HargaPokok> hargaPokoks { get; set; }
        private HargaPokok hargaPokokSelected { get; set; }
        private IEnumerable<DataPajak> dataPajaks { get; set; }
        private IEnumerable<GrupProduk> grupProduks { get; set; }
        public GrupProduk GrupProdukSelected { get; set; }
        public IEnumerable<produk> produks { get; set; }
       // public ReceivedProduk receivedProdukSelected;
        public produk produkselected { get; set; }
        public IEnumerable<TypeProduk> typeProduks { get; set; }
        public TypeProduk typeProdukSelected { get; set; }
        public IEnumerable<Kontak> kontaks { get; set; }
        public Kontak kontakSelected { get; set; }
        private DataPajak dataPajakSelected { get; set; }
        public bool isEdit = false;
        private string kiriman;

        private string UploadFileA { get; set; }
        private string UploadFileB { get; set; }
        private string UploadFileC { get; set; }
        private string UploadFileD { get; set; }
        private void Init()
        {
            this.ClearForm();
            this.LoadKategoriProduk();
            this.LoadCurrency();
            this.LoadGrupProduk();
            this.LoadTipeproduk();
            this.LoadBaseUnit();
            this.LoadUnitCost();
            this.LoadVendorPrimary();
            this.LoadVendor2();
            this.LoadVendor3();
            this.LoadVendor4();
            this.LoadTax();
            if (this.produkForm.isEdit == true)
                this.LoadProduk();
        }



        private void ClearForm()
        {
            this.kategoriProdukSelected = null;
            cbCategory.SelectedIndex = -1;
            txtSKU.Text = "";
            this.GrupProdukSelected = null;
            srgroupproduk.Text = "";
            txtProductName.Text = "";
            txtSellingPrice.Text = "";
            this.DataMataUangSelected = null;
            cbCurrency.SelectedIndex = -1;
            this.satuanDasarSelected = null;
            cbBaseUnit.SelectedIndex = -1;
            txtMinimumOrder.Text = "";
            txtDiscount.Text = "";
            Date1.Text = DateTime.Now.ToShortDateString();
            Date2.Text = DateTime.Now.ToShortDateString();
            txtStock.Text = "";
            txtMinStock.Text = "";
            txtPurchasingPrice.Text = "";
            this.typeProdukSelected = null;
            cbProductType.SelectedIndex = -1;
            this.hargaPokokSelected = null;
            cbUnitCost.SelectedIndex = -1;
            txtRemarks.Text = "";
            this.dataPajakSelected = null;
            cbTax.SelectedIndex = -1;
            txtLength.Text = "";
            txtWide.Text = "";
            txtTall.Text = "";
            txtWeight.Text = "";
            ChkInactive.IsChecked = false;
            this.kontakSelected = null;
            txtRemarksVendor.Text = "";
            txtRemarksVendor2.Text = "";
            txtRemarksVendor3.Text = "";
            txtRemarksVendor4.Text = "";
        }

        public void LoadKategoriProduk()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kategoriProduks = uow.KategoriProduk.GetAll();
                cbCategory.ItemsSource = this.kategoriProduks;
                cbCategory.SelectedValuePath = "Id";
                cbCategory.DisplayMemberPath = "ProdukKategori";
            }
        }
        public void LoadGrupProduk()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.grupProduks = uow.GrupProduk.GetAll();
                srgroupproduk.ItemsSource = this.grupProduks;
            }
        }

        public void LoadStok()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.produks = uow.produk.GetAll().Where(m => m.AKtif == true);
                DGSKUPurchaseDelivery.ItemsSource = this.produks;
                int sum = 0;
                for (int i = 0; i < DGSKUPurchaseDelivery.Items.Count; i++)
                {
                    sum = Convert.ToInt32((DGSKUPurchaseDelivery.Items[i] as produk).IdProduk);
                }
                srid.Text = sum.ToString();
                int suma = 0;
                for (int i = 0; i < DGSKUPurchaseDelivery.Items.Count; i++)
                {
                    suma = Convert.ToInt32((DGSKUPurchaseDelivery.Items[i] as produk).JumlahStok);
                }
                txtStock.Text = suma.ToString();
                int sumar = 0;
                for (int i = 0; i < DGSKUPurchaseDelivery.Items.Count; i++)
                {
                    sumar = Convert.ToInt32((DGSKUPurchaseDelivery.Items[i] as produk).HargaBeli);
                }
                txtPurchasingPrice.Text = sumar.ToString();
            }
        }

        public void LoadTipeproduk()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.typeProduks = uow.TypeProduk.GetAll();
                cbProductType.ItemsSource = this.typeProduks;
                cbProductType.SelectedValuePath = "Id";
                cbProductType.DisplayMemberPath = "NamaTypeProduk";
            }
        }

        private void LoadCurrency()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dataMataUangs = uow.DataMataUang.GetAll();
                cbCurrency.ItemsSource = this.dataMataUangs;
                cbCurrency.SelectedValuePath = "Id";
                cbCurrency.DisplayMemberPath = "NamaMataUang";
            }
        }

        private void LoadBaseUnit()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.satuanDasars = uow.SatuanDasar.GetAll();
                cbBaseUnit.ItemsSource = this.satuanDasars;
                cbBaseUnit.SelectedValuePath = "Id";
                cbBaseUnit.DisplayMemberPath = "NamaSatuan";
            }
        }
        private void LoadUnitCost()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.hargaPokoks = uow.HargaPokok.GetAll();
                cbUnitCost.ItemsSource = this.hargaPokoks;
                cbUnitCost.SelectedValuePath = "IdTipeHargaPokok";
                cbUnitCost.DisplayMemberPath = "TipeHargaPokok";
            }

        }

        private void LoadTax()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dataPajaks = uow.DataPajak.GetAll();
                cbTax.ItemsSource = this.dataPajaks;
                cbTax.SelectedValuePath = "Id";
                cbTax.DisplayMemberPath = "NamaPajak";
            }
        }

        public void LoadVendorPrimary()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kontaks = uow.Kontak.GetAll().Where(m => m.TypeKontak.ToLower() == "vendor");
                cbVendorPrimary.ItemsSource = this.kontaks;
                cbVendorPrimary.SelectedValuePath = "Id";
                cbVendorPrimary.DisplayMemberPath = "NamaA";
            }
        }

        public void LoadVendor2()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kontaks = uow.Kontak.GetAll().Where(m => m.TypeKontak.ToLower() == "vendor");
                cbVendor2.ItemsSource = this.kontaks;
                cbVendor2.SelectedValuePath = "Id";
                cbVendor2.DisplayMemberPath = "NamaB";
            }
        }

        public void LoadVendor3()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kontaks = uow.Kontak.GetAll().Where(m => m.TypeKontak.ToLower() == "vendor");
                cbVendor3.ItemsSource = this.kontaks;
                cbVendor3.SelectedValuePath = "Id";
                cbVendor3.DisplayMemberPath = "NamaC";
            }
        }

        public void LoadVendor4()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kontaks = uow.Kontak.GetAll().Where(m => m.TypeKontak.ToLower() == "vendor");
                cbVendor4.ItemsSource = this.kontaks;
                cbVendor4.SelectedValuePath = "Id";
                cbVendor4.DisplayMemberPath = "NamaD";
            }
        }

        private void LoadProduk()
        {
            this.ClearForm();
            if (this.produkForm != null && this.produkForm.listprodukSelected != null)
            {
                cbCategory.SelectedValue = this.produkForm.listprodukSelected.IdProdukKategori;
                txtSKU.Text = this.produkForm.listprodukSelected.SKU;
                srgroupproduk.Text = this.produkForm.listprodukSelected.NamaGroupProduk;
                txtProductName.Text = this.produkForm.listprodukSelected.NamaProduk;
                txtSellingPrice.Text = this.produkForm.listprodukSelected.HargaJual.ToString();
                cbCurrency.SelectedValue = this.produkForm.listprodukSelected.IdMataUang;
                cbBaseUnit.SelectedValue = this.produkForm.listprodukSelected.IdSatuanDasar;
                txtMinimumOrder.Text = this.produkForm.listprodukSelected.MinPemesanan.ToString();
                chkdiskon.IsChecked = this.produkForm.listprodukSelected.CheckboxDiskonProduk;
                txtDiscount.Text = this.produkForm.listprodukSelected.DiskonProdukPersen;
                chkover.IsChecked = this.produkForm.listprodukSelected.CheckboxUbahHarga;
                chkmanagestok.IsChecked = this.produkForm.listprodukSelected.CheckboxManageStok;
                Date1.Text = this.produkForm.listprodukSelected.TanggalMulaiDiskonProduk.GetValueOrDefault().ToShortDateString();
                Date2.Text = this.produkForm.listprodukSelected.TanggalBerakhirDiskonProduk.GetValueOrDefault().ToShortDateString();
                txtStock.Text = this.produkForm.listprodukSelected.JumlahStok.ToString();
                txtMinStock.Text = this.produkForm.listprodukSelected.BatasStokMin.ToString();
                txtPurchasingPrice.Text = this.produkForm.listprodukSelected.HargaBeli.ToString();
                cbProductType.SelectedValue = this.produkForm.listprodukSelected.IdTipeProduk;
                cbUnitCost.SelectedValuePath = this.produkForm.listprodukSelected.TipeHargaPokok;
                txtRemarks.Text = this.produkForm.listprodukSelected.Keterangan;
                cbTax.SelectedValue = this.produkForm.listprodukSelected.IdPajak;
                chktaxable.IsChecked = this.produkForm.listprodukSelected.CheckboxPajak;
                chkinclusive.IsChecked = this.produkForm.listprodukSelected.CheckBoxInclusiveTax;
                txtLength.Text = this.produkForm.listprodukSelected.Panjang;
                txtWide.Text = this.produkForm.listprodukSelected.Lebar;
                txtTall.Text = this.produkForm.listprodukSelected.Tinggi;
                txtWeight.Text = this.produkForm.listprodukSelected.Berat;
                ChkInactive.IsChecked = this.produkForm.listprodukSelected.CheckBoxTidakAktif;
                if (!string.IsNullOrEmpty(this.produkForm.listprodukSelected.UploadImage0))
                    cbVendorPrimary.SelectedValue = this.produkForm.listprodukSelected.IdKontak;
                cbVendor2.SelectedValue = this.produkForm.listprodukSelected.IdKontak;
                cbVendor3.SelectedValue = this.produkForm.listprodukSelected.IdKontak;
                cbVendor4.SelectedValue = this.produkForm.listprodukSelected.IdKontak;
                txtRemarksVendor.Text = this.produkForm.listprodukSelected.KeteranganSuplierA;
                txtRemarksVendor2.Text = this.produkForm.listprodukSelected.KeteranganSuplierB;
                txtRemarksVendor3.Text = this.produkForm.listprodukSelected.KeteranganSuplierC;
                txtRemarksVendor4.Text = this.produkForm.listprodukSelected.KeteranganSuplierD;
            }
        }

        private void Cbcategory_change(object sender, SelectionChangedEventArgs e)
        {
            this.kategoriProdukSelected = null;
            if (cbCategory.SelectedItem != null)
            {
                this.kategoriProdukSelected = (KategoriProduk)cbCategory.SelectedItem;
            }
        }

        private void cb_selection_changegrup(object sender, SelectionChangedEventArgs e)
        {
            this.GrupProdukSelected = null;
            if (srgroupproduk.SelectedItem != null)
            {
                this.GrupProdukSelected = (GrupProduk)srgroupproduk.SelectedItem;
                chkdiskon.IsChecked = this.GrupProdukSelected.CheckboxDiskon;
                txtDiscount.Text = this.GrupProdukSelected.DiskonPersen.ToString();
                Date1.Text = this.GrupProdukSelected.TanggalMulaiDiskon.GetValueOrDefault().ToShortDateString();
                Date2.Text = this.GrupProdukSelected.TanggalAkhirDiskon.GetValueOrDefault().ToShortDateString();
            }
        }
        private void Cbcurrency_Selectchange(object sender, SelectionChangedEventArgs e)
        {
            this.DataMataUangSelected = null;
            if (cbCurrency.SelectedItem != null)
            {
                this.DataMataUangSelected = (DataMataUang)cbCurrency.SelectedItem;
            }
        }

        private void Cbbaseunit_selectchange(object sender, SelectionChangedEventArgs e)
        {
            this.satuanDasarSelected = null;
            if (cbBaseUnit.SelectedItem != null)
            {
                this.satuanDasarSelected = (SatuanDasar)cbBaseUnit.SelectedItem;
            }
        }

        private void CbTipeproduk_selectchange(object sender, SelectionChangedEventArgs e)
        {
            this.typeProdukSelected = null;
            if (cbProductType.SelectedItem != null)
            {
                this.typeProdukSelected = (TypeProduk)cbProductType.SelectedItem;
            }
        }

        private void Cbunitcost_selectionchange(object sender, SelectionChangedEventArgs e)
        {
            this.hargaPokokSelected = null;
            if (cbUnitCost.SelectedItem != null)
            {
                this.hargaPokokSelected = (HargaPokok)cbUnitCost.SelectedItem;
            }
        }

        private void Cbtax_selectchange(object sender, SelectionChangedEventArgs e)
        {
            this.dataPajakSelected = null;
            if (cbTax.SelectedItem != null)
            {
                this.dataPajakSelected = (DataPajak)cbTax.SelectedItem;
            }
        }

        private void CbVendorprimary_Change(object sender, SelectionChangedEventArgs e)
        {
            this.kontakSelected = null;
            if (cbVendorPrimary.SelectedItem != null)
            {
                this.kontakSelected = (Kontak)cbVendorPrimary.SelectedItem;
            }
        }

        private void CbVendor2_Change(object sender, SelectionChangedEventArgs e)
        {
            this.kontakSelected = null;
            if (cbVendor2.SelectedItem != null)
            {
                this.kontakSelected = (Kontak)cbVendor2.SelectedItem;
            }
        }

        private void CbVendor3_Change(object sender, SelectionChangedEventArgs e)
        {
            this.kontakSelected = null;
            if (cbVendor3.SelectedItem != null)
            {
                this.kontakSelected = (Kontak)cbVendor3.SelectedItem;
            }
        }

        private void CbVendor4_Change(object sender, SelectionChangedEventArgs e)
        {
            this.kontakSelected = null;
            if (cbVendor4.SelectedItem != null)
            {
                this.kontakSelected = (Kontak)cbVendor4.SelectedItem;
            }
        }

        private void UploadFileA_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;
            dlg.Filter = Helper.UploadFilter(Helper.enUploadType.Images);

            if ((bool)dlg.ShowDialog())
            {
                Stream file = dlg.OpenFile();
                string filename = dlg.SafeFileName;
                this.UploadFileA = Helper.UploadFile(Helper.enUploadType.Images, file, filename);
            }
            else
            {
                MessageBox.Show("File not selected");
            }
        }

        private void UploadFileB_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;
            dlg.Filter = Helper.UploadFilter(Helper.enUploadType.Images);

            if ((bool)dlg.ShowDialog())
            {
                Stream file = dlg.OpenFile();
                string filename = dlg.SafeFileName;
                this.UploadFileB = Helper.UploadFile(Helper.enUploadType.Images, file, filename);
            }
            else
            {
                MessageBox.Show("File not selected");
            }
        }

        private void UploadFileC_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;
            dlg.Filter = Helper.UploadFilter(Helper.enUploadType.Images);

            if ((bool)dlg.ShowDialog())
            {
                Stream file = dlg.OpenFile();
                string filename = dlg.SafeFileName;
                this.UploadFileC = Helper.UploadFile(Helper.enUploadType.Images, file, filename);
            }
            else
            {
                MessageBox.Show("File not selected");
            }
        }

        private void UploadFileD_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;
            dlg.Filter = Helper.UploadFilter(Helper.enUploadType.Images);

            if ((bool)dlg.ShowDialog())
            {
                Stream file = dlg.OpenFile();
                string filename = dlg.SafeFileName;
                this.UploadFileD = Helper.UploadFile(Helper.enUploadType.Images, file, filename);
            }
            else
            {
                MessageBox.Show("File not selected");
            }
        }

        private produk GetData()
        {
            produk oData = new produk();

            if (this.kategoriProdukSelected != null)
            {
                oData.IdProdukKategori = this.kategoriProdukSelected.Id;
                oData.ProdukKategori = this.kategoriProdukSelected.ProdukKategori;
            }
            oData.SKU = txtSKU.Text;
            if (this.GrupProdukSelected != null)
            {
                oData.IdGroupProduk = this.GrupProdukSelected.Id;
                oData.NamaGroupProduk = this.GrupProdukSelected.NamaGrupProduk;
            }
            oData.NamaProduk = txtProductName.Text;
            oData.HargaJual = double.Parse(txtSellingPrice.Text);
            if (this.DataMataUangSelected != null)
            {
                oData.IdMataUang = this.DataMataUangSelected.Id;
                oData.MataUang = this.DataMataUangSelected.NamaMataUang;
            }
            if (this.satuanDasarSelected != null)
            {
                oData.IdSatuanDasar = this.satuanDasarSelected.Id;
                oData.SatuanDasar = this.satuanDasarSelected.NamaSatuan;
            }
            oData.MinPemesanan = double.Parse(txtMinimumOrder.Text);
            oData.CheckboxDiskonProduk = chkdiskon.IsChecked;
            oData.CheckboxUbahHarga = chkover.IsChecked;
            if(chkdiskon.IsChecked == false)
            {
                oData.DiskonProdukPersen = "0";
            }
            oData.DiskonProdukPersen = txtDiscount.Text;
            oData.TanggalMulaiDiskonProduk = DateTime.Parse(Date1.Text);
            oData.TanggalBerakhirDiskonProduk = DateTime.Parse(Date2.Text);
            oData.BatasStokMin = int.Parse(txtMinStock.Text);
            if (this.typeProdukSelected != null)
            {
                oData.IdTipeProduk = this.typeProdukSelected.Id;
                oData.TipeProduk = this.typeProdukSelected.NamaTypeProduk;
                oData.IdAkunHargaPokok = this.typeProdukSelected.IdAkunHargaPokok;
                oData.IdAkunPenjualan = this.typeProdukSelected.IdAkunPenjualan;
                oData.IdAkunPersediaan = this.typeProdukSelected.IdAkunPersediaan;
                oData.IdAkunPengirimanBeli = this.typeProdukSelected.IdAkunPengirimanBeli;
                oData.IdAkunPengirimanJual = this.typeProdukSelected.IdAkunPengirimanJual;
                oData.IdAkunReturPenjualan = this.typeProdukSelected.IdAkunReturPenjualan;
                oData.IdAkunJasa = this.typeProdukSelected.IdAkunService;

            }
            if (this.hargaPokokSelected != null)
            {
                oData.TipeHargaPokok = hargaPokokSelected.TipeHargaPokok;
            }
            oData.Keterangan = txtRemarks.Text;
            oData.CheckboxPajak = chktaxable.IsChecked;
            oData.CheckBoxInclusiveTax = chkinclusive.IsChecked;
            if (this.dataPajakSelected != null)
            {
                oData.IdPajak = this.dataPajakSelected.Id;
                oData.Pajak = this.dataPajakSelected.KodePajak;
                oData.PersentasePajak = double.Parse(dataPajakSelected.Persentase.ToString());
                oData.IdAkunPajak = int.Parse(dataPajakSelected.IdAkunJual.ToString());
            }
            oData.Panjang = txtLength.Text;
            oData.Lebar = txtWide.Text;
            oData.Tinggi = txtTall.Text;
            oData.Berat = txtWeight.Text;
            oData.CheckBoxTidakAktif = ChkInactive.IsChecked;
            oData.UploadImage0 = this.UploadFileA;
            oData.UploadImage1 = this.UploadFileB;
            oData.UploadImage2 = this.UploadFileC;
            oData.UploadImage3 = this.UploadFileD;
            if (this.kontakSelected != null)
            {
                oData.IdKontak = this.kontakSelected.Id;
                oData.SuplierA = this.kontakSelected.NamaA;
            }
            if (this.kontakSelected != null)
            {
                oData.IdKontak = this.kontakSelected.Id;
                oData.SuplierB = this.kontakSelected.NamaB;
            }
            if (this.kontakSelected != null)
            {
                oData.IdKontak = this.kontakSelected.Id;
                oData.SuplierC = this.kontakSelected.NamaC;
            }
            if (this.kontakSelected != null)
            {
                oData.IdKontak = this.kontakSelected.Id;
                oData.SuplierD = this.kontakSelected.NamaD;
            }
            oData.KeteranganSuplierA = txtRemarksVendor.Text;
            oData.KeteranganSuplierB = txtRemarksVendor2.Text;
            oData.KeteranganSuplierC = txtRemarksVendor3.Text;
            oData.KeteranganSuplierD = txtRemarksVendor4.Text;
            if (this.produkForm.listprodukSelected != null)
                oData.IdProduk = this.produkForm.listprodukSelected.IdProduk;

            return oData;
        }

        private void saveproduk_Click(object sender, RoutedEventArgs e)
        {
            if (cbCategory.Text == "" || txtProductName.Text == "" || txtSellingPrice.Text == "" || cbCurrency.Text == "" || cbBaseUnit.Text == "" || txtMinimumOrder.Text == "" || Date1.Text == "" || Date2.Text == "" || cbProductType.Text == "" || cbUnitCost.Text == "" || txtLength.Text == "" || txtWide.Text == "" || txtTall.Text == "" || txtWeight.Text == ""
                || cbVendorPrimary.Text == "" || txtRemarksVendor.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            ProdukBLL ProdukBLL = new ProdukBLL();
            if (this.chkmanagestok.IsChecked == false)
            {
                if (ProdukBLL.AddProduk(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Product successfully added !");
                    this.produkForm.LoadProduk("");
                }
                else
                {
                    MessageBox.Show("Product failed to add !");
                }
            }
            else
            {
                if (DGSKUPurchaseDelivery.Items.Count > 0)
                {
                    foreach (var item in DGSKUPurchaseDelivery.Items)
                    {
                        if (item is produk)
                        {
                            produk oData = (produk)item;
                            if (this.kategoriProdukSelected != null)
                            {
                                oData.IdProdukKategori = this.kategoriProdukSelected.Id;
                                oData.ProdukKategori = this.kategoriProdukSelected.ProdukKategori;
                            }
                            oData.SKU = txtSKU.Text;
                            if (this.GrupProdukSelected != null)
                            {
                                oData.IdGroupProduk = this.GrupProdukSelected.Id;
                                oData.NamaGroupProduk = this.GrupProdukSelected.NamaGrupProduk;
                            }
                            oData.NamaProduk = txtProductName.Text;
                            oData.HargaJual = double.Parse(txtSellingPrice.Text);
                            if (this.DataMataUangSelected != null)
                            {
                                oData.IdMataUang = this.DataMataUangSelected.Id;
                                oData.MataUang = this.DataMataUangSelected.NamaMataUang;
                            }
                            oData.HargaBeli = double.Parse(txtPurchasingPrice.Text);
                            oData.JumlahStok = double.Parse(txtStock.Text);
                            if (this.satuanDasarSelected != null)
                            {
                                oData.IdSatuanDasar = this.satuanDasarSelected.Id;
                                oData.SatuanDasar = this.satuanDasarSelected.NamaSatuan;
                            }
                            oData.MinPemesanan = double.Parse(txtMinimumOrder.Text);
                            oData.CheckboxDiskonProduk = chkdiskon.IsChecked;
                            oData.CheckboxUbahHarga = chkover.IsChecked;
                            if (chkdiskon.IsChecked == false)
                            {
                                oData.DiskonProdukPersen = "0";
                            }
                            oData.DiskonProdukPersen = txtDiscount.Text;
                            oData.TanggalMulaiDiskonProduk = DateTime.Parse(Date1.Text);
                            oData.TanggalBerakhirDiskonProduk = DateTime.Parse(Date2.Text);
                            oData.BatasStokMin = int.Parse(txtMinStock.Text);
                            if (this.typeProdukSelected != null)
                            {
                                oData.IdTipeProduk = this.typeProdukSelected.Id;
                                oData.TipeProduk = this.typeProdukSelected.NamaTypeProduk;
                                oData.IdAkunHargaPokok = this.typeProdukSelected.IdAkunHargaPokok;
                                oData.IdAkunPenjualan = this.typeProdukSelected.IdAkunPenjualan;
                                oData.IdAkunPersediaan = this.typeProdukSelected.IdAkunPersediaan;
                                oData.IdAkunPengirimanBeli = this.typeProdukSelected.IdAkunPengirimanBeli;
                                oData.IdAkunPengirimanJual = this.typeProdukSelected.IdAkunPengirimanJual;
                                oData.IdAkunReturPenjualan = this.typeProdukSelected.IdAkunReturPenjualan;
                                oData.IdAkunJasa = this.typeProdukSelected.IdAkunService;

                            }
                            if (this.hargaPokokSelected != null)
                            {
                                oData.TipeHargaPokok = hargaPokokSelected.TipeHargaPokok;
                            }
                            oData.Keterangan = txtRemarks.Text;
                            oData.CheckboxPajak = chktaxable.IsChecked;
                            oData.CheckBoxInclusiveTax = chkinclusive.IsChecked;
                            if (this.dataPajakSelected != null)
                            {
                                oData.IdPajak = this.dataPajakSelected.Id;
                                oData.Pajak = this.dataPajakSelected.KodePajak;
                                oData.PersentasePajak = double.Parse(dataPajakSelected.Persentase.ToString());
                                oData.IdAkunPajak = int.Parse(dataPajakSelected.IdAkunJual.ToString());
                            }
                            oData.Panjang = txtLength.Text;
                            oData.Lebar = txtWide.Text;
                            oData.Tinggi = txtTall.Text;
                            oData.Berat = txtWeight.Text;
                            oData.CheckBoxTidakAktif = ChkInactive.IsChecked;
                            oData.UploadImage0 = this.UploadFileA;
                            oData.UploadImage1 = this.UploadFileB;
                            oData.UploadImage2 = this.UploadFileC;
                            oData.UploadImage3 = this.UploadFileD;
                            if (this.kontakSelected != null)
                            {
                                oData.IdKontak = this.kontakSelected.Id;
                                oData.SuplierA = this.kontakSelected.NamaA;
                            }
                            if (this.kontakSelected != null)
                            {
                                oData.IdKontak = this.kontakSelected.Id;
                                oData.SuplierB = this.kontakSelected.NamaB;
                            }
                            if (this.kontakSelected != null)
                            {
                                oData.IdKontak = this.kontakSelected.Id;
                                oData.SuplierC = this.kontakSelected.NamaC;
                            }
                            if (this.kontakSelected != null)
                            {
                                oData.IdKontak = this.kontakSelected.Id;
                                oData.SuplierD = this.kontakSelected.NamaD;
                            }
                            oData.KeteranganSuplierA = txtRemarksVendor.Text;
                            oData.KeteranganSuplierB = txtRemarksVendor2.Text;
                            oData.KeteranganSuplierC = txtRemarksVendor3.Text;
                            oData.KeteranganSuplierD = txtRemarksVendor4.Text;
                            oData.AKtif = false;
                            if (ProdukBLL.EditProduk(oData) == true)
                            {
                                
                                MessageBox.Show("Product added successfully !");
                                this.produkForm.LoadProduk("");
                            }
                            else
                            {
                               MessageBox.Show("Product failed to add !");
                            }
                        }
                    }
                }
            }
             
        Produk v = new Produk();
            Switcher.Switchnewproduk(v);
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Produk v = new Produk();
            Switcher.Switchnewproduk(v);
        }

        private void saas(object sender, EventArgs e)
        {
            txtStock.Text = StockReceivedName.kiriman;
        }

        private void Category_Click(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is CategoryProduk.CategoryProduk)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                CategoryProduk.CategoryProduk newCategory = new CategoryProduk.CategoryProduk(this);
                newCategory.Show();
            }
        }
        public void GroupProduk_Click(object sender, RoutedEventArgs e)
        {
            GroupProduct.GroupProduct v = new GroupProduct.GroupProduct(this);
            v.Show();
        }
        private void Stock_Click(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is StockReceivedName)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
               StockReceivedName newStock = new StockReceivedName(this);
                newStock.Show();
            }
        }

        private void TxtSellingPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtSellingPrice.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtSellingPrice.Text = "";
                    return;
                }

            }
        }

        private void TxtMinimumOrder_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtMinimumOrder.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtMinimumOrder.Text = "";
                    return;
                }

            }
        }

        private void TxtDiscount_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtDiscount.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtDiscount.Text = "";
                    return;
                }

            }
        }

        private void TxtStock_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtStock.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtStock.Text = "";
                    return;
                }

            }
        }

        private void TxtMinStock_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtMinStock.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtMinStock.Text = "";
                    return;
                }

            }
        }

        private void TxtPurchasingPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtPurchasingPrice.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtPurchasingPrice.Text = "";
                    return;
                }

            }
        }

        private void TxtLength_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtLength.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtLength.Text = "";
                    return;
                }

            }
        }

        private void TxtWide_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtWide.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtWide.Text = "";
                    return;
                }

            }
        }

        private void TxtTall_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtTall.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtTall.Text = "";
                    return;
                }

            }
        }

        private void TxtWeight_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtWeight.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtWeight.Text = "";
                    return;
                }

            }
        }

        private void TxtSKU_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        
        private void TxtProductName_TextChanged(object sender, TextChangedEventArgs e)
        {
        //    string tString = txtProductName.Text;
        //    if (tString.Trim() == "") return;
        //    for (int i = 0; i < tString.Length; i++)
        //    {
        //        if (char.IsNumber(tString[i]))
        //        {
        //            MessageBox.Show("Harus Diisi Character");
        //            txtProductName.Text = "";
        //            return;
        //        }

        //    }
       }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if(chkmanagestok.IsChecked == true)
            {
                txtStock.Visibility = Visibility.Visible;
                txtPurchasingPrice.Visibility = Visibility.Visible;
                btnstok.Visibility = Visibility.Visible;
            }
            else if(chkmanagestok.IsChecked == false)
            {
                txtStock.Visibility = Visibility.Hidden;
                txtPurchasingPrice.Visibility = Visibility.Hidden;
                btnstok.Visibility = Visibility.Hidden;
            }
        }

        private void txtid_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }

}
