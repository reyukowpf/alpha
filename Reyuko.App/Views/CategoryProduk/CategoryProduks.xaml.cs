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


    public partial class CategoryProduks : UserControl
    {
        public CategoryProduks()
        {
            InitializeComponent();
            this.Init();
        }


        public IEnumerable<KategoriProduk> kategoriProduks { get; set; }
        public KategoriProduk kategoriProdukSelected { get; set; }
        public bool isEdit = false;
        private IEnumerable<KategoriProduk> kategoriProdukChilds { get; set; }
        private int pageIndex = 1;
        private int pageSize = 10;

        private void Init()
        {
            this.ClearForm();
            this.LoadKategoriProduk();
        }

        private void ClearForm()
        {
            this.kategoriProdukSelected = null;
        }

        public void LoadKategoriProduk()
        {
            TvCategoryProduk.Items.Clear();
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kategoriProduks = uow.KategoriProduk.GetAll();
                var roots = this.kategoriProduks.Where(m => m.IdProdukKategoriParent.GetValueOrDefault(0) == 0);
                if (roots != null)
                {
                    foreach (var root in roots)
                    {
                        TreeViewItem node = new TreeViewItem() { Header = root.ProdukKategori, TabIndex = root.Id };
                        this.AddChild(node, root.Id);
                        TvCategoryProduk.Items.Add(node);
                    }
                }
            }
        }

        private TreeViewItem AddChild(TreeViewItem node, int parentId)
        {
            var items = this.kategoriProduks.Where(m => m.IdProdukKategoriParent == parentId);
            if (items != null)
            {
                foreach (var item in items)
                {
                    TreeViewItem leaf = new TreeViewItem() { Header = item.ProdukKategori, TabIndex = item.Id };
                    this.AddChild(leaf, item.Id);
                    node.Items.Add(leaf);
                }
            }

            return node;
        }

        private void TvCategoryProduk_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<Object> e)
        {
            this.kategoriProdukSelected = null;
            if (TvCategoryProduk.SelectedItem != null)
            {
                TreeViewItem node = (TreeViewItem)TvCategoryProduk.SelectedItem;
                this.kategoriProdukSelected = this.kategoriProduks.Where(m => m.Id == node.TabIndex).FirstOrDefault();
                this.LoadKategoriProduk1(this.kategoriProdukSelected.Id);
            }
        }

        public void LoadKategoriProduk1(int Id)
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kategoriProdukChilds = uow.KategoriProduk.GetAll().Where(m => m.Id == Id);
                DGCategoryProduk.ItemsSource = this.kategoriProdukChilds;
                
            }
        }

        private void BtnNewCategoryProduct_Clicks(object sender, RoutedEventArgs e)
        {
            this.isEdit = false;
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is NewCategoryProduk)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                NewCategoryProduk newCategory = new NewCategoryProduk(this);
                newCategory.Show();
            }
        }

        private void BtnEditCategoryProduct_Clicks(object sender, RoutedEventArgs e)
        {
            this.isEdit = true;
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is NewCategoryProduk)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                NewCategoryProduk newCategory = new NewCategoryProduk(this);
                newCategory.Show();
            }
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (this.kategoriProdukSelected == null)
            {
                MessageBox.Show("Category Product not selected !");
            }
            else
            {
                KategoriProdukBLL purchasedeliveryBLL = new KategoriProdukBLL();
                if (purchasedeliveryBLL.RemoveKategoriProduk(this.kategoriProdukSelected.Id) == true)
                {
                    MessageBox.Show("Category Product successfully deleted");
                    this.LoadKategoriProduk();
                    this.kategoriProdukSelected = null;
                }
            }
        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

