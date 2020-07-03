using Reyuko.BLL.Core;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
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

namespace Reyuko.App.Views.ContactClasification
{
    /// <summary>
    /// </summary>
    public partial class NewContactClasification : Window
    {
        public NewContactClasification(ContactClasification ContactClasificationForm)
        {
            InitializeComponent();
            this.ContactClasificationForm = ContactClasificationForm;
            this.Init();
        }

        public object UserControl { get; internal set; }
        private ContactClasification ContactClasificationForm { get; set; }
        private IEnumerable<TypeKontak> TypeKontaks { get; set; }
        private TypeKontak TypeKontakSelected { get; set; }

        private void ClearForm()
        {
            CbContactType.SelectedIndex = -1;
            txtKlasifikasiKontak.Text = "";
            ChkGender.IsChecked = false;
            ChkPosition.IsChecked = false;
            ChkTransaction.IsChecked = false;
            ChkOutstanding.IsChecked = false;
            ChkPIC1.IsChecked = false;
            txtPIC1.Text = "";
            ChkGenderPIC1.IsChecked = false;
            ChkPositionPIC1.IsChecked = false;
            ChkPIC2.IsChecked = false;
            txtPIC2.Text = "";
            ChkGenderPIC2.IsChecked = false;
            ChkPositionPIC2.IsChecked = false;
            ChkPIC3.IsChecked = false;
            txtPIC3.Text = "";
            ChkGenderPIC3.IsChecked = false;
            ChkPositionPIC3.IsChecked = false;
            txtNote.Text = "";

            this.TypeKontakSelected = null;

        }

        private void Init()
        {
            this.ClearForm();
            this.LoadComboTypeKontak();
            if (this.ContactClasificationForm.isEdit == true)
                this.LoadKlasifikasiKontak();
        }

        private void LoadComboTypeKontak()
        {
            this.TypeKontaks = null;
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.TypeKontaks = uow.TypeKontak.GetAll();
                CbContactType.ItemsSource = this.TypeKontaks;
                CbContactType.DisplayMemberPath = "Type";
                CbContactType.SelectedValuePath = "Id";
            }
        }

        private void LoadKlasifikasiKontak()
        {
            this.ClearForm();
            if (this.ContactClasificationForm != null && this.ContactClasificationForm.KlasifikasiKontakSelected != null)
            {
                CbContactType.SelectedValue = this.ContactClasificationForm.KlasifikasiKontakSelected.IdTypeKontak;
                txtKlasifikasiKontak.Text = this.ContactClasificationForm.KlasifikasiKontakSelected.NamaKlasifikasiKontak;
                ChkGender.IsChecked = this.ContactClasificationForm.KlasifikasiKontakSelected.CheckboxGender;
                ChkPosition.IsChecked = this.ContactClasificationForm.KlasifikasiKontakSelected.CheckboxPosition;
                ChkTransaction.IsChecked = this.ContactClasificationForm.KlasifikasiKontakSelected.CheckboxTransaksi;
                ChkOutstanding.IsChecked = this.ContactClasificationForm.KlasifikasiKontakSelected.CheckboxOutstanding;
                ChkPIC1.IsChecked = this.ContactClasificationForm.KlasifikasiKontakSelected.CheckboxPIC1;
                txtPIC1.Text = this.ContactClasificationForm.KlasifikasiKontakSelected.NamaPIC1;
                ChkGenderPIC1.IsChecked = this.ContactClasificationForm.KlasifikasiKontakSelected.CheckboxGenderPIC1;
                ChkPositionPIC1.IsChecked = this.ContactClasificationForm.KlasifikasiKontakSelected.CheckboxPositionPIC1;
                ChkPIC2.IsChecked = this.ContactClasificationForm.KlasifikasiKontakSelected.CheckboxPIC2;
                txtPIC2.Text = this.ContactClasificationForm.KlasifikasiKontakSelected.NamaPIC2;
                ChkGenderPIC2.IsChecked = this.ContactClasificationForm.KlasifikasiKontakSelected.CheckboxGenderPIC2;
                ChkPositionPIC2.IsChecked = this.ContactClasificationForm.KlasifikasiKontakSelected.CheckboxPositionPIC2;
                ChkPIC3.IsChecked = this.ContactClasificationForm.KlasifikasiKontakSelected.CheckboxPIC3;
                txtPIC3.Text = this.ContactClasificationForm.KlasifikasiKontakSelected.NamaPIC3;
                ChkGenderPIC3.IsChecked = this.ContactClasificationForm.KlasifikasiKontakSelected.CheckboxGenderPIC3;
                ChkPositionPIC3.IsChecked = this.ContactClasificationForm.KlasifikasiKontakSelected.CheckboxPositionPIC3;
                txtNote.Text = this.ContactClasificationForm.KlasifikasiKontakSelected.Note;

                this.TypeKontakSelected = this.TypeKontaks.Where(m => m.Id == this.ContactClasificationForm.KlasifikasiKontakSelected.IdTypeKontak.GetValueOrDefault(0)).FirstOrDefault();
            }
        }


