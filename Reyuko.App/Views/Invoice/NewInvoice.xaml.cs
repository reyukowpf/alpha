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

namespace Reyuko.App.Views.Invoice
{
    /// <summary>

    /// </summary>
    public partial class NewInvoice : UserControl
    {
        public NewInvoice()
        {
            InitializeComponent();
            Switcher.pageSwitchNewInvoice = this;
            this.Init();
        }
        private IEnumerable<Invoice> invoices { get; set; }
        public IEnumerable<Kontak> kontaks { get; set; }
        public Kontak kontakSelected { get; set; }
        private IEnumerable<DataMataUang> dataMataUangs { get; set; }
        private DataMataUang DataMataUangSelected { get; set; }
        public IEnumerable<Dokumen> dokumens { get; set; }
        public Dokumen dokumenSelected { get; set; }
        public IEnumerable<SalesOrder> SalesOrders { get; set; }
        public SalesOrder SalesOrderSelected { get; set; }
        public IEnumerable<Deliveryorders> DeliveryOrders { get; set; }
        public Deliveryorders DeliveryOrderSelected { get; set; }
        public IEnumerable<Lokasi> lokasi { get; set; }
        public Lokasi lokasiSelected { get; set; }
        public IEnumerable<DataDepartemen> dataDepartemens { get; set; }
        public DataDepartemen Selectdepartment { get; set; }
        public DataDepartemen dataDepartemenSelected;
        public IEnumerable<DataProyek> dataProyeks { get; set; }
        public DataProyek Selectproyek { get; set; }
        public DataProyek dataProyekSelected;
        public IEnumerable<OptionAnnual> optionAnnuals { get; set; }
        public OptionAnnual optionAnnualSelected { get; set; }
        public IEnumerable<Termspembayaran> termspembayarans { get; set; }
        public Termspembayaran termspembayaranSelected;
        public IEnumerable<DropdownBankKas> dropdownBankkas { get; set; }
        public DropdownBankKas dropdownBankkasSelected;


