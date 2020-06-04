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

namespace Reyuko.App.Views.FixedAssetCategory
{
    /// <summary>


    public partial class FixedAssetCategory : UserControl
    {
        public FixedAssetCategory()
        {
            InitializeComponent();
            this.Init();
        }

        private IEnumerable<KelompokHartaTetap> kelompokHartaTetaps { get; set; }
        public KelompokHartaTetap kelompokHartaTetapSelected { get; set; }
        public bool isEdit = false;
        private int pageIndex = 1;
        private int pageSize = 10;

        private void Init()
        {
            this.ClearForm();
            this.LoadKelompokHartaTetap();
        }

        private void ClearForm()
        {
            this.kelompokHartaTetaps = new List<KelompokHartaTetap>();
            DGFixedAssetCategory.ItemsSource = this.kelompokHartaTetaps;
        }

        public void LoadKelompokHartaTetap()
        {
            this.kelompokHartaTetaps = new List<KelompokHartaTetap>();
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kelompokHartaTetaps = uow.KelompokHartaTetap.GetAll();
                DGFixedAssetCategory.ItemsSource = this.kelompokHartaTetaps;
            }
        }

        private void NewFixedAssetCategory_Clicks(object sender, RoutedEventArgs e)
        {
            this.isEdit = false;
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is NewFixedAsset)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                NewFixedAsset period = new NewFixedAsset(this);
                period.Show();
            }
        }

        private void EditFixedAssetCategory_Clicks(object sender, RoutedEventArgs e)
        {
            this.isEdit = true;
            NewFixedAsset fix = new NewFixedAsset(this);
            fix.Show();
        }

        private void accountsetting_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (this.kelompokHartaTetapSelected == null)
            {
                MessageBox.Show("Fixed Asset Category not selected yet !");
            }
            else
            {
                KelompokHartaTetapBLL KelompokHartaTetapBLL = new KelompokHartaTetapBLL();
                if (KelompokHartaTetapBLL.RemoveKelompokHartaTetap(this.kelompokHartaTetapSelected.Id) == true)
                {
                    MessageBox.Show("Fixed Asset Category successfully deleted");
                    this.LoadKelompokHartaTetap();
                    this.kelompokHartaTetapSelected = null;
                }
            }
        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DGFixedAssetCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.kelompokHartaTetapSelected = null;
            if (DGFixedAssetCategory.SelectedItem != null)
            {
                this.kelompokHartaTetapSelected = (KelompokHartaTetap)DGFixedAssetCategory.SelectedItem;
            }
        }
    }
}

