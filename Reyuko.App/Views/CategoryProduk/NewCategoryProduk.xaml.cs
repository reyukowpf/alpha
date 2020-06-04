using Reyuko.App.Views.Produk;
using Reyuko.BLL.Core;
using Reyuko.DAL.Domain;
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
    public partial class NewCategoryProduk : Window
    {
        public NewCategoryProduk(CategoryProduks categoryProdukForm)
        {
            InitializeComponent();
            this.categoryProdukForm = categoryProdukForm;
            this.Init();
        }

        public object UserControl { get; internal set; }
        public CategoryProduks categoryProdukForm;
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
            if (this.categoryProdukForm.isEdit == true) ;
                this.LoadKategoriProduk();
        }

        
        private void LoadComboKategoriProdukParent()
        {
            this.kategoriProduks = this.categoryProdukForm.kategoriProduks;
            CBKategoryParent.ItemsSource = this.kategoriProduks;
            CBKategoryParent.DisplayMemberPath = "ProdukKategori";
            CBKategoryParent.SelectedValuePath = "Id";
        }

        private void LoadKategoriProduk()
        {
            this.ClearForm();
            if (this.categoryProdukForm != null && this.categoryProdukForm.kategoriProdukSelected != null)
            {
                txtCategoryName.Text = this.categoryProdukForm.kategoriProdukSelected.ProdukKategori;
                CBKategoryParent.SelectedValue = this.categoryProdukForm.kategoriProdukSelected.IdProdukKategoriParent;
                txtDescription.Text = this.categoryProdukForm.kategoriProdukSelected.deskripsi;

                this.kategoriProdukSelected = this.kategoriProduks.Where(m => m.Id == this.categoryProdukForm.kategoriProdukSelected.IdProdukKategoriParent.GetValueOrDefault(0)).FirstOrDefault();
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
            if (this.categoryProdukForm.kategoriProdukSelected != null)
                oData.Id = this.categoryProdukForm.kategoriProdukSelected.Id;

            return oData;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            KategoriProdukBLL KategoriProdukBLL = new KategoriProdukBLL();
            if (this.categoryProdukForm.isEdit == false)
            {
                if (txtCategoryName.Text == "")
                {
                    MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                if (KategoriProdukBLL.AddKategoriProduk(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Kategori Produk berhasil ditambahkan !");
                    this.categoryProdukForm.LoadKategoriProduk();
                }
                else
                {
                    if (txtCategoryName.Text == "")
                    {
                        this.ClearForm();
                        MessageBox.Show("Category Name can't empty field !");
                        this.categoryProdukForm.LoadKategoriProduk();
                    }

                }
            }
            else
            {
                if (KategoriProdukBLL.EditKategoriProduk(this.GetData()) == true)
                {
                    this.ClearForm();
                    MessageBox.Show("Product Category successfully changed !");
                    this.categoryProdukForm.LoadKategoriProduk();
                }
                else
                {
                    MessageBox.Show("Product Category failed to change !");
                }
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
            
        }

        private void TxtDescription_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
