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


namespace Reyuko.App.Views.GeneralJournal
{
    /// <summary>


    public partial class GeneralJournal : UserControl
    {
        public GeneralJournal()
        {
            InitializeComponent();
            Switcher.pageSwitcherjurnal = this;
            this.Init();
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
        private IEnumerable<DataMataUang> dataMataUangs { get; set; }
        public DataMataUang DataMataUangSelected;
        private IEnumerable<TransaksiJurnalUmum> transaksiJurnalUmums { get; set; }
        public TransaksiJurnalUmum transaksiJurnalSelected;
        public bool isEdit = false;
        private void Init()
        {
            this.LoadComboCurrency();
            this.LoadSrnojurnal();
            this.LoadJurnalUmum();
        }

        public void LoadJurnalUmum()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.transaksiJurnalUmums = uow.TransaksiJurnalUmum.GetAll();
                DGGeneral.ItemsSource = this.transaksiJurnalUmums;
            }
        }
        public void LoadJurnalUmumCurrency()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.transaksiJurnalUmums = uow.TransaksiJurnalUmum.GetAll().Where(m => m.IdMataUang == this.DataMataUangSelected.Id);
                DGGeneral.ItemsSource = this.transaksiJurnalUmums;
            }
        }
        public void LoadtransJurnalUmum()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.transaksiJurnalUmums = uow.TransaksiJurnalUmum.GetAll().Where(m => m.NoTransaksiJurnalUmum == this.transaksiJurnalSelected.NoTransaksiJurnalUmum);
                DGGeneral.ItemsSource = this.transaksiJurnalUmums;
            }
        }
        public void LoadSrnojurnal()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.transaksiJurnalUmums = uow.TransaksiJurnalUmum.GetAll();
                srnojurnal.ItemsSource = this.transaksiJurnalUmums;
            }
        }
        private void LoadComboCurrency()
        {
            this.dataMataUangs = new List<DataMataUang>();
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dataMataUangs = uow.DataMataUang.GetAll();
                Cbcurrency.DisplayMemberPath = "NamaMataUang";
                Cbcurrency.SelectedValuePath = "Id";
                Cbcurrency.ItemsSource = this.dataMataUangs;
            }
        }

        private void NewJurnal_Clicks(object sender, RoutedEventArgs e)
        {
            NewGeneralJournal v = new NewGeneralJournal(this);
            Switcher.Switchjurnal(v);
        }

        private void Detail_Clicks(object sender, RoutedEventArgs e)
        {

        }

        private void Refresh_Clicks(object sender, RoutedEventArgs e)
        {

        }
        private void cbcurrency_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.DataMataUangSelected = null;
            if (Cbcurrency.SelectedItem != null)
            {
                this.DataMataUangSelected = (DataMataUang)Cbcurrency.SelectedItem;
            }
            this.LoadJurnalUmumCurrency();
        }
        private void nojurnal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.transaksiJurnalSelected = null;
            if (srnojurnal.SelectedItem != null)
            {
                this.transaksiJurnalSelected = (TransaksiJurnalUmum)srnojurnal.SelectedItem;
            }
            this.LoadtransJurnalUmum();
        }
        private void DGjurnal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.transaksiJurnalSelected = null;
            if (DGGeneral.SelectedItem != null)
            {
                this.transaksiJurnalSelected = (TransaksiJurnalUmum)DGGeneral.SelectedItem;
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (this.transaksiJurnalSelected == null)
            {
                MessageBox.Show("Jurnal Umum belum dipilih !");
            }
            else
            {
                TransaksiJurnalUmumBLL TransaksiJurnalUmumBLL = new TransaksiJurnalUmumBLL();
                if (TransaksiJurnalUmumBLL.RemoveTransaksiJurnalUmum(this.transaksiJurnalSelected.IdTransaksiJurnalUmum) == true)
                {
                    MessageBox.Show("Jurnal Umum berhasil dihapus");
                    this.LoadJurnalUmum();
                    this.transaksiJurnalSelected = null;
                }
            }
        }
       
    } 
    }

