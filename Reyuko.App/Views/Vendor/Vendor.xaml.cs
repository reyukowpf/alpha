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
using Path = System.IO.Path;

namespace Reyuko.App.Views.Vendor
{
    /// <summary>

    /// </summary>
    public partial class Vendor : UserControl
    {
        public Vendor()
        {
            InitializeComponent();
            Switcher.pageSwitchvendor = this;
            this.Init();
        }
        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
        public IEnumerable<Kontak> Kontaks { get; set; }
        public Kontak KontakSelected { get; set; }
        public bool isEdit = false;
        private int pageIndex = 1;
        private int pageSize = 10;

        private void Init()
        {
            this.ClearForm();
            this.LoadKontak("");
        }

        private void ClearForm()
        {
            this.KontakSelected = null;

            txtName.Text = "";
            txtType.Text = "";
            txtVendorID.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtGender.Text = "";
            txtCountry.Text = "";
            txtAddress.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtZip.Text = "";
            txtMap.Text = "";
            txtPosition.Text = "";
            txtTaxID.Text = "";
            txtCreditLimit.Text = "";
            txtBankName.Text = "";
            txtAccountNo.Text = "";
            txtAccountName.Text = "";
            txtRemarks.Text = "";
            imgPhoto.Source = null;

            tabPIC1.IsEnabled = false;
            tabPIC1.Header = "PIC 1";
            txtNamePIC1.Text = "";
            txtPhonePIC1.Text = "";
            txtEmailPIC1.Text = "";
            txtGenderPIC1.Text = "";
            txtAddressPIC1.Text = "";
            txtCityPIC1.Text = "";
            txtStatePIC1.Text = "";
            txtZipPIC1.Text = "";
            txtMapPIC1.Text = "";
            txtPositionPIC1.Text = "";
            txtRemarksPIC1.Text = "";
            imgPhotoPIC1.Source = null;

            tabPIC2.IsEnabled = false;
            tabPIC2.Header = "PIC 2";
            txtNamePIC2.Text = "";
            txtPhonePIC2.Text = "";
            txtEmailPIC2.Text = "";
            txtGenderPIC2.Text = "";
            txtAddressPIC2.Text = "";
            txtCityPIC2.Text = "";
            txtStatePIC2.Text = "";
            txtZipPIC2.Text = "";
            txtMapPIC2.Text = "";
            txtPositionPIC2.Text = "";
            txtRemarksPIC2.Text = "";
            imgPhotoPIC2.Source = null;

            tabPIC3.IsEnabled = false;
            tabPIC3.Header = "PIC 3";
            txtNamePIC3.Text = "";
            txtPhonePIC3.Text = "";
            txtEmailPIC3.Text = "";
            txtGenderPIC3.Text = "";
            txtAddressPIC3.Text = "";
            txtCityPIC3.Text = "";
            txtStatePIC3.Text = "";
            txtZipPIC3.Text = "";
            txtMapPIC3.Text = "";
            txtPositionPIC3.Text = "";
            txtRemarksPIC3.Text = "";
            imgPhotoPIC3.Source = null;

        }

