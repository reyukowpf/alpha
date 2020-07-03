using Reyuko.BLL.Core;
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

namespace Reyuko.App.Views.GroupProduct
{
    /// <summary>
    
    /// </summary>
    public partial class GroupProduct : Window
    {
        public GroupProduct(Produk.NewProduk newProduk)
        {
            InitializeComponent();
            this.newProduk = newProduk;
            this.Init();         
        }
       
        public object UserControl { get; internal set; }
        public Produk.NewProduk newProduk;
        private IEnumerable<KategoriProduk> KategoriProduks { get; set; }
        private KategoriProduk KategoriProdukSelected { get; set; }
        public bool isEdit = false;

        private void ClearForm()
        {
            txtGroupName.Text = "";
            txtSKU.Text = "";
            cbCategory.SelectedIndex = -1;
            chkDiscount.IsChecked = false;
            txtDiscount.Text = "0";
            dtTanggalMulaiDiskon.Text = DateTime.Now.ToShortDateString();
            dtTanggalAkhirDiskon.Text = DateTime.Now.ToShortDateString();
            txtDescription.Text = "";

            this.KategoriProdukSelected = null;
        }

        private void Init()
        {
            this.ClearForm();
            this.LoadComboKategoriProduk();
        }

        private void LoadComboKategoriProduk()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.KategoriProduks = uow.KategoriProduk.GetAll();
                cbCategory.ItemsSource = this.KategoriProduks;
                cbCategory.DisplayMemberPath = "ProdukKategori";
                cbCategory.SelectedValuePath = "Id";
            }
        }

      
        private GrupProduk GetData()
        {
            GrupProduk oData = new GrupProduk();
            oData.NamaGrupProduk = txtGroupName.Text;
            oData.GrupSKU = txtSKU.Text;
            if (this.KategoriProdukSelected != null)
            {
                oData.IdKategoriProduk = this.KategoriProdukSelected.Id;
                oData.KategoriProduk = this.KategoriProdukSelected.ProdukKategori;
            }
            oData.Keterangan = txtDescription.Text;
            oData.CheckboxDiskon = chkDiscount.IsChecked;
            oData.DiskonPersen = double.Parse(txtDiscount.Text);
            if (!string.IsNullOrEmpty(dtTanggalMulaiDiskon.Text))
                oData.TanggalMulaiDiskon = DateTime.Parse(dtTanggalMulaiDiskon.Text);
            if (!string.IsNullOrEmpty(dtTanggalAkhirDiskon.Text))
                oData.TanggalAkhirDiskon = DateTime.Parse(dtTanggalAkhirDiskon.Text);
            
            return oData;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtGroupName.Text == "" || cbCategory.Text == "" || dtTanggalMulaiDiskon.Text == "" || dtTanggalAkhirDiskon.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            GrupProdukBLL GroupProdukBLL = new GrupProdukBLL();
            
                if (GroupProdukBLL.AddGrupProduk(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Product Group successfully added !");
                newProduk.LoadGrupProduk();
                }
                else
                {
                    MessageBox.Show("Product Group failed to add !");
                }
            this.Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.ClearForm();
            this.Close();
        }

        private void CbCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.KategoriProdukSelected = null;
            if (cbCategory.SelectedItem != null)
            {
                this.KategoriProdukSelected = (KategoriProduk)cbCategory.SelectedItem;
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
                    MessageBox.Show("Harus Diisi Numerik");
                    txtDiscount.Text = "";
                    return;
                }

            }
        }

        private void TxtGroupName_TextChanged(object sender, TextChangedEventArgs e)
        {
            //string tString = txtGroupName.Text;
            //if (tString.Trim() == "") return;
            //for (int i = 0; i < tString.Length; i++)
            //{
            //    if (char.IsNumber(tString[i]))
            //    {
            //        MessageBox.Show("Harus Diisi Character");
            //        txtGroupName.Text = "";
            //        return;
            //    }

            //}
        }

        private void TxtSKU_TextChanged(object sender, TextChangedEventArgs e)
        {
            //string tString = txtSKU.Text;
            //if (tString.Trim() == "") return;
            //for (int i = 0; i < tString.Length; i++)
            //{
            //    if (char.IsNumber(tString[i]))
            //    {
            //        MessageBox.Show("Harus Diisi Character");
            //        txtSKU.Text = "";
            //        return;
            //    }

            //}
        }
    }
}
