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

namespace Reyuko.App.Views.PurchaseReturn
{
    /// <summary>
    
    /// </summary>
    public partial class NewPurchaseReturn : UserControl
    {
        public NewPurchaseReturn()
        {
            InitializeComponent();
            Switcher.pageSwitchNewPurchaseReturn = this;
            this.Init();
        }
        private IEnumerable<PurchaseReturn> purchaseReturns { get; set; }
        
        private IEnumerable<Kontak> kontaks { get; set; }
        public Kontak kontakSelected { get; set; }
        private IEnumerable<DataMataUang> dataMataUangs { get; set; }
        private DataMataUang DataMataUangSelected { get; set; }
        public IEnumerable<Dokumen> dokumens { get; set; }
        public Dokumen dokumenSelected { get; set; }
        public IEnumerable<DropdownBankKas> dropdownBankKas { get; set; }
        public DropdownBankKas dropdownBankKasSelected;
        public IEnumerable<Lokasi> lokasis { get; set; }
        public Lokasi lokasiSelected;
        public IEnumerable<DataDepartemen> dataDepartemens { get; set; }
        public DataDepartemen dataDepartemenSelected;
        public IEnumerable<DataProyek> dataProyeks { get; set; }
        public DataProyek dataProyekSelected;
        public IEnumerable<Termspembayaran> termspembayarans { get; set; }
        public Termspembayaran termspembayaranSelected;
        public IEnumerable<Purchasereturn>purchasereturns  { get; set; }
        public Purchasereturn purchasereturnSelected;
        public IEnumerable<Receivedgood> receivedgoods { get; set; }
        public Receivedgood receivedgoodSelected;
        public IEnumerable<ListOrderBeli> listOrderBelis { get; set; }
        private void Init()
        {
            this.Clearform();
            this.LoadVendor();
            this.LoadCurrency();
            this.LoadNoDokumen();
            this.LoadCash();
            this.LoadLokasi();
            this.LoadStaff();
            this.LoadReceived();
        }

