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
    public partial class Skucustom : Window
    {
        public Skucustom(NewInvoice newinvoice)
        {
            InitializeComponent();
            this.newinvoice = newinvoice;
            this.Init();
        }
        private void ClearForm()
        {
            
        }

        private void Init()
        {
            this.ClearForm();
        }
        public NewInvoice newinvoice;
        public OrderCustomJual GetData()
        {
            OrderCustomJual oData = new OrderCustomJual();
            oData.HargaCustom = double.Parse(txtharga.Text);
            oData.NamaCustom = txtnama.Text;
          //  oData.DiskonJasa = double.Parse(txtdiskon1.Text);
            oData.JumlahCustom = int.Parse(txttotal.Text);
            oData.TotalCustom = double.Parse(txttotal1.Text);
            oData.Checkbokaktif = true;
            return oData;
        }
        public void Addsku_Clicks(object sender, RoutedEventArgs e)
        {
            InvoicesBLL invoiceBLL = new InvoicesBLL();
                if (invoiceBLL.AddOrderCustomJual(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Add Order Sell Custom successfully added !");
                    this.newinvoice.LoadDataSku();
                }
                else
                {
                    MessageBox.Show("Add Order Sell Custom failed to add !");
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
            txttotal1.Text = ((float.Parse(txttotal.Text.ToString()) * float.Parse(txtharga.Text.ToString()))).ToString();
        }
            
       
    }
}
