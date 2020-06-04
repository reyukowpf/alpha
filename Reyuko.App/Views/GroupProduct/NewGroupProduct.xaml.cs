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
using Microsoft.Win32;
using System.IO;
using Path = System.IO.Path;
using Reyuko.Utils.Common;

namespace Reyuko.App.Views.GroupProduct
{
    /// <summary>
    
    /// </summary>
    public partial class NewGroupProduct : UserControl
    {
        public NewGroupProduct(GroupProducts groupProductForm)
        {
            InitializeComponent();
            this.groupProductForm = groupProductForm;
            Switcher.pageSwitcherNewgrupproduk = this;
            this.Init();         
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
        public object UserControl { get; internal set; }
        public GroupProducts groupProductForm;
        private IEnumerable<KategoriProduk> KategoriProduks { get; set; }
        private KategoriProduk KategoriProdukSelected { get; set; }
        public bool isEdit = false;
        private string UploadFileA { get; set; }
        private string UploadFileB { get; set; }
        private string UploadFileC { get; set; }
        private string UploadFileD { get; set; }

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
            if (this.groupProductForm.isEdit == true)
                this.LoadGrupProduk();
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

        private void LoadGrupProduk()
        {
            this.ClearForm();
            if (this.groupProductForm != null && this.groupProductForm.GrupProdukSelected != null)
            {
                txtGroupName.Text = this.groupProductForm.GrupProdukSelected.NamaGrupProduk;
                txtSKU.Text = this.groupProductForm.GrupProdukSelected.GrupSKU;
                cbCategory.SelectedValue = this.groupProductForm.GrupProdukSelected.IdKategoriProduk;
                chkDiscount.IsChecked = this.groupProductForm.GrupProdukSelected.CheckboxDiskon;
                txtDiscount.Text = this.groupProductForm.GrupProdukSelected.DiskonPersen.ToString();
                dtTanggalMulaiDiskon.Text = this.groupProductForm.GrupProdukSelected.TanggalMulaiDiskon.GetValueOrDefault().ToShortDateString();
                dtTanggalAkhirDiskon.Text = this.groupProductForm.GrupProdukSelected.TanggalAkhirDiskon.GetValueOrDefault().ToShortDateString();
                txtDescription.Text = this.groupProductForm.GrupProdukSelected.Keterangan;
                this.KategoriProdukSelected = this.KategoriProduks.Where(m => m.Id == this.groupProductForm.GrupProdukSelected.IdKategoriProduk).FirstOrDefault(); ;
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
           // oData.
            if (this.groupProductForm.GrupProdukSelected != null)
                oData.Id = this.groupProductForm.GrupProdukSelected.Id;

            return oData;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtGroupName.Text == "" || cbCategory.Text == "" ||  dtTanggalMulaiDiskon.Text == "" || dtTanggalAkhirDiskon.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            GrupProdukBLL GroupProdukBLL = new GrupProdukBLL();
            if (this.groupProductForm.isEdit == false)
            {
                if (GroupProdukBLL.AddGrupProduk(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Product Group successfully added !");
                    this.groupProductForm.LoadGrupProduk();
                }
                else
                {
                    MessageBox.Show("Product Group failed to add !");
                }
            }
            else
            {
                if (GroupProdukBLL.EditGrupProduk(this.GetData()) == true)
                {
                    this.ClearForm();
                    MessageBox.Show("Product Group successfully changed !");
                    this.groupProductForm.LoadGrupProduk();
                }
                else
                {
                    MessageBox.Show("Product Group failed to change !");
                }
            }
            GroupProducts v = new GroupProducts();
            Switcher.Switchnewgrupproduk(v);
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.ClearForm();
            GroupProducts v = new GroupProducts();
            Switcher.Switchnewgrupproduk(v);
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
                    MessageBox.Show("Must Have Numeric");
                    txtDiscount.Text = "";
                    return;
                }

            }
        }

        private void TxtGroupName_TextChanged(object sender, TextChangedEventArgs e)
        {
         
        }

        private void TxtSKU_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TxtDescription_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
