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
using Path = System.IO.Path;

namespace Reyuko.App.Views.Produk
{
    /// <summary>
    
    /// </summary>
    public partial class Produk : UserControl
    {
        public Produk()
        {
            InitializeComponent();
            Switcher.pageSwitcherproduk = this;
            this.Init();
        }
        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
        public produk listprodukSelected { get; set; }
        public IEnumerable<produk> listproduks { get; set; }
        public produk produk { get; set; }
        public IEnumerable<KategoriProduk> kategoriProduks { get; internal set; }
        public object kategoriProdukSelected { get; internal set; }
        public IEnumerable<produk> produks { get; set; }
        public produk produkSelected { get; set; }


        public bool isEdit = false;
        private int pageSize = 10;
        private int pageIndex = 1;

        private void Init()
        {
            this.LoadProduk("");
            this.LoadKategoriProduk();
            this.LoadSearchProduk();
        }

        private void ClearForm()
        {
            this.listproduks = null;
        }

        public void LoadSearchProduk()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.produks = uow.produk.GetAll();
                srproduk.ItemsSource = this.produks;
            }
        }
        private void SearchProduk_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.produkSelected = null;
            if (srproduk.SelectedItem != null)
            {
                this.produkSelected = (produk)srproduk.SelectedItem;
            }
        }
        private void LoadKategoriProduk()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kategoriProduks = uow.KategoriProduk.GetAll();
                cbkategori.ItemsSource = this.kategoriProduks;
                cbkategori.SelectedValuePath = "Id";
                cbkategori.DisplayMemberPath = "ProdukKategori";
            }
        }
        private void KategoriProduk_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.kategoriProdukSelected = null;
            if (cbkategori.SelectedItem != null)
            {
                this.kategoriProdukSelected = (KategoriProduk)cbkategori.SelectedItem;
            }
        }
        public void LoadProduk(string NamaProduk)
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.listproduks = uow.produk.GetAll();
                List<produk> itemSource = new List<produk>();
                if (!string.IsNullOrEmpty(NamaProduk))
                    itemSource = this.listproduks.Where(m => m.NamaProduk.Contains(NamaProduk)).ToList();
                else
                    itemSource = this.listproduks.ToList();
                LstProduct.ItemsSource = itemSource;
            }
        }

        private void LstProduk_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.ClearForm();
            if (LstProduct.SelectedItem != null)
            {
                this.listprodukSelected = (produk)LstProduct.SelectedItem;
                if (this.listprodukSelected != null)
                {
                    using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
                    {
                        this.produk = uow.produk.Get(this.listprodukSelected.IdProduk);
                        LblNamaProduk.Content = this.produk.NamaProduk;
                        txtCategory.Text = this.produk.ProdukKategori;
                        txtSKU.Text = this.produk.SKU;
                        txtProductGroup.Text = this.produk.NamaGroupProduk;
                        txtCogs.Text = this.produk.HargaPokokAverage.GetValueOrDefault(0).ToString();
                        txtPurchasingprice.Text = this.produk.HargaBeli.GetValueOrDefault(0).ToString();
                        txtSellingprice.Text = this.produk.HargaJual.GetValueOrDefault(0).ToString();
                        txtBaseUnit.Text = this.produk.SatuanDasar;
                        txtCurrency.Text = this.produk.MataUang;
                        txtMinimumOrder.Text = this.produk.MinPemesanan.GetValueOrDefault(0).ToString();
                        if (this.produk.CheckboxDiskonProduk == true)
                            txtDiscountyes.Text = "Yes";
                        else if (this.produk.CheckboxDiskonProduk == false)
                            txtDiscountyes.Text = "No";
                        txtDiscount.Text = this.produk.DiskonProdukPersen;
                        txtPeriode.Text = this.produk.TanggalMulaiDiskonProduk.GetValueOrDefault().ToShortDateString();
                        txtPeriode1.Text = this.produk.TanggalBerakhirDiskonProduk.GetValueOrDefault().ToShortDateString();
                        txtManageStock.Text = this.produk.CheckboxManageStok.ToString();
                        txtStock.Text = this.produk.JumlahStok.ToString();
                        txtMinStock.Text = this.produk.BatasStokMin.ToString();
                        txtProducttype.Text = this.produk.TipeProduk;
                        txtRemarks.Text = this.produk.Keterangan;
                        txtIncludingTax.Text = this.produk.CheckBoxInclusiveTax.ToString();
                        txtLength.Text = this.produk.Panjang;
                        txtWide.Text = this.produk.Lebar;
                        txtTall.Text = this.produk.Tinggi;
                        txtWeight.Text = this.produk.Berat;
                        txtVendor1.Text = this.produk.SuplierA;
                        VendorPrimary.Text = this.produk.KeteranganSuplierA;
                        txtVendor2.Text = this.produk.SuplierB;
                        Vendor2.Text = this.produk.KeteranganSuplierB;
                        txtVendor3.Text = this.produk.SuplierC;
                        Vendor3.Text = this.produk.KeteranganSuplierC;
                        txtVendor4.Text = this.produk.SuplierD;
                        Vendor4.Text = this.produk.KeteranganSuplierD;
                        if (!string.IsNullOrEmpty(this.produk.UploadImage0))
                            Image1.Source = new BitmapImage(new Uri(Path.GetFullPath(this.produk.UploadImage0)));
                        else if (!string.IsNullOrEmpty(this.produk.UploadImage0))
                            Image1.Source = new BitmapImage(new Uri(Path.GetFullPath("/Reyuko.App/bin/Debug/files/images/1.jpg")));
                        if (!string.IsNullOrEmpty(this.produk.UploadImage1))
                            Image2.Source = new BitmapImage(new Uri(Path.GetFullPath(this.produk.UploadImage1)));
                        if (!string.IsNullOrEmpty(this.produk.UploadImage2))
                            Image3.Source = new BitmapImage(new Uri(Path.GetFullPath(this.produk.UploadImage2)));
                        if (!string.IsNullOrEmpty(this.produk.UploadImage3))
                            Image4.Source = new BitmapImage(new Uri(Path.GetFullPath(this.produk.UploadImage3)));
                    }
                }
            }
        }

       

        private void New_Click(object sender, RoutedEventArgs e)
        {
            this.isEdit = false;
            NewProduk v = new NewProduk(this);
            Switcher.Switchproduk(v);
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            this.isEdit = true;
            NewProduk v = new NewProduk(this);
            Switcher.Switchproduk(v);
        }

        private void Sales_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
             
    

