using DevExpress.XtraPrinting;
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

namespace Reyuko.App.Views.Produk
{
    /// <summary>
    /// </summary>
    public partial class StockReceivedName : Window
    {
        internal bool isEdit;

        public StockReceivedName(NewProduk newproduk)
        {
            InitializeComponent();
            this.newproduk = newproduk;
            this.Init();
        }

        private void Init()
        {
            this.LoadKontak();
            this.LoadComboLokasi();
            this.LoadComboCash();
            this.ClearForm();
        }

        private void ClearForm()
        {
            tgl.Text = DateTime.Now.ToShortDateString();
        }

        public static string kiriman;
        public NewProduk newproduk;
        public IEnumerable<Kontak> Kontaks { get; set; }
        public Kontak KontakSelected { get; set; }
        //public IEnumerable<ReceivedProduk> receivedProduks { get;set; }
        public IEnumerable<Lokasi> lokasis { get; set; }
        public Lokasi lokasiSelected;
        //public ReceivedProduk receivedProdukSelected;
        public IEnumerable<DropdownBankKas> dropdownBankKas { get; set; }
        public DropdownBankKas dropdownBankSelected;
     
        public object UserControl { get; internal set; }

        public void LoadKontak()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.Kontaks = uow.Kontak.GetAll().Where(m => m.TypeKontak.ToLower() == "vendor");
                srvendor.ItemsSource = this.Kontaks;
            }
        }
        private void LoadComboLokasi()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.lokasis = uow.Lokasi.GetAll();
                CBLocation.DisplayMemberPath = "NamaTempatLokasi";
                CBLocation.SelectedValuePath = "Id";
                CBLocation.ItemsSource = this.lokasis;
            }
        }

        private void GetOtherFormTextBox()
        {
            txtTotalUnit.Text = newproduk.txtStock.Text;
        }
        private void LoadComboCash()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dropdownBankKas = uow.DropdownBankKas.GetAll();
                CBCash.DisplayMemberPath = "DropdownBankkas";
                CBCash.SelectedValuePath = "Id";
                CBCash.ItemsSource = this.dropdownBankKas;
            }
        }
        private void cbcash_Change(object sender, SelectionChangedEventArgs e)
        {
            this.dropdownBankSelected = null;
            if (CBCash.SelectedItem != null)
            {
                this.dropdownBankSelected = (DropdownBankKas)CBCash.SelectedItem;
            }
        }
        private void cblokasi_Change(object sender, SelectionChangedEventArgs e)
        {
            this.lokasiSelected = null;
            if (CBLocation.SelectedItem != null)
            {
                this.lokasiSelected = (Lokasi)CBLocation.SelectedItem;
            }
        }
        private void srvendor_Change(object sender, SelectionChangedEventArgs e)
        {
            this.KontakSelected = null;
            if (srvendor.SelectedItem != null)
            {
                this.KontakSelected = (Kontak)srvendor.SelectedItem;
            }
        }
        private void NewVendor_Click(object sender, RoutedEventArgs e)
        {
            /*bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is NewVendor)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                NewVendor newStock = new NewVendor(this);
                newStock.Show();
            }*/
        }
        public void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtTotalUnit.Text == "" || txtPurchasingprice.Text == "" || txtReceivednumber.Text == "" || srvendor.Text == "" || CBLocation.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            ProdukBLL receivedProdukBLL = new ProdukBLL();
            produk oData = new produk();
           if (this.KontakSelected != null)
            {
                oData.IdKontak = this.KontakSelected.Id;
                oData.SuplierA = this.KontakSelected.NamaA;
            }
            if (this.lokasiSelected != null)
            {
                oData.IdLokasi = this.lokasiSelected.Id;
                oData.NamaLokasi = this.lokasiSelected.NamaTempatLokasi;
            }
            oData.Tanggal = DateTime.Parse(tgl.Text);
            if(this.dropdownBankSelected != null)
            {
                oData.IdDropdownBankkas = this.dropdownBankSelected.Id;
                oData.DropdownBankkas = this.dropdownBankSelected.DropdownBankkas;
            }
            oData.JumlahStok = double.Parse(txtTotalUnit.Text);
            oData.HargaBeli = double.Parse(txtPurchasingprice.Text);
            oData.ReceivedNumber = txtReceivednumber.Text;
            oData.Keterangan = txtNote.Text;
            oData.AKtif = true;
            oData.CheckboxManageStok = true;
            if (receivedProdukBLL.AddProduk(oData) > 0)
                {
          //          this.ClearForm();
                 this.newproduk.LoadStok();
                }
                else
                {
                }          
       
            this.Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();   
        }

        private void TxtTotalUnit_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtTotalUnit.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Harus Diisi Numerik");
                    txtTotalUnit.Text = "";
                    return;
                }

            }
        }

        private void TxtPurchasingprice_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtPurchasingprice.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Harus Diisi Numerik");
                    txtPurchasingprice.Text = "";
                    return;
                }

            }
        }

        private void TxtReceivednumber_TextChanged(object sender, TextChangedEventArgs e)
        {
           

     
        }
    }
}
