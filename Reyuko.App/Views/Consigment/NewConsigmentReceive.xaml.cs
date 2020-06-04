using Reyuko.BLL.Core;
using Reyuko.DAL.Domain;
using Reyuko.DAL;
using Reyuko.Utils;
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
namespace Reyuko.App.Views.Consigment
{
    /// <summary>
    
    /// </summary>
    public partial class NewConsigmentReceive : UserControl
    {
        public NewConsigmentReceive(Consigment consigmentform)
        {
            InitializeComponent();
            this.consigmentform = consigmentform;
            Switcher.pageSwitcherNewreceive = this;
            this.Init();
        }
        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
        public Consigment consigmentform;
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
        private IEnumerable<PenerimaanBarang> penerimaanBarangs { get; set; }
        private PenerimaanBarang penerimaanbarangSelected { get; set; }
        public IEnumerable<DataDepartemen> dataDepartemens { get; set; }
        public DataDepartemen Selectdepartment { get; set; }
        public IEnumerable<DataProyek> dataProyeks { get; set; }
        public DataProyek Selectproyek { get; set; }
        public DataDepartemen dataDepartemenSelected;
        public DataProyek dataProyekSelected;
        public IEnumerable<OrderInventori> orderInventoris { get; set; }
        public OrderInventori orderInventoriSelected;
        private void Init()
        {
            this.ClearForm();
            this.LoadVendor();
            this.LoadNoDokumen();
            this.LoadCurrency();
            this.LoadLokasi();
            this.LoadAnnual();
            this.LoadStaff();
       }

