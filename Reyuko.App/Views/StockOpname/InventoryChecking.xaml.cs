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

namespace Reyuko.App.Views.StockOpname
{
    /// <summary>
    
    /// </summary>
    public partial class InventoryChecking : UserControl
    {
        public InventoryChecking()
        {
            InitializeComponent();
            Switcher.pageSwitchercheking = this;
            this.Init();
        }
        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        public IEnumerable<Lokasi> lokasis { get; set; }
        public Lokasi LokasiSelected { get; set; }
        public IEnumerable<Dokumen> dokumens { get; set; }
        public Dokumen dokumenSelected { get; set; }

        private void Init()
        {
            this.LoadSearchLokasi();
            this.LoadNoDokumen();
        }

        public void LoadNoDokumen()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dokumens = uow.Dokumen.GetAll();
                srdocumentnumber.ItemsSource = this.dokumens;
            }
        }
        private void dokumen_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.dokumenSelected = null;
            if (srdocumentnumber.SelectedItem != null)
            {
                this.dokumenSelected = (Dokumen)srdocumentnumber.SelectedItem;
            }
        }
        public void LoadSearchLokasi()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.lokasis = uow.Lokasi.GetAll();
                srlocation.ItemsSource = this.lokasis;
            }
        }
        private void SearchLokasi_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.LokasiSelected = null;
            if (srlocation.SelectedItem != null)
            {
                this.LokasiSelected = (Lokasi)srlocation.SelectedItem;
            }
        }

        private void NewInventoryChecking_Click(object sender, RoutedEventArgs e)
        {
            NewInventoryChecking v = new NewInventoryChecking();
            Switcher.Switchcheking(v);
        }

        private void EditInventroyChecking_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
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
             
    

