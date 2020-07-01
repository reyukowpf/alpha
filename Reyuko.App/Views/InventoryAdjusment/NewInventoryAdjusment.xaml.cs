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

namespace Reyuko.App.Views.InventoryAdjusment
{
    /// <summary>
    
    /// </summary>
    public partial class NewInventoryAdjusment : UserControl
    {
        public NewInventoryAdjusment()
        {
            InitializeComponent();
            Switcher.pageSwitchernewinventoryadjusmen = this;
            this.Init();
        }
        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
        private IEnumerable<DropdownPPTBarang> dropdownPPTBarangs { get; set; }
        public DropdownPPTBarang dropdownPPTBarangSelected;
        private IEnumerable<Dokumen> dokumens { get; set; }
        public Dokumen dokumenSelected;
        private IEnumerable<Kontak> kontaks { get; set; }
        public Kontak kontakSelected;
        private IEnumerable<Lokasi> lokasis { get; set; }
        public Lokasi lokasiSelected;
        private IEnumerable<DataDepartemen> dataDepartemens { get; set; }
        public DataDepartemen dataDepartemenSelected;
        private IEnumerable<DataProyek> dataProyeks { get; set; }
        public DataProyek dataProyekSelected;
        private IEnumerable<RekeningPerkiraan> rekeningPerkiraans { get; set; }
        public RekeningPerkiraan rekeningPerkiraanSelected;
        public IEnumerable<OrderInventori> orderInventoris { get; set; }
        public OrderInventori orderInventoriSelected;
        private void Init()
        {
            this.LoadComboAction();
            this.LoadComboAkun();
            this.LoadComboLokasiA();
            this.LoadComboLokasiB();
            this.LoadDokumen();
            this.LoadPetugas();
        }
        public void LoadDataSku()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.orderInventoris = uow.OrderInventori.GetAll().Where(m => m.CheckboxAktif == true);
                DGSKUInventoryAdjusment.ItemsSource = this.orderInventoris;
                /* int sum = 0;
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
                txtAfterTotalTax.Text = (float.Parse(suma.ToString()) + float.Parse(txtTotalTax.Text)).ToString();*/
            }
        }
        public void LoadComboAction()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dropdownPPTBarangs = uow.DropdownPPTBarang.GetAll();
                cbAction.ItemsSource = this.dropdownPPTBarangs;
                cbAction.SelectedValuePath = "Id";
                cbAction.DisplayMemberPath = "Action";
            }
        }
        public void LoadComboAkun()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.rekeningPerkiraans = uow.RekeningPerkiraan.GetAll();
                cbAccount.ItemsSource = this.rekeningPerkiraans;
                cbAccount.SelectedValuePath = "Id";
                cbAccount.DisplayMemberPath = "NamaRekeningPerkiraan";
            }
        }
        public void LoadComboLokasiA()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.lokasis = uow.Lokasi.GetAll();
                cbLocationA.ItemsSource = this.lokasis;
                cbLocationA.SelectedValuePath = "Id";
                cbLocationA.DisplayMemberPath = "NamaTempatLokasi";
            }
        }
        public void LoadComboLokasiB()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.lokasis = uow.Lokasi.GetAll();
                cbLocationB.ItemsSource = this.lokasis;
                cbLocationB.SelectedValuePath = "Id";
                cbLocationB.DisplayMemberPath = "NamaTempatLokasi";
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
        public void LoadDokumen()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dokumens = uow.Dokumen.GetAll();
                srnorefrensidokumen.ItemsSource = this.dokumens;
            }
        }
        public void LoadPetugas()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kontaks = uow.Kontak.GetAll().Where(m => m.TypeKontak.ToLower() == "employee");
                srstaff.ItemsSource = this.kontaks;
            }
        }
        private void action_selectionchange(object sender, SelectionChangedEventArgs e)
        {
            this.dropdownPPTBarangSelected = null;
            if (cbAction.SelectedItem != null)
            {
                dropdownPPTBarangSelected = (DropdownPPTBarang)cbAction.SelectedItem;
            }
        }
        private void akun_selectionchange(object sender, SelectionChangedEventArgs e)
        {
            this.rekeningPerkiraanSelected = null;
            if (cbAccount.SelectedItem != null)
            {
                rekeningPerkiraanSelected = (RekeningPerkiraan)cbAccount.SelectedItem;
            }
        }
        private void lokasia_selectionchange(object sender, SelectionChangedEventArgs e)
        {
            this.lokasiSelected = null;
            if (cbLocationA.SelectedItem != null)
            {
                lokasiSelected = (Lokasi)cbLocationA.SelectedItem;
            }
        }
        private void lokasib_selectionchange(object sender, SelectionChangedEventArgs e)
        {
            this.lokasiSelected = null;
            if (cbLocationB.SelectedItem != null)
            {
                lokasiSelected = (Lokasi)cbLocationB.SelectedItem;
            }
        }

        private void departmen_selectionchange(object sender, SelectionChangedEventArgs e)
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
        private void staff_selectionchange(object sender, SelectionChangedEventArgs e)
        {
            this.kontakSelected = null;
            if (srstaff.SelectedItem != null)
            {
                kontakSelected = (Kontak)srstaff.SelectedItem;
            }
        }
        private void dokumen_selectionchange(object sender, SelectionChangedEventArgs e)
        {
            this.dokumenSelected = null;
            if (srnorefrensidokumen.SelectedItem != null)
            {
                dokumenSelected = (Dokumen)srnorefrensidokumen.SelectedItem;
            }
        }
        public void Departmen_Checked(object sender, EventArgs e)
        {
            this.departmn.IsChecked = true;
            {
                cbDepartment.Visibility = Visibility.Visible;
                cbProyek.Visibility = Visibility.Hidden;
                cbProyek.SelectedIndex = -1;
                this.LoadDepartmen();
            }
        }

        public void Project_Checked(object sender, EventArgs e)
        {
            this.projec.IsChecked = true;
            {
                cbProyek.Visibility = Visibility.Visible;
                cbDepartment.Visibility = Visibility.Hidden;
                cbDepartment.SelectedIndex = -1;
                this.LoadProyek();
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
        private void SaveInventoryAdjusment_Click(object sender, RoutedEventArgs e)
        {
            if (cbAction.Text == "" || txtRefferenceNumber.Text == "" || date.Text == "" || cbAccount.Text == "" || cbLocationA.Text == "" || cbLocationB.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            PermPenyTransferBarangBLL permBLL = new PermPenyTransferBarangBLL();
            PermPenyTransferBarangBLL PermBLL = new PermPenyTransferBarangBLL();
            PermPenyTransferBarang perm = new PermPenyTransferBarang();
            perm.IdKodeTransaksi = 9;
            perm.NoPemPenydanTransferBarang = double.Parse(txtRefferenceNumber.Text);
            if (this.dropdownPPTBarangSelected != null)
            {
                perm.DropdownPemakaianTransferBarang = this.dropdownPPTBarangSelected.Id;
            }
            perm.Tanggal = DateTime.Parse(date.Text);
            if (this.rekeningPerkiraanSelected != null)
            {
                perm.IdAkunKe = this.rekeningPerkiraanSelected.Id;
            }
            if (this.dokumenSelected != null)
            {
                perm.IdNoReferensiDokumen = this.dokumenSelected.Id;
                perm.NoReferensiDokumen = this.dokumenSelected.NoReferensiDokumen;
            }
            if (this.lokasiSelected != null)
            {
                perm.IdLokasiDari = this.lokasiSelected.Id;
                perm.NamaDariLokasi = this.lokasiSelected.NamaTempatLokasi;
            }
            if (this.lokasiSelected != null)
            {
                perm.IdLokasiKe = this.lokasiSelected.Id;
                perm.NamaKeLokasi = this.lokasiSelected.NamaTempatLokasi;
            }            
            if (this.dataDepartemenSelected != null)
            {
                perm.IdDepartemen = this.dataDepartemenSelected.Id;
            }
            if (this.dataProyekSelected != null)
            {
                perm.IdProyek = this.dataProyekSelected.Id;
            }
            if (this.kontakSelected != null)
            {
                perm.IdPetugas = this.kontakSelected.Id;
                perm.NamaPetugas = this.kontakSelected.NamaA;
            }
            perm.Keterangan = txtNote.Text;
            perm.IdUserId = 1;
            perm.IdPeriodeAkuntansi = 1;
            perm.RealRecordingTime = DateTime.Now;
            if (PermBLL.AddPermPenyTransferBarang(perm) > 0)
            {
                //  this.ClearForm();
                MessageBox.Show("Inventory Adjusment successfully added !");
            }
            else
            {
                MessageBox.Show("Inventory Adjusment failed to add !");
            }
            if (DGSKUInventoryAdjusment.Items.Count > 0)
            {
                foreach (var item in DGSKUInventoryAdjusment.Items)
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
                        if (permBLL.EditInventory(oNewData1, perm) == true)
                        {
                        }
                    }
                }
                InventoryAdjusment v = new InventoryAdjusment();
                Switcher.Switchnewinventoryadjusmen(v);
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
            InventoryAdjusment v = new InventoryAdjusment();
            Switcher.Switchnewinventoryadjusmen(v);
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

        private void TxtRefferenceNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtRefferenceNumber.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtRefferenceNumber.Text = "";
                    return;
                }

            }
        }
    }
}
             
    

