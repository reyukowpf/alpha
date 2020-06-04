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
    public partial class NewConsigmentReturn : UserControl
    {
        public NewConsigmentReturn(Consigment consigmentform)
        {
            InitializeComponent();
            this.consigmentform = consigmentform;
            Switcher.pageSwitcherNewreturn = this;
            this.Init();
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
        public Consigment consigmentform;
        private IEnumerable<Kontak> kontaks { get; set; }
        public Kontak kontakSelected { get; set; }
        private IEnumerable<DataMataUang> dataMataUangs { get; set; }
        private DataMataUang DataMataUangSelected { get; set; }
        public IEnumerable<Dokumen> dokumens { get; set; }
        public Dokumen dokumenSelected { get; set; }
        public IEnumerable<Lokasi> lokasi { get; set; }
        public Lokasi lokasiSelected { get; set; }
        public IEnumerable<OptionAnnual> optionAnnuals { get; set; }
        public OptionAnnual optionAnnualSelected { get; set; }
        private IEnumerable<ReturBarang> ReturBarangs { get; set; }
        private ReturBarang ReturbarangSelected { get; set; }
        public IEnumerable<DataDepartemen> dataDepartemens { get; set; }
        public DataDepartemen Selectdepartment { get; set; }
        public IEnumerable<DataProyek> dataProyeks { get; set; }
        public DataProyek Selectproyek { get; set; }
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
            this.orderInventoris = new List<OrderInventori>();
            DGSKUConsigment.ItemsSource = this.orderInventoris;
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
        public void LoadStaff()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kontaks = uow.Kontak.GetAll().Where(m => m.TypeKontak.ToLower() == "employee");
                srstaff.ItemsSource = this.kontaks;
            }
        }

        public void LoadProyek()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dataProyeks = uow.DataProyek.GetAll();
                cbproject.ItemsSource = this.dataProyeks;
                cbproject.SelectedValuePath = "Id";
                cbproject.DisplayMemberPath = "NamaProyek";
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
        private void department_selectionchange(object sender, SelectionChangedEventArgs e)
        {
            this.Selectdepartment = null;
            if (cbdepartmen.SelectedItem != null)
            {
                Selectdepartment = (DataDepartemen)cbdepartmen.SelectedItem;
            }
        }
        private void proyek_selectionchange(object sender, SelectionChangedEventArgs e)
        {
            this.Selectproyek = null;
            if (cbproject.SelectedItem != null)
            {
                Selectproyek = (DataProyek)cbproject.SelectedItem;
            }
        }
        public void Departmen_Checked(object sender, EventArgs e)
        {
            this.rbdepartmen.IsChecked = true;
            {
                cbdepartmen.Visibility = Visibility.Visible;
                cbproject.Visibility = Visibility.Hidden;
                cbproject.SelectedIndex = -1;
                this.LoadDepartmen();
            }
        }

        public void Proyek_Checked(object sender, EventArgs e)
        {
            this.rbproject.IsChecked = true;
            {
                cbproject.Visibility = Visibility.Visible;
                cbdepartmen.Visibility = Visibility.Hidden;
                cbdepartmen.SelectedIndex = -1;
                this.LoadProyek();
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

        }
        private void btnsku(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is Skureturn)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                Skureturn newVendor = new Skureturn(this);
                newVendor.Show();
            }
        }
        public void dokumen_Click(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is Document.DocumentConsigmentreturn)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                Document.DocumentConsigmentreturn newDokumen = new Document.DocumentConsigmentreturn(this);
                newDokumen.Show();
            }
        }

        private void SaveConsigmentReturn_Click(object sender, RoutedEventArgs e)
        {
            if (tglconsigment.Text == "" || cbCurrency.Text == "" || txtConsigmentNumber.Text == "" || cbLocation.Text == "" || dtshipping.Text == "" || txtAnnualFrequency.Text == "" || tglberulang.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            ReturBarangBLL returbarangBLL = new ReturBarangBLL();
            ReturBarangBLL ReturbarangBLL = new ReturBarangBLL();
            ReturBarang returBarang = new ReturBarang();
            returBarang.IdKodeTransaksi = 19;
            returBarang.KodeTransaksi = "CI";
            returBarang.NoReturBarangKonsinyasi = double.Parse(txtConsigmentNumber.Text);
            if (this.kontakSelected != null)
            {
                returBarang.IdVendor = this.kontakSelected.Id;
                returBarang.NamaVendor = this.kontakSelected.NamaA;
            }
            returBarang.Email = txtemail.Text;
            returBarang.NoHp = double.Parse(txthp.Text);
            if (this.DataMataUangSelected != null)
            {
                returBarang.IdMataUang = this.DataMataUangSelected.Id;
                returBarang.MataUang = this.DataMataUangSelected.KodeMataUang;
                returBarang.KursTukar = this.DataMataUangSelected.KursTukar;
            }
            if (this.lokasiSelected != null)
            {
                returBarang.IdLokasi = this.lokasiSelected.Id;
                returBarang.NamaLokasi = this.lokasiSelected.NamaTempatLokasi;
            }
            returBarang.Keterangan = txtNote.Text;
            if (this.Selectdepartment != null)
            {
                returBarang.IdDepartemen = this.Selectdepartment.Id;
            }
            if (this.Selectproyek != null)
            {
                returBarang.IdProyek = this.Selectproyek.Id;
            }
            returBarang.CheckboxInclusiveTax = chkinclusivetax.IsChecked;
            returBarang.TanggalPengantaran = DateTime.Parse(dtshipping.Text);
            returBarang.CheckBooxBerulang = chkannual.IsChecked;
            if (this.optionAnnualSelected != null)
            {
                returBarang.IdOpsiAnnual = this.optionAnnualSelected.IdOptionAnnual;
                returBarang.Annual = this.optionAnnualSelected.Annual;
            }
            if (this.kontakSelected != null)
            {
                returBarang.IdPetugas = this.kontakSelected.Id;
                returBarang.NamaPetugas = this.kontakSelected.NamaA;
            }
            if (this.dokumenSelected != null)
            {
                returBarang.IdNoRefernsiDokumen = this.dokumenSelected.Id;
                returBarang.NoReferensiDokumen = this.dokumenSelected.NoReferensiDokumen;
            }
            returBarang.Tanggal = DateTime.Parse(tglconsigment.Text);
            returBarang.DurasiBerulang = double.Parse(txtAnnualFrequency.Text);
            returBarang.TanggalBerulang = DateTime.Parse(tglberulang.Text);
            returBarang.TotalSebelumPajak = double.Parse(txtbeforeTax.Text);
            returBarang.TotalPajak = double.Parse(txtTotalTax.Text);
            returBarang.TotalSetelahPajak = double.Parse(txtAfterTotalTax.Text);
            returBarang.IdUserId = 1;
            returBarang.IdPeriodeAkutansi = 1;
            returBarang.RealRecordingTime = DateTime.Now;
            if (ReturbarangBLL.AddReturBarang(returBarang) > 0)
            {
                //  this.ClearForm();
                MessageBox.Show("Consignment Item returns successfully added !");
            }
            else
            {
                MessageBox.Show("Consignment Item returns failed to add !");
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
                        if (returbarangBLL.EditInventory(oNewData1, returBarang) == true)
                        {
                        }
                    }
                }
                Consigment v = new Consigment();
                Switcher.Switchnewreturn(v);
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
            Switcher.Switchnewreturn(v);
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
                    MessageBox.Show("Harus Diisi Numerik");
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
                    MessageBox.Show("Harus Diisi Numerik");
                    txtAnnualFrequency.Text = "";
                    return;
                }

            }
        }
    }
}
             
    

