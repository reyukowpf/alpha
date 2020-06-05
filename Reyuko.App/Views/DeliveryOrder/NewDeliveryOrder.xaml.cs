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

namespace Reyuko.App.Views.DeliveryOrder
{
    /// <summary>

    /// </summary>
    public partial class NewDeliveryOrder : UserControl
    {
        public NewDeliveryOrder()
        {
            InitializeComponent();
            Switcher.pageSwitchNewDeliveryorder = this;
            this.Init();
        }
        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        public IEnumerable<Kontak> kontaks { get; set; }
        public Kontak kontakSelected { get; set; }
        public IEnumerable<Dokumen> dokumens { get; set; }
        public Dokumen dokumenSelected { get; set; }
        private IEnumerable<DataMataUang> dataMataUangs { get; set; }
        private DataMataUang DataMataUangSelected { get; set; }
        public IEnumerable<Lokasi> lokasi { get; set; }
        public Lokasi lokasiSelected { get; set; }
        public IEnumerable<SalesOrder> SalesOrders { get; set; }
        public SalesOrder SalesOrderSelected { get; set; }
        public IEnumerable<OrderProdukJual> orderProdukJuals { get; set; }
        public IEnumerable<DataDepartemen> dataDepartemens { get; set; }
        public DataDepartemen Selectdepartment { get; set; }
        public IEnumerable<DataProyek> dataProyeks { get; set; }
        public DataProyek Selectproyek { get; set; }
        public DataDepartemen dataDepartemenSelected;
        public DataProyek dataProyekSelected;
        public IEnumerable<OptionAnnual> optionAnnuals { get; set; }
        public OptionAnnual optionAnnualSelected { get; set; }


        private void Init()
        {
            this.LoadCustomer();
            this.LoadNoDokumen();
            this.LoadCurrency();
            this.LoadLokasi();
            this.LoadSalesorder();
            this.LoadAnnual();
            this.LoadStaff();
            this.ClearForm();
        }
        public void ClearForm()
        {
            dtDeliveryorderdate.Text = DateTime.Now.ToShortDateString();
            dtValiditydate.Text = DateTime.Now.ToShortDateString();
            dtAnnualdate.Text = DateTime.Now.ToShortDateString();
        }


