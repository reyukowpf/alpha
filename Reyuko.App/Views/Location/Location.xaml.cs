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

namespace Reyuko.App.Views.Location
{
    /// <summary>

    /// </summary>
    public partial class Location : UserControl
    {
        public Location()
        {
            InitializeComponent();
            this.Init();
        }

        public IEnumerable<ListLokasi> ListLokasis { get; set; }
        public ListLokasi ListLokasiSelected { get; set; }
        public IEnumerable<OrderInventori> orderInventoris { get; set; }
        public IEnumerable<Lokasi> lokasi { get; set; }
        public Lokasi lokasiSelected { get; set; }
        public IEnumerable<KategoriProduk> kategoriProduks { get; internal set; }
        public object kategoriProdukSelected { get; internal set; }
        public IEnumerable<ListProduk> listProduks { get; internal set; }
        public ListProduk ListProdukSelected { get; set; }

        public Lokasi Lokasi { get; set; }
        public bool isEdit = false;
        private int pageIndex = 1;
        private int pageSize = 10;

        private void Init()
        {
            this.ClearForm();
            this.LoadLokasi("");
            this.LoadLokasis();
            this.LoadKategoriProduk();
            this.LoadListProduk();
        }

        public void LoadListProduk()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.listProduks = uow.ListProduk.GetAll();
                srtable.ItemsSource = this.listProduks;
            }
        }
        private void ListProduk_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.ListProdukSelected = null;
            if (srtable.SelectedItem != null)
            {
                this.ListProdukSelected = (ListProduk)srtable.SelectedItem;
            }
        }
        private void LoadKategoriProduk()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kategoriProduks = uow.KategoriProduk.GetAll();
                cbkategori.ItemsSource = this.kategoriProduks;
                cbkategori.SelectedValuePath = "Id";
                cbkategori.DisplayMemberPath = "ProdukKategori";
            }
        }
        private void KategoriProduk_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.kategoriProdukSelected = null;
            if (cbkategori.SelectedItem != null)
            {
                this.kategoriProdukSelected = (KategoriProduk)cbkategori.SelectedItem;
            }
        }
        public void LoadLokasis()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.lokasi = uow.Lokasi.GetAll();
                srsidelist.ItemsSource = this.lokasi;
            }
        }
        private void Lokasis_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.lokasiSelected = null;
            if (srsidelist.SelectedItem != null)
            {
                this.lokasiSelected = (Lokasi)srsidelist.SelectedItem;
            }
        }

        private void ClearForm()
        {
            this.ListLokasiSelected = null;

        }

        public void LoadLokasi(string NamaTempatLokasi)
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.ListLokasis = uow.ListLokasi.GetAll();
                List<ListLokasi> itemSource = new List<ListLokasi>();
                if (!string.IsNullOrEmpty(NamaTempatLokasi))
                    itemSource = this.ListLokasis.Where(m => m.NamaTempatLokasi.Contains(NamaTempatLokasi)).ToList();
                else
                    itemSource = this.ListLokasis.ToList();
                LiLocation.ItemsSource = itemSource;
            }
        }

        public void LoadLokasiSKU()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.orderInventoris = uow.OrderInventori.GetAll().Where(m => m.IdLokasi == this.ListLokasiSelected.Id);
                DGLocation.ItemsSource = this.orderInventoris;
            }
        }
        private void BtnNewLocation_Click(object sender, RoutedEventArgs e)
        {
            this.isEdit = false;
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is NewLocation)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                NewLocation newlokasi = new NewLocation(this);
                newlokasi.Show();
            }
        }

        private void BtnEditLocation_Click(object sender, RoutedEventArgs e)
        {
            this.isEdit = true;
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is NewLocation)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                NewLocation newlokasi = new NewLocation(this);
                newlokasi.Show();
            }
        }

        private void LiLocation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.ClearForm();
            if (LiLocation.SelectedItem != null)
            {
                this.ListLokasiSelected = (ListLokasi)LiLocation.SelectedItem;
                if (this.ListLokasiSelected != null)
                {
                    using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
                    {
                        this.Lokasi = uow.Lokasi.Get(this.ListLokasiSelected.IdLokasi);
                    }
                }
                this.LoadLokasiSKU();
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

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}



