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
using Microsoft.Win32;
using System.IO;
using Path = System.IO.Path;
using Reyuko.Utils.Common;
using System.Text.RegularExpressions;

namespace Reyuko.App.Views.Employee
{
    /// <summary>

    /// </summary>
    public partial class Employeeshoping : Window
    {
        public Employeeshoping(PurchaseDocument.NewShopingchart EmployeeForm)
        {
            InitializeComponent();
            this.EmployeeForm = EmployeeForm;
            this.Init();
        }

      
        public object UserControl { get; internal set; }
        private PurchaseDocument.NewShopingchart EmployeeForm;
        private IEnumerable<KlasifikasiKontak> KlasifikasiKontaks { get; set; }
        private KlasifikasiKontak KlasifikasiKontakSelected { get; set; }
        private IEnumerable<Alamat> Alamats { get; set; }
        private Alamat NegaraSelected { get; set; }
        private Alamat PropinsiSelected { get; set; }
        private Alamat NegaraPIC1Selected { get; set; }
        private Alamat PropinsiPIC1Selected { get; set; }
        private Alamat NegaraPIC2Selected { get; set; }
        private Alamat PropinsiPIC2Selected { get; set; }
        private Alamat NegaraPIC3Selected { get; set; }
        private Alamat PropinsiPIC3Selected { get; set; }
        private IEnumerable<GolonganKontak> GolonganKontak { get; set; }
        private GolonganKontak GolonganKontakSelected { get; set; }
        private TypeKontak TypeKontak { get; set; }
        private IEnumerable<ListLokasi> ListLokasis { get; set; }
        private ListLokasi ListLokasiSelected { get; set; }
        private IEnumerable<ListDataDepartemen> ListDataDepartemens { get; set; }
        private ListDataDepartemen ListDataDepartemenselected { get; set; }
        private IEnumerable<DataProyek> DataProyeks { get; set; }
        private DataProyek DataProyekSelected { get; set; }
        private string Photo { get; set; }
        private string PhotoPIC1 { get; set; }
        private string PhotoPIC2 { get; set; }
        private string PhotoPIC3 { get; set; }

        private void Init()
        {
            this.ClearForm();
            this.LoadTypeKontak();
            this.LoadAlamat();
            this.LoadComboKasifikasiKontak();
            this.LoadComboCountry();
            this.LoadComboGolongan();
            this.LoadComboListLokasi();
            this.LoadComboListDataDepartemen();
            this.LoadComboDataProyek();
            if (this.EmployeeForm.isEdit == true)
                this.LoadKontak();
        }

        private void ClearForm()
        {
            this.KlasifikasiKontakSelected = null;
            this.NegaraSelected = null;
            this.PropinsiSelected = null;
            this.GolonganKontakSelected = null;
            this.ListLokasiSelected = null;
            this.ListDataDepartemenselected = null;
            this.DataProyekSelected = null;

            this.Photo = "";
           
            cbClasification.SelectedIndex = -1;
            txtEmployeeID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            rdMale.IsChecked = true;
            rdFemale.IsChecked = false;
            cbCountry.SelectedIndex = -1;
            txtAddress.Text = "";
            txtCity.Text = "";
            cbState.SelectedIndex = -1;
            txtZip.Text = "";
            txtMap.Text = "";
            txtPosition.Text = "";
            cbSalaryGroup.SelectedIndex = -1;
            cbDepartment.SelectedIndex = -1;
            cbLocation.SelectedIndex = -1;
            cbProject.SelectedIndex = -1;
            txtTaxID.Text = "";
            txtBankName.Text = "";
            txtBankAccount.Text = "";
            txtAccountName.Text = "";
            txtRemarks.Text = "";
            imgPhoto.Source = null;

            
        }

