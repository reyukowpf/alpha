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

namespace Reyuko.App.Views.PurchaseReturn
{
    /// <summary>
   
    /// </summary>
    public partial class Skuother : Window
    {
        public Skuother(NewPurchaseReturn newreturn)
        {
            InitializeComponent();
            this.newreturn = newreturn;
            this.Init();
        }
        private void ClearForm()
        {
        }

        private void Init()
        {
            this.LoadTrans();
            this.ClearForm();
        }
        public NewPurchaseReturn newreturn;
        private void LoadTrans()
        {
            this.ClearForm();
            if (this.newreturn != null && this.newreturn.receivedgoodSelected != null)
            {
                txttax.Text = this.newreturn.receivedgoodSelected.IdTransaksi.ToString();
            }
        }
        public OrderCustomBeli GetData()
        {
            OrderCustomBeli oData = new OrderCustomBeli();
            oData.NamaCustom = txtnama.Text;
            oData.HargaCustom = double.Parse(txtprice.Text);
        //    oData.IdTransaksi = newreturn.receivedgoodSelected.IdTransaksi;
            //oData.DiskonProduk = double.Parse(txtdiskon1.Text);
            oData.JumlahCustom = int.Parse(txttotal.Text);
            oData.TotalCustom = double.Parse(txttotal1.Text);
            oData.Checkboxaktif = false;
            return oData;
        }
        public void Addsku_Clicks(object sender, RoutedEventArgs e)
        {
            ShopingchartBLL receivedBLL = new ShopingchartBLL();
                if (receivedBLL.AddOrderCustombeli(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Add Order Buy Custom successfully added !");
                    this.newreturn.LoadDataSku();
                }
                else
                {
                    MessageBox.Show("Add Order Buy Custom failed to add !");
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