        private KlasifikasiKontak GetData()
        {
            KlasifikasiKontak oData = new KlasifikasiKontak();
            if (this.TypeKontakSelected != null)
            {
                oData.IdTypeKontak = this.TypeKontakSelected.Id;
                oData.TypeKontak = this.TypeKontakSelected.Type;
            }
        oData.NamaKlasifikasiKontak =    txtKlasifikasiKontak.Text;
            oData.CheckboxGender = ChkGender.IsChecked;
            oData.CheckboxPosition = ChkPosition.IsChecked;
            oData.CheckboxTransaksi = ChkTransaction.IsChecked;
            oData.CheckboxOutstanding = ChkOutstanding.IsChecked;
            oData.CheckboxPIC1 = ChkPIC1.IsChecked;
            oData.NamaPIC1 = txtPIC1.Text;
            oData.CheckboxGenderPIC1 = ChkGenderPIC1.IsChecked;
            oData.CheckboxPositionPIC1 = ChkPositionPIC1.IsChecked;
            oData.CheckboxPIC2 = ChkPIC2.IsChecked;
            oData.NamaPIC2 = txtPIC2.Text;
            oData.CheckboxGenderPIC2 = ChkGenderPIC2.IsChecked;
            oData.CheckboxPositionPIC2 = ChkPositionPIC2.IsChecked;
            oData.CheckboxPIC3 = ChkPIC3.IsChecked;
            oData.NamaPIC3 = txtPIC3.Text;
            oData.CheckboxGenderPIC3 = ChkGenderPIC3.IsChecked;
            oData.CheckboxPositionPIC3 = ChkPositionPIC3.IsChecked;
            oData.Note = txtNote.Text;
            if (this.ContactClasificationForm.KlasifikasiKontakSelected != null)
                oData.Id = this.ContactClasificationForm.KlasifikasiKontakSelected.Id;

            return oData;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (CbContactType.Text == "" || txtKlasifikasiKontak.Text == "" || txtNote.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            KlasifikasiKontakBLL KlasifikasiKontakBLL = new KlasifikasiKontakBLL();
            if (this.ContactClasificationForm.isEdit == false)
            {
                if (KlasifikasiKontakBLL.AddKlasifikasiKontak(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Contact Classification successfully added !");
                    this.ContactClasificationForm.LoadKlasifikasiKontak();
                }
                else
                {
                    MessageBox.Show("Contact Classification failed to be added !");
                }
            }
            else
            {
                if (KlasifikasiKontakBLL.EditKlasifikasiKontak(this.GetData()) == true)
                {
                    this.ClearForm();
                    MessageBox.Show("Contact Classification successfully changed !");
                    this.ContactClasificationForm.LoadKlasifikasiKontak();
                }
                else
                {
                    MessageBox.Show("Contact Classification failed to change !");
                }
            }
            this.Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.ClearForm();
            this.Close();
        }

        private void CbContactType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.TypeKontakSelected = null;
            if (CbContactType.SelectedItem != null)
            {
                this.TypeKontakSelected = (TypeKontak)CbContactType.SelectedItem;
            }
        }

        private void TxtPIC1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TxtPIC2_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TxtPIC3_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TxtKlasifikasiKontak_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtNote_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ChkPIC1_Checked(object sender, RoutedEventArgs e)
        {
        }
    }
}