        private void LoadTypeKontak()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.TypeKontak = uow.TypeKontak.SingleOrDefault(m => m.Type.ToLower() == "employee");
            }
        }

        private void LoadComboKasifikasiKontak()
        {
            cbClasification.SelectedIndex = -1;
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.KlasifikasiKontaks = uow.KlasifikasiKontak.GetAll();
                cbClasification.ItemsSource = this.KlasifikasiKontaks;
                cbClasification.DisplayMemberPath = "NamaKlasifikasiKontak";
                cbClasification.SelectedValuePath = "Id";
            }
        }

        private void LoadAlamat()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.Alamats = uow.Alamat.GetAll();
            }
        }

        private void LoadComboCountry()
        {
            var countries = this.Alamats.Where(m => m.Type.ToLower() == "negara");
            cbCountry.SelectedIndex = -1;
            cbCountry.ItemsSource = countries;
            cbCountry.DisplayMemberPath = "Nama";
            cbCountry.SelectedValuePath = "Id";

           
        }

        private void LoadComboGolongan()
        {
            cbSalaryGroup.SelectedIndex = -1;
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.GolonganKontak = uow.GolonganKontak.GetAll();
                cbSalaryGroup.ItemsSource = this.GolonganKontak;
                cbSalaryGroup.DisplayMemberPath = "NamaGolongan";
                cbSalaryGroup.SelectedValuePath = "Id";
            }
        }

        private void LoadComboListLokasi()
        {
            cbLocation.SelectedIndex = -1;
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.ListLokasis = uow.ListLokasi.GetAll();
                cbLocation.ItemsSource = this.ListLokasis;
                cbLocation.DisplayMemberPath = "NamaTempatLokasi";
                cbLocation.SelectedValuePath = "IdLokasi";
            }
        }

        private void LoadComboListDataDepartemen()
        {
            cbDepartment.SelectedIndex = -1;
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.ListDataDepartemens = uow.ListDataDepartemen.GetAll();
                cbDepartment.ItemsSource = this.ListDataDepartemens;
                cbDepartment.DisplayMemberPath = "NamaDepartemen";
                cbDepartment.SelectedValuePath = "IdDepartemen";
            }
        }

        private void LoadComboDataProyek()
        {
            cbProject.SelectedIndex = -1;
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.DataProyeks = uow.DataProyek.GetAll();
                cbProject.ItemsSource = this.DataProyeks;
                cbProject.DisplayMemberPath = "NamaProyek";
                cbProject.SelectedValuePath = "Id";
            }
        }


        private void LoadKontak()
        {
           
                
        }

        private Kontak GetData()
        {
            string message = "";
            if (this.KlasifikasiKontakSelected == null)
                message += "Klasifikasi kontak belum dipilih\n";
            if (string.IsNullOrEmpty(txtEmployeeID.Text))
                message += "Employee Id belum diisi\n";
            if (string.IsNullOrEmpty(txtName.Text))
                message += "Nama Employee belum diisi\n";

            Kontak oData = new Kontak();

            oData.IdTypeKontak = this.TypeKontak.Id;
            oData.TypeKontak = this.TypeKontak.Type;
            if (this.KlasifikasiKontakSelected != null)
            {
                oData.IdKlasifikasiKontak = this.KlasifikasiKontakSelected.Id;
                oData.KlasifikasiKontak = this.KlasifikasiKontakSelected.NamaKlasifikasiKontak;
            }
            oData.KontakID = txtEmployeeID.Text;
            oData.NamaA = txtName.Text;
            oData.NoHPA = txtPhone.Text;
            oData.EmailA = txtEmail.Text;
            oData.GenderA = rdMale.IsChecked == true ? true : false;
            if (this.NegaraSelected != null)
            {
                oData.IdNegaraA = this.NegaraSelected.Id;
                oData.NegaraA = this.NegaraSelected.Nama;
            }
            oData.AlamatA = txtAddress.Text;
            oData.KotaA = txtCity.Text;
            if (this.PropinsiSelected != null)
            {
                oData.IdPropinsiA = this.PropinsiSelected.Id;
                oData.PropinsiA = this.PropinsiSelected.Nama;
            }
            oData.KodePosA = txtZip.Text;
            oData.MapLocationA = txtMap.Text;
            oData.PositionA = txtPosition.Text;
            oData.KeteranganA = txtRemarks.Text;
            oData.UploadPhotoA = this.Photo;

          
            if (this.GolonganKontakSelected != null)
            {
                oData.IdGolongan = this.GolonganKontakSelected.Id;
                oData.NamaGolongan = this.GolonganKontakSelected.NamaGolongan;
            }
            if (this.ListLokasiSelected != null) {
                oData.IdLokasi = this.ListLokasiSelected.IdLokasi;
                oData.Lokasi = this.ListLokasiSelected.NamaTempatLokasi;
            }
            if (this.ListDataDepartemenselected != null)
            {
                oData.IdDepartemen = this.ListDataDepartemenselected.IdDepartemen;
                oData.NamaDepartemen = this.ListDataDepartemenselected.NamaDepartemen;
            }
            if (this.DataProyekSelected != null)
            {
                oData.IdProyek = this.DataProyekSelected.Id;
                oData.Proyek = this.DataProyekSelected.NamaProyek;
            }

            oData.NPWPA = txtTaxID.Text;
            oData.NamaBankA = txtBankName.Text;
           // oData.NoRekA = double.Parse(txtBankAccount.Text);
            oData.NamaBukuRekening = txtAccountName.Text;
            oData.IdUserId = null;
            oData.RealTimeRecording = DateTime.Now;

            return oData;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (cbClasification.Text == "" || txtEmployeeID.Text == "" || txtName.Text == "" || txtPhone.Text == "" || txtEmail.Text == "" || cbCountry.Text == "" || txtAddress.Text == "" || txtCity.Text == "" || cbState.Text == "" || txtZip.Text == "" || txtMap.Text == "" || txtPosition.Text == "" || cbSalaryGroup.Text == "" || cbDepartment.Text == "" || cbLocation.Text == "" || cbProject.Text == "" || txtTaxID.Text == "" || txtBankName.Text == "" || txtBankAccount.Text == "" || txtAccountName.Text == "" || txtRemarks.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            KontakBLL KontakBLL = new KontakBLL();
                if (KontakBLL.AddKontak(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Employee successfully added !");
                    this.EmployeeForm.LoadEmployee();
                }
                else
                {
                    MessageBox.Show("Employee failed to add !");
                }
            Employee v = new Employee();
            Switcher.Switchnewemployee(v);
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Employee v = new Employee();
            Switcher.Switchnewemployee(v);
        }

        private void CbClasification_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.KlasifikasiKontakSelected = null;
            if (cbClasification.SelectedItem != null)
            {
                this.KlasifikasiKontakSelected = (KlasifikasiKontak)cbClasification.SelectedItem;
   
            }
        }

        private void CbCountry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.NegaraSelected = null;
            if (cbCountry.SelectedItem != null)
            {
                this.NegaraSelected = (Alamat)cbCountry.SelectedItem;
            }
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                int CountryId = Convert.ToInt32(cbCountry.SelectedValue);
                this.Alamats = uow.Alamat.GetAll().Where(x => x.IdParent == CountryId).ToList();
                cbState.ItemsSource = this.Alamats;
                cbState.DisplayMemberPath = "Nama";
                cbState.SelectedValuePath = "Id";
            }
        }

        private void CbState_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.PropinsiSelected = null;
            if (cbState.SelectedItem != null)
            {
                this.PropinsiSelected = (Alamat)cbState.SelectedItem;
            }
        }

        private void CbSalaryGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.GolonganKontakSelected = null;
            if (cbSalaryGroup.SelectedItem != null)
            {
                this.GolonganKontakSelected = (GolonganKontak)cbSalaryGroup.SelectedItem;
            }
        }

        private void CbCountryPIC1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void CbStatePIC1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void CbCountryPIC2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void CbStatePIC2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void CbCountryPIC3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void CbStatePIC3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void CbDepartment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.ListDataDepartemenselected = null;
            if (cbDepartment.SelectedItem != null)
            {
                this.ListDataDepartemenselected = (ListDataDepartemen)cbDepartment.SelectedItem;
            }
        }

        private void CbLocation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.ListLokasiSelected = null;
            if (cbLocation.SelectedItem != null)
            {
                this.ListLokasiSelected = (ListLokasi)cbLocation.SelectedItem;
            }
        }

        private void CbProject_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.DataProyekSelected = null;
            if (cbProject.SelectedItem != null)
            {
                this.DataProyekSelected = (DataProyek)cbProject.SelectedItem;
            }
        }

        private void BtnUploadPhoto_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;
            dlg.Filter = Helper.UploadFilter(Helper.enUploadType.Images);

            if ((bool)dlg.ShowDialog())
            {
                Stream file = dlg.OpenFile();
                string filename = dlg.SafeFileName;
                this.Photo = Helper.UploadFile(Helper.enUploadType.Images, file, filename);
                imgPhoto.Source = new BitmapImage(new Uri(Path.GetFullPath(this.Photo)));
            }
            else
            {
                MessageBox.Show("File not selected");
            }
        }

        private void BtnUploadPhotoPIC1_Click(object sender, RoutedEventArgs e)
        {
          }

        private void BtnUploadPhotoPIC2_Click(object sender, RoutedEventArgs e)
        {
        }

        private void BtnUploadPhotoPIC3_Click(object sender, RoutedEventArgs e)
        {
        }

        private void TxtEmployeeID_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TxtPhone_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtPhone.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtPhone.Text = "";
                    return;
                }

            }
        }

        private void TxtZip_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtZip.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtZip.Text = "";
                    return;
                }

            }
        }

        private void TxtTaxID_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtTaxID.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtTaxID.Text = "";
                    return;
                }

            }
        }

        private void TxtPhonePIC1_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void TxtZipPIC1_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void TxtPhonePIC2_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
        private void TxtZipPIC2_TextChanged(object sender, TextChangedEventArgs e)
        {
         
        }

        private void TxtPhonePIC3_TextChanged(object sender, TextChangedEventArgs e)
        {
         
        }

        private void TxtZipPIC3_TextChanged(object sender, TextChangedEventArgs e)
        {
         
        }

        private void TxtName_TextChanged(object sender, TextChangedEventArgs e)
        {
         
        }

        private void TxtCity_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtCity.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Harus Diisi Character");
                    txtCity.Text = "";
                    return;
                }

            }
        }

        private void TxtBankName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtBankName.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Harus Diisi Character");
                    txtBankName.Text = "";
                    return;
                }

            }
        }

        private void TxtBankAccount_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtBankAccount.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Harus Diisi Character");
                    txtBankAccount.Text = "";
                    return;
                }

            }
        }

        private void TxtAccountName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtAccountName.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Harus Diisi Character");
                    txtAccountName.Text = "";
                    return;
                }

            }
        }

        
        private void TxtEmail_OnLostFocus(object sender, RoutedEventArgs e)
        {
            // Baca inputan email menggunakan Lost Focus
            if (txtEmail.Text.Length == 0)
            {
                InfoMail.Content = "Empty";
            }
            else if (!Regex.IsMatch(txtEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                InfoMail.Content = "Invalid";
                txtEmail.Select(0, txtEmail.Text.Length);
            }

            else
            {
                InfoMail.Content = "OK";
            }
        }

            }
}
