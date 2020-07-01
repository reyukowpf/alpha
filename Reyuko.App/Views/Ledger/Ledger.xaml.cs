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

namespace Reyuko.App.Views.Ledger
{
    /// <summary>


    public partial class Ledger : UserControl
    {
        public Ledger()
        {
            InitializeComponent();
            this.Init();
        }
        public IEnumerable<KlasifikasiAkun> KlasifikasiAkuns { get; set; }
        public KlasifikasiAkun KlasifikasiAkunSelected { get; set; }
        public IEnumerable<BukuBesar> bukuBesars { get; set; }
        public IEnumerable<DataDepartemen> dataDepartemens { get; set; }
        public IEnumerable<DataProyek> dataProyeks { get; set; }
        public BukuBesar bukuBesarSelected { get; set; }

        private void Init()
        {
            this.LoadKlasifikasiAkun();
            this.LoadComboDepartemen();
            this.LoadComboProyek();
        }

        private void LoadComboDepartemen()
        {
            this.dataDepartemens = new List<DataDepartemen>();
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dataDepartemens = uow.DataDepartemen.GetAll();
                cbDepartment.DisplayMemberPath = "NamaDepartemen";
                cbDepartment.SelectedValuePath = "Id";
                cbDepartment.ItemsSource = this.dataDepartemens;
            }
        }

        private void LoadComboProyek()
        {
            this.dataProyeks = new List<DataProyek>();
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dataProyeks = uow.DataProyek.GetAll();
                cbProject.DisplayMemberPath = "NamaProyek";
                cbProject.SelectedValuePath = "Id";
                cbProject.ItemsSource = this.dataProyeks;
            }
        }
        public void LoadBukubesar()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.bukuBesars = uow.BukuBesar.GetAll().Where(m => m.IdKlasfikasi == this.KlasifikasiAkunSelected.Id);
                DGLedger.ItemsSource = this.bukuBesars;
            }
        }
        public void LoadKlasifikasiAkun()
        {
            tvLedger.Items.Clear();
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.KlasifikasiAkuns = uow.KlasifikasiAkun.GetAll();
                var roots = this.KlasifikasiAkuns.Where(m => m.IdParentKategoriKA.GetValueOrDefault(0) == 0);
                if (roots != null)
                {
                    foreach (var root in roots)
                    {
                        TreeViewItem node = new TreeViewItem() { Header = root.KategoriKA, TabIndex = root.Id };
                        this.AddChild(node, root.Id);
                        tvLedger.Items.Add(node);
                    }
                }
            }
        }
        public void LoadLedgerDetail()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                var BukuBesar = uow.BukuBesar.SingleOrDefault(m => m.IdKlasfikasi == this.KlasifikasiAkunSelected.Id);
                if (BukuBesar != null)
                {
                    lblnama.Content = BukuBesar.NamaRekeningPerkiraan;
                    chkdate.IsChecked = true;
                    chkrefrence.IsChecked = true;
                    chkdepartmen.IsChecked = false;
                    chkproject.IsChecked = false;
                    chkdebit.IsChecked = true;
                    chkkredit.IsChecked = true;
                    chklokasi.IsChecked = false;
                    chkcustomer.IsChecked = true;
                }
            }
        }
        private TreeViewItem AddChild(TreeViewItem node, int parentId)
        {
            var items = this.KlasifikasiAkuns.Where(m => m.IdParentKategoriKA == parentId);
            if (items != null)
            {
                foreach (var item in items)
                {
                    TreeViewItem leaf = new TreeViewItem() { Header = item.KategoriKA, TabIndex = item.Id };
                    this.AddChild(leaf, item.Id);
                    node.Items.Add(leaf);
                }
            }

            return node;
        }

        private void tvLedger_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<Object> e)
        {
            this.KlasifikasiAkunSelected = null;
            if (tvLedger.SelectedItem != null)
            {
                TreeViewItem node = (TreeViewItem)tvLedger.SelectedItem;
                this.KlasifikasiAkunSelected = this.KlasifikasiAkuns.Where(m => m.Id == node.TabIndex).FirstOrDefault();
                this.LoadLedgerDetail();
                    this.LoadBukubesar();
            }
        }

        private void Viewledger_Click(object sender, RoutedEventArgs e)
        {
            
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
        private void show_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

