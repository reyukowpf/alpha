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

namespace Reyuko.App.Views.Production
{
    /// <summary>
   
    /// </summary>
    public partial class Sku : Window
    {
        public Sku(NewProduction newproduct)
        {
            InitializeComponent();
            this.newproduct = newproduct;
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
        public NewProduction newproduct;
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
                txtunit.Text = this.produkSelected.SatuanDasar;
                txtprice.Text = this.produkSelected.HargaPokokAverage.ToString();
            }
        }
        public OrderProductioninput GetData()
        {
            OrderProductioninput oData = new OrderProductioninput();
            if (this.produkSelected != null)
            {
                oData.IdProduk = this.produkSelected.IdProduk;
                oData.Sku = this.produkSelected.SKU;
                oData.IdSatuanDasar = this.produkSelected.IdSatuanDasar;
                oData.SatuanDasar = this.produkSelected.SatuanDasar;
                oData.HargaPokok = this.produkSelected.HargaPokokAverage;
                oData.NamaProduk = this.produkSelected.NamaProduk;
                oData.IdAkunPersediaan = this.produkSelected.IdAkunPersediaan;
            }
            oData.JumlahProduk = double.Parse(txttotal.Text);
            oData.TotalOrderProduk = double.Parse(txttotal1.Text);
            oData.CheckboxAktif = true;
            return oData;
        }
        public void Addsku_Clicks(object sender, RoutedEventArgs e)
        {
            ProductionBLL productionBLL = new ProductionBLL();
                if (productionBLL.AddOrderProdutioninput(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Add Order Production Input successfully added !");
                    this.newproduct.LoadDataSku();
                }
                else
                {
                    MessageBox.Show("Add Order Production Input failed to add !");
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
        }
            
       
    }
}