        private void ClearForm()
        {
            srvendor.Text = "";
            txtemail.Text = "";
            txthp.Text = "";
            tglconsigment.Text = DateTime.Now.ToShortDateString();
            this.DataMataUangSelected = null;
            cbCurrency.SelectedIndex = -1;
            srnodokumen.Text = "";
            txtConsigmentNumber.Text = "";
            txtNote.Text = "";
            this.lokasiSelected = null;
            cbLocation.SelectedIndex = -1;
            cbdepartmen.SelectedIndex = -1;
            cbproyek.SelectedIndex = -1;
            chkinclusivetax.IsChecked = false;
            dtshipping.Text = DateTime.Now.ToShortDateString();
            chkannual.IsChecked = false;
            this.optionAnnualSelected = null;
            cbAnnual.SelectedIndex = -1;
            txtAnnualFrequency.Text = "";
            tglberulang.Text = DateTime.Now.ToShortDateString();
            txtTotalTax.Text = "";
            txtAfterTotalTax.Text = "";
         }
        public void LoadDataSku()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.orderInventoris = uow.OrderInventori.GetAll().Where(m => m.CheckboxAktif == true);
                DGSKUConsigment.ItemsSource = this.orderInventoris;
                int sum = 0;
                for (int i = 0; i < DGSKUConsigment.Items.Count; i++)
                {
                    sum += Convert.ToInt32((DGSKUConsigment.Items[i] as OrderInventori).PersentasePajak);
                }
                txtTotalTax.Text = sum.ToString();
                int sumar = 0;
                for (int i = 0; i < DGSKUConsigment.Items.Count; i++)
                {
                    sumar += Convert.ToInt32((DGSKUConsigment.Items[i] as OrderInventori).HargaJual);
                }
                txtbeforeTax.Text = sumar.ToString();
                int suma = 0;
                for (int i = 0; i < DGSKUConsigment.Items.Count; i++)
                {
                    suma += Convert.ToInt32((DGSKUConsigment.Items[i] as OrderInventori).TotalJual);
                }
                txtAfterTotalTax.Text = (float.Parse(suma.ToString()) + float.Parse(txtTotalTax.Text)).ToString();
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
                cbdepartmen.ItemsSource = this.dataDepartemens;
                cbdepartmen.SelectedValuePath = "Id";
                cbdepartmen.DisplayMemberPath = "NamaDepartemen";
            }
        }

        public void LoadProyek()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dataProyeks = uow.DataProyek.GetAll();
                cbproyek.ItemsSource = this.dataProyeks;
                cbproyek.SelectedValuePath = "Id";
                cbproyek.DisplayMemberPath = "NamaProyek";
            }
        }

        private void department_selectionchange(object sender, SelectionChangedEventArgs e)
        {
            this.dataDepartemenSelected = null;
            if (cbdepartmen.SelectedItem != null)
            {
                dataDepartemenSelected = (DataDepartemen)cbdepartmen.SelectedItem;
            }
        }
        private void proyek_selectionchange(object sender, SelectionChangedEventArgs e)
        {
            this.dataProyekSelected = null;
            if (cbproyek.SelectedItem != null)
            {
                dataProyekSelected = (DataProyek)cbproyek.SelectedItem;
            }
        }
        private void staff_selectionchange(object sender, SelectionChangedEventArgs e)
        {
            this.kontakSelected = null;
            if (srstaff.SelectedItem != null)
            {
                kontakSelected = (Kontak)srstaff.SelectedItem;
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
        private void vendor_Click(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is Vendor.Vendors)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                Vendor.Vendors newVendor = new Vendor.Vendors(this);
                newVendor.Show();
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
                Sku newVendor = new Sku(this);
                newVendor.Show();
            }
        }
        public void dokumen_Click(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is Document.Documentconsigmentreceive)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                Document.Documentconsigmentreceive newDokumen = new Document.Documentconsigmentreceive(this);
                newDokumen.Show();
            }
        }

       
        private void SaveConsigmentReceive_Click(object sender, RoutedEventArgs e)
        {
            if (tglconsigment.Text == "" || cbCurrency.Text == "" || txtConsigmentNumber.Text == "" || cbLocation.Text == "" || dtshipping.Text == "" || txtAnnualFrequency.Text == "" || tglberulang.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            PenerimaanBarangBLL penerimaanbarangBLL = new PenerimaanBarangBLL();
            PenerimaanBarangBLL PenerimaanbarangBLL = new PenerimaanBarangBLL();
            PenerimaanBarang penerimaanBarang = new PenerimaanBarang();
            penerimaanBarang.IdKodeTransaksi = 19;
            penerimaanBarang.KodeTransaksi = "CI";
            penerimaanBarang.NoPenerimaanBarangKonsinyasi = double.Parse(txtConsigmentNumber.Text);
            if (this.kontakSelected != null)
            {
                penerimaanBarang.IdVendor = this.kontakSelected.Id;
                penerimaanBarang.NamaVendor = this.kontakSelected.NamaA;
            }
            penerimaanBarang.Email = txtemail.Text;
            penerimaanBarang.NoHp = double.Parse(txthp.Text);
            if (this.DataMataUangSelected != null)
            {
                penerimaanBarang.IdMataUang = this.DataMataUangSelected.Id;
                penerimaanBarang.MataUang = this.DataMataUangSelected.KodeMataUang;
                penerimaanBarang.KursTukar = this.DataMataUangSelected.KursTukar;
            }
            if (this.lokasiSelected != null)
            {
                penerimaanBarang.IdLokasi = this.lokasiSelected.Id;
                penerimaanBarang.NamaLokasi = this.lokasiSelected.NamaTempatLokasi;
            }
            penerimaanBarang.Keterangan = txtNote.Text;
            if (this.dataDepartemenSelected != null)
            {
                penerimaanBarang.IdDepartemen = this.dataDepartemenSelected.Id;
            }
            if (this.dataProyekSelected != null)
            {
                penerimaanBarang.IdProyek = this.dataProyekSelected.Id;
            }
            penerimaanBarang.CheckboxInclusiveTax = chkinclusivetax.IsChecked;
            penerimaanBarang.TanggalPenerimaan = DateTime.Parse(dtshipping.Text);
            penerimaanBarang.CheckBooxBerulang = chkannual.IsChecked;
            if (this.optionAnnualSelected != null)
            {
                penerimaanBarang.IdOpsiAnnual = this.optionAnnualSelected.IdOptionAnnual;
                penerimaanBarang.Annual = this.optionAnnualSelected.Annual;
            }
            if (this.kontakSelected != null)
            {
                penerimaanBarang.IdPetugas = this.kontakSelected.Id;
                penerimaanBarang.NamaPetugas = this.kontakSelected.NamaA;
            }
            if (this.dokumenSelected != null)
            {
                penerimaanBarang.IdNoRefernsiDokumen = this.dokumenSelected.Id;
                penerimaanBarang.NoReferensiDokumen = this.dokumenSelected.NoReferensiDokumen;
            }
            penerimaanBarang.Tanggal = DateTime.Parse(tglconsigment.Text);
            penerimaanBarang.DurasiBerulang = double.Parse(txtAnnualFrequency.Text);
            penerimaanBarang.TanggalBerulang = DateTime.Parse(tglberulang.Text);
            penerimaanBarang.TotalSebelumPajak = double.Parse(txtbeforeTax.Text);
            penerimaanBarang.TotalPajak = double.Parse(txtTotalTax.Text);
            penerimaanBarang.TotalSetelahPajak = double.Parse(txtAfterTotalTax.Text);
            penerimaanBarang.IdUserId = 1;
            penerimaanBarang.IdPeriodeAkutansi = 1;
            penerimaanBarang.RealRecordingTime = DateTime.Now;
            if (PenerimaanbarangBLL.AddPenerimaanBarang(penerimaanBarang) > 0)
            {
                //  this.ClearForm();
                MessageBox.Show("Receipt of Consignment Goods successfully added !");
            }
            else
            {
                MessageBox.Show("Receipt of Consignment Goods failed to add !");
            }
            if (DGSKUConsigment.Items.Count > 0)
            {
                foreach (var item in DGSKUConsigment.Items)
                {
                    if (item is OrderInventori)
                    {
                        OrderInventori oNewData1 = (OrderInventori)item;
                        if (this.lokasiSelected != null)
                        {
                            oNewData1.IdLokasi = this.lokasiSelected.Id;
                            oNewData1.NamaLokasi = this.lokasiSelected.NamaTempatLokasi;
                        }
                        if (this.dokumenSelected != null)
                        {
                            oNewData1.IdNoReferensiDokumen = this.dokumenSelected.Id;
                            oNewData1.NoReferensiDokumen = this.dokumenSelected.NoReferensiDokumen;
                        }
                        oNewData1.Keterangan = txtNote.Text;
                        oNewData1.CheckboxAktif = false;
                        if (penerimaanbarangBLL.EditInventory(oNewData1, penerimaanBarang) == true)
                        {
                        }
                    }
                }
                    Consigment v = new Consigment();
                    Switcher.Switchnewreceive(v);
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
            Consigment v = new Consigment();
            Switcher.Switchnewreceive(v);
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

        private void TxtConsigmentNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtConsigmentNumber.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtConsigmentNumber.Text = "";
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
                    MessageBox.Show("Must Have Numeric");
                    txtAnnualFrequency.Text = "";
                    return;
                }

            }
        }

        private void Departmen_Checked(object sender, RoutedEventArgs e)
        {
            this.rbdepartmen.IsChecked = true;
            {
                cbdepartmen.Visibility = Visibility.Visible;
                cbproyek.Visibility = Visibility.Hidden;
                cbproyek.SelectedIndex = -1;
                this.LoadDepartmen();
            }
        }

        private void Proyek_Checked(object sender, RoutedEventArgs e)
        {
            this.rbproject.IsChecked = true;
            {
                cbproyek.Visibility = Visibility.Visible;
                cbdepartmen.Visibility = Visibility.Hidden;
                cbdepartmen.SelectedIndex = -1;
                this.LoadProyek();
            }
        }
    }
}
             
    

