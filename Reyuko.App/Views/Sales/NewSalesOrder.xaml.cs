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

namespace Reyuko.App.Views.Sales
{
    /// <summary>
    
    /// </summary>
    public partial class NewSalesOrder : UserControl
    {
        public NewSalesOrder()
        {
            InitializeComponent();
            Switcher.pageSwitcherSalesorder = this;
            this.Init();
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
        public IEnumerable<Kontak> kontaks { get; set; }
        public Kontak kontakSelected { get; set; }
        private IEnumerable<DataMataUang> dataMataUangs { get; set; }
        private DataMataUang DataMataUangSelected { get; set; }
        public IEnumerable<Dokumen> dokumens { get; set; }
        public Dokumen dokumenSelected { get; set; }
        public IEnumerable<Lokasi> lokasi { get; set; }
        public Lokasi lokasiSelected { get; set; }
        public IEnumerable<OptionAnnual> optionAnnuals { get; set; }
        public OptionAnnual optionAnnualSelected { get; set; }
        public IEnumerable<DataDepartemen> dataDepartemens { get; set; }
        public DataDepartemen Selectdepartment { get; set; }
        public IEnumerable<DataProyek> dataProyeks { get; set; }
        public IEnumerable<Termspembayaran> termspembayarans { get; set; }
        public Termspembayaran termspembayaranSelected;
        public DataProyek Selectproyek { get; set; }
        public DataDepartemen dataDepartemenSelected;
        public DataProyek dataProyekSelected;

        private void Init()
        {
            this.ClearForm();
            this.LoadCustomer();
            this.LoadStaff();
            this.LoadNoDokumen();
            this.LoadCurrency();
            this.LoadLokasi();
            this.LoadAnnual();
        }
        private void ClearForm()
        {
            srcustomer.Text = "";
            txtemail.Text = "";
            txthp.Text = "";
            dtSales.Text = DateTime.Now.ToShortDateString();
            this.DataMataUangSelected = null;
            cbCurrency.SelectedIndex = -1;
            srnodokumen.Text = "";
            txtSalesQuotationNo.Text = "";
            txtNote.Text = "";
            this.lokasiSelected = null;
            cbLocation.SelectedIndex = -1;
            cbDepartment.SelectedIndex = -1;
            cbProyek.SelectedIndex = -1;
            chkcomplete.IsChecked = false;
            chkinclusive.IsChecked = false;
            dtValidaty.Text = DateTime.Now.ToShortDateString();
            chkannual.IsChecked = false;
            this.optionAnnualSelected = null;
            cbAnnual.SelectedIndex = -1;
            txtAnnualFrequency.Text = "";
            dtAnnual.Text = DateTime.Now.ToShortDateString();
            txtTotalTax.Text = "";
            txtAfterTotalTax.Text = "";
            txtPaid.Text = "";
            txtInstallmentannual.Text = "";
            txtInstallments.Text = "";
            txtDuedate.Text = "";
        }
        public void LoadCustomer()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kontaks = uow.Kontak.GetAll().Where(m => m.TypeKontak.ToLower() == "pelanggan");
                srcustomer.ItemsSource = this.kontaks;
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
        public void LoadStaff()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kontaks = uow.Kontak.GetAll().Where(m => m.TypeKontak.ToLower() == "employee");
                srstaff.ItemsSource = this.kontaks;
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
        public void LoadNoDokumen()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dokumens = uow.Dokumen.GetAll();
                srnodokumen.ItemsSource = this.dokumens;
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
        private void staff_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.kontakSelected = null;
            if (srstaff.SelectedItem != null)
            {
                this.kontakSelected = (Kontak)srstaff.SelectedItem;
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

        private void dokumen_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.dokumenSelected = null;
            if (srnodokumen.SelectedItem != null)
            {
                this.dokumenSelected = (Dokumen)srnodokumen.SelectedItem;
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
        private void annual_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.optionAnnualSelected = null;
            if (cbAnnual.SelectedItem != null)
            {
                this.optionAnnualSelected = (OptionAnnual)cbAnnual.SelectedItem;
            }
        }

        public SalesOrder GetData()
        {
             SalesOrder oData = new SalesOrder();
             oData.Email = txtemail.Text;
             oData.NoHp = int.Parse(txthp.Text);
             oData.TanggalOrderPenjualan = DateTime.Parse(dtSales.Text);
             oData.NoPenawaran = double.Parse (txtSalesQuotationNo.Text);
             oData.Keterangan = txtNote.Text;
             oData.TanggalPengantaran = DateTime.Parse(dtValidaty.Text);
             oData.DurasiBerulang = double.Parse (txtAnnualFrequency.Text);
             oData.TanggalBerulang = DateTime.Parse(dtAnnual.Text);
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

             oData.CheckboxSelesai = chkcomplete.IsChecked;
             oData.CheckboxInclusiveTax = chkinclusive.IsChecked;
             oData.CheckboxBerulang = chkannual.IsChecked;

            return oData;
        }

        private void Savesales_Click(object sender, RoutedEventArgs e)
        {
            if (srcustomer.Name == "" || txtemail.Name == "" || txthp.Name == "" || dtSales.Text == "" || cbCurrency.Text == "" || srnodokumen.Name == "" || txtSalesQuotationNo.Text == "" || cbLocation.Text == "" || dtValidaty.Text == "" || cbAnnual.Text == "" || srstaff.Name == "" || txtAnnualFrequency.Text == "" || dtAnnual.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            SalesOrderBLL salesOrderBLL = new SalesOrderBLL();
            if (salesOrderBLL.AddSalesOrder(this.GetData()) > 0)
            {
                
                MessageBox.Show("Sales Order successfully added !");
              
            }
            else
            {
                MessageBox.Show("Sales Order failed to be added !");
            }
            Sales v = new Sales();
            Switcher.Switchorder(v);
        }
    

        private void StockList_Click(object sender, RoutedEventArgs e)
        {
            StockList v = new StockList();
            v.Show();
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
            Sales v = new Sales();
            Switcher.Switchorder(v);
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

        private void Customer_Click(object sender, RoutedEventArgs e)
        {
            {
                bool isWindowOpen = false;

                foreach (Window w in Application.Current.Windows)
                {
                    if (w is Customer)
                    {
                        isWindowOpen = true;
                        w.Activate();
                    }
                }

                if (!isWindowOpen)
                {
                    Customer customer = new Customer();
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
                    if (w is Document.Documentsalesorder)
                    {
                        isWindowOpen = true;
                        w.Activate();
                    }
                }

                if (!isWindowOpen)
                {
                    Document.Documentsalesorder document = new Document.Documentsalesorder(this);
                    document.Show();
                }


            }
        }

        private void PaymentTerm_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Service_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TxtAnnualFrequency_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtAnnualFrequency.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtAnnualFrequency.Text = "";
                    return;
                }

            }
        }

        private void TxtSalesQuotationNo_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtSalesQuotationNo.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtSalesQuotationNo.Text = "";
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
                cbCash.Visibility = Visibility.Hidden;
                cbCash.SelectedIndex = -1;
                this.LoadPaymentTerms();
            }
        }

        private void rbCash_Checked(object sender, RoutedEventArgs e)
        {
            this.rbCash.IsChecked = true;
            {
                cbCash.Visibility = Visibility.Visible;
                cbPayment.Visibility = Visibility.Hidden;
                cbPayment.SelectedIndex = -1;
                //    this.lo();
            }
        }
    }
}
             
    