        public void LoadSalesorder()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.SalesOrders = uow.SalesOrder.GetAll();
                cbSalesorder.ItemsSource = this.SalesOrders;
                cbSalesorder.SelectedValuePath = "IdOrderPenjualan";
                cbSalesorder.DisplayMemberPath = "NoOrderPenjualan";
            }
        }
        private void Salesorder_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.SalesOrderSelected = null;
            if (cbSalesorder.SelectedItem != null)
            {
                this.SalesOrderSelected = (SalesOrder)cbSalesorder.SelectedItem;
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
                cbAnnual.SelectedValuePath = "IdOpsiAnnual";
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
        public void LoadCustomer()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kontaks = uow.Kontak.GetAll().Where(m => m.TypeKontak.ToLower() == "pelanggan");
                srcustomer.ItemsSource = this.kontaks;
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
        public void LoadNoDokumen()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dokumens = uow.Dokumen.GetAll();
                srnodokumen.ItemsSource = this.dokumens;
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
                    sumar += Convert.ToInt32((DGSKU.Items[i] as OrderProdukJual).HargaJual);
                }
                txtTotalbeforeTax.Text = sumar.ToString();
                int suma = 0;
                for (int i = 0; i < DGSKU.Items.Count; i++)
                {
                    suma += Convert.ToInt32((DGSKU.Items[i] as OrderProdukJual).TotalOrderProduk);
                }
                txtAfterTotalTax.Text = (float.Parse(suma.ToString()) + float.Parse(txtTotalTax.Text)).ToString();
                txtOutstanding.Text = txtAfterTotalTax.Text;
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
                    if (w is Document.Documentdeliveryorder)
                    {
                        isWindowOpen = true;
                        w.Activate();
                    }
                }

                if (!isWindowOpen)
                {
                    Document.Documentdeliveryorder document = new Document.Documentdeliveryorder(this);
                    document.Show();
                }


            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Deliveryorder v = new Deliveryorder();
            Switcher.SwitchNewDeliveryorder(v);
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
        private void TxtDeliveryOrderNo_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtDeliveryOrderNo.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtDeliveryOrderNo.Text = "";
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

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (dtDeliveryorderdate.Text == "" || cbCurrency.Text == "" || txtDeliveryOrderNo.Text == "" || cbSalesorder.Text == "" || cbLocation.Text == "" || dtValiditydate.Text == "" || txtAnnualFrequency.Text == "" || dtAnnualdate.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            DeliveryOrdersBLL deliveryBLL = new DeliveryOrdersBLL();
            DeliveryOrdersBLL DeliveryBLL = new DeliveryOrdersBLL();
            Deliveryorders deliveryorders = new Deliveryorders();
            if (this.kontakSelected != null)
            {
                deliveryorders.IdPelanggan = this.kontakSelected.Id;
                deliveryorders.NamePelanggan = this.kontakSelected.NamaA;
            }
            deliveryorders.Email = txtemail.Text;
            deliveryorders.NoHp = txthp.Text;
            deliveryorders.TanggalDo = DateTime.Parse(dtDeliveryorderdate.Text);
            if (this.DataMataUangSelected != null)
            {
                deliveryorders.IdMaatUang = this.DataMataUangSelected.Id;
                deliveryorders.MaatUang = this.DataMataUangSelected.NamaMataUang;
                deliveryorders.KursTukar = this.DataMataUangSelected.KursTukar;
            }
            if (this.dokumenSelected != null)
            {
                deliveryorders.IdNoReferansiDokumen = this.dokumenSelected.Id;
                deliveryorders.NoReferansiDokumen = this.dokumenSelected.NoReferensiDokumen;
            }
            deliveryorders.NoDo = txtDeliveryOrderNo.Text;
            if (this.SalesOrderSelected != null)
            {
                deliveryorders.IdOrderPenjualan = this.SalesOrderSelected.IdOrderPenjualan;
                deliveryorders.NomorOrderPenjualan = this.SalesOrderSelected.NoOrderPenjualan;
            }
            deliveryorders.Keterangan = txtNote.Text;
            if (this.lokasiSelected != null)
            {
                deliveryorders.IdLokasi = this.lokasiSelected.Id;
                deliveryorders.NameLokasi = this.lokasiSelected.NamaTempatLokasi;
            }
            if (this.dataDepartemenSelected != null)
            {
                deliveryorders.IdDepartemen = this.dataDepartemenSelected.Id;
            }
            if (this.dataProyekSelected != null)
            {
                deliveryorders.IdProyek = this.dataProyekSelected.Id;
            }
            deliveryorders.CheckboxInclusivePajak = chkinclusive.IsChecked;
            deliveryorders.TanggalPengiriman = DateTime.Parse(dtValiditydate.Text);
            deliveryorders.DurationBerulang = double.Parse(txtAnnualFrequency.Text);
            deliveryorders.TanggalBerulang = DateTime.Parse(dtAnnualdate.Text);
            if (this.optionAnnualSelected != null)
            {
                deliveryorders.IdOpsiAnnual = this.optionAnnualSelected.IdOptionAnnual;
                deliveryorders.Annual = this.optionAnnualSelected.Annual;
            }
            if (this.kontakSelected != null)
            {
                deliveryorders.IdPetugas = this.kontakSelected.Id;
                deliveryorders.NamePetugas = this.kontakSelected.NamaA;
            }
            deliveryorders.CheckboxBerulang = chkannual.IsChecked;
            deliveryorders.IdKodeTransaksi = 25;
            deliveryorders.KodeTransaksi = "DO";
            deliveryorders.IdReferalTransaksi = 1;
            deliveryorders.IdPeriodeAkuntansi = 1;
            deliveryorders.RealRecordingTime = DateTime.Now;
            deliveryorders.TotalSebelumPajak = double.Parse(txtTotalbeforeTax.Text);
            deliveryorders.TotalPajak = double.Parse(txtTotalTax.Text);
            deliveryorders.TotalSetelahPajak = double.Parse(txtAfterTotalTax.Text);
            if (DeliveryBLL.AddDeliveryOrder(deliveryorders) > 0)
            {
                //  this.ClearForm();
                MessageBox.Show("Delivery Order successfully added !");
            }
            else
            {
                MessageBox.Show("Delivery Order failed to add !");
            }
             if (DGSKU.Items.Count > 0)
             {
                 foreach (var item in DGSKU.Items)
                 {
                     if (item is OrderProdukJual)
                     {
                         OrderProdukJual oNewData1 = (OrderProdukJual)item;
                         oNewData1.IdReferalTransaksi = 1;
                         oNewData1.Tanggal = DateTime.Parse(dtDeliveryorderdate.Text);
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
                        oNewData1.TanggalPengiriman = DateTime.Parse(dtValiditydate.Text);
                        oNewData1.Checkbokaktif = false;
                         if (deliveryBLL.EditOrderProdukjual(oNewData1, deliveryorders) == true)
                         {
                         }
                     }
                 }
                    Deliveryorder v = new Deliveryorder();
                    Switcher.SwitchNewDeliveryorder(v);
                }
            }
        }
    }
             
    

