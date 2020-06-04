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

namespace Reyuko.App.Views.Service
{
    /// <summary>
    
    /// </summary>
    public partial class Service : UserControl
    {
        public Service()
        {
            InitializeComponent();
            Switcher.pageSwitchService = this;
            this.Init();
        }
        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        public IEnumerable<KategoriProduk> kategoriProduks { get; internal set; }
        public object kategoriProdukSelected { get; internal set; }
        public IEnumerable<produk> produks { get; set; }
        public produk produk;
        public produk produkSelected { get; set; }
        public produk listprodukSelected { get; set; }
        public IEnumerable<produk> listproduks { get; set; }
        private void Init()
        {          
            this.LoadKategoriProduk();
            this.LoadSearchProduk();
            this.LoadProduk("");
        }

        public void LoadSearchProduk()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.produks = uow.produk.GetAll();
                srserviceproduk.ItemsSource = this.produks;
            }
        }
        private void SearchProduk_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.produkSelected = null;
            if (srserviceproduk.SelectedItem != null)
            {
                this.produkSelected = (produk)srserviceproduk.SelectedItem;
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
                LstService.ItemsSource = itemSource;
            }
        }
        private void LstProduk_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           // this.ClearForm();
            if (LstService.SelectedItem != null)
            {
                this.listprodukSelected = (produk)LstService.SelectedItem;
                if (this.listprodukSelected != null)
                {
                    using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
                    {
                        this.produk = uow.produk.Get(this.listprodukSelected.IdProduk);
                        txtservice.Text = this.produk.NamaProduk;
                        txtCategory.Text = this.produk.ProdukKategori;
                        txtSKU.Text = this.produk.SKU;
                        txtProductGroup.Text = this.produk.NamaGroupProduk;
                        txtCogs.Text = this.produk.HargaPokokAverage.GetValueOrDefault(0).ToString();
                        txtPurchasingprice.Text = this.produk.HargaBeli.GetValueOrDefault(0).ToString();
                        txtSellingprice.Text = this.produk.HargaJual.GetValueOrDefault(0).ToString();
                        txtBaseUnit.Text = this.produk.SatuanDasar;
                        txtCurrency.Text = this.produk.MataUang;
                        if (this.produk.CheckboxDiskonProduk == true)
                            txtDiscountyes.Text = "Yes";
                        else if (this.produk.CheckboxDiskonProduk == false)
                            txtDiscountyes.Text = "No";
                        txtDiscount.Text = this.produk.DiskonProdukPersen;
                        txtPeriode.Text = this.produk.TanggalMulaiDiskonProduk.GetValueOrDefault().ToShortDateString();
                        txtPeriode1.Text = this.produk.TanggalBerakhirDiskonProduk.GetValueOrDefault().ToShortDateString();
                        txtRemarks.Text = this.produk.Keterangan;
                        if (!string.IsNullOrEmpty(this.produk.UploadImage0))
                            Image1.Source = new BitmapImage(new Uri(Path.GetFullPath(this.produk.UploadImage0)));
                    }
                }
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

        private void New_Click(object sender, RoutedEventArgs e)
        {
            NewService newService = new NewService();
            Switcher.SwitchService(newService);
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Sales_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
             
    

