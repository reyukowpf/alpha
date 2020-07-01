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

namespace Reyuko.App.Views.PurchaseDocument
{
    /// <summary>
   
    /// </summary>
    public partial class Skuservicepurchaseorder : UserControl
    {
        public Skuservicepurchaseorder(NewPurchasedOrder neworder)
        {
            InitializeComponent();
            this.neworder = neworder;
            this.Init();
        }
        public IEnumerable<produk> produks { get; set; }
        public produk produkSelected;
        private void ClearForm()
        {
            
        }

        private void Init()
        {
            this.ClearForm();
            this.Loadproduk();
        }
        public NewPurchasedOrder neworder;
        private void Loadproduk()
        {
             using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
             {
                    this.produks = uow.produk.GetAll();
                    srsku.ItemsSource = this.produks;
             }
        }
        private void produk_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.produkSelected = null;
            if (srsku.SelectedItem != null)
            {
                this.produkSelected = (produk)srsku.SelectedItem;
                txtprice.Text = this.produkSelected.HargaBeli.ToString();
                txtdiskon.Text = this.produkSelected.DiskonProdukPersen;
                txttax.Text = this.produkSelected.PersentasePajak.ToString();
                txtdiskon1.Text = ((float.Parse(txtprice.Text.ToString()) * float.Parse(txtdiskon.Text.ToString()) / 100)).ToString();
            }
        }
        public OrderJasaBeli GetData()
        {
            OrderJasaBeli oData = new OrderJasaBeli();
            if (this.produkSelected != null)
            {
                oData.IdProduk = this.produkSelected.IdProduk;
                oData.Sku = this.produkSelected.SKU;
                oData.NamaJasa = this.produkSelected.NamaProduk;
                oData.HargaJasa = this.produkSelected.HargaBeli;
                oData.PersentasePajak = this.produkSelected.PersentasePajak;
                oData.IdAkunPajakJasa = this.produkSelected.IdAkunPajak;
                oData.IdPajak = this.produkSelected.IdPajak;
                oData.NamaPajak = this.produkSelected.Pajak;
                oData.IdAkunJasa = this.produkSelected.IdAkunJasa;
            }
            oData.DiskonJasa = double.Parse(txtdiskon1.Text);
            oData.TotalJasa = int.Parse(txttotal.Text);
            oData.TotalOrderJasa = double.Parse(txttotal1.Text);
            oData.TotalPajakJasa = double.Parse(txttotaltax.Text);
            oData.Checkboxaktif = true;
            return oData;
        }
        public void Addsku_Clicks(object sender, RoutedEventArgs e)
        {
            ShopingchartBLL shopingBLL = new ShopingchartBLL();
                if (shopingBLL.AddOrderJasabeli(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Add Order Buy Service successfully added !");
                   this.neworder.LoadDataSku();
                }
                else
                {
                    MessageBox.Show("Add Order Sell Service failed to add !");
                }
            neworder.DGSKUorder.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Collapsed;
        }

        private void Cancel_Clicks(object sender, RoutedEventArgs e)
        {
            neworder.DGSKUorder.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Collapsed;
        }

      
        private void txttotal_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txttotal.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txttotal.Text = "";
                    return;
                }
            }
            txttotal1.Text = ((float.Parse(txttotal.Text.ToString()) * float.Parse(txtprice.Text.ToString())) - (float.Parse(txtdiskon.Text.ToString())/100 * float.Parse(txtprice.Text.ToString()))*float.Parse(txttotal.Text.ToString())).ToString();
            txttotaltax.Text = (float.Parse(txttotal1.Text.ToString()) * float.Parse(txttax.Text.ToString())).ToString();
        }
            
       
    }
}
