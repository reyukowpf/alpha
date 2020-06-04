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

namespace Reyuko.App.Views.Produk
{
    /// <summary>
    /// </summary>
    public partial class StockReceivedName : Window
    {
        internal bool isEdit;

        public StockReceivedName()
        {
            InitializeComponent();
        }
        public IEnumerable<Kontak> Kontaks { get; set; }
        public Kontak KontakSelected { get; set; }

        public object UserControl { get; internal set; }

        public void LoadKontak(string NamaA)
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.Kontaks = uow.Kontak.GetAll().Where(m => m.TypeKontak.ToLower() == "vendor");
                
            }
        }

        private void NewVendor_Click(object sender, RoutedEventArgs e)
        {
            /*bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is NewVendor)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                NewVendor newStock = new NewVendor(this);
                newStock.Show();
            }*/
        }
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();   
        }

        private void TxtTotalUnit_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtTotalUnit.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Harus Diisi Numerik");
                    txtTotalUnit.Text = "";
                    return;
                }

            }
        }

        private void TxtPurchasingprice_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtPurchasingprice.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Harus Diisi Numerik");
                    txtPurchasingprice.Text = "";
                    return;
                }

            }
        }

        private void TxtReceivednumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtReceivednumber.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Harus Diisi Numerik");
                    txtReceivednumber.Text = "";
                    return;
                }

            }
        }
    }
}