        public void LoadKontak(string NamaA)
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.Kontaks = uow.Kontak.GetAll().Where(m => m.TypeKontak.ToLower() == "vendor");
                List<Kontak> itemSource = new List<Kontak>();
                if (!string.IsNullOrEmpty(NamaA))
                    itemSource = this.Kontaks.Where(m => m.NamaA.Contains(NamaA)).ToList();
                else
                    itemSource = this.Kontaks.ToList();
                LiDataVendor.ItemsSource = itemSource;
            }
        }

        private void BtnNew_Click(object sender, RoutedEventArgs e)
        {
            this.isEdit = false;
            NewVendors s = new NewVendors(this);
            Switcher.Switchvendor(s);
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            this.isEdit = true;
            NewVendors s = new NewVendors(this);
            Switcher.Switchvendor(s);
        }

        private void Other_Click(object sender, RoutedEventArgs e)
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

        private void Outstanding_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Payment_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (this.KontakSelected == null)
            {
                MessageBox.Show("Vendor belum dipilih!");
            }
            else
            {
                KontakBLL KontakBLL = new KontakBLL();
                if (KontakBLL.RemoveKontak(this.KontakSelected.Id) == true)
                {
                    MessageBox.Show("Vendor berhasil dihapus");
                    this.LoadKontak("");
                    this.KontakSelected = null;
                }
            }
        }

        private void LiDataVendor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.ClearForm();
            if (LiDataVendor.SelectedItem != null)
            {
                this.KontakSelected = (Kontak)LiDataVendor.SelectedItem;
                if (this.KontakSelected != null)
                {
                    using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
                    {
                        txtName.Text = this.KontakSelected.NamaA;
                        txtType.Text = this.KontakSelected.TypeKontak;
                        txtVendorID.Text = this.KontakSelected.KontakID;
                        txtPhone.Text = this.KontakSelected.NoHPA;
                        txtEmail.Text = this.KontakSelected.EmailA;
                        txtGender.Text = "Male";
                        if (this.KontakSelected.GenderA != true)
                            txtGender.Text = "Female";
                        txtCountry.Text = this.KontakSelected.NegaraA;
                        txtAddress.Text = this.KontakSelected.AlamatA;
                        txtCity.Text = this.KontakSelected.KotaA;
                        txtState.Text = this.KontakSelected.PropinsiA;
                        txtZip.Text = this.KontakSelected.KodePosA;
                        txtMap.Text = this.KontakSelected.MapLocationA;
                        txtPosition.Text = this.KontakSelected.PositionA;
                        txtTaxID.Text = this.KontakSelected.NPWPA;
                        txtCreditLimit.Text = this.KontakSelected.BatasKreditA.ToString();
                        txtBankName.Text = this.KontakSelected.NamaBankA;
                        txtAccountNo.Text = this.KontakSelected.NoRekA.ToString();
                        txtAccountName.Text = this.KontakSelected.NamaBukuRekening;
                        txtRemarks.Text = this.KontakSelected.KeteranganA;
                        if (!string.IsNullOrEmpty(this.KontakSelected.UploadPhotoA))
                            imgPhoto.Source = new BitmapImage(new Uri(Path.GetFullPath(this.KontakSelected.UploadPhotoA)));

                        if (this.KontakSelected != null)
                        {
                            var oKlasifikasi = uow.KlasifikasiKontak.Get(this.KontakSelected.IdKlasifikasiKontak.GetValueOrDefault(0));
                            if (oKlasifikasi != null)
                            {
                                if (oKlasifikasi.CheckboxPIC1 == true)
                                {
                                    tabPIC1.IsEnabled = true;
                                    txtNamePIC1.Text = this.KontakSelected.NamaB;
                                    txtPhonePIC1.Text = this.KontakSelected.NoHPB;
                                    txtEmailPIC1.Text = this.KontakSelected.EmailB;
                                    if (oKlasifikasi.CheckboxGenderPIC1 == true)
                                    {
                                        txtGenderPIC1.Text = "Male";
                                        if (this.KontakSelected.GenderB != true)
                                            txtGenderPIC2.Text = "Female";
                                    }
                                    txtAddressPIC1.Text = this.KontakSelected.AlamatB;
                                    txtCityPIC1.Text = this.KontakSelected.KotaB;
                                    txtStatePIC1.Text = this.KontakSelected.PropinsiB;
                                    txtZipPIC1.Text = this.KontakSelected.KodePosB;
                                    txtMapPIC1.Text = this.KontakSelected.MapLocationB;
                                    if (oKlasifikasi.CheckboxPositionPIC1 == true)
                                        txtPositionPIC1.Text = this.KontakSelected.PositionB;
                                    txtRemarksPIC1.Text = this.KontakSelected.KeteranganB;
                                    if (!string.IsNullOrEmpty(this.KontakSelected.UploadPhotoB))
                                        imgPhotoPIC1.Source = new BitmapImage(new Uri(Path.GetFullPath(this.KontakSelected.UploadPhotoB)));

                                    if (oKlasifikasi.CheckboxPIC2 == true)
                                    {
                                        tabPIC2.IsEnabled = true;
                                        txtNamePIC2.Text = this.KontakSelected.NamaC;
                                        txtPhonePIC2.Text = this.KontakSelected.NoHPC;
                                        txtEmailPIC2.Text = this.KontakSelected.EmailC;
                                        if (oKlasifikasi.CheckboxGenderPIC2 == true)
                                        {
                                            txtGenderPIC2.Text = "Male";
                                            if (this.KontakSelected.GenderB != true)
                                                txtGenderPIC2.Text = "Female";
                                        }
                                        txtAddressPIC2.Text = this.KontakSelected.AlamatC;
                                        txtCityPIC2.Text = this.KontakSelected.KotaC;
                                        txtStatePIC2.Text = this.KontakSelected.PropinsiC;
                                        txtZipPIC2.Text = this.KontakSelected.KodePosC;
                                        txtMapPIC2.Text = this.KontakSelected.MapLocationC;
                                        if (oKlasifikasi.CheckboxPositionPIC2 == true)
                                            txtPositionPIC2.Text = this.KontakSelected.PositionC;
                                        txtRemarksPIC2.Text = this.KontakSelected.KeteranganC;
                                        if (!string.IsNullOrEmpty(this.KontakSelected.UploadPhotoC))
                                            imgPhotoPIC2.Source = new BitmapImage(new Uri(Path.GetFullPath(this.KontakSelected.UploadPhotoC)));

                                        if (oKlasifikasi.CheckboxPIC3 == true)
                                        {
                                            tabPIC3.IsEnabled = true;
                                            txtNamePIC3.Text = this.KontakSelected.NamaD;
                                            txtPhonePIC3.Text = this.KontakSelected.NoHPD;
                                            txtEmailPIC3.Text = this.KontakSelected.EmailD;
                                            if (oKlasifikasi.CheckboxGenderPIC3 == true)
                                            {
                                                txtGenderPIC3.Text = "Male";
                                                if (this.KontakSelected.GenderB != true)
                                                    txtGenderPIC2.Text = "Female";
                                            }
                                            txtAddressPIC3.Text = this.KontakSelected.AlamatD;
                                            txtCityPIC3.Text = this.KontakSelected.KotaD;
                                            txtStatePIC3.Text = this.KontakSelected.PropinsiD;
                                            txtZipPIC3.Text = this.KontakSelected.KodePosD;
                                            txtMapPIC3.Text = this.KontakSelected.MapLocationD;
                                            if (oKlasifikasi.CheckboxPositionPIC3 == true)
                                                txtPositionPIC3.Text = this.KontakSelected.PositionD;
                                            txtRemarksPIC3.Text = this.KontakSelected.KeteranganD;
                                            if (!string.IsNullOrEmpty(this.KontakSelected.UploadPhotoC))
                                                imgPhotoPIC3.Source = new BitmapImage(new Uri(Path.GetFullPath(this.KontakSelected.UploadPhotoC)));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}



