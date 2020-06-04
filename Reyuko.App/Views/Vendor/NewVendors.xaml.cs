﻿using Reyuko.BLL.Core;
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
    public partial class NewVendors : UserControl
    {
        public NewVendors(Vendor VendorForm)
        {
            InitializeComponent();
            this.VendorForm = VendorForm;
            Switcher.pageSwitchernewvendor = this;
            this.Init();
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
        public object UserControl { get; internal set; }
        private Vendor VendorForm;
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
            if (this.VendorForm.isEdit == true)
                this.LoadKontak();
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

            tabPIC1.IsEnabled = false;
            tabPIC1.Header = "PIC 1";
            txtNamePIC1.Text = "";
            txtPhonePIC1.Text = "";
            txtEmailPIC1.Text = "";
            rdMalePIC1.IsChecked = true;
            rdFemalePIC1.IsChecked = false;
            cbCountryPIC1.SelectedIndex = -1;
            txtAddressPIC1.Text = "";
            txtCityPIC1.Text = "";
            cbStatePIC1.Text = "";
            txtZip.Text = "";
            txtMapPIC1.Text = "";
            txtPositionPIC1.Text = "";
            txtNotePIC1.Text = "";
            imgPhotoPIC1.Source = null;

            tabPIC2.IsEnabled = false;
            tabPIC2.Header = "PIC 2";
            txtNamePIC2.Text = "";
            txtPhonePIC2.Text = "";
            txtEmailPIC2.Text = "";
            rdMalePIC2.IsChecked = true;
            rdFemalePIC2.IsChecked = false;
            cbCountryPIC2.SelectedIndex = -1;
            txtAddressPIC2.Text = "";
            txtCityPIC2.Text = "";
            cbStatePIC2.Text = "";
            txtZip.Text = "";
            txtMapPIC2.Text = "";
            txtPositionPIC2.Text = "";
            txtNotePIC2.Text = "";
            imgPhotoPIC2.Source = null;

            tabPIC3.IsEnabled = false;
            tabPIC3.Header = "PIC 3";
            txtNamePIC3.Text = "";
            txtPhonePIC3.Text = "";
            txtEmailPIC3.Text = "";
            rdMalePIC3.IsChecked = true;
            rdFemalePIC3.IsChecked = false;
            cbCountryPIC3.SelectedIndex = -1;
            txtAddressPIC3.Text = "";
            txtCityPIC3.Text = "";
            cbStatePIC3.Text = "";
            txtZip.Text = "";
            txtMapPIC3.Text = "";
            txtPositionPIC3.Text = "";
            txtNotePIC3.Text = "";
            imgPhotoPIC3.Source = null;

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

            cbCountryPIC1.SelectedIndex = -1;
            cbCountryPIC1.ItemsSource = countries;
            cbCountryPIC1.DisplayMemberPath = "Nama";
            cbCountryPIC1.SelectedValuePath = "Id";

            cbCountryPIC2.SelectedIndex = -1;
            cbCountryPIC2.ItemsSource = countries;
            cbCountryPIC2.DisplayMemberPath = "Nama";
            cbCountryPIC2.SelectedValuePath = "Id";

            cbCountryPIC3.SelectedIndex = -1;
            cbCountryPIC3.ItemsSource = countries;
            cbCountryPIC3.DisplayMemberPath = "Nama";
            cbCountryPIC3.SelectedValuePath = "Id";

        }

        private void LoadKontak()
        {
            this.ClearForm();
            if (this.VendorForm != null && this.VendorForm.KontakSelected != null)
            {

                this.KlasifikasiKontakSelected = this.KlasifikasiKontaks.Where(m => m.Id == this.VendorForm.KontakSelected.IdKlasifikasiKontak).FirstOrDefault();
                this.NegaraSelected = this.Alamats.Where(m => m.Id == this.VendorForm.KontakSelected.IdNegaraA).FirstOrDefault();
                this.NegaraPIC1Selected = this.Alamats.Where(m => m.Id == this.VendorForm.KontakSelected.IdNegaraB).FirstOrDefault();
                this.NegaraPIC2Selected = this.Alamats.Where(m => m.Id == this.VendorForm.KontakSelected.IdNegaraC).FirstOrDefault();
                this.NegaraPIC3Selected = this.Alamats.Where(m => m.Id == this.VendorForm.KontakSelected.IdNegaraD).FirstOrDefault();
                this.PropinsiSelected = this.Alamats.Where(m => m.Id == this.VendorForm.KontakSelected.IdPropinsiA).FirstOrDefault();
                this.PropinsiPIC1Selected = this.Alamats.Where(m => m.Id == this.VendorForm.KontakSelected.IdPropinsiB).FirstOrDefault(); ;
                this.PropinsiPIC2Selected = this.Alamats.Where(m => m.Id == this.VendorForm.KontakSelected.IdPropinsiC).FirstOrDefault(); ;
                this.PropinsiPIC3Selected = this.Alamats.Where(m => m.Id == this.VendorForm.KontakSelected.IdPropinsiD).FirstOrDefault(); ;

                cbClasification.SelectedValue = this.VendorForm.KontakSelected.IdKlasifikasiKontak;
                txtVendorID.Text = this.VendorForm.KontakSelected.KontakID;
                txtName.Text = this.VendorForm.KontakSelected.NamaA;
                txtPhone.Text = this.VendorForm.KontakSelected.NoHPA;
                txtEmail.Text = this.VendorForm.KontakSelected.EmailA;
                if (this.VendorForm.KontakSelected.GenderA == true)
                {
                    rdMale.IsChecked = true;
                    rdFemale.IsChecked = false;
                }
                else
                {
                    rdMale.IsChecked = false;
                    rdFemale.IsChecked = true;
                }
                cbCountry.SelectedValue = this.VendorForm.KontakSelected.IdNegaraA;
                txtAddress.Text = this.VendorForm.KontakSelected.AlamatA;
                txtCity.Text = this.VendorForm.KontakSelected.KotaA;
                cbState.SelectedValue = this.VendorForm.KontakSelected.IdPropinsiA;
                txtZip.Text = this.VendorForm.KontakSelected.KodePosA;
                txtMap.Text = this.VendorForm.KontakSelected.MapLocationA;
                txtPosition.Text = this.VendorForm.KontakSelected.PositionA;
                txtTaxID.Text = this.VendorForm.KontakSelected.NPWPA;
                txtCredit.Text = this.VendorForm.KontakSelected.BatasKreditA.ToString();
                txtBankName.Text = this.VendorForm.KontakSelected.NamaBankA;
                txtBankAccount.Text = this.VendorForm.KontakSelected.NoRekA.ToString();
                txtAccountName.Text = this.VendorForm.KontakSelected.NamaBukuRekening;
                txtNote.Text = this.VendorForm.KontakSelected.KeteranganA;
                if (!string.IsNullOrEmpty(this.VendorForm.KontakSelected.UploadPhotoA))
                    imgPhoto.Source = new BitmapImage(new Uri(Path.GetFullPath(this.VendorForm.KontakSelected.UploadPhotoA)));
                this.Photo = this.VendorForm.KontakSelected.UploadPhotoA;

                if (this.KlasifikasiKontakSelected.CheckboxPIC1 == true)
                {
                    if (this.KlasifikasiKontakSelected.CheckboxGenderPIC1 == true)
                    {
                        lblGenderPIC1.Visibility = Visibility.Visible;
                        rdMalePIC1.Visibility = Visibility.Visible;
                        rdFemalePIC1.Visibility = Visibility.Visible;
                    }
                    if (this.KlasifikasiKontakSelected.CheckboxPositionPIC1 == true)
                    {
                        lblPositionPIC1.Visibility = Visibility.Visible;
                        txtPositionPIC1.Visibility = Visibility.Visible;
                    }

                    tabPIC1.IsEnabled = true;
                    txtNamePIC1.Text = this.VendorForm.KontakSelected.NamaB;
                    txtPhonePIC1.Text = this.VendorForm.KontakSelected.NoHPB;
                    txtEmailPIC1.Text = this.VendorForm.KontakSelected.EmailB;
                    if (this.VendorForm.KontakSelected.GenderB == true)
                    {
                        rdMalePIC1.IsChecked = true;
                        rdFemalePIC1.IsChecked = false;
                    }
                    else
                    {
                        rdMalePIC1.IsChecked = false;
                        rdFemalePIC1.IsChecked = true;
                    }
                    cbCountryPIC1.SelectedValue = this.VendorForm.KontakSelected.IdNegaraB;
                    txtAddressPIC1.Text = this.VendorForm.KontakSelected.AlamatB;
                    txtCityPIC1.Text = this.VendorForm.KontakSelected.KotaB;
                    cbStatePIC1.SelectedValue = this.VendorForm.KontakSelected.IdPropinsiB;
                    txtZip.Text = this.VendorForm.KontakSelected.KodePosB;
                    txtMapPIC1.Text = this.VendorForm.KontakSelected.MapLocationB;
                    txtPositionPIC1.Text = this.VendorForm.KontakSelected.PositionB;
                    txtNotePIC1.Text = this.VendorForm.KontakSelected.KeteranganB;
                    if (!string.IsNullOrEmpty(this.VendorForm.KontakSelected.UploadPhotoB))
                        imgPhotoPIC1.Source = new BitmapImage(new Uri(Path.GetFullPath(this.VendorForm.KontakSelected.UploadPhotoB))); ;
                    this.PhotoPIC1 = this.VendorForm.KontakSelected.UploadPhotoB;

                }

                if (this.KlasifikasiKontakSelected.CheckboxPIC2 == true)
                {
                    if (this.KlasifikasiKontakSelected.CheckboxGenderPIC2 == true)
                    {
                        lblGenderPIC2.Visibility = Visibility.Visible;
                        rdMalePIC2.Visibility = Visibility.Visible;
                        rdFemalePIC2.Visibility = Visibility.Visible;
                    }
                    if (this.KlasifikasiKontakSelected.CheckboxPositionPIC2 == true)
                    {
                        lblPositionPIC2.Visibility = Visibility.Visible;
                        txtPositionPIC2.Visibility = Visibility.Visible;
                    }

                    tabPIC2.IsEnabled = true;
                    txtNamePIC2.Text = this.VendorForm.KontakSelected.NamaC;
                    txtPhonePIC2.Text = this.VendorForm.KontakSelected.NoHPC;
                    txtEmailPIC2.Text = this.VendorForm.KontakSelected.EmailC;
                    if (this.VendorForm.KontakSelected.GenderB == true)
                    {
                        rdMalePIC2.IsChecked = true;
                        rdFemalePIC2.IsChecked = false;
                    }
                    else
                    {
                        rdMalePIC2.IsChecked = false;
                        rdFemalePIC2.IsChecked = true;
                    }
                    cbCountryPIC2.SelectedValue = this.VendorForm.KontakSelected.IdNegaraC;
                    txtAddressPIC2.Text = this.VendorForm.KontakSelected.AlamatC;
                    txtCityPIC2.Text = this.VendorForm.KontakSelected.KotaC;
                    cbStatePIC2.SelectedValue = this.VendorForm.KontakSelected.IdPropinsiC;
                    txtZip.Text = this.VendorForm.KontakSelected.KodePosC;
                    txtMapPIC2.Text = this.VendorForm.KontakSelected.MapLocationC;
                    txtPositionPIC2.Text = this.VendorForm.KontakSelected.PositionC;
                    txtNotePIC2.Text = this.VendorForm.KontakSelected.KeteranganC;
                    if (!string.IsNullOrEmpty(this.VendorForm.KontakSelected.UploadPhotoC))
                        imgPhotoPIC2.Source = new BitmapImage(new Uri(Path.GetFullPath(this.VendorForm.KontakSelected.UploadPhotoC))); ;
                    this.PhotoPIC2 = this.VendorForm.KontakSelected.UploadPhotoC;

                }

                if (this.KlasifikasiKontakSelected.CheckboxPIC3 == true)
                {
                    if (this.KlasifikasiKontakSelected.CheckboxGenderPIC3 == true)
                    {
                        lblGenderPIC3.Visibility = Visibility.Visible;
                        rdMalePIC3.Visibility = Visibility.Visible;
                        rdFemalePIC3.Visibility = Visibility.Visible;
                    }
                    if (this.KlasifikasiKontakSelected.CheckboxPositionPIC3 == true)
                    {
                        lblPositionPIC3.Visibility = Visibility.Visible;
                        txtPositionPIC3.Visibility = Visibility.Visible;
                    }

                    tabPIC3.IsEnabled = true;
                    txtNamePIC3.Text = this.VendorForm.KontakSelected.NamaD;
                    txtPhonePIC3.Text = this.VendorForm.KontakSelected.NoHPD;
                    txtEmailPIC3.Text = this.VendorForm.KontakSelected.EmailD;
                    if (this.VendorForm.KontakSelected.GenderB == true)
                    {
                        rdMalePIC3.IsChecked = true;
                        rdFemalePIC3.IsChecked = false;
                    }
                    else
                    {
                        rdMalePIC3.IsChecked = false;
                        rdFemalePIC3.IsChecked = true;
                    }
                    cbCountryPIC3.SelectedValue = this.VendorForm.KontakSelected.IdNegaraD;
                    txtAddressPIC3.Text = this.VendorForm.KontakSelected.AlamatD;
                    txtCityPIC3.Text = this.VendorForm.KontakSelected.KotaD;
                    cbStatePIC3.SelectedValue = this.VendorForm.KontakSelected.IdPropinsiD;
                    txtZip.Text = this.VendorForm.KontakSelected.KodePosD;
                    txtMapPIC3.Text = this.VendorForm.KontakSelected.MapLocationD;
                    txtPositionPIC3.Text = this.VendorForm.KontakSelected.PositionD;
                    txtNotePIC3.Text = this.VendorForm.KontakSelected.KeteranganD;
                    if (!string.IsNullOrEmpty(this.VendorForm.KontakSelected.UploadPhotoD))
                        imgPhotoPIC3.Source = new BitmapImage(new Uri(Path.GetFullPath(this.VendorForm.KontakSelected.UploadPhotoD))); ;
                    this.PhotoPIC3 = this.VendorForm.KontakSelected.UploadPhotoD;

                }
            }
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

            oData.NamaB = txtNamePIC1.Text;
            oData.NoHPB = txtPhonePIC1.Text;
            oData.EmailB = txtEmailPIC1.Text;
            oData.GenderB = rdMalePIC1.IsChecked == true ? true : false;
            if (this.NegaraPIC1Selected != null)
            {
                oData.IdNegaraB = this.NegaraPIC1Selected.Id;
                oData.NegaraB = this.NegaraPIC1Selected.Nama;
            }
            oData.AlamatB = txtAddressPIC1.Text;
            oData.KotaB = txtCityPIC1.Text;
            if (this.PropinsiPIC1Selected != null)
            {
                oData.IdPropinsiB = this.PropinsiPIC1Selected.Id;
                oData.PropinsiB = this.PropinsiPIC1Selected.Nama;
            }
            oData.KodePosB = txtZipPIC1.Text;
            oData.MapLocationB = txtMapPIC1.Text;
            oData.PositionB = txtPositionPIC1.Text;
            oData.KeteranganB = txtNotePIC1.Text;
            oData.UploadPhotoB = this.PhotoPIC1;

            oData.NamaC = txtNamePIC2.Text;
            oData.NoHPC = txtPhonePIC2.Text;
            oData.EmailC = txtEmailPIC2.Text;
            oData.GenderC = rdMalePIC2.IsChecked == true ? true : false;
            if (this.NegaraPIC2Selected != null)
            {
                oData.IdNegaraC = this.NegaraPIC2Selected.Id;
                oData.NegaraC = this.NegaraPIC2Selected.Nama;
            }
            oData.AlamatC = txtAddressPIC2.Text;
            oData.KotaC = txtCityPIC2.Text;
            if (this.PropinsiPIC2Selected != null)
            {
                oData.IdPropinsiC = this.PropinsiPIC2Selected.Id;
                oData.PropinsiC = this.PropinsiPIC2Selected.Nama;
            }
            oData.KodePosC = txtZipPIC2.Text;
            oData.MapLocationC = txtMapPIC2.Text;
            oData.PositionC = txtPositionPIC2.Text;
            oData.KeteranganC = txtNotePIC2.Text;
            oData.UploadPhotoC = this.PhotoPIC2;

            oData.NamaD = txtNamePIC3.Text;
            oData.NoHPD = txtPhonePIC3.Text;
            oData.EmailD = txtEmailPIC3.Text;
            oData.GenderD = rdMalePIC3.IsChecked == true ? true : false;
            if (this.NegaraPIC3Selected != null)
            {
                oData.IdNegaraD = this.NegaraPIC3Selected.Id;
                oData.NegaraD = this.NegaraPIC3Selected.Nama;
            }
            oData.AlamatD = txtAddressPIC3.Text;
            oData.KotaD = txtCityPIC3.Text;
            if (this.PropinsiPIC3Selected != null)
            {
                oData.IdPropinsiD = this.PropinsiPIC3Selected.Id;
                oData.PropinsiD = this.PropinsiPIC3Selected.Nama;
            }
            oData.KodePosD = txtZipPIC3.Text;
            oData.MapLocationD = txtMapPIC3.Text;
            oData.PositionD = txtPositionPIC3.Text;
            oData.KeteranganD = txtNotePIC3.Text;
            oData.UploadPhotoD = this.PhotoPIC3;

            oData.NPWPA = txtTaxID.Text;
            oData.BatasKreditA = txtCredit.Text;
            oData.NamaBankA = txtBankName.Text;
            oData.NoRekA = double.Parse(txtBankAccount.Text);
            oData.NamaBukuRekening = txtAccountName.Text;
            oData.IdUserId = null;
            oData.RealTimeRecording = DateTime.Now;

            if (this.VendorForm.KontakSelected != null)
            {
                oData.Id = this.VendorForm.KontakSelected.Id;
                oData.IdGolongan = this.VendorForm.KontakSelected.IdGolongan;
                oData.NamaGolongan = this.VendorForm.KontakSelected.NamaGolongan;
                oData.IdDepartemen = this.VendorForm.KontakSelected.IdDepartemen;
                oData.NamaDepartemen = this.VendorForm.KontakSelected.NamaDepartemen;
                oData.IdLokasi = this.VendorForm.KontakSelected.IdLokasi;
                oData.Lokasi = this.VendorForm.KontakSelected.Lokasi;
                oData.IdProyek = this.VendorForm.KontakSelected.IdProyek;
                oData.Proyek = this.VendorForm.KontakSelected.Proyek;
            }

            return oData;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (cbClasification.Text == "" || txtVendorID.Text == "" || txtName.Text == "" || txtPhone.Text == "" || txtEmail.Text == "" || cbCountry.Text == "" || txtAddress.Text == "" || txtCity.Text == "" || cbState.Text == "" || txtZip.Text == "" || txtMap.Text == "" || txtPosition.Text == "" || txtTaxID.Text == "" || txtCredit.Text == "" || txtBankName.Text == "" || txtBankAccount.Text == "" || txtAccountName.Text == "" )
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            KontakBLL KontakBLL = new KontakBLL();
            if (this.VendorForm.isEdit == false)
            {
                if (KontakBLL.AddKontak(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Vendor successfully added !");
                    this.VendorForm.LoadKontak("");
                }
                else
                {
                    MessageBox.Show("Vendor failed to add !");
                }
            }
            else
            {
                if (KontakBLL.EditKontak(this.GetData()) == true)
                {
                    this.ClearForm();
                    MessageBox.Show("Vendor successfully changed !");
                    this.VendorForm.LoadKontak("");
                }
                else
                {
                    MessageBox.Show("Vendor failed to change !");
                }
            }
            Vendor v = new Vendor();
            Switcher.Switchnewvendor(v);
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Vendor v = new Vendor();
            Switcher.Switchnewvendor(v);
        }

        private void CbClasification_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.KlasifikasiKontakSelected = null;
            if (cbClasification.SelectedItem != null)
            {
                this.KlasifikasiKontakSelected = (KlasifikasiKontak)cbClasification.SelectedItem;
                tabPIC1.IsEnabled = false;
                tabPIC1.Header = "PIC 1";
                tabPIC2.IsEnabled = false;
                tabPIC2.Header = "PIC 2";
                tabPIC3.IsEnabled = false;
                tabPIC2.Header = "PIC 3";

                if (this.KlasifikasiKontakSelected.CheckboxPIC1 == true)
                {
                    tabPIC1.IsEnabled = true;
                    if (this.KlasifikasiKontakSelected.CheckboxGenderPIC1 == true)
                    {
                        lblGenderPIC1.Visibility = Visibility.Visible;
                        rdMalePIC1.Visibility = Visibility.Visible;
                        rdFemalePIC1.Visibility = Visibility.Visible;
                    }
                    if (this.KlasifikasiKontakSelected.CheckboxPositionPIC1 == true)
                    {
                        lblPositionPIC1.Visibility = Visibility.Visible;
                        txtPositionPIC1.Visibility = Visibility.Visible;
                    }
                }
                if (this.KlasifikasiKontakSelected.CheckboxPIC2 == true)
                {
                    tabPIC2.IsEnabled = true;
                    if (this.KlasifikasiKontakSelected.CheckboxGenderPIC2 == true)
                    {
                        lblGenderPIC2.Visibility = Visibility.Visible;
                        rdMalePIC2.Visibility = Visibility.Visible;
                        rdFemalePIC2.Visibility = Visibility.Visible;
                    }
                    if (this.KlasifikasiKontakSelected.CheckboxPositionPIC2 == true)
                    {
                        lblPositionPIC2.Visibility = Visibility.Visible;
                        txtPositionPIC2.Visibility = Visibility.Visible;
                    }
                }
                if (this.KlasifikasiKontakSelected.CheckboxPIC3 == true)
                {
                    tabPIC3.IsEnabled = true;
                    if (this.KlasifikasiKontakSelected.CheckboxGenderPIC3 == true)
                    {
                        lblGenderPIC3.Visibility = Visibility.Visible;
                        rdMalePIC3.Visibility = Visibility.Visible;
                        rdFemalePIC3.Visibility = Visibility.Visible;
                    }
                    if (this.KlasifikasiKontakSelected.CheckboxPositionPIC3 == true)
                    {
                        lblPositionPIC3.Visibility = Visibility.Visible;
                        txtPositionPIC3.Visibility = Visibility.Visible;
                    }
                }
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

        private void CbCountryPIC1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.NegaraPIC1Selected = null;
            if (cbCountryPIC1.SelectedItem != null)
            {
                this.NegaraPIC1Selected = (Alamat)cbCountryPIC1.SelectedItem;
            }
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                int CountryId = Convert.ToInt32(cbCountryPIC1.SelectedValue);
                this.Alamats = uow.Alamat.GetAll().Where(x => x.IdParent == CountryId).ToList();
                cbStatePIC1.ItemsSource = this.Alamats;
                cbStatePIC1.DisplayMemberPath = "Nama";
                cbStatePIC1.SelectedValuePath = "Id";
            }
        }

        private void CbStatePIC1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.PropinsiPIC1Selected = null;
            if (cbStatePIC1.SelectedItem != null)
            {
                this.PropinsiPIC1Selected = (Alamat)cbStatePIC1.SelectedItem;
            }
        }

        private void CbCountryPIC2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.NegaraPIC2Selected = null;
            if (cbCountryPIC2.SelectedItem != null)
            {
                this.NegaraPIC2Selected = (Alamat)cbCountryPIC2.SelectedItem;
            }
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                int CountryId = Convert.ToInt32(cbCountryPIC2.SelectedValue);
                this.Alamats = uow.Alamat.GetAll().Where(x => x.IdParent == CountryId).ToList();
                cbStatePIC2.ItemsSource = this.Alamats;
                cbStatePIC2.DisplayMemberPath = "Nama";
                cbStatePIC2.SelectedValuePath = "Id";
            }
        }

        private void CbStatePIC2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.PropinsiPIC2Selected = null;
            if (cbStatePIC2.SelectedItem != null)
            {
                this.PropinsiPIC2Selected = (Alamat)cbStatePIC2.SelectedItem;
            }
        }

        private void CbCountryPIC3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.NegaraPIC3Selected = null;
            if (cbCountryPIC3.SelectedItem != null)
            {
                this.NegaraPIC3Selected = (Alamat)cbCountryPIC3.SelectedItem;
            }
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                int CountryId = Convert.ToInt32(cbCountryPIC3.SelectedValue);
                this.Alamats = uow.Alamat.GetAll().Where(x => x.IdParent == CountryId).ToList();
                cbStatePIC3.ItemsSource = this.Alamats;
                cbStatePIC3.DisplayMemberPath = "Nama";
                cbStatePIC3.SelectedValuePath = "Id";
            }
        }

        private void CbStatePIC3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.PropinsiPIC3Selected = null;
            if (cbStatePIC3.SelectedItem != null)
            {
                this.PropinsiPIC3Selected = (Alamat)cbStatePIC3.SelectedItem;
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
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;
            dlg.Filter = Helper.UploadFilter(Helper.enUploadType.Images);

            if ((bool)dlg.ShowDialog())
            {
                Stream file = dlg.OpenFile();
                string filename = dlg.SafeFileName;
                this.PhotoPIC1 = Helper.UploadFile(Helper.enUploadType.Images, file, filename);
                imgPhotoPIC1.Source = new BitmapImage(new Uri(Path.GetFullPath(this.PhotoPIC1)));
            }
            else
            {
                MessageBox.Show("File not selected");
            }
        }

        private void BtnUploadPhotoPIC2_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;
            dlg.Filter = Helper.UploadFilter(Helper.enUploadType.Images);

            if ((bool)dlg.ShowDialog())
            {
                Stream file = dlg.OpenFile();
                string filename = dlg.SafeFileName;
                this.PhotoPIC2 = Helper.UploadFile(Helper.enUploadType.Images, file, filename);
                imgPhotoPIC2.Source = new BitmapImage(new Uri(Path.GetFullPath(this.PhotoPIC2)));
            }
            else
            {
                MessageBox.Show("File not selected");
            }
        }

        private void BtnUploadPhotoPIC3_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;
            dlg.Filter = Helper.UploadFilter(Helper.enUploadType.Images);

            if ((bool)dlg.ShowDialog())
            {
                Stream file = dlg.OpenFile();
                string filename = dlg.SafeFileName;
                this.PhotoPIC3 = Helper.UploadFile(Helper.enUploadType.Images, file, filename);
                imgPhotoPIC3.Source = new BitmapImage(new Uri(Path.GetFullPath(this.PhotoPIC3)));
            }
            else
            {
                MessageBox.Show("File not selected");
            }
        }

        private void TxtVendorID_TextChanged(object sender, TextChangedEventArgs e)
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

        private void TxtPhonePIC1_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtPhonePIC1.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtPhonePIC1.Text = "";
                    return;
                }

            }
        }

        private void TxtZipPIC1_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtZipPIC1.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtZipPIC1.Text = "";
                    return;
                }

            }
        }

        private void TxtPhonePIC2_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtPhonePIC2.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtPhonePIC2.Text = "";
                    return;
                }

            }
        }

        private void TxtZipPIC2_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtZipPIC2.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtZipPIC2.Text = "";
                    return;
                }

            }
        }

        private void TxtPhonePIC3_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtPhonePIC3.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtPhonePIC3.Text = "";
                    return;
                }

            }
        }

        private void TxtZipPIC3_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtZipPIC3.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtZipPIC3.Text = "";
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

        private void TxtNamePIC1_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtNamePIC1.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtNamePIC1.Text = "";
                    return;
                }

            }
        }

        private void TxtCityPIC1_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtCityPIC1.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtCityPIC1.Text = "";
                    return;
                }

            }
        }

        private void TxtNamePIC2_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtNamePIC2.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtNamePIC2.Text = "";
                    return;
                }

            }
        }

        private void TxtCityPIC2_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtCityPIC2.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtCityPIC2.Text = "";
                    return;
                }

            }
        }

        private void TxtNamePIC3_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtNamePIC3.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtNamePIC3.Text = "";
                    return;
                }

            }
        }

        private void TxtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtAddress_TextChanged(object sender, TextChangedEventArgs e)
        {

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

        private void TxtNote_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtEmailPIC1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtAddressPIC1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtMapPIC1_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtMapPIC1.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtMapPIC1.Text = "";
                    return;
                }

            }
        }

        private void TxtPositionPIC1_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtPositionPIC1.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtPositionPIC1.Text = "";
                    return;
                }

            }
        }

        private void TxtNotePIC1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtEmailPIC2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtAddressPIC2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtMapPIC2_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtMapPIC2.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtMapPIC2.Text = "";
                    return;
                }

            }
        }

        private void TxtPositionPIC2_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtPositionPIC2.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtPositionPIC2.Text = "";
                    return;
                }

            }
        }

        private void TxtEmailPIC3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtAddressPIC3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtCityPIC3_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtCityPIC3.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtCityPIC3.Text = "";
                    return;
                }

            }
        }

        private void TxtMapPIC3_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtMapPIC3.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtMapPIC3.Text = "";
                    return;
                }

            }
        }

        private void TxtPositionPIC3_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtPositionPIC3.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtPositionPIC3.Text = "";
                    return;
                }

            }
        }

        private void TxtNotePIC3_TextChanged(object sender, TextChangedEventArgs e)
        {

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

        private void TxtEmail1_OnLostFocus(object sender, RoutedEventArgs e)
        {
            // Baca inputan email menggunakan Lost Focus
            if (txtEmailPIC1.Text.Length == 0)
            {
                InfoMail1.Content = "Empty";
            }
            else if (!Regex.IsMatch(txtEmailPIC1.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                InfoMail1.Content = "Invalid";
                txtEmailPIC1.Select(0, txtEmailPIC1.Text.Length);
            }

            else
            {
                InfoMail1.Content = "OK";
            }
        }

        private void TxtEmail2_OnLostFocus(object sender, RoutedEventArgs e)
        {
            // Baca inputan email menggunakan Lost Focus
            if (txtEmailPIC2.Text.Length == 0)
            {
                InfoMail2.Content = "Empty";
            }
            else if (!Regex.IsMatch(txtEmailPIC2.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                InfoMail2.Content = "Invalid";
                txtEmailPIC2.Select(0, txtEmailPIC2.Text.Length);
            }

            else
            {
                InfoMail2.Content = "OK";
            }
        }

        private void TxtEmail3_OnLostFocus(object sender, RoutedEventArgs e)
        {
            // Baca inputan email menggunakan Lost Focus
            if (txtEmailPIC3.Text.Length == 0)
            {
                InfoMail3.Content = "Empty";
            }
            else if (!Regex.IsMatch(txtEmailPIC3.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                InfoMail3.Content = "Invalid";
                txtEmailPIC3.Select(0, txtEmailPIC3.Text.Length);
            }

            else
            {
                InfoMail3.Content = "OK";
            }
        }
    }
}
