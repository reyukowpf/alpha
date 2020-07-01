using Reyuko.BLL.Core;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Reyuko.App.Views.Stocklist
{
    /// <summary>
    /// </summary>
    public partial class StockList : Window
    {
        public StockList()
        {
            InitializeComponent();
            this.Init();
        }
        private IEnumerable<Lokasi> lokasis { get; set; }
        private Lokasi lokasiSelected;
        private IEnumerable<KategoriProduk> kategoriProduks { get; set; }
        private KategoriProduk kategoriProdukSelected;
        private void Init()
        {
            this.LoadLokasi();
            this.LoadKategori();
        }
        private void LoadLokasi()
        {
            this.lokasis = new List<Lokasi>();
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.lokasis = uow.Lokasi.GetAll();
                cbLocation.DisplayMemberPath = "NamaTempatLokasi";
                cbLocation.SelectedValuePath = "Id";
                cbLocation.ItemsSource = this.lokasis;
            }
        }
        private void LoadKategori()
        {
            this.kategoriProduks = new List<KategoriProduk>();
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kategoriProduks = uow.KategoriProduk.GetAll();
                cbCategory.DisplayMemberPath = "ProdukKategori";
                cbCategory.SelectedValuePath = "Id";
                cbCategory.ItemsSource = this.kategoriProduks;
            }
        }
        public object UserControl { get; internal set; }


        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
