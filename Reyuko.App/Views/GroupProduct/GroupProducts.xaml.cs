using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.BLL.Core;
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

namespace Reyuko.App.Views.GroupProduct
{
    /// <summary>

    /// </summary>
    public partial class GroupProducts : UserControl
    {
        public GroupProducts()
        {
            InitializeComponent();
            Switcher.pageSwitchergrupproduk = this;
            this.Init();
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
        public IEnumerable<GrupDiskon> GrupDiskons { get; set; }
        public GrupDiskon GrupDiskonSelected { get; set; }
        public IEnumerable<GrupProduk> GrupProduks { get; set; }
        public GrupProduk GrupProdukSelected { get; set; }
        public IEnumerable<KategoriProduk> kategoriProduks { get; set; }
        public KategoriProduk kategoriProdukSelected { get; set; }
        public IEnumerable<GrupProduk> grupProduks { get; set; }
        
        public bool isEdit = false;
        private int pageIndex = 1;
        private int pageSize = 10;

        private void Init()
        {
            this.ClearForm();
            this.LoadGrupProduk();
            this.LoadGroupProduk();
            this.LoadKategoriProduk();
        }

        public void LoadGroupProduk()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.grupProduks = uow.GrupProduk.GetAll();
                srgroupproduk.ItemsSource = this.grupProduks;
            }
        }
        private void GroupProduk_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.GrupProdukSelected = null;
            if (srgroupproduk.SelectedItem != null)
            {
                this.GrupProdukSelected = (GrupProduk)srgroupproduk.SelectedItem;
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
        private void ClearForm()
        {
            this.GrupProdukSelected = null;
            txtGroupID.Text = "";
            txtGroupName.Text = "";
            txtCategory.Text = "";
            txtDiscountyes.Text = "";
            txtDiscount.Text = "0";
            txtPeriode.Text = "";
            txtPeriode1.Text = "";
            txtDescription.Text = "";
        }

        public void LoadGrupProduk()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.GrupProduks = uow.GrupProduk.GetAll();
                LiGroupProduct.ItemsSource = this.GrupProduks;
            }
        }
        private void LiGroupProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //this.kategoriProdukSelected = null;
            this.ClearForm();
            if (LiGroupProduct.SelectedItem != null)
            {
                this.GrupProdukSelected = (GrupProduk)LiGroupProduct.SelectedItem;
                txtGroupID.Text = this.GrupProdukSelected.Id.ToString();
                txtGroupName.Text = this.GrupProdukSelected.NamaGrupProduk;
                txtCategory.Text = this.GrupProdukSelected.KategoriProduk;
                if (this.GrupProdukSelected.CheckboxDiskon == true)
                    txtDiscountyes.Text = "Ya";
                txtDiscount.Text = this.GrupProdukSelected.DiskonPersen.ToString();
                if (this.GrupProdukSelected.TanggalMulaiDiskon != null)
                    txtPeriode.Text = this.GrupProdukSelected.TanggalMulaiDiskon.GetValueOrDefault().ToShortDateString();
                if (this.GrupProdukSelected.TanggalAkhirDiskon != null)
                    txtPeriode1.Text = this.GrupProdukSelected.TanggalAkhirDiskon.GetValueOrDefault().ToShortDateString();
                txtDescription.Text = this.GrupProdukSelected.Keterangan;
                this.LoadKategoriProduk(this.GrupProdukSelected.IdKategoriProduk);
            }
        }

        public void LoadKategoriProduk(int id)
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kategoriProduks = uow.KategoriProduk.GetAll().Where(m => m.IdProdukKategoriParent == id);
                LstMember.ItemsSource = this.kategoriProduks;
            }
        }
        private void BtnNewGroupProduct_Click(object sender, RoutedEventArgs e)
        {
            this.isEdit = false;
            NewGroupProduct v = new NewGroupProduct(this);
            Switcher.Switchgrupproduk(v);
        }

        private void BtnEditGroupProduct_Click(object sender, RoutedEventArgs e)
        {
            this.isEdit = true;
            NewGroupProduct v = new NewGroupProduct(this);
            Switcher.Switchgrupproduk(v);
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (this.GrupProdukSelected == null)
            {
                MessageBox.Show("Group Product not selected !");
            }
            else
            {
                GrupProdukBLL purchasedeliveryBLL = new GrupProdukBLL();
                if (purchasedeliveryBLL.RemoveGrupProduk(this.GrupProdukSelected.Id) == true)
                {
                    MessageBox.Show("Group Product successfully deleted");
                    this.LoadGrupProduk();
                    this.GrupProdukSelected = null;
                }
            }
        }
 
       
    }
}



