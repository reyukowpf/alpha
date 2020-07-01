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

namespace Reyuko.App.Views.PurchaseDelivery
{
    /// <summary>
    
    /// </summary>
    public partial class PurchaseDelivery : UserControl
    {
        public PurchaseDelivery()
        {
            InitializeComponent();
            Switcher.pageSwitchPurchaseDelivery = this;
            this.Init();
        }
        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        public IEnumerable<Kontak> kontaks { get; set; }
        public Kontak kontakSelected { get; set; }
        private IEnumerable<KlasifikasiKontak> KlasifikasiKontaks { get; set; }
        private KlasifikasiKontak KlasifikasiKontakSelected { get; set; }
        private IEnumerable<DataMataUang> dataMataUangs { get; set; }
        private DataMataUang DataMataUangSelected { get; set; }
        private IEnumerable<Recap> recaps { get; set; }
        private Recap RecapSelected { get; set; }
        public IEnumerable<Purchasedelivery> purchasedeliveries { get; set; }
        public Purchasedelivery PurchasedeliverySelected { get; set; }

        private void Init()
        {
            this.LoadCustomer();
            this.LoadComboKasifikasiKontak();
            this.LoadCurrency();
            this.LoadRecap();
            this.LoadPurchasedelivery();
        }

        public void LoadPurchasedelivery()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.purchasedeliveries = uow.PurchaseDelivery.GetAll();
                DGPurchaseDelivery.ItemsSource = this.purchasedeliveries;
            }
        }
        private void DGPurchaseDelivery_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.PurchasedeliverySelected = null;
            if (DGPurchaseDelivery.SelectedItem != null)
            {
                this.PurchasedeliverySelected = (Purchasedelivery)DGPurchaseDelivery.SelectedItem;
            }
        }
        private void LoadRecap()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.recaps = uow.Recap.GetAll();
                cbRecap.ItemsSource = this.recaps;
                cbRecap.SelectedValuePath = "IdRecap";
                cbRecap.DisplayMemberPath = "Recaps";
            }
        }
        private void recap_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.RecapSelected = null;
            if (cbRecap.SelectedItem != null)
            {
                this.RecapSelected = (Recap)cbRecap.SelectedItem;
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
        private void currency_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.DataMataUangSelected = null;
            if (cbCurrency.SelectedItem != null)
            {
                this.DataMataUangSelected = (DataMataUang)cbCurrency.SelectedItem;
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
        private void CbClasification_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.KlasifikasiKontakSelected = null;
            /*if (cbClasification.SelectedItem != null)
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
                    tabPIC1.Header = this.KlasifikasiKontakSelected.NamaPIC1;
                    if (this.KlasifikasiKontakSelected.CheckboxGenderPIC1 == true)
                    {
                        rdMalePIC1.Visibility = Visibility.Visible;
                        rdFemalePIC1.Visibility = Visibility.Visible;
                    }
                    if (this.KlasifikasiKontakSelected.CheckboxPositionPIC1 == true)
                    {
                        txtPositionPIC1.Visibility = Visibility.Visible;
                    }
                }
                if (this.KlasifikasiKontakSelected.CheckboxPIC2 == true)
                {
                    tabPIC2.IsEnabled = true;
                    tabPIC2.Header = this.KlasifikasiKontakSelected.NamaPIC2;
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
                    tabPIC3.Header = this.KlasifikasiKontakSelected.NamaPIC3;
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

            }*/
        }
        public void LoadCustomer()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kontaks = uow.Kontak.GetAll().Where(m => m.TypeKontak.ToLower() == "vendor");
                srvendor.ItemsSource = this.kontaks;
            }
        }
        private void customer_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.kontakSelected = null;
            if (srvendor.SelectedItem != null)
            {
                this.kontakSelected = (Kontak)srvendor.SelectedItem;
            }

        }

        private void NewPurchaseDelivery_Click(object sender, RoutedEventArgs e)
        {
            NewPurchaseDelivery newPurchaseDelivery = new NewPurchaseDelivery();
            Switcher.SwitchPurchaseDelivery(newPurchaseDelivery);
        }

        private void Detail_Click(object sender, RoutedEventArgs e)
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

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (this.PurchasedeliverySelected == null)
            {
                MessageBox.Show("PurchaseDelivery not selected !");
            }
            else
            {
                PurchasedeliveryBLL purchasedeliveryBLL = new PurchasedeliveryBLL();
                if (purchasedeliveryBLL.RemovePurchasedelivery(this.PurchasedeliverySelected.IdPengirimanBarangPembelian) == true)
                {
                    MessageBox.Show("PurchaseDelivery successfully deleted");
                    this.LoadPurchasedelivery();
                    this.PurchasedeliverySelected = null;
                }
            }
        }
        private void Viewaschart_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Viewposted_Click(object sender, RoutedEventArgs e)
        {

        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Txtvalue_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtvalue.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtvalue.Text = "";
                    return;
                }

            }
        }

        private void TxtRange_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtRange.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtRange.Text = "";
                    return;
                }

            }
        }
    }
}
             
    

