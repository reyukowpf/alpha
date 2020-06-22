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

namespace Reyuko.App.Views.Vendor
{
    /// <summary>

    /// </summary>
    public partial class Vendorspurchasedelivery : Window
    {
        public Vendorspurchasedelivery(PurchaseDelivery.NewPurchaseDelivery VendorForm)
        {
            InitializeComponent();
            this.VendorForm = VendorForm;
            this.Init();
        }

        public object UserControl { get; internal set; }
        public PurchaseDelivery.NewPurchaseDelivery VendorForm;
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
        private TypeKontak TypeKontak { get; set; }
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
        }

        private void ClearForm()
        {
            this.KlasifikasiKontakSelected = null;
            this.NegaraSelected = null;
            this.NegaraPIC1Selected = null;
            this.NegaraPIC2Selected = null;
            this.NegaraPIC3Selected = null;
            this.PropinsiSelected = null;
            this.PropinsiPIC1Selected = null;
            this.PropinsiPIC2Selected = null;
            this.PropinsiPIC3Selected = null;

            this.Photo = "";
            this.PhotoPIC1 = "";
            this.PhotoPIC2 = "";
            this.PhotoPIC3 = "";

            cbClasification.SelectedIndex = -1;
            txtVendorID.Text = "";
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
            txtTaxID.Text = "";
            txtCredit.Text = "";
            txtBankName.Text = "";
            txtBankAccount.Text = "";
            txtAccountName.Text = "";
            txtNote.Text = "";
            imgPhoto.Source = null;
        }

        private void LoadTypeKontak()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.TypeKontak = uow.TypeKontak.SingleOrDefault(m => m.Type.ToLower() == "vendor");
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

        
        private Kontak GetData()
        {
            string message = "";
            if (this.KlasifikasiKontakSelected == null)
                message += "Contact classification has not been selected\n";
            if (string.IsNullOrEmpty(txtVendorID.Text))
                message += "Vendor Id not yet filled\n";
            if (string.IsNullOrEmpty(txtName.Text))
                message += "Vendor Name not yet filled\n";

            Kontak oData = new Kontak();

            oData.IdTypeKontak = this.TypeKontak.Id;
            oData.TypeKontak = this.TypeKontak.Type;
            if (this.KlasifikasiKontakSelected != null)
            {
                oData.IdKlasifikasiKontak = this.KlasifikasiKontakSelected.Id;
                oData.KlasifikasiKontak = this.KlasifikasiKontakSelected.NamaKlasifikasiKontak;
            }
            oData.KontakID = txtVendorID.Text;
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
            oData.KeteranganA = txtNote.Text;
            oData.UploadPhotoA = this.Photo;

            oData.RealTimeRecording = DateTime.Now;

            return oData;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (cbClasification.Text == "" || txtVendorID.Text == "" || txtName.Text == "" || txtPhone.Text == "" || txtEmail.Text == "" || cbCountry.Text == "" || txtAddress.Text == "" || txtCity.Text == "" || cbState.Text == "" || txtZip.Text == "" || txtMap.Text == "" || txtPosition.Text == "" || txtTaxID.Text == "" || txtCredit.Text == "" || txtBankName.Text == "" || txtBankAccount.Text == "" || txtAccountName.Text == "" || txtNote.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            KontakBLL KontakBLL = new KontakBLL();
            if (KontakBLL.AddKontak(this.GetData()) > 0)
            {
                this.ClearForm();
                MessageBox.Show("Vendor successfully added !");
                VendorForm.LoadVendor();
            }
            else
            {
                MessageBox.Show("Vendor failed to add !");
            }
            this.Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
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

        private void TxtPhone_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtPhone.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
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
                    MessageBox.Show("Must Have Numeric");
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
                    MessageBox.Show("Must Have Numeric");
                    txtTaxID.Text = "";
                    return;
                }

            }
        }

        private void TxtCredit_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtCredit.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtCredit.Text = "";
                    return;
                }

            }
        }


        private void TxtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtName.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtName.Text = "";
                    return;
                }

            }
        }

        private void TxtCity_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtCity.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
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
                    MessageBox.Show("Must Have Character");
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
                    MessageBox.Show("Must Have Numeric");
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
                    MessageBox.Show("Must Have Character");
                    txtAccountName.Text = "";
                    return;
                }

            }
        }


        private void TxtMap_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtMap.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtMap.Text = "";
                    return;
                }

            }
        }

        private void TxtPosition_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtPosition.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtPosition.Text = "";
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
