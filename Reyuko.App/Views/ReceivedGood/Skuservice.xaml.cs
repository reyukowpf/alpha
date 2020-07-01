using DevExpress.Xpf.Editors.Helpers;
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

namespace Reyuko.App.Views.ReceivedGood
{
    /// <summary>
   
    /// </summary>
    public partial class Skuservice : Window
    {
        public Skuservice(NewReceivedGood newReceivedGood)
        {
            InitializeComponent();
            this.newReceivedGood = newReceivedGood;
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
        public NewReceivedGood newReceivedGood;
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
                txtprice.Text = this.produkSelected.HargaPokokAverage.ToString();
                txtdiskon.Text = this.produkSelected.DiskonProdukPersen;
                txttax.Text = this.produkSelected.PersentasePajak.ToString();
                txtdiskon1.Text = ((float.Parse(txtprice.Text.ToString()) * float.Parse(txtdiskon.Text.ToString()) / 100)).ToString();
            }
        }
        public OrderProdukBeli GetData()
        {
            OrderProdukBeli oData = new OrderProdukBeli();
            if (this.produkSelected != null)
            {
                oData.IdProduk = this.produkSelected.IdProduk;
                oData.Sku = this.produkSelected.SKU;
                oData.SatuanDasar = this.produkSelected.SatuanDasar;
                oData.HargaBeli = this.produkSelected.HargaBeli;
                oData.NamaProduk = this.produkSelected.NamaProduk;
                oData.PersentasePajak = this.produkSelected.PersentasePajak;
                oData.IdPajak = this.produkSelected.IdPajak;
                oData.NamaPajak = this.produkSelected.Pajak;
                oData.IdAkunPajakProduk = this.produkSelected.IdAkunPajak;
                oData.IdTypeProduk = this.produkSelected.IdTipeProduk;
                oData.TypeProduk = this.produkSelected.TipeProduk;
                oData.AkunPersediaan = this.produkSelected.IdAkunPersediaan;
                oData.AkunPengirimanBeli = this.produkSelected.IdAkunPengirimanBeli;
                oData.ProdukKategori = this.produkSelected.ProdukKategori;
            }           
            oData.DiskonProduk = double.Parse(txtdiskon1.Text);
            oData.TotalProduk = int.Parse(txttotal.Text);
            oData.TotalOrderProduk = double.Parse(txttotal1.Text);
            oData.TotalPajakProduk = double.Parse(txttotaltax.Text);
            oData.Checkboxaktif = true;
            return oData;
        }
        public void Addsku_Clicks(object sender, RoutedEventArgs e)
        {
            ReceivedGoodsBLL receivedBLL = new ReceivedGoodsBLL();
                if (receivedBLL.AddOrderProdukbeli(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Add Order Buy Product successfully added !");
                    this.newReceivedGood.LoadDataSku();
                }
                else
                {
                    MessageBox.Show("Add Order Buy Product failed to add !");
                }
            this.Close();
        }

        private void Cancel_Clicks(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void load(object sender, EventArgs e)
        {
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
