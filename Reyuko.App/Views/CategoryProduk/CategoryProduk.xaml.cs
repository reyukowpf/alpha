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

namespace Reyuko.App.Views.CategoryProduk
{
    /// <summary>
    /// </summary>
    public partial class CategoryProduk : Window
    {
        public CategoryProduk(Produk.NewProduk newProduk)
        {
            InitializeComponent();
            this.newProduk = newProduk;
            this.Init();
        }

        public object UserControl { get; internal set; }
        public Produk.NewProduk newProduk;
        private IEnumerable<KategoriProduk> kategoriProduks { get; set; }
        private KategoriProduk kategoriProdukSelected { get; set; }

        private void ClearForm()
        {
            txtCategoryName.Text = "";
            CBKategoryParent.SelectedIndex = -1;
            txtDescription.Text = "";

            this.kategoriProdukSelected = null;
        }

        private void Init()
        {
            this.ClearForm();
            this.LoadComboKategoriProdukParent();
        }

        
        private void LoadComboKategoriProdukParent()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kategoriProduks = uow.KategoriProduk.GetAll();
                CBKategoryParent.ItemsSource = this.kategoriProduks;
                CBKategoryParent.DisplayMemberPath = "ProdukKategori";
                CBKategoryParent.SelectedValuePath = "Id";
            }
        }

      
      private KategoriProduk GetData()
        {
            KategoriProduk oData = new KategoriProduk();
            oData.ProdukKategori = txtCategoryName.Text;
            if (this.kategoriProdukSelected != null)
            {
                oData.IdProdukKategoriParent = this.kategoriProdukSelected.Id;
                oData.ProdukKategoriParent = this.kategoriProdukSelected.ProdukKategori;
            }
            
            oData.deskripsi = txtDescription.Text;
            if (this.kategoriProdukSelected != null)
                oData.Id = this.kategoriProdukSelected.Id;

            return oData;
        }

        public void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            KategoriProdukBLL KategoriProdukBLL = new KategoriProdukBLL();
            if (txtCategoryName.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (KategoriProdukBLL.AddKategoriProduk(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Product Category successfully added !");
                newProduk.LoadKategoriProduk();
                }
                else
                {
                    MessageBox.Show("Product Category failed to added !");
                }
            this.Close();            
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.ClearForm();
            this.Close();
        }

        private void CBKategoryParent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.kategoriProdukSelected = null;
            if (CBKategoryParent.SelectedItem != null)
            {
                this.kategoriProdukSelected = (KategoriProduk)CBKategoryParent.SelectedItem;
            }

        }

        private void TxtCategoryName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtCategoryName.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Harus Diisi Character");
                    txtCategoryName.Text = "";
                    return;
                }

            }
        }

        private void TxtDescription_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtDescription.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Harus Diisi Numerik");
                    txtDescription.Text = "";
                    return;
                }

            }
        }
    }
}
