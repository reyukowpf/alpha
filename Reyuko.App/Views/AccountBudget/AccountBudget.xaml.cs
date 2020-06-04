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

namespace Reyuko.App.Views.AccountBudget
{
    /// <summary>


    public partial class AccountBudget : UserControl
    {
        public AccountBudget()
        {
            InitializeComponent();
            this.Init();
        }
        public IEnumerable<KlasifikasiAkun> KlasifikasiAkuns { get; set; }
        public KlasifikasiAkun KlasifikasiAkunSelected { get; set; }
        public IEnumerable<RekeningAnggaran> rekeningAnggarans { get; set; }
        public IEnumerable<RekeningPerkiraan> rekeningPerkiraans { get; set; }
        public RekeningAnggaran rekeningAnggaranSelected;
        public RekeningPerkiraan rekeningPerkiraanSelected;
        private void Init()
        {
            this.LoadKlasifikasiAkun();
            //         this.LoadRekeningAnggaranDetail();
        }


        public void LoadKlasifikasiAkun()
        {
            tvAccountBudget.Items.Clear();
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
                        tvAccountBudget.Items.Add(node);
                    }
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

        private void tvAccountBudget_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<Object> e)
        {
            this.KlasifikasiAkunSelected = null;
            if (tvAccountBudget.SelectedItem != null)
            {
                TreeViewItem node = (TreeViewItem)tvAccountBudget.SelectedItem;
                this.KlasifikasiAkunSelected = this.KlasifikasiAkuns.Where(m => m.Id == node.TabIndex).FirstOrDefault();
                this.LoadRekeningAnggaranDetail();
                this.LoadAnggaran();
            }
        }
        public void LoadRekeningAnggaranDetail()
        {

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                var RekeningAnggaran = uow.RekeningAnggaran.GetAll().Join(uow.RekeningPerkiraan.GetAll(),
                    e => e.IdRekeningPerkiraan,
                    d => d.Id, (e, d) => new
                    {
                        u = e.IdRekeningPerkiraan,
                        g = d.IdKlasifikasiRekeningPerkiraan,
                        c = d.Id,
                    }).
                Where(d => d.g == this.KlasifikasiAkunSelected.Id).Take(10);

                if (RekeningAnggaran != null)
                {
                    //   lblnama.Content = this.rekeningAnggaranSelected.NamaAkun;
                    chkdate.IsChecked = true;
                    chkkodebudget.IsChecked = true;
                    chkdepartment.IsChecked = true;
                    chkproject.IsChecked = true;
                    chklokasi.IsChecked = true;
                    chkdeskripsi.IsChecked = false;
                    chkbudget.IsChecked = true;
                    chkrealization.IsChecked = true;
                }
            }
        }
        public void LoadAnggaran()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                var a = new List<RekeningAnggaran>();
                var b = new List<RekeningPerkiraan>();
                var ab = (from RekeningAnggaran in a
                          join RekeningPerkiraan in b
                          on RekeningAnggaran.IdRekeningPerkiraan equals RekeningPerkiraan.Id
                          select new
                          {
                              s = RekeningPerkiraan.Id,
                              abbb = RekeningAnggaran.NamaAkun
                          }).ToList();
                DGBudget.ItemsSource = ab;
            }
        }
        private void View_Clicks(object sender, RoutedEventArgs e)
        {

        }

        private void Print_Clicks(object sender, RoutedEventArgs e)
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


    }
}

