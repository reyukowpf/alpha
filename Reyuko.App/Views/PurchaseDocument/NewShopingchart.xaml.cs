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

namespace Reyuko.App.Views.PurchaseDocument
{
    /// <summary>
    
    /// </summary>
    public partial class NewShopingchart : UserControl
    {
        public NewShopingchart()
        {
            InitializeComponent();
            Switcher.pageSwitchNewShopingchart = this;
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
        public IEnumerable<ListOrderBeli> listOrderBelis { get; set; }
        public Dokumen dokumenSelected { get; set; }
        public IEnumerable<Lokasi> lokasi { get; set; }
        public Lokasi lokasiSelected { get; set; }
        public IEnumerable<OptionAnnual> optionAnnuals { get; set; }
        public OptionAnnual optionAnnualSelected { get; set; }
        public IEnumerable<DataDepartemen> dataDepartemens { get; set; }
        public IEnumerable<DataProyek> dataProyeks { get; set; }
        public IEnumerable<Termspembayaran> termspembayarans { get; set; }
        public Termspembayaran termspembayaranSelected;
        public DataDepartemen dataDepartemenSelected;
        public DataProyek dataProyekSelected;
        public bool isEdit = false;
        private void Init()
        {
            this.ClearForm();
            this.LoadEmployee();
            this.LoadStaff();
            this.LoadNoDokumen();
            this.LoadCurrency();
            this.LoadLokasi();
            this.LoadAnnual();
        }
        private void ClearForm()
        {
            sremployee.Text = "";
            txtemail.Text = "";
            txthp.Text = "";
            dtIssued.Text = DateTime.Now.ToShortDateString();
            cbCurrency.SelectedIndex = -1;
            srnodokumen.Text = "";
            txtRequestNo.Text = "";
            txtNote.Text = "";
            cbLocation.SelectedIndex = -1;
            cbDepartment.SelectedIndex = -1;
            cbProyek.SelectedIndex = -1;
            chkcomplete.IsChecked = false;
            rbdeprtmen.IsChecked = false;
            rbprojec.IsChecked = false;
            chkannual.IsChecked = false;
            cbAnnual.SelectedIndex = -1;
            srstaff.Text = "";
            txtAnnualFrequency.Text = "";
            dtAnnual.Text = DateTime.Now.ToShortDateString();
           
        }
        public void LoadEmployee()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kontaks = uow.Kontak.GetAll().Where(m => m.TypeKontak.ToLower() == "employee");
                sremployee.ItemsSource = this.kontaks;
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
        private void employee_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.kontakSelected = null;
            if (sremployee.SelectedItem != null)
            {
                this.kontakSelected = (Kontak)sremployee.SelectedItem;
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
        private void StockList_Click(object sender, RoutedEventArgs e)
        {

        }
        private void produk_Click(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is Skushopingchart)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                Skushopingchart newsku = new Skushopingchart(this);
                newsku.Show();
            }
        }
        private void service_Click(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is Skuservice)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                Skuservice newsku = new Skuservice(this);
                newsku.Show();
            }
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
            PurchaseDocument v = new PurchaseDocument();
            Switcher.SwitchNewShopingchart(v);
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

