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

namespace Reyuko.App.Views.Service
{
    /// <summary>
    
    /// </summary>
    public partial class NewService : UserControl
    {
        public NewService()
        {
            InitializeComponent();
            Switcher.pageSwitchNewService = this;
            this.Init();
        }
        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
        public object UserControl { get; internal set; }
        public IEnumerable<KategoriProduk> kategoriProduks { get; set; }
        public KategoriProduk kategoriProdukSelected { get; set; }
        private IEnumerable<DataMataUang> dataMataUangs { get; set; }
        private DataMataUang DataMataUangSelected { get; set; }
        private IEnumerable<SatuanDasar> satuanDasars { get; set; }
        private SatuanDasar satuanDasarSelected { get; set; }
        private IEnumerable<DataPajak> dataPajaks { get; set; }
        private DataPajak dataPajakSelected { get; set; }
        private string UploadFileA { get; set; }
        private string UploadFileB { get; set; }
        private string UploadFileC { get; set; }
        private string UploadFileD { get; set; }

        private void Init()
        {
            this.LoadKategoriProduk();
            this.LoadCurrency();
            this.LoadBaseUnit();
            this.LoadTax();
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
        private void Cbtax_selectchange(object sender, SelectionChangedEventArgs e)
        {
            this.dataPajakSelected = null;
            if (cbTax.SelectedItem != null)
            {
                this.dataPajakSelected = (DataPajak)cbTax.SelectedItem;
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
        private void Cbbaseunit_selectchange(object sender, SelectionChangedEventArgs e)
        {
            this.satuanDasarSelected = null;
            if (cbBaseUnit.SelectedItem != null)
            {
                this.satuanDasarSelected = (SatuanDasar)cbBaseUnit.SelectedItem;
            }
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
        private void Cbcategory_change(object sender, SelectionChangedEventArgs e)
        {
            this.kategoriProdukSelected = null;
            if (cbCategory.SelectedItem != null)
            {
                this.kategoriProdukSelected = (KategoriProduk)cbCategory.SelectedItem;
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
        private void Cbcurrency_Selectchange(object sender, SelectionChangedEventArgs e)
        {
            this.DataMataUangSelected = null;
            if (cbCurrency.SelectedItem != null)
            {
                this.DataMataUangSelected = (DataMataUang)cbCurrency.SelectedItem;
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
        public produk GetData()
        {
            produk oData = new produk();
            oData.SKU = txtSKU.Text;
            oData.NamaProduk = txtServiceName.Text;
            oData.HargaPokokAverage = double.Parse(txtCogs.Text);
            oData.HargaJual = double.Parse(txtSellingPrice.Text);
            oData.Keterangan = txtRemarks.Text;
            if (this.kategoriProdukSelected != null)
            {
                oData.IdProdukKategori = this.kategoriProdukSelected.Id;
                oData.ProdukKategori = this.kategoriProdukSelected.ProdukKategori;
            }
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
            if (this.dataPajakSelected != null)
            {
                oData.IdPajak = this.dataPajakSelected.Id;
                oData.Pajak = this.dataPajakSelected.NamaPajak;
            }
            
            oData.CheckboxPajak = chktaxable.IsChecked;
            oData.CheckboxDiskonProduk = chkdiskon.IsChecked;
            oData.N1Calculation = chkN1calculation.IsChecked;
            oData.TimeBasedUnit = chkTimebased.IsChecked;
            oData.CheckboxKalender = chkCalendar.IsChecked;
            oData.CheckBoxTidakAktif = chkInactive.IsChecked;
            oData.CheckBoxInclusiveTax = chkInclusivetax.IsChecked;
            oData.TanggalMulaiDiskonProduk = DateTime.Parse(Date1.Text);
            oData.TanggalBerakhirDiskonProduk = DateTime.Parse(Date2.Text);
            oData.UploadImage0 = this.UploadFileA;
            oData.UploadImage1 = this.UploadFileB;
            oData.UploadImage2 = this.UploadFileC;
            oData.UploadImage3 = this.UploadFileD;

            return oData;
        }
        private void saveservice_click(object sender, RoutedEventArgs e)
        {
            if (cbCategory.Text == "" || txtSKU.Text == "" || txtServiceName.Text == "" || txtCogs.Text == "" || txtSellingPrice.Text == "" || cbCurrency.Text == "" || cbBaseUnit.Text == "" || Date1.Text == "" || Date2.Text == "" )
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            ProdukBLL produkBLL = new ProdukBLL();
            if (produkBLL.AddProduk(this.GetData()) > 0)
            {

                MessageBox.Show("Service successfully added !");

            }
            else
            {
                MessageBox.Show("Service failed to be added !");
            }
            Service v = new Service();
            Switcher.SwitchNewService(v);
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Service v = new Service();
            Switcher.SwitchNewService(v);
        }

        private void TxtSellingPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtSellingPrice.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtSellingPrice.Text = "";
                    return;
                }

            }
        }

        private void TxtSKU_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TxtServiceName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtServiceName.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtServiceName.Text = "";
                    return;
                }

            }
        }

        private void TxtCogs_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtCogs.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtCogs.Text = "";
                    return;
                }

            }
        }

        private void TxtRemarks_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
