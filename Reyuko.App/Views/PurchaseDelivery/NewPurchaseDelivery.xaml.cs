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

namespace Reyuko.App.Views.PurchaseDelivery
{
    /// <summary>
    
    /// </summary>
    public partial class NewPurchaseDelivery : UserControl
    {
        public NewPurchaseDelivery()
        {
            InitializeComponent();
            Switcher.pageSwitchNewPurchaseDelivery = this;
            this.Init();
        }
        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        public IEnumerable<Kontak> kontaks { get; set; }
        public Kontak kontakSelected { get; set; }
        public IEnumerable<PurchaseOrder> purchaseOrders { get; set; }
        public PurchaseOrder purchaseOrderSelected { get; set; }
        private IEnumerable<DataMataUang> dataMataUangs { get; set; }
        private DataMataUang DataMataUangSelected { get; set; }
        public IEnumerable<Dokumen> dokumens { get; set; }
        public Dokumen dokumenSelected { get; set; }
        public IEnumerable<Lokasi> lokasi { get; set; }
        public Lokasi lokasiSelected { get; set; }
        public IEnumerable<DataDepartemen> dataDepartemens { get; set; }
        public IEnumerable<Purchasedelivery> purchasedeliveries { get; set; }
        public DataDepartemen Selectdepartment { get; set; }
        
        public DataDepartemen dataDepartemenSelected;
        public IEnumerable<DataProyek> dataProyeks { get; set; }
        public DataProyek Selectproyek { get; set; }
        
        public DataProyek dataProyekSelected;
        public IEnumerable<OptionAnnual> optionAnnuals { get; set; }
        public OptionAnnual optionAnnualSelected { get; set; }
        public IEnumerable<ListOrderBeli> listOrderBelis { get; set; }
        public ListOrderBeli listOrderBeliSelected;
        public Kontak petugasSelected;

        private void Init()
        {           
            this.LoadVendor();
            this.LoadCurrency();
            this.LoadNoDokumen();
            this.LoadLokasi();
            this.LoadAnnual();
            this.LoadStaff();
            this.ClearForm();
            this.LoadPO();
        }

        private void ClearForm()
        {
            dtDelivery.Text = DateTime.Now.ToShortDateString();
            dtPurchase.Text = DateTime.Now.ToShortDateString();
            dtAnnualdate.Text = DateTime.Now.ToShortDateString();
        }

