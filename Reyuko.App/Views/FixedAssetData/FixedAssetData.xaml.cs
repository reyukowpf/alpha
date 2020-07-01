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
namespace Reyuko.App.Views.FixedAssetData
{
    /// <summary>


    public partial class FixedAssetData : UserControl
    {
        public FixedAssetData()
        {
            InitializeComponent();
            Switcher.pageSwitcherassetdata = this;
            this.Init();
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        public IEnumerable<KelompokHartaTetap> kelompokHartaTetaps { get; set; }
        public KelompokHartaTetap KelompokhartatetapSelected { get; set; }
        private IEnumerable<DataHartaTetap> dataHartaTetaps { get; set; }
        public DataHartaTetap datahartatetapSelected { get; set; }
        private DataHartaTetap dataHartaTetap { get; set; }
        public bool isEdit = false;
        private void Init()
        {
            this.LoadFixedAsset();
        }

        private TreeViewItem AddChild(TreeViewItem node, int parentId)
        {
            var items = this.kelompokHartaTetaps.Where(m => m.IdParent == parentId);
            if (items != null)
            {
                foreach (var item in items)
                {
                    TreeViewItem leaf = new TreeViewItem() { Header = item.NamaKelompokHartaTetap, TabIndex = item.Id };
                    this.AddChild(leaf, item.Id);
                    node.Items.Add(leaf);
                }
            }

            return node;
        }

        public void LoadFixedAsset()
        {
            tvfixasset.Items.Clear();
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kelompokHartaTetaps = uow.KelompokHartaTetap.GetAll();
                var roots = this.kelompokHartaTetaps.Where(m => m.IdParent.GetValueOrDefault(0) == 0);
                if (roots != null)
                {
                    foreach (var root in roots)
                    {
                        TreeViewItem node = new TreeViewItem() { Header = root.NamaKelompokHartaTetap, TabIndex = root.Id };
                        this.AddChild(node, root.Id);
                        tvfixasset.Items.Add(node);
                    }
                }
            }
        }
        public void LoadFixedAssetDetail()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                var DataHartaTetap = uow.DataHartaTetap.SingleOrDefault(m => m.IdKelompokHartaTetap == this.KelompokhartatetapSelected.IdParent);
                if (DataHartaTetap != null)
                {
                    lblnama.Content = DataHartaTetap.NamaHartaTetap;
                    nama.Content = DataHartaTetap.NamaHartaTetap;
                    txtassetno.Text = DataHartaTetap.NoHartaTetap.ToString();
                    txtassetname.Text = DataHartaTetap.NamaHartaTetap;
                    txtcategory.Text = DataHartaTetap.NamaKelompokHartaTetap;
                    txtpurchase.Text = DataHartaTetap.TanggalBeli.ToString();
                    txtbuyingprice.Text = DataHartaTetap.HargaBeli.ToString();
                    txtsalvage.Text = DataHartaTetap.NilaiResidu.ToString();
                    txtlife.Text = DataHartaTetap.UmurEkonimis.ToString();
                    txtlokasi.Text = DataHartaTetap.Lokasi;
                    txtdepartmen.Text = DataHartaTetap.IdDepartment.ToString();
                    txtdatedepr.Text = DataHartaTetap.AkumulasiBeban.ToString();
                    txtbook.Text = DataHartaTetap.NilaiBuku.ToString();
                    txttanggal.Text = DataHartaTetap.TerhitungTanggal.ToString();
                    txtmonthdepr.Text = DataHartaTetap.BebanPerBulan.ToString();
                    txtmethod.Text = DataHartaTetap.Diperoleh;
                    //  this.Loadkelompokharta();

                }
            }
        }

        private void tvfixasset_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<Object> e)
        {
            this.KelompokhartatetapSelected = null;
            if (tvfixasset.SelectedItem != null)
            {
                TreeViewItem node = (TreeViewItem)tvfixasset.SelectedItem;
                this.KelompokhartatetapSelected = this.kelompokHartaTetaps.Where(m => m.Id == node.TabIndex).FirstOrDefault();
                this.LoadFixedAssetDetail();
                this.Loadkelompokharta(this.KelompokhartatetapSelected.Id);
            }
        }
        public void Loadkelompokharta(int id)
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dataHartaTetaps = uow.DataHartaTetap.GetAll().Where(m => m.IdKelompokHartaTetap == id);
                DGFixedAssetData.ItemsSource = this.dataHartaTetaps;

            }
        }
        private void NewTimah_Clicks(object sender, RoutedEventArgs e)
        {
            this.isEdit = false;
            NewFixedAssetData s = new NewFixedAssetData(this);
            Switcher.Switchassetdata(s);
        }

        private void Edit_Clicks(object sender, RoutedEventArgs e)
        {
            this.isEdit = true;
            NewFixedAssetData s = new NewFixedAssetData(this);
            Switcher.Switchassetdata(s);

        }

        private void other_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