        private void Init()
        {
            this.Clearform();
            this.LoadCustomer();
            this.LoadCurrency();
            this.LoadNoDokumen();
            this.LoadSalesorder();
            this.LoadDeliveryorder();
            this.LoadLokasi();
            this.LoadAnnual();
            this.LoadStaff();
            this.LoadCash();
        }
        public void LoadCash()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dropdownBankkas = uow.DropdownBankKas.GetAll();
                cbCash.ItemsSource = this.dropdownBankkas;
                cbCash.SelectedValuePath = "Id";
                cbCash.DisplayMemberPath = "DropdownBankkas";
            }
        }
        private void cash_selectionchange(object sender, SelectionChangedEventArgs e)
        {
            this.dropdownBankkasSelected = null;
            if (cbCash.SelectedItem != null)
            {
                dropdownBankkasSelected = (DropdownBankKas)cbCash.SelectedItem;
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
        private void proyek_selectionchange(object sender, SelectionChangedEventArgs e)
        {
            this.dataProyekSelected = null;
            if (cbProyek.SelectedItem != null)
            {
                dataProyekSelected = (DataProyek)cbProyek.SelectedItem;
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
        private void department_selectionchange(object sender, SelectionChangedEventArgs e)
        {
            this.dataDepartemenSelected = null;
            if (cbDepartment.SelectedItem != null)
            {
                dataDepartemenSelected = (DataDepartemen)cbDepartment.SelectedItem;
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
        public void LoadDeliveryorder()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.DeliveryOrders = uow.DeliveryOrder.GetAll();
                cbDONumber.ItemsSource = this.DeliveryOrders;
                cbDONumber.SelectedValuePath = "Id";
                cbDONumber.DisplayMemberPath = "NomorOrderPenjualan";
            }
        }
        private void Deliveryorder_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.DeliveryOrderSelected = null;
            if (cbDONumber.SelectedItem != null)
            {
                this.DeliveryOrderSelected = (Deliveryorders)cbDONumber.SelectedItem;
            }
        }
        public void LoadSalesorder()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.SalesOrders = uow.SalesOrder.GetAll();
                cbSONumber.ItemsSource = this.SalesOrders;
                cbSONumber.SelectedValuePath = "IdOrderPenjualan";
                cbSONumber.DisplayMemberPath = "NoOrderPenjualan";
            }
        }
        private void Salesorder_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.SalesOrderSelected = null;
            if (cbSONumber.SelectedItem != null)
            {
                this.SalesOrderSelected = (SalesOrder)cbSONumber.SelectedItem;
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
        public void LoadCustomer()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kontaks = uow.Kontak.GetAll().Where(m => m.TypeKontak.ToLower() == "pelanggan");
                srcustomer.ItemsSource = this.kontaks;
            }
        }

        private void customer_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.kontakSelected = null;
            if (srcustomer.SelectedItem != null)
            {
                this.kontakSelected = (Kontak)srcustomer.SelectedItem;
                txtemail.Text = this.kontakSelected.EmailA;
                txthp.Text = this.kontakSelected.NoHPA;
            }

        }

        private void Clearform()
        {
            //  this.invoices = new List<Invoice>();
            //  DGSKUInvoice.ItemsSource = this.invoices;
            Custome.IsChecked = false;
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
        public invoice GetData()
        {
            invoice oData = new invoice();
            oData.Email = txtemail.Text;
            oData.NoHp = txthp.Text;
            oData.TanggalInvoice = DateTime.Parse(dtInvoicedate.Text);
            oData.NoInvoice = txtInvoiceNumber.Text;
            oData.Keterangan = txtNote.Text;
            oData.TanggalPengiriman = DateTime.Parse(dtDeliverydate.Text);
            oData.DurasiBerulang = double.Parse(txtAnnualFrequency.Text);
            oData.TanggalBerulang = DateTime.Parse(dtAnnualdate.Text);
            if (this.kontakSelected != null)
            {
                oData.IdPelanggan = this.kontakSelected.Id;
                oData.NamaPelanggan = this.kontakSelected.NamaA;
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
            if (this.DeliveryOrderSelected != null)
            {
                oData.IdDo = this.DeliveryOrderSelected.Id;
                oData.NoDo = this.DeliveryOrderSelected.NoDo;
            }
            if (this.SalesOrderSelected != null)
            {
                oData.IdOrderPenjualan = this.SalesOrderSelected.IdOrderPenjualan;
                oData.NoOrderPenjualan = this.SalesOrderSelected.NoOrderPenjualan;
            }
            if (this.dropdownBankkasSelected != null)
            {
                oData.IdBankCash = this.dropdownBankkasSelected.Id;
                oData.BankCash = this.dropdownBankkasSelected.DropdownBankkas;
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
            if (this.optionAnnualSelected != null)
            {
                oData.IdOpsiAnnual = this.optionAnnualSelected.IdOptionAnnual;
                oData.Annual = this.optionAnnualSelected.Annual;
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

            oData.CheckboxManual = chkmanual.IsChecked;
            oData.CheckboxInclusiveTax = chkinclusive.IsChecked;
            oData.CheckboxBerulang = chkannual.IsChecked;

            return oData;
        }

        private void Saveinvoice_Click(object sender, RoutedEventArgs e)
        {
            if (dtInvoicedate.Text == "" || cbCurrency.Text == "" || txtInvoiceNumber.Text == "" || cbDONumber.Text == "" || cbSONumber.Text == "" || cbCash.Text == "" || cbLocation.Text == ""
                 || dtDeliverydate.Text == "" || cbAnnual.Text == "" || txtAnnualFrequency.Text == "" || dtAnnualdate.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            InvoicesBLL invoicesBLL = new InvoicesBLL();
            if (invoicesBLL.AddInvoices(this.GetData()) > 0)
            {

                MessageBox.Show("Invoice successfully added !");
                //      this.measurementUnitForm.LoadSatuanDasar();
            }
            else
            {
                MessageBox.Show("Invoice failed to be added !");
            }
            Invoice v = new Invoice();
            Switcher.SwitchNewInvoice(v);
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

        private void Customer_Click(object sender, RoutedEventArgs e)
        {
            {
                bool isWindowOpen = false;

                foreach (Window w in Application.Current.Windows)
                {
                    if (w is Sales.Customer)
                    {
                        isWindowOpen = true;
                        w.Activate();
                    }
                }

                if (!isWindowOpen)
                {
                    Sales.Customer customer = new Sales.Customer();
                    customer.Show();
                }


            }
        }

        private void Dokumen_Click(object sender, RoutedEventArgs e)
        {
            {
                bool isWindowOpen = false;

                foreach (Window w in Application.Current.Windows)
                {
                    if (w is Document.Documentinvoice)
                    {
                        isWindowOpen = true;
                        w.Activate();
                    }
                }

                if (!isWindowOpen)
                {
                    Document.Documentinvoice document = new Document.Documentinvoice(this);
                    document.Show();
                }


            }
        }

        private void PaymentTerm_Click(object sender, RoutedEventArgs e)
        {
            {
                bool isWindowOpen = false;

                foreach (Window w in Application.Current.Windows)
                {
                    if (w is Sales.PaymentTerm)
                    {
                        isWindowOpen = true;
                        w.Activate();
                    }
                }

                if (!isWindowOpen)
                {
                    Sales.PaymentTerm payment = new Sales.PaymentTerm(this);
                    payment.Show();
                }


            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Invoice v = new Invoice();
            Switcher.SwitchNewInvoice(v);
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

        private void Custom_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
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
        private void rbpayment_Checked(object sender, RoutedEventArgs e)
        {
            this.rbpayment.IsChecked = true;
            {
                cbPayment.Visibility = Visibility.Visible;
                cbCash1.Visibility = Visibility.Hidden;
                cbCash1.SelectedIndex = -1;
                this.LoadPaymentTerms();
            }
        }

        private void rbcash_Checked(object sender, RoutedEventArgs e)
        {
            this.rbcash.IsChecked = true;
            {
                cbCash1.Visibility = Visibility.Visible;
                cbPayment.Visibility = Visibility.Hidden;
                cbPayment.SelectedIndex = -1;
                //    this.lo();
            }
        }
        private void TxtInvoiceNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtInvoiceNumber.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtInvoiceNumber.Text = "";
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



