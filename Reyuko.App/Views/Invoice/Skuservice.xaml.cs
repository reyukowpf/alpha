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

namespace Reyuko.App.Views.Invoice
{
    /// <summary>
   
    /// </summary>
    public partial class Skuservice : Window
    {
        public Skuservice(NewInvoice newinvoice)
        {
            InitializeComponent();
            this.newinvoice = newinvoice;
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
        public NewInvoice newinvoice;
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
                txtprice.Text = this.produkSelected.HargaJual.ToString();
                txtdiskon.Text = this.produkSelected.DiskonProdukPersen;
                txttax.Text = this.produkSelected.PersentasePajak.ToString();
                txtdiskon1.Text = ((float.Parse(txtprice.Text.ToString()) * float.Parse(txtdiskon.Text.ToString()) / 100)).ToString();
            }
        }
        public OrderJasaJual GetData()
        {
            OrderJasaJual oData = new OrderJasaJual();
            if (this.produkSelected != null)
            {
                oData.IdProduk = this.produkSelected.IdProduk;
                oData.ProdukKategori = this.produkSelected.ProdukKategori;
                oData.Sku = this.produkSelected.SKU;
                oData.AkunJasa = this.produkSelected.IdAkunJasa;
                oData.HargaJasa = this.produkSelected.HargaJual;
                oData.NamaProduk = this.produkSelected.NamaProduk;
                oData.Persentase = this.produkSelected.PersentasePajak;
                oData.IdAkunPajakJual = this.produkSelected.IdAkunPajak;
                oData.IdPajak = this.produkSelected.IdPajak;
                oData.Pajak = this.produkSelected.Pajak;                
            }
            oData.DiskonJasa = double.Parse(txtdiskon1.Text);
            oData.JumlahJasa = int.Parse(txttotal.Text);
            oData.TotalOrderJasa = double.Parse(txttotal1.Text);
            oData.TotalPajak = double.Parse(txttotaltax.Text);
            oData.Checkbokaktif = true;
            return oData;
        }
        public void Addsku_Clicks(object sender, RoutedEventArgs e)
        {
            InvoicesBLL invoiceBLL = new InvoicesBLL();
                if (invoiceBLL.AddOrderJasaJual(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Add Order Sell Service successfully added !");
                    this.newinvoice.LoadDataSku();
                }
                else
                {
                    MessageBox.Show("Add Order Sell Service failed to add !");
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
