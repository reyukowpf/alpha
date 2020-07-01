using Reyuko.BLL.Core;
using Reyuko.DAL.Domain;
using Reyuko.DAL;
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
using Reyuko.Utils;
using System.Text.RegularExpressions;

namespace Reyuko.App.Views.Location
{
    /// <summary>
    /// </summary>
    public partial class NewLocation : Window
    {
        public NewLocation(Location LocationForm)
        {
            InitializeComponent();
            this.LocationForm = LocationForm;
            this.Init();
        }

        public object UserControl { get; internal set; }
        private Location LocationForm;
        private IEnumerable<Alamat> Alamats { get; set; }
        private Alamat NegaraSelected { get; set; }
        private Alamat PropinsiSelected { get; set; }

        private void ClearForm()
        {
            txtLocationName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            cbCountry.SelectedIndex = -1;
            txtAddress.Text = "";
            txtCity.Text = "";
            cbState.SelectedIndex = -1;
            txtZipcode.Text = "";
            txtMap.Text = "";
            chkDefault.IsChecked = false;
            chkNotActive.IsChecked = false;

            this.NegaraSelected = null;
            this.PropinsiSelected = null;
        }

        private void Init()
        {
            this.ClearForm();
            this.LoadAlamat();
            this.LoadComboCountry();
            if (this.LocationForm.isEdit == true)
                this.Loadlokasi();
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

        private void Loadlokasi()
        {
            this.ClearForm();
            if (this.LocationForm != null && this.LocationForm.Lokasi != null)
            {
                txtLocationName.Text = this.LocationForm.Lokasi.NamaTempatLokasi;
                txtPhone.Text = this.LocationForm.Lokasi.NoTelpLokasi;
                txtEmail.Text = this.LocationForm.Lokasi.EmailLokasi;
                cbCountry.SelectedValue = this.LocationForm.Lokasi.IdNegara;
                txtAddress.Text = this.LocationForm.Lokasi.AlamatLokasi;
                txtCity.Text = this.LocationForm.Lokasi.KotaLokasi;
                cbState.SelectedValue = this.LocationForm.Lokasi.IdPropinsi;
                txtZipcode.Text = this.LocationForm.Lokasi.KodePosLokasi.ToString();
                txtMap.Text = this.LocationForm.Lokasi.MapLocationLokasi;
                chkDefault.IsChecked = this.LocationForm.Lokasi.CheckboxDefault;
                chkNotActive.IsChecked = this.LocationForm.Lokasi.CheckboxNotActive;

                this.NegaraSelected = this.Alamats.Where(m => m.Id == this.LocationForm.Lokasi.IdNegara.GetValueOrDefault(0)).FirstOrDefault();
                this.PropinsiSelected = this.Alamats.Where(m => m.Id == this.LocationForm.Lokasi.IdPropinsi.GetValueOrDefault(0)).FirstOrDefault();
            }
        }

        private Lokasi GetData()
        {
            Lokasi oData = new Lokasi();
            oData.NamaTempatLokasi = txtLocationName.Text;
            oData.NoTelpLokasi = txtPhone.Text;
            oData.EmailLokasi = txtEmail.Text;
            if (this.NegaraSelected != null)
            {
                oData.IdNegara = this.NegaraSelected.Id;
                oData.NamaNegara = this.NegaraSelected.Nama;
            }
            oData.AlamatLokasi = txtAddress.Text;
            oData.KotaLokasi = txtCity.Text;
            if (this.PropinsiSelected != null)
            {
                oData.IdPropinsi = this.PropinsiSelected.Id;
                oData.PropinsiLokasi = this.PropinsiSelected.Nama;
            }
            oData.KodePosLokasi = int.Parse(txtZipcode.Text);
            oData.MapLocationLokasi = txtMap.Text;
            oData.CheckboxDefault = chkDefault.IsChecked;
            oData.CheckboxNotActive = chkNotActive.IsChecked;
            if (this.LocationForm.Lokasi != null)
                oData.Id = this.LocationForm.Lokasi.Id;

            return oData;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtLocationName.Text == "" || txtPhone.Text == "" || txtEmail.Text == "" || cbCountry.Text == "" || txtAddress.Text == "" || txtCity.Text == "" || cbState.Text == "" || txtZipcode.Text == "" || txtMap.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            LokasiBLL LokasiBLL = new LokasiBLL();
            if (this.LocationForm.isEdit == false)
            {
                if (LokasiBLL.AddLokasi(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Location added successfully !");
                    this.LocationForm.LoadLokasi("");
                }
                else
                {
                    MessageBox.Show("Location failed to add !");
                }
            }
            else
            {
                if (LokasiBLL.EditLokasi(this.GetData()) == true)
                {
                    this.ClearForm();
                    MessageBox.Show("Location successfully changed !");
                    this.LocationForm.LoadLokasi("");
                }
                else
                {
                    MessageBox.Show("Location failed to change !");
                }
            }
            this.Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.ClearForm();
            this.Close();
        }

        private void cbCountry_SelectionChanged(object sender, SelectionChangedEventArgs e)
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

        private void cbState_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.PropinsiSelected = null;
            if (cbState.SelectedItem != null)
            {
                this.PropinsiSelected = (Alamat)cbState.SelectedItem;
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

        private void TxtZipcode_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtZipcode.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtZipcode.Text = "";
                    return;
                }

            }
        }

        private void TxtLocationName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtLocationName.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Harus Diisi Character");
                    txtLocationName.Text = "";
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
                    MessageBox.Show("Harus Diisi Character");
                    txtCity.Text = "";
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