        private void Manager_Click(object sender, RoutedEventArgs e)
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
                    Customer Customer = new Customer();
                    Customer.Show();
                }


            }
        }

        private void Document_Click(object sender, RoutedEventArgs e)
        {
            {
                bool isWindowOpen = false;

                foreach (Window w in Application.Current.Windows)
                {
                    if (w is Document)
                    {
                        isWindowOpen = true;
                        w.Activate();
                    }
                }

                if (!isWindowOpen)
                {
                    Document document = new Document();
                    document.Show();
                }


            }
        }

        private void Product_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Service_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TxtRequestNo_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtRequestNo.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtRequestNo.Text = "";
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
        public void LoadDataSku()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.listOrderBelis = uow.ListOrderBeli.GetAll().Where(m => m.Checkboxaktif == true);
                DGSKUShopingChart.ItemsSource = this.listOrderBelis;
                int sumar = 0;
                for (int i = 0; i < DGSKUShopingChart.Items.Count; i++)
                {
                    sumar += Convert.ToInt32((DGSKUShopingChart.Items[i] as ListOrderBeli).TotalOrder);
                }
                   txttotalbeforetax.Text = sumar.ToString();             
            }
        }

        private void DGSKUShopingChart_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public Shopingchart GetData()
        {
            Shopingchart oData = new Shopingchart();
            oData.Email = txtemail.Text;
            oData.Nohp = txthp.Text;
            oData.TanggaldiBuat = DateTime.Parse(dtIssued.Text);
            oData.NoPermintaanBarang = txtRequestNo.Text;
            oData.Keterangan = txtNote.Text;
            oData.TanggalDigunakan = DateTime.Parse(dtRequired.Text);
            oData.DurasiBerulang = double.Parse(txtAnnualFrequency.Text);
            oData.TanggalBerulang = DateTime.Parse(dtAnnual.Text);
            if (this.kontakSelected != null)
            {
                oData.IdEmployee = this.kontakSelected.Id;
                oData.NamaManager = this.kontakSelected.NamaA;
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
            

            oData.CheckboxSelesai = chkcomplete.IsChecked;           
            oData.CheckboxBerulang = chkannual.IsChecked;

            return oData;
        }

        private void Saveshopingchart_Click(object sender, RoutedEventArgs e)
        {
            if (sremployee.Name == "" || txtemail.Name == "" || txthp.Name == "" || dtIssued.Text == "" || cbCurrency.Text == "" || srnodokumen.Name == "" || txtRequestNo.Text == "" || txtNote.Text == "" || cbLocation.Text == "" || dtRequired.Text == "" || cbAnnual.Text == "" || srstaff.Name == "" || txtAnnualFrequency.Text == "" || dtAnnual.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            ShopingchartBLL shopingBLL = new ShopingchartBLL();
            ShopingchartBLL ShopingBLL = new ShopingchartBLL();
            Shopingchart shoping = new Shopingchart();
            shoping.IdKodeTransaksi = 14;
            shoping.KodeTransaksi = "MR";
            if (this.kontakSelected != null)
            {
                shoping.IdEmployee = this.kontakSelected.Id;
                shoping.NamaManager = this.kontakSelected.NamaA;
            }
            shoping.Email = txtemail.Text;
            shoping.Nohp = txthp.Text;
            shoping.TanggaldiBuat = DateTime.Parse(dtIssued.Text);
            if (this.DataMataUangSelected != null)
            {
                shoping.IdMataUang = this.DataMataUangSelected.Id;
                shoping.MataUang = this.DataMataUangSelected.KodeMataUang;
                shoping.KursTukar = this.DataMataUangSelected.KursTukar;
            }
            if (this.dokumenSelected != null)
            {
                shoping.IdNoReferensiDokumen = this.dokumenSelected.Id;
                shoping.NoReferensiDokumen = this.dokumenSelected.NoReferensiDokumen;
            }
            shoping.NoPermintaanBarang = txtRequestNo.Text;
            if (this.lokasiSelected != null)
            {
                shoping.IdLokasi = this.lokasiSelected.Id;
                shoping.NamaLokasi = this.lokasiSelected.NamaTempatLokasi;
            }
            shoping.Keterangan = txtNote.Text;
            if (this.dataDepartemenSelected != null)
            {
                shoping.IdDepartemen = this.dataDepartemenSelected.Id;
            }
            if (this.dataProyekSelected != null)
            {
                shoping.IdProyek = this.dataProyekSelected.Id;
            }
            shoping.CheckboxSelesai = chkcomplete.IsChecked;
            shoping.TanggalDigunakan = DateTime.Parse(dtRequired.Text);
            shoping.CheckboxBerulang = chkannual.IsChecked;
            if (this.optionAnnualSelected != null)
            {
                shoping.IdOpsiAnnual = this.optionAnnualSelected.IdOptionAnnual;
                shoping.Annual = this.optionAnnualSelected.Annual;
            }
            if (this.kontakSelected != null)
            {
                shoping.IdPetugas = this.kontakSelected.Id;
                shoping.NamaPetugas = this.kontakSelected.NamaA;
            }
            shoping.DurasiBerulang = double.Parse(txtAnnualFrequency.Text);
            shoping.TanggalBerulang = DateTime.Parse(dtAnnual.Text);
            shoping.Nilai = double.Parse(txttotalbeforetax.Text);
            shoping.IdUserId = 1;
            shoping.IdPeriodeAkuntansi = 1;
            shoping.RealRecordingTime = DateTime.Now;
            if (ShopingBLL.AddShopingcharts(shoping) > 0)
            {
                //  this.ClearForm();
                MessageBox.Show("Shoping Chart successfully added !");
            }
            else
            {
                MessageBox.Show("Shoping Chart failed to add !");
            }
            if (DGSKUShopingChart.Items.Count > 0)
            {
                foreach (var item in DGSKUShopingChart.Items)
                {
                    if (item is ListOrderBeli)
                    {
                        ListOrderBeli oNewData1 = (ListOrderBeli)item;
                        oNewData1.Tanggal = DateTime.Parse(dtIssued.Text);
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
                        oNewData1.Checkboxaktif = false;
                        if (shopingBLL.EditOrderProdukBeli(oNewData1, shoping) == true)
                        {
                        }
                    }
                }
            }
                PurchaseDocument v = new PurchaseDocument();
            Switcher.SwitchNewShopingchart(v);
        }

        private void rbdeprtmen_Checked(object sender, RoutedEventArgs e)
        {
            this.rbdeprtmen.IsChecked = true;
            {
                cbDepartment.Visibility = Visibility.Visible;
                cbProyek.Visibility = Visibility.Hidden;
                cbProyek.SelectedIndex = -1;
                this.LoadDepartmen();
            }
        }

        private void rbprojec_Checked(object sender, RoutedEventArgs e)
        {
            this.rbprojec.IsChecked = true;
            {
                cbProyek.Visibility = Visibility.Visible;
                cbDepartment.Visibility = Visibility.Hidden;
                cbDepartment.SelectedIndex = -1;
                this.LoadProyek();
            }
        }
    }
}
             
    