        private void LoadPO()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.purchaseOrders = uow.PurchaseOrder.GetAll();
                cbPurchaseorder.ItemsSource = this.purchaseOrders;
                cbPurchaseorder.SelectedValuePath = "IdOrderPembelian";
                cbPurchaseorder.DisplayMemberPath = "NoOrderPembelian";
            }
        }
        private void PO_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.purchaseOrderSelected = null;
            if (cbPurchaseorder.SelectedItem != null)
            {
                this.purchaseOrderSelected = (PurchaseOrder)cbPurchaseorder.SelectedItem;
                this.LoadDataSku();
                txtNote.Text = this.purchaseOrderSelected.Keterangan;
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
        private void staff_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.petugasSelected = null;
            if (srstaff.SelectedItem != null)
            {
                this.petugasSelected = (Kontak)srstaff.SelectedItem;
            }
        }
        private void LoadAnnual()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.optionAnnuals = uow.OptionAnnual.GetAll();
                cbAnnual.ItemsSource = this.optionAnnuals;
                cbAnnual.SelectedValuePath = "IdOptionAnnual";
                cbAnnual.DisplayMemberPath = "Annual";
            }
        }
        private void annual_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.optionAnnualSelected = null;
            if (cbAnnual.SelectedItem != null)
            {
                this.optionAnnualSelected = (OptionAnnual)cbAnnual.SelectedItem;
            }
        }
        public void LoadDepartmen()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dataDepartemens = uow.DataDepartemen.GetAll();
                cbDepartment.ItemsSource = this.dataDepartemens;
                cbDepartment.SelectedValuePath = "Id";
                cbDepartment.DisplayMemberPath = "NamaDepartemen";
            }
        }

        public void LoadProyek()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dataProyeks = uow.DataProyek.GetAll();
                cbProyek.ItemsSource = this.dataProyeks;
                cbProyek.SelectedValuePath = "Id";
                cbProyek.DisplayMemberPath = "NamaProyek";
            }
        }

        private void department_selectionchange(object sender, SelectionChangedEventArgs e)
        {
            this.dataDepartemenSelected = null;
            if (cbDepartment.SelectedItem != null)
            {
                dataDepartemenSelected = (DataDepartemen)cbDepartment.SelectedItem;
            }
        }
        private void proyek_selectionchange(object sender, SelectionChangedEventArgs e)
        {
            this.dataProyekSelected = null;
            if (cbProyek.SelectedItem != null)
            {
                dataProyekSelected = (DataProyek)cbProyek.SelectedItem;
            }
        }
        private void LoadLokasi()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.lokasi = uow.Lokasi.GetAll();
                cbLocation.ItemsSource = this.lokasi;
                cbLocation.SelectedValuePath = "Id";
                cbLocation.DisplayMemberPath = "NamaTempatLokasi";
            }
        }
        private void lokasi_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.lokasiSelected = null;
            if (cbLocation.SelectedItem != null)
            {
                this.lokasiSelected = (Lokasi)cbLocation.SelectedItem;
            }
        }
        public void LoadNoDokumen()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dokumens = uow.Dokumen.GetAll();
                srnodokumen.ItemsSource = this.dokumens;
            }
        }
        private void dokumen_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.dokumenSelected = null;
            if (srnodokumen.SelectedItem != null)
            {
                this.dokumenSelected = (Dokumen)srnodokumen.SelectedItem;
            }
        }
        public void LoadDataSku()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.listOrderBelis = uow.ListOrderBeli.GetAll().Where(m => m.IdTransaksi == this.purchaseOrderSelected.IdTransaksi);
                DGSKUPurchaseDelivery.ItemsSource = this.listOrderBelis;
                int sum = 0;
                for (int i = 0; i < DGSKUPurchaseDelivery.Items.Count; i++)
                {
                    sum += Convert.ToInt32((DGSKUPurchaseDelivery.Items[i] as ListOrderBeli).TotalPajakProduk);
                }
                txtTotalTax.Text = sum.ToString();
                int sumar = 0;
                for (int i = 0; i < DGSKUPurchaseDelivery.Items.Count; i++)
                {
                    sumar += Convert.ToInt32((DGSKUPurchaseDelivery.Items[i] as ListOrderBeli).TotalOrderProduk);
                }
                txttotalbeforetax.Text = sumar.ToString();
                txtAfterTotalTax.Text = (float.Parse(sumar.ToString()) + float.Parse(txtTotalTax.Text)).ToString();
            }
        }

        private void btnvendor(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is Vendor.Vendorspurchasedelivery)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                Vendor.Vendorspurchasedelivery newVendor = new Vendor.Vendorspurchasedelivery(this);
                newVendor.Show();
            }
        }
        private void btndokumen(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is Document.Documentpurchasedelivery)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                Document.Documentpurchasedelivery newdokumen = new Document.Documentpurchasedelivery(this);
                newdokumen.Show();
            }
        }
        private void LoadCurrency()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dataMataUangs = uow.DataMataUang.GetAll().Where(m => m.CheckBoxAktif == true);
                cbCurrency.ItemsSource = this.dataMataUangs;
                cbCurrency.SelectedValuePath = "Id";
                cbCurrency.DisplayMemberPath = "NamaMataUang";
            }
        }
        private void currency_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.DataMataUangSelected = null;
            if (cbCurrency.SelectedItem != null)
            {
                this.DataMataUangSelected = (DataMataUang)cbCurrency.SelectedItem;
            }
        }
        public void LoadVendor()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kontaks = uow.Kontak.GetAll().Where(m => m.TypeKontak.ToLower() == "vendor");
                srvendor.ItemsSource = this.kontaks;
            }
        }
        private void vendor_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.kontakSelected = null;
            if (srvendor.SelectedItem != null)
            {
                this.kontakSelected = (Kontak)srvendor.SelectedItem;
                txtemail.Text = this.kontakSelected.EmailA;
                txthp.Text = this.kontakSelected.NoHPA;
            }

        }

        private void btnsku(object sender, RoutedEventArgs e)
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
                Sku newsku = new Sku(this);
                newsku.Show();
            }
        }

        private void Savepurchasedelivery_Click(object sender, RoutedEventArgs e)
        {
            if (dtPurchase.Text == "" || cbCurrency.Text == "" || txtPurchaseDeliveryNo.Text == "" || cbPurchaseorder.Text == "" || cbLocation.Text == "" || dtDelivery.Text == "" || txtAnnualFrequency.Text == "" || dtAnnualdate.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            PurchasedeliveryBLL purchasedeliveryBLL = new PurchasedeliveryBLL();
                        Purchasedelivery oNewData1 = new Purchasedelivery();
                        oNewData1.KodeTransaksi = "PD";
                        oNewData1.IdKodeTransaksi = 26;
                        if (this.kontakSelected != null)
                        {
                            oNewData1.IdVendor = this.kontakSelected.Id;
                            oNewData1.NamaVendor = this.kontakSelected.NamaA;
                        }
                        oNewData1.Email = txtemail.Text;
                        oNewData1.NoHp = txthp.Text;
                        oNewData1.TanggalPengirimanBarangPembelian = DateTime.Parse(dtPurchase.Text);
                        if (this.DataMataUangSelected != null)
                        {
                            oNewData1.IdMataUang = this.DataMataUangSelected.Id;
                            oNewData1.MataUang = this.DataMataUangSelected.NamaMataUang;
                            oNewData1.KursTukar = this.DataMataUangSelected.KursTukar;
                        }
                        if (this.dokumenSelected != null)
                        {
                            oNewData1.IdNoReferensiDokumen = this.dokumenSelected.Id;
                            oNewData1.NoReferensiDokumen = this.dokumenSelected.NoReferensiDokumen;
                        }
                        oNewData1.NoPengirimanBarangPembelian = double.Parse(txtPurchaseDeliveryNo.Text);
                        if (this.purchaseOrderSelected != null)
                        {
                            oNewData1.IdOrderPembelian = this.purchaseOrderSelected.IdOrderPembelian;
                            oNewData1.NoOrderPembelian = this.purchaseOrderSelected.NoOrderPembelian;
                        }
                        oNewData1.Keterangan = txtNote.Text;
                        if (this.lokasiSelected != null)
                        {
                            oNewData1.IdLokasi = this.lokasiSelected.Id;
                            oNewData1.NamaLokasi = this.lokasiSelected.NamaTempatLokasi;
                        }
                        if (this.dataDepartemenSelected != null)
                        {
                            oNewData1.IdDepartemen = this.dataDepartemenSelected.Id;
                        }
                        if (this.dataProyekSelected != null)
                        {
                            oNewData1.IdProyek = this.dataProyekSelected.Id;
                        }
                        oNewData1.CheckboxInclusiveTax = chkinclusive.IsChecked;
                        oNewData1.CheckboxBerulang = chkannual.IsChecked;
                        oNewData1.TanggalPengantaran = DateTime.Parse(dtDelivery.Text);
                        oNewData1.DurationBerulang = double.Parse(txtAnnualFrequency.Text);
                        oNewData1.TanggalBerulang = DateTime.Parse(dtAnnualdate.Text);
                        if (this.optionAnnualSelected != null)
                        {
                            oNewData1.IdOpsiAnnual = this.optionAnnualSelected.IdOptionAnnual;
                            oNewData1.Annual = this.optionAnnualSelected.Annual;
                        }
                        if (this.petugasSelected != null)
                        {
                            oNewData1.IdPetugas = this.petugasSelected.Id;
                            oNewData1.NamaPetugas = this.petugasSelected.NamaA;
                        }
                        if (this.purchaseOrderSelected != null)
                        {
                            oNewData1.IdTransaksi = this.purchaseOrderSelected.IdTransaksi;
                        }
                         oNewData1.TotalDebitAkunStokProduk = double.Parse(txttotalbeforetax.Text);
                        oNewData1.TotalKreditAkunPengirimanBeliProduk = double.Parse(txttotalbeforetax.Text);
                        oNewData1.TotalSebelumPajak = double.Parse(txttotalbeforetax.Text);
                        oNewData1.TotalPajak = double.Parse(txtTotalTax.Text);
                        oNewData1.TotalSetelahPajak = double.Parse(txtAfterTotalTax.Text);
                        oNewData1.RealRecordingTime = DateTime.Now;
                        if (purchasedeliveryBLL.AddPurchasedelivery(oNewData1) > 0)
                        {
                            //  this.ClearForm();
                            MessageBox.Show("Purchased Delivery successfully added !");
                        }
                        else
                        {
                            MessageBox.Show("Purchased Delivery failed to add !");
                        }
            PurchaseDelivery v = new PurchaseDelivery();
                Switcher.SwitchNewPurchaseDelivery(v);
            
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
            PurchaseDelivery v = new PurchaseDelivery();
            Switcher.SwitchNewPurchaseDelivery(v);
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
        private void duplicate_Click(object sender, RoutedEventArgs e)
        {

        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Product_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Service_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Rbdepartmen_Checked(object sender, RoutedEventArgs e)
        {
            this.rbdepartmen.IsChecked = true;
            {
                cbDepartment.Visibility = Visibility.Visible;
                cbProyek.Visibility = Visibility.Hidden;
                cbProyek.SelectedIndex = -1;
                this.LoadDepartmen();
            }
        }

        private void Rbproyek_Checked(object sender, RoutedEventArgs e)
        {
            this.rbproyek.IsChecked = true;
            {
                cbProyek.Visibility = Visibility.Visible;
                cbDepartment.Visibility = Visibility.Hidden;
                cbDepartment.SelectedIndex = -1;
                this.LoadProyek();
            }
        }

        private void TxtPurchaseDeliveryNo_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtPurchaseDeliveryNo.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtPurchaseDeliveryNo.Text = "";
                    return;
                }

            }
        }

        private void TxtAnnualFrequency_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtAnnualFrequency.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtAnnualFrequency.Text = "";
                    return;
                }

            }
        }
    }
}
             
    

