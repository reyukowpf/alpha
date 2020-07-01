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
        public IEnumerable<produk> produks { get; set; }
        public produk produkSelected;
        public Kontak kontakSelected { get; set; }
        private IEnumerable<DataMataUang> dataMataUangs { get; set; }
        public IEnumerable<KodeTransaksi> kodeTransaksi { get; set; }
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
        public Kontak petugasSelected;
        public DataProyek dataProyekSelected;
        public bool isEdit = false;
        private void Init()
        {
            this.ClearForm();
            this.LoadEmployee();
            this.LoadStaff();
            this.LoadNoDokumen();
            this.LoadKode();
            this.LoadCurrency();
            this.Loadproduk();
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
            dtRequired.Text = DateTime.Now.ToShortDateString();
        }
        public void LoadKode()
        {

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
        private void txttax_TextChanged(object sender, TextChangedEventArgs e)
        {
            txttota.Text = txttax1.Text;
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
            this.petugasSelected = null;
            if (srstaff.SelectedItem != null)
            {
                this.petugasSelected = (Kontak)srstaff.SelectedItem;
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
        
        private void Loadproduk()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.produks = uow.produk.GetAll();
                srsku.ItemsSource = this.produks;
            }
        }
        private void produk_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.produkSelected = null;
            if (srsku.SelectedItem != null)
            {
                this.produkSelected = (produk)srsku.SelectedItem;
                txtunit.Text = this.produkSelected.SatuanDasar;
                txtprice.Text = this.produkSelected.HargaBeli.ToString();
                txtdiskon.Text = this.produkSelected.DiskonProdukPersen;
                txttax.Text = this.produkSelected.PersentasePajak.ToString();
                txtdiskon1.Text = ((float.Parse(txtprice.Text.ToString()) * float.Parse(txtdiskon.Text.ToString()) / 100)).ToString();
            }
        }
        public OrderProdukBeli GetData()
        {
            OrderProdukBeli oData = new OrderProdukBeli();
            if (this.produkSelected != null)
            {
                oData.IdProduk = this.produkSelected.IdProduk;
                oData.ProdukKategori = this.produkSelected.ProdukKategori;
                oData.Sku = this.produkSelected.SKU;
                oData.SatuanDasar = this.produkSelected.SatuanDasar;
                oData.IdPajak = this.produkSelected.IdPajak;
                oData.NamaPajak = this.produkSelected.Pajak;
                oData.PersentasePajak = this.produkSelected.PersentasePajak;
                oData.HargaBeli = this.produkSelected.HargaBeli;
                oData.IdAkunPajakProduk = this.produkSelected.IdAkunPajak;
                oData.NamaProduk = this.produkSelected.NamaProduk;
                oData.IdTypeProduk = this.produkSelected.IdTipeProduk;
                oData.TypeProduk = this.produkSelected.TipeProduk;
                oData.AkunPersediaan = this.produkSelected.IdAkunPersediaan;
                oData.AkunPengirimanBeli = this.produkSelected.IdAkunPengirimanBeli;
            }
            oData.TotalPajakProduk = double.Parse(txttotaltax.Text);
            oData.IdTransaksi = int.Parse(txttota.Text);
            oData.DiskonProduk = double.Parse(txtdiskon1.Text);
            oData.TotalProduk = double.Parse(txttotal.Text);
            oData.TotalOrderProduk = double.Parse(txttotal1.Text);
            oData.Checkboxaktif = true;
            return oData;
        }
        
        private void txttotal_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txttotal.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txttotal.Text = "";
                    return;
                }
            }
           txttotal1.Text = ((float.Parse(txttotal.Text.ToString()) * float.Parse(txtprice.Text.ToString())) - (float.Parse(txtdiskon.Text.ToString()) / 100 * float.Parse(txtprice.Text.ToString())) * float.Parse(txttotal.Text.ToString())).ToString();
            txttotaltax.Text = (float.Parse(txttotal1.Text.ToString()) * float.Parse(txttax.Text.ToString())).ToString();
        }

        private void txttotalservice_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txttotalservice.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txttotalservice.Text = "";
                    return;
                }
            }
            txttotal1.Text = ((float.Parse(txttotalservice.Text.ToString()) * float.Parse(txtprice.Text.ToString())) - (float.Parse(txtdiskon.Text.ToString()) / 100 * float.Parse(txtprice.Text.ToString())) * float.Parse(txttotalservice.Text.ToString())).ToString();
            txttotaltax.Text = (float.Parse(txttotal1.Text.ToString()) * float.Parse(txttax.Text.ToString())).ToString();
        }
        public OrderJasaBeli GetData1()
        {
            OrderJasaBeli oData = new OrderJasaBeli();
            if (this.produkSelected != null)
            {
                oData.IdProduk = this.produkSelected.IdProduk;
                oData.Sku = this.produkSelected.SKU;
                oData.NamaJasa = this.produkSelected.NamaProduk;
                oData.HargaJasa = this.produkSelected.HargaBeli;
                oData.PersentasePajak = this.produkSelected.PersentasePajak;
                oData.IdAkunPajakJasa = this.produkSelected.IdAkunPajak;
                oData.IdPajak = this.produkSelected.IdPajak;
                oData.NamaPajak = this.produkSelected.Pajak;
                oData.IdAkunJasa = this.produkSelected.IdAkunJasa;
            }
            oData.DiskonJasa = double.Parse(txtdiskon1.Text);
            oData.TotalJasa = int.Parse(txttotalservice.Text);
            oData.IdTransaksi = int.Parse(txttota.Text);
            oData.TotalOrderJasa = double.Parse(txttotal1.Text);
            oData.TotalPajakJasa = double.Parse(txttotaltax.Text);
            oData.Checkboxaktif = true;
            return oData;
        }

        public OrderCustomBeli GetData2()
        {
            OrderCustomBeli oData = new OrderCustomBeli();
            oData.NamaCustom = txtnama.Text;
            oData.HargaCustom = double.Parse(txtprice.Text);
            oData.IdTransaksi = int.Parse(txttota.Text);
            oData.JumlahCustom = int.Parse(txttotalcustom.Text);
            oData.TotalCustom = double.Parse(txttotal1.Text);
            oData.Checkboxaktif = true;
            return oData;
        }

        private void txtharga_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtharga.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtharga.Text = "";
                    return;
                }
            }
            txttotal1.Text = ((float.Parse(txttotalcustom.Text.ToString()) * float.Parse(txtharga.Text.ToString()))).ToString();
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                // your event handler here
                    ShopingchartBLL shopingBLL = new ShopingchartBLL();
                    if (shopingBLL.AddOrderProdukbeli(this.GetData()) > 0)
                    {
                        MessageBox.Show("Add Order Buy Product successfully added !");
                        this.LoadDataSku();
                        txttotal.Visibility = Visibility.Collapsed;
                        txtunit.Visibility = Visibility.Collapsed;
                        txtbudget.Visibility = Visibility.Collapsed;
                        gg.Visibility = Visibility.Collapsed;
                        srsku.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        MessageBox.Show("Add Order Buy Product failed to add !");
                    }
                e.Handled = true;

            }
        }
        private void TextBoxservice_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                // your event handler here
                ShopingchartBLL shopingchartBLL = new ShopingchartBLL();
                if (shopingchartBLL.AddOrderJasabeli(this.GetData1()) > 0)
                {
                    MessageBox.Show("Add Order Buy Service successfully added !");
                    this.LoadDataSku();
                    txttotalservice.Visibility = Visibility.Collapsed;
                    txtunit.Visibility = Visibility.Collapsed;
                    txtbudget.Visibility = Visibility.Collapsed;
                    gg.Visibility = Visibility.Collapsed;
                    srsku.Visibility = Visibility.Collapsed;
                }
                else
                {
                    MessageBox.Show("Add Order Buy Service failed to add !");
                }
                e.Handled = true;

            }
        }

        private void TextBoxharga_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                // your event handler here
                ShopingchartBLL shopingBLL = new ShopingchartBLL();
                if (shopingBLL.AddOrderProdukbeli(this.GetData()) > 0)
                {
                    MessageBox.Show("Add Order Buy Custom successfully added !");
                    this.LoadDataSku();
                    txttotal.Visibility = Visibility.Collapsed;
                    txtunit.Visibility = Visibility.Collapsed;
                    txtbudget.Visibility = Visibility.Collapsed;
                    gg.Visibility = Visibility.Collapsed;
                    srsku.Visibility = Visibility.Collapsed;
                }
                else
                {
                    MessageBox.Show("Add Order Buy Custom failed to add !");
                }
                e.Handled = true;

            }
        }

        private void produk_Click(object sender, RoutedEventArgs e)
        {
            txttotal.Visibility = Visibility.Visible;
            txtunit.Visibility = Visibility.Visible;
            txtbudget.Visibility = Visibility.Visible;
            gg.Visibility = Visibility.Visible;
            srsku.Visibility = Visibility.Visible;
            txttotalservice.Visibility = Visibility.Hidden;
        }

        private void service_Click(object sender, RoutedEventArgs e)
        {
            txttotalservice.Visibility = Visibility.Visible;
            txttotal.Visibility = Visibility.Hidden;
            txtunit.Visibility = Visibility.Visible;
            txtbudget.Visibility = Visibility.Visible;
            gg.Visibility = Visibility.Visible;
            srsku.Visibility = Visibility.Visible;
        }
        private void custom_Click(object sender, RoutedEventArgs e)
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
                    if (w is Employee.Employeeshoping)
                    {
                        isWindowOpen = true;
                        w.Activate();
                    }
                }

                if (!isWindowOpen)
                {
                    Employee.Employeeshoping Customer = new Employee.Employeeshoping(this);
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
                    if (w is Document.Documentshoping)
                    {
                        isWindowOpen = true;
                        w.Activate();
                    }
                }

                if (!isWindowOpen)
                {
                    Document.Documentshoping document = new Document.Documentshoping(this);
                    document.Show();
                }


            }
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
            if (this.petugasSelected != null)
            {
                shoping.IdPetugas = this.petugasSelected.Id;
                shoping.NamaPetugas = this.petugasSelected.NamaA;
            }
            shoping.DurasiBerulang = double.Parse(txtAnnualFrequency.Text);
            shoping.TanggalBerulang = DateTime.Parse(dtAnnual.Text);
            shoping.Nilai = double.Parse(txttotalbeforetax.Text);
            shoping.IdUserId = 1;
            shoping.IdPeriodeAkuntansi = 1;
            shoping.RealRecordingTime = DateTime.Now;
            shoping.Checkaktif = true;
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
                        oNewData1.IdTransaksi = shoping.IdPermintaanBarang;
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

        private void chkproduk_Checked(object sender, RoutedEventArgs e)
        {
            /*if (this.chkproduk.IsChecked == true)
            {
                txtNote1.Visibility = Visibility.Visible;
            }
            else if (this.chkproduk.IsChecked == false)
            {
                txtNote1.Visibility = Visibility.Hidden;
            } */

            /* this.chkproduk.IsChecked = false;
             {
                 txtNote1.Visibility = Visibility.Hidden;
             }*/
        }
    }
}



