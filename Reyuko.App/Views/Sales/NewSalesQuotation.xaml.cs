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
    public partial class NewSalesQuotation : UserControl
    {
        public NewSalesQuotation()
        {
            InitializeComponent();
            Switcher.pageSwitcherSalesquotation = this;
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
        public IEnumerable<OrderProdukJual> orderProdukJuals { get; set; }
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
        public IEnumerable<Salesquotation> salesquotations { get; set; }

        private void Init()
        {
            this.ClearForm();
            this.LoadCustomer();
            this.LoadNoDokumen();
            this.LoadCurrency();
            this.LoadLokasi();
            this.LoadAnnual();
            this.LoadStaff();
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
        public void LoadStaff()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kontaks = uow.Kontak.GetAll().Where(m => m.TypeKontak.ToLower() == "employee");
                srstaff.ItemsSource = this.kontaks;
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
        public void LoadDataSku()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.orderProdukJuals = uow.OrderProdukJual.GetAll().Where(m => m.Checkbokaktif == true);
                DGSKU.ItemsSource = this.orderProdukJuals;
                int sum = 0;
                for (int i = 0; i < DGSKU.Items.Count; i++)
                {
                    sum += Convert.ToInt32((DGSKU.Items[i] as OrderProdukJual).TotalPajak);
                }
                txtTotalTax.Text = sum.ToString();
                int sumar = 0;
                for (int i = 0; i < DGSKU.Items.Count; i++)
                {
                    sumar += Convert.ToInt32((DGSKU.Items[i] as OrderProdukJual).TotalOrderProduk);
                }
                txtTotalbeforeTax.Text = sumar.ToString();
                int suma = 0;
                for (int i = 0; i < DGSKU.Items.Count; i++)
                {
                    suma += Convert.ToInt32((DGSKU.Items[i] as OrderProdukJual).TotalOrderProduk);
                }
                txtAfterTotalTax.Text = (float.Parse(suma.ToString()) + float.Parse(txtTotalTax.Text)).ToString();
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
        
        private void staff_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.kontakSelected = null;
            if (srstaff.SelectedItem != null)
            {
                this.kontakSelected = (Kontak)srstaff.SelectedItem;
            }
        }

        private void Savesales_Click(object sender, RoutedEventArgs e)
        {
            if (srcustomer.Name == "" || txtemail.Name == "" || txthp.Name == "" || dtSales.Text == "" || cbCurrency.Text == "" || srnodokumen.Name == "" || txtSalesQuotationNo.Text == "" || cbLocation.Text == "" || dtValidaty.Text == "" || cbAnnual.Text == "" || srstaff.Name == "" || txtAnnualFrequency.Text == "" || dtAnnual.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            SalesquotationBLL quotaBLL = new SalesquotationBLL();
            SalesquotationBLL QuotaBLL = new SalesquotationBLL();
            Salesquotation salesquotation = new Salesquotation();
            if (this.kontakSelected != null)
            {
                salesquotation.IdKontak = this.kontakSelected.Id;
                salesquotation.NamaPelanggan = this.kontakSelected.NamaA;
            }
            salesquotation.Email = txtemail.Text;
            salesquotation.NoHp = txthp.Text;
            salesquotation.TanggalPenawaranHarga = DateTime.Parse(dtSales.Text);
            if (this.DataMataUangSelected != null)
            {
                salesquotation.IdMataUang = this.DataMataUangSelected.Id;
                salesquotation.MataUang = this.DataMataUangSelected.NamaMataUang;
                salesquotation.KursTukar = this.DataMataUangSelected.KursTukar;
            }
            if (this.dokumenSelected != null)
            {
                salesquotation.IdNoReferensiDokumen = this.dokumenSelected.Id;
                salesquotation.NoReferensiDokumen = this.dokumenSelected.NoReferensiDokumen;
            }
            salesquotation.NoPenawaranHarga = txtSalesQuotationNo.Text;
            salesquotation.Keterangan = txtNote.Text;
            if (this.lokasiSelected != null)
            {
                salesquotation.IdLokasi = this.lokasiSelected.Id;
                salesquotation.NamaLokasi = this.lokasiSelected.NamaTempatLokasi;
            }
            if (this.dataDepartemenSelected != null)
            {
                salesquotation.IdDepartemen = this.dataDepartemenSelected.Id;
            }
            if (this.dataProyekSelected != null)
            {
                salesquotation.IdProyek = this.dataProyekSelected.Id;
            }
            salesquotation.CheckboxInclusiveTax = chkinclusive.IsChecked;
            salesquotation.CheckboxSelesai = chkcomplete.IsChecked;
            salesquotation.TanggalPenutupan = DateTime.Parse(dtValidaty.Text);
            if (this.kontakSelected != null)
            {
                salesquotation.IdPetugas = this.kontakSelected.Id;
                salesquotation.NamaPetugas = this.kontakSelected.NamaA;
            }
            if (this.termspembayaranSelected != null)
            {
                salesquotation.IdTermPembayaran = this.termspembayaranSelected.IdTermPembayaran;
                salesquotation.TermPembayaran = this.termspembayaranSelected.NamaSkema;
            }
            salesquotation.CheckboxBerulang = chkannual.IsChecked;
            salesquotation.DurasiBerulang = double.Parse(txtAnnualFrequency.Text);
            salesquotation.TanggalBerulang = DateTime.Parse(dtAnnual.Text);
            if (this.optionAnnualSelected != null)
            {
                salesquotation.IdOpsiAnnual = this.optionAnnualSelected.IdOptionAnnual;
                salesquotation.Annual = this.optionAnnualSelected.Annual;
            }
            salesquotation.IdKodeTransaksi = 15;
            salesquotation.KodeTransaksi = "SQ";
            salesquotation.IdPeriodeAkutansi = 1;
            salesquotation.RealRecordingTime = DateTime.Now;
            salesquotation.TotalOrderProduk = salesquotation.TotalSebelumPajak;
            salesquotation.TotalSebelumPajak = double.Parse(txtTotalbeforeTax.Text);
            salesquotation.TotalPajak = double.Parse(txtTotalTax.Text);
            salesquotation.TotalSetelahPajak = double.Parse(txtAfterTotalTax.Text);
            if (QuotaBLL.AddSalesquotation(salesquotation) > 0)
            {
                //  this.ClearForm();
                MessageBox.Show("Sales Quotation successfully added !");
            }
            else
            {
                MessageBox.Show("Sales Quotation failed to add !");
            }
            if (DGSKU.Items.Count > 0)
            {
                foreach (var item in DGSKU.Items)
                {
                    if (item is OrderProdukJual)
                    {
                        OrderProdukJual oNewData1 = (OrderProdukJual)item;
                        oNewData1.IdReferalTransaksi = 1;
                        oNewData1.Tanggal = DateTime.Parse(dtSales.Text);
                        if (this.lokasiSelected != null)
                        {
                            oNewData1.IdLokasi = this.lokasiSelected.Id;
                            oNewData1.NamaLokasi = this.lokasiSelected.NamaTempatLokasi;
                        }
                        if (this.dataDepartemenSelected != null)
                        {
                            oNewData1.IdDepartemenProduk = this.dataDepartemenSelected.Id;
                        }
                        if (this.dataProyekSelected != null)
                        {
                            oNewData1.IdProyekProduk = this.dataProyekSelected.Id;
                        }
                        oNewData1.TanggalPengiriman = DateTime.Parse(dtValidaty.Text);
                        oNewData1.Checkbokaktif = false;
                        if (quotaBLL.EditOrderProdukjual(oNewData1, salesquotation) == true)
                        {
                        }
                    }
                }
            }
            Sales v = new Sales();
            Switcher.Switch2(v);
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
            Switcher.Switch2(v);
        }
        private void notes_Click(object sender, RoutedEventArgs e)
        {
            InternalNote v = new InternalNote();
            v.Show();
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
                    if (w is Document.Documentsalesorderquotation)
                    {
                        isWindowOpen = true;
                        w.Activate();
                    }
                }

                if (!isWindowOpen)
                {
                    Document.Documentsalesorderquotation document = new Document.Documentsalesorderquotation(this);
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
                    if (w is PaymentTerm)
                    {
                        isWindowOpen = true;
                        w.Activate();
                    }
                }

                if (!isWindowOpen)
                {
                    PaymentTerm newPaymentterm = new PaymentTerm(this);
                    newPaymentterm.Show();
                }


            }
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
             
    

