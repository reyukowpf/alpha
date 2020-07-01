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

namespace Reyuko.App.Views.InventoryAdjusment
{
    /// <summary>
   
    /// </summary>
    public partial class Sku : Window
    {
        public Sku(NewInventoryAdjusment newreceived)
        {
            InitializeComponent();
            this.newreceived = newreceived;
            this.Init();
        }
        public IEnumerable<OrderProdukBeli> orderProdukBelis { get; set; }
        public OrderProdukBeli orderprodukbeliSelected;
        private void ClearForm()
        {
        }

        private void Init()
        {
            this.ClearForm();
            this.Loadproduk();
        }
        public NewInventoryAdjusment newreceived;
        private void Loadproduk()
        {
             using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
             {
                    this.orderProdukBelis = uow.OrderProdukBeli.GetAll();
                    srsku.ItemsSource = this.orderProdukBelis;
             }
        }
        private void produk_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.orderprodukbeliSelected = null;
            if (srsku.SelectedItem != null)
            {
                this.orderprodukbeliSelected = (OrderProdukBeli)srsku.SelectedItem;
                txtunit.Text = this.orderprodukbeliSelected.SatuanDasar;
                txtprice.Text = this.orderprodukbeliSelected.HargaBeli.ToString();
                txttax.Text = this.orderprodukbeliSelected.PersentasePajak.ToString();
            }
        }
        public OrderInventori GetData()
        {
            OrderInventori oData = new OrderInventori();
            if (this.orderprodukbeliSelected != null)
            {
                oData.IdProduk = this.orderprodukbeliSelected.IdProduk;
                oData.Sku = this.orderprodukbeliSelected.Sku;
                oData.SatuanDasar = this.orderprodukbeliSelected.SatuanDasar;
                oData.HargaBeli = this.orderprodukbeliSelected.HargaBeli;
                oData.NamaProduk = this.orderprodukbeliSelected.NamaProduk;
            }
            oData.Keluar = int.Parse(txttotal.Text);
            oData.TotalBeli = double.Parse(txttotal1.Text);
            oData.TotalPajak = double.Parse(txttotaltax.Text);
            oData.CheckboxAktif = true;
            return oData;
        }
        public void Addsku_Clicks(object sender, RoutedEventArgs e)
        {
            PermPenyTransferBarangBLL permBLL = new PermPenyTransferBarangBLL();
                if (permBLL.AddOrderInventori(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Add Order Inventory successfully added !");
                    this.newreceived.LoadDataSku();
                }
                else
                {
                    MessageBox.Show("Add Order Inventory failed to add !");
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
            txttotal1.Text = ((float.Parse(txttotal.Text.ToString()) * float.Parse(txtprice.Text.ToString()))).ToString();
            txttotaltax.Text = (float.Parse(txttotal1.Text.ToString()) * float.Parse(txttax.Text.ToString())).ToString();
        }
            
       
    }
}
