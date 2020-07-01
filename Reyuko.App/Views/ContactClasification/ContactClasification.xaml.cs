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


    public partial class ContactClasification : UserControl
    {
        public ContactClasification()
        {
            InitializeComponent();
            this.Init();
        }


        public IEnumerable<KlasifikasiKontak> KlasifikasiKontaks { get; set; }
        public KlasifikasiKontak KlasifikasiKontakSelected { get; set; }
        public bool isEdit = false;
        private int pageIndex = 1;
        private int pageSize = 10;

        private void Init()
        {
            this.ClearForm();
            this.KlasifikasiKontakSelected = null;
            this.LoadKlasifikasiKontak();
        }

        private void ClearForm()
        {
            txtIDContactClasification.Text = "";
            txtContactType.Text = "";
            txtKlasifikasiKontak.Text = "";
            txtAyah.Text = "";
            txtIbu.Text = "";
            txtKakak.Text = "";
            txtNote.Text = "";
        }

        public void LoadKlasifikasiKontak()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.KlasifikasiKontaks = uow.KlasifikasiKontak.GetAll();
                TvContactClasification.ItemsSource = this.KlasifikasiKontaks;
                TvContactClasification.DisplayMemberPath = "NamaKlasifikasiKontak";
                TvContactClasification.SelectedValuePath = "Id";
            }
        }

        public void LoadKlasifikasiKontakDetail()
        {
            this.ClearForm();
            if (this.KlasifikasiKontakSelected != null)
            {
                txtIDContactClasification.Text = this.KlasifikasiKontakSelected.Id.ToString();
                txtContactType.Text = this.KlasifikasiKontakSelected.TypeKontak;
                txtKlasifikasiKontak.Text = this.KlasifikasiKontakSelected.NamaKlasifikasiKontak;
                txtAyah.Text = this.KlasifikasiKontakSelected.NamaPIC1;
                txtIbu.Text = this.KlasifikasiKontakSelected.NamaPIC2;
                txtKakak.Text = this.KlasifikasiKontakSelected.NamaPIC3;
                txtNote.Text = this.KlasifikasiKontakSelected.Note;
            }
        }

        private void TvContactClasification_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<Object> e)
        {
            this.KlasifikasiKontakSelected = null;
            if (TvContactClasification.SelectedItem != null)
            {
                this.KlasifikasiKontakSelected = (KlasifikasiKontak)TvContactClasification.SelectedItem;
                this.LoadKlasifikasiKontakDetail();
            }
        }

        private void BtnNew_Clicks(object sender, RoutedEventArgs e)
        {
            this.isEdit = false;
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is NewContactClasification)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                NewContactClasification period = new NewContactClasification(this);
                period.Show();
            }
        }

        private void BtnEdit_Clicks(object sender, RoutedEventArgs e)
        {
            this.isEdit = true;
            NewContactClasification v = new NewContactClasification(this);
            v.Show();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (this.KlasifikasiKontakSelected == null)
            {
                MessageBox.Show("Contact classification has not been selected !");
            }
            else
            {
                KlasifikasiKontakBLL KlasifikasiKontakBLL = new KlasifikasiKontakBLL();
                if (KlasifikasiKontakBLL.RemoveKlasifikasiKontak(this.KlasifikasiKontakSelected.Id) == true)
                {
                    MessageBox.Show("Contact Classification successfully deleted");
                    this.LoadKlasifikasiKontak();
                    this.KlasifikasiKontakSelected = null;
                }
            }

        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