        public void LoadReceived()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.receivedgoods = uow.Receivedgood.GetAll();
                cbReceiveNumber.ItemsSource = this.receivedgoods;
                cbReceiveNumber.SelectedValuePath = "IdOrder";
                cbReceiveNumber.DisplayMemberPath = "NoOrder";
            }
        }
        private void received_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.receivedgoodSelected = null;
            if (cbReceiveNumber.SelectedItem != null)
            {
                receivedgoodSelected = (Receivedgood)cbReceiveNumber.SelectedItem;
                this.LoadDataSku();
                this.LoadDatapo();
            }
        }
        public void LoadDatapo()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.purchasereturns = uow.PurchaseReturn.GetAll().Where(m => m.IdTransaksi == this.receivedgoodSelected.IdTransaksi);
                DGpurchasereturn.ItemsSource = this.purchasereturns;
            }
        }
        public void LoadDataSku()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.listOrderBelis = uow.ListOrderBeli.GetAll().Where(m => m.IdTransaksi == this.receivedgoodSelected.IdTransaksi);
                DGSKUpurchasereturn.ItemsSource = this.listOrderBelis;
                int sum = 0;
                for (int i = 0; i < DGSKUpurchasereturn.Items.Count; i++)
                {
                    sum += Convert.ToInt32((DGSKUpurchasereturn.Items[i] as ListOrderBeli).TotalPajakProduk);
                }
                txtTotalprodukTax.Text = sum.ToString();
                int sum1 = 0;
                for (int i = 0; i < DGSKUpurchasereturn.Items.Count; i++)
                {
                    sum1 += Convert.ToInt32((DGSKUpurchasereturn.Items[i] as ListOrderBeli).TotalPajakJasa);
                }
                txtTotaljasaTax.Text = sum1.ToString();
                int sum2 = 0;
                for (int i = 0; i < DGSKUpurchasereturn.Items.Count; i++)
                {
                    sum2 += Convert.ToInt32((DGSKUpurchasereturn.Items[i] as ListOrderBeli).TotalPajak);
                }
                txtTotalTax.Text = sum2.ToString();
                int sumar = 0;
                for (int i = 0; i < DGSKUpurchasereturn.Items.Count; i++)
                {
                    sumar += Convert.ToInt32((DGSKUpurchasereturn.Items[i] as ListOrderBeli).TotalOrderProduk);
                }
                txttotalprodukbeforetax.Text = sumar.ToString();
                int sumar1 = 0;
                for (int i = 0; i < DGSKUpurchasereturn.Items.Count; i++)
                {
                    sumar1 += Convert.ToInt32((DGSKUpurchasereturn.Items[i] as ListOrderBeli).TotalOrderJasa);
                }
                txttotaljasabeforetax.Text = sumar1.ToString();
                int sumar2 = 0;
                for (int i = 0; i < DGSKUpurchasereturn.Items.Count; i++)
                {
                    sumar2 += Convert.ToInt32((DGSKUpurchasereturn.Items[i] as ListOrderBeli).TotalOrder);
                }
                txttotalbeforetax.Text = sumar2.ToString();
                txtAfterTotalTax.Text = (float.Parse(sumar2.ToString()) + float.Parse(txtTotalTax.Text)).ToString();
            }
        }
        public void LoadPaymentTerms()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.termspembayarans = uow.Termspembayaran.GetAll();
                cbPayment.ItemsSource = this.termspembayarans;
                cbPayment.SelectedValuePath = "Id";
                cbPayment.DisplayMemberPath = "NamaSkema";
            }
        }
        private void payment_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.termspembayaranSelected = null;
            if (cbPayment.SelectedItem != null)
            {
                termspembayaranSelected = (Termspembayaran)cbPayment.SelectedItem;
                txtuangmuka.Text = this.termspembayaranSelected.UangMuka.ToString();
                txtPaid.Text = (float.Parse(txtuangmuka.Text) * float.Parse(txtAfterTotalTax.Text)).ToString();
                txtInstallments.Text = this.termspembayaranSelected.TermPembayaran.ToString();
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
            this.kontakSelected = null;
            if (srstaff.SelectedItem != null)
            {
                this.kontakSelected = (Kontak)srstaff.SelectedItem;
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
                this.lokasis = uow.Lokasi.GetAll();
                cbLocation.ItemsSource = this.lokasis;
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
        private void LoadCash()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dropdownBankKas = uow.DropdownBankKas.GetAll();
                cbCash.ItemsSource = this.dropdownBankKas;
                cbCash.SelectedValuePath = "Id";
                cbCash.DisplayMemberPath = "DropdownBankkas";
            }
        }
        private void cash_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.dropdownBankKasSelected = null;
            if (cbCash.SelectedItem != null)
            {
                this.dropdownBankKasSelected = (DropdownBankKas)cbCash.SelectedItem;
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

        private void btnvendor(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is Vendor.Vendorspurchase)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                Vendor.Vendorspurchase newVendor = new Vendor.Vendorspurchase(this);
                newVendor.Show();
            }
        }
        private void btndokumen(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is Document.Documentpurchase)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                Document.Documentpurchase newdokumen = new Document.Documentpurchase(this);
                newdokumen.Show();
            }
        }
        private void Clearform()
        {
        }
        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

 

        private void savepurchasereturn_Click(object sender, RoutedEventArgs e)
        {
            if (dtReceived.Text == "" || cbCurrency.Text == "" || txtPurchaseReturnNumber.Text == "" || cbReceiveNumber.Text == "" || cbCash.Text == "" || txtNote.Text == "" || cbLocation.Text == "" || dtDelivery.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            PurchasereturnBLL returBLL = new PurchasereturnBLL();
            if (DGpurchasereturn.Items.Count > 0)
            {
                foreach (var item in DGpurchasereturn.Items)
                {
                    if (item is Purchasereturn)
                    {
                        Purchasereturn oData = (Purchasereturn)item;
                        oData.Email = txtemail.Text;
                        oData.IdKodeTransaksi = 21;
                        oData.KodeTransaksi = "PR";
                        oData.NoHp = txthp.Text;
                        oData.TanggalReturPembelian = DateTime.Parse(dtReceived.Text);
                        oData.NoReturPembelian = double.Parse(txtPurchaseReturnNumber.Text);
                        oData.Keterangan = txtNote.Text;
                        oData.TanggalPengantaran = DateTime.Parse(dtDelivery.Text);

                        if (this.kontakSelected != null)
                        {
                            oData.IdVendor = this.kontakSelected.Id;
                            oData.NamaVendor = this.kontakSelected.NamaA;
                        }
                        if (this.DataMataUangSelected != null)
                        {
                            oData.IdMataUang = this.DataMataUangSelected.Id;
                            oData.MataUang = this.DataMataUangSelected.NamaMataUang;
                            oData.KursTukar = this.DataMataUangSelected.KursTukar;
                        }
                        if (this.dokumenSelected != null)
                        {
                            oData.IdNoReferensiDokumen = this.dokumenSelected.Id;
                            oData.NoReferensiDokumen = this.dokumenSelected.NoReferensiDokumen;
                        }
                        if (this.purchasereturnSelected != null)
                        {
                            oData.IdReturPembelian = this.purchasereturnSelected.IdReturPembelian;
                            oData.NoReferensiTransaksi = this.purchasereturnSelected.NoReferensiTransaksi;
                        }
                        if (this.dropdownBankKasSelected != null)
                        {
                            oData.IdMataUang = this.dropdownBankKasSelected.Id;
                            oData.MataUang = this.dropdownBankKasSelected.DropdownBankkas;
                        }
                        if (this.lokasiSelected != null)
                        {
                            oData.IdLokasi = this.lokasiSelected.Id;
                            oData.NamaLokasi = this.lokasiSelected.NamaTempatLokasi;
                        }
                        if (this.dataDepartemenSelected != null)
                        {
                            oData.IdDepartemen = this.dataDepartemenSelected.Id;

                        }
                        if (this.dataProyekSelected != null)
                        {
                            oData.IdProyek = this.dataProyekSelected.Id;

                        }
                        if (this.kontakSelected != null)
                        {
                            oData.IdPetugas = this.kontakSelected.Id;
                            oData.NamaPetugas = this.kontakSelected.NamaA;
                        }
                        if (this.termspembayaranSelected != null)
                        {
                            oData.IdTermPembayaran = this.termspembayaranSelected.IdTermPembayaran;
                            oData.TermPembayaran = this.termspembayaranSelected.NamaSkema;
                        }

                        oData.CheckboxInclusiveTax = chkinclusive.IsChecked;
                        oData.CheckboxManual = chkmanual.IsChecked;
                        if (returBLL.EditPurchasereturn(oData) == true)
                        {
                            //  this.ClearForm();
                            MessageBox.Show("Purchased Return successfully added !");
                        }
                        else
                        {
                            MessageBox.Show("Purchased Return failed to add !");
                        }
                    }
                }
            }
            PurchaseReturn v = new PurchaseReturn();
            Switcher.SwitchNewPurchaseReturn(v);
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
            PurchaseReturn v = new PurchaseReturn();
            Switcher.SwitchNewPurchaseReturn(v);
        }

        private void Product_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Service_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Custom_Click(object sender, RoutedEventArgs e)
        {

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

        private void TxtPurchaseReturnNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtPurchaseReturnNumber.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtPurchaseReturnNumber.Text = "";
                    return;
                }

            }
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

        private void rbPayment_Checked(object sender, RoutedEventArgs e)
        {
            this.rbPayment.IsChecked = true;
            {
                cbPayment.Visibility = Visibility.Visible;
                cbCash1.Visibility = Visibility.Hidden;
                cbCash1.SelectedIndex = -1;
                this.LoadPaymentTerms();
            }
        }

        private void rbCash_Checked(object sender, RoutedEventArgs e)
        {
            this.rbCash.IsChecked = true;
            {
                cbCash1.Visibility = Visibility.Visible;
                cbPayment.Visibility = Visibility.Hidden;
                cbPayment.SelectedIndex = -1;
                //    this.lo();
            }
        }
    }
}
             
    

