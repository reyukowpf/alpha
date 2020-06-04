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

namespace Reyuko.App.Views.Production   
{
    /// <summary>

    /// </summary>
    public partial class NewProduction : UserControl
    {
        public NewProduction(Production productionform)
        {
            InitializeComponent();
            Switcher.pageSwitchNewProduction = this;
            this.productionform = productionform;
            this.Init();
        }

        private void Init()
        {
            this.ClearForm();
            this.LoadNoDokumen();
            this.LoadComboLokasi();
            this.LoadStaff();
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
        public Production productionform;
        private IEnumerable<Dokumen> dokumens { get; set; }
        private Dokumen dokumenSelected;
        private IEnumerable<Lokasi> lokasis { get; set; }
        private Lokasi lokasiSelected;
        private IEnumerable<Kontak> kontaks { get; set; }
        private Kontak kontakSelected;
        public IEnumerable<OrderProductioninput> orderProductioninputs { get; set; }
        public OrderProductioninput orderProductioninputSelected;
        public IEnumerable<OrderFinishedproduk> orderFinishedproduks { get; set; }
        public OrderFinishedproduk orderFinishedprodukSelected;
        public void LoadNoDokumen()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dokumens = uow.Dokumen.GetAll();
                srnodokumen.ItemsSource = this.dokumens;
            }
        }
        public void LoadStaff()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kontaks = uow.Kontak.GetAll().Where(m => m.TypeKontak.ToLower() == "employee");
                srstaff.ItemsSource = this.kontaks;
            }
        }

        public void LoadDataSku()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.orderProductioninputs = uow.OrderProductioninput.GetAll().Where(m => m.CheckboxAktif == true);
                DGSKUProduction.ItemsSource = this.orderProductioninputs;
                int sum = 0;
                for (int i = 0; i < DGSKUProduction.Items.Count; i++)
                {
                    sum += Convert.ToInt32((DGSKUProduction.Items[i] as OrderProductioninput).TotalOrderProduk);
                }
                txtTotalinput.Text = sum.ToString();
            }
        }
        public void LoadDataFinishproduk()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.orderFinishedproduks = uow.OrderFinishedproduk.GetAll().Where(m => m.CheckboxAktif == true);
                DGSKUFinishedProduction.ItemsSource = this.orderFinishedproduks;
                    int suma = 0;
                    for (int i = 0; i < DGSKUFinishedProduction.Items.Count; i++)
                    {
                           suma += Convert.ToInt32((DGSKUFinishedProduction.Items[i] as OrderFinishedproduk).TotalBiaya);
                    }
                txtTotal.Text = suma.ToString();
                txtBalance.Text = ((float.Parse(txtTotalinput.Text.ToString()) - float.Parse(txtTotal.Text.ToString()))).ToString();
            }
        }
        private void LoadComboLokasi()
        {
            this.lokasis = new List<Lokasi>();
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.lokasis = uow.Lokasi.GetAll();
                cbLocation.DisplayMemberPath = "NamaTempatLokasi";
                cbLocation.SelectedValuePath = "id_order_finish_produk";
                cbLocation.ItemsSource = this.lokasis;
            }
        }
        private void Srnodokumen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.dokumenSelected = null;
            if (srnodokumen.SelectedItem != null)
            {
                this.dokumenSelected = (Dokumen)srnodokumen.SelectedItem;
            }
        }
        private void cblokasi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.lokasiSelected = null;
            if (cbLocation.SelectedItem != null)
            {
                this.lokasiSelected = (Lokasi)cbLocation.SelectedItem;
            }
        }
        private void srstaff_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.kontakSelected = null;
            if (srstaff.SelectedItem != null)
            {
                this.kontakSelected = (Kontak)srstaff.SelectedItem;
            }
        }
        private void Calculate_Click(object sender, RoutedEventArgs e)
        {

        }
        private production GetData()
        {
            production oData = new production();
            if (this.dokumenSelected != null)
            {
                oData.IdDocumentReference = this.dokumenSelected.Id;
                oData.DokumenReference = this.dokumenSelected.NoReferensiDokumen;
            }
            oData.Tanggal = DateTime.Parse(tanggal.Text);
            if (this.lokasiSelected != null)
            {
                oData.IdLokasi = this.lokasiSelected.Id;
                oData.Location = this.lokasiSelected.NamaTempatLokasi;
            }
            if (this.kontakSelected != null)
            {
                oData.IdKontak = this.kontakSelected.Id;
                oData.NamaPetugas = this.kontakSelected.NamaA;
            }
            oData.Note = txtNote.Text;
            oData.ProductionNumber = double.Parse(txtProductionNumber.Text);
          
            return oData;
        }
        private void SaveProduction_Click(object sender, RoutedEventArgs e)
        {
            if (txtProductionNumber.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            ProductionBLL productionBLL = new ProductionBLL();
            ProductionBLL ProductionBLL = new ProductionBLL();
            production production = new production();
            production.IdKodeTransaksi = 28;
            if (this.dokumenSelected != null)
            {
                production.IdDocumentReference = this.dokumenSelected.Id;
                production.DokumenReference = this.dokumenSelected.NoReferensiDokumen;
            }
            production.Tanggal = DateTime.Parse(tanggal.Text);
            if (this.lokasiSelected != null)
            {
                production.IdLokasi = this.lokasiSelected.Id;
                production.Location = this.lokasiSelected.NamaTempatLokasi;
            }
            if (this.kontakSelected != null)
            {
                production.IdKontak = this.kontakSelected.Id;
                production.NamaPetugas = this.kontakSelected.NamaA;
            }
            production.Note = txtNote.Text;
            production.ProductionNumber = double.Parse(txtProductionNumber.Text);
            production.TotalDebitAkunPersediaanProduk = double.Parse(txtTotal.Text);
            production.TotalKreditAkunPersediaanProduk = double.Parse(txtTotalinput.Text);
            if (ProductionBLL.AddProduction(production) > 0)
            {
                //  this.ClearForm();
                MessageBox.Show("Productions successfully added !");
            }
            else
            {
                MessageBox.Show("Productions failed to add !");
            }
            if (DGSKUProduction.Items.Count > 0)
            {
                foreach (var item in DGSKUProduction.Items)
                {
                    if (item is OrderProductioninput)
                    {
                        OrderProductioninput oNewData1 = (OrderProductioninput)item;
                        if (this.lokasiSelected != null)
                        {
                            oNewData1.IdLokasi = this.lokasiSelected.Id;
                            oNewData1.NamaLokasi = this.lokasiSelected.NamaTempatLokasi;
                        }
                        oNewData1.Tanggal = DateTime.Parse(tanggal.Text);
                        oNewData1.CheckboxAktif = false;
                        oNewData1.IdProduction = production.Id;
                        oNewData1.IdAkunPersediaan = production.IdAkunPersediaanProduk; 
                        if (productionBLL.EditProductioninput(oNewData1, production) == true)
                        {
                        }
                    }
                }
            }
                if (DGSKUFinishedProduction.Items.Count > 0)
                {
                    foreach (var item in DGSKUFinishedProduction.Items)
                    {
                        if (item is OrderFinishedproduk)
                        {
                            OrderFinishedproduk oNewData1 = (OrderFinishedproduk)item;
                            if (this.lokasiSelected != null)
                            {
                                oNewData1.IdLokasi = this.lokasiSelected.Id;
                                oNewData1.NamaLokasi = this.lokasiSelected.NamaTempatLokasi;
                            }
                            oNewData1.Tanggal = DateTime.Parse(tanggal.Text);
                            oNewData1.CheckboxAktif = false;
                            oNewData1.IdAkunPersediaan = production.IdAkunPersediaanProduk;
                            oNewData1.IdProduction = production.Id;
                            if (productionBLL.EditFinishedproduk(oNewData1, production) == true)
                            {
                            }
                        }
                    }
                    Production v = new Production();
                Switcher.SwitchNewProduction(v);
            }
        }

        private void ClearForm()
        {
            srnodokumen.Text = "";
            tanggal.Text = DateTime.Now.ToShortDateString();
            cbLocation.SelectedIndex = -1;
            srstaff.Text = "";
            txtNote.Text = "";
        //    txtProductionNumber = "";
        }

        private void StockList_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is Print.Print)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                Print.Print print = new Print.Print();
                print.Show();
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Production v = new Production();
            Switcher.SwitchNewProduction(v);
        }
        private void notes_Click(object sender, RoutedEventArgs e)
        {

        }
        private void saveasdraft_Click(object sender, RoutedEventArgs e)
        {

        }
        private void saveaspdf_Click(object sender, RoutedEventArgs e)
        {

        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Product_Click(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is Sku)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                Sku newVendor = new Sku(this);
                newVendor.Show();
            }
        }

        private void Othercost_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FinishedProduct_Click(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is FinisProduk)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                FinisProduk newVendor = new FinisProduk(this);
                newVendor.Show();
            }
        }

        private void TxtProductionNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtProductionNumber.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtProductionNumber.Text = "";
                    return;
                }

            }
        }

    }
}
             
    

