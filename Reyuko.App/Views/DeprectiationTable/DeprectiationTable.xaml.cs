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

namespace Reyuko.App.Views.DeprectiationTable
{
    /// <summary>


    public partial class DeprectiationTable : UserControl
    {
        public DeprectiationTable()
        {
            InitializeComponent();
            this.Init();
        }

        private IEnumerable<TabelPenyusutan> tabelPenyusutans { get; set; }
        public TabelPenyusutan tabelPenyusutanSelected { get; set; }
        public bool isEdit = false;
        private int pageIndex = 1;
        private int pageSize = 10;

        private void Init()
        {
            this.ClearForm();
            this.LoadTabelPenyusutan();
        }

        private void ClearForm()
        {
            this.tabelPenyusutanSelected = null;
        }

        public void LoadTabelPenyusutan()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.tabelPenyusutans = uow.TabelPenyusutan.GetPaged(this.pageIndex, this.pageSize);
                DGDeprectiation.ItemsSource = this.tabelPenyusutans;
            }
        }
       
        private void NewDeprectiation_Clicks(object sender, RoutedEventArgs e)
        {
            this.isEdit = false;
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is NewDeprectiationTable)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                NewDeprectiationTable newdepr = new NewDeprectiationTable(this);
                newdepr.Show();
            }
        }

        private void EditDeprectiation_Clicks(object sender, RoutedEventArgs e)
        {
            this.isEdit = true;
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is NewDeprectiationTable)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                NewDeprectiationTable newdepr = new NewDeprectiationTable(this);
                newdepr.Show();
            }
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (this.tabelPenyusutanSelected == null)
            {
                MessageBox.Show("Depreciation Table has not been selected !");
            }
            else
            {
                TabelPenyusutanBLL TabelPenyusutanBLL = new TabelPenyusutanBLL();
                if (TabelPenyusutanBLL.RemoveTabelPenyusutan(this.tabelPenyusutanSelected.Id) == true)
                {
                    MessageBox.Show("Depreciation Table successfully deleted");
                    this.LoadTabelPenyusutan();
                    this.tabelPenyusutanSelected = null;
                }
            }
        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DGDeprectiation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.tabelPenyusutanSelected = null;
            if (DGDeprectiation.SelectedItem != null)
            {
                this.tabelPenyusutanSelected = (TabelPenyusutan)DGDeprectiation.SelectedItem;
            }
        }
    } 
    }

