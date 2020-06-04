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

namespace Reyuko.App.Views.CashActivities
{
    /// <summary>
   
    /// </summary>
    public partial class Giro : Window
    {
        public Giro()
        {
            InitializeComponent();
            this.Init();
        }

        private void ClearForm()
        {
            txtchequeno.Text = "";
            txtchequeaccountno.Text = "";
            txtbank.Text = "";
            tanggalgiro.Text = DateTime.Now.ToShortDateString();
        }

        private void Init()
        {
            this.ClearForm();
        }
       /* public OrderTransaksiCash GetData()
        {
            OrderTransaksiCash oData = new OrderTransaksiCash();
            if (this.rekeningPerkiraanSelected != null)
            {
                oData.IdAkunHutangPiutangReferensi = this.rekeningPerkiraanSelected.Id;
            }
            oData.Debit = double.Parse(txtdebit.Text);
            oData.Keterangan = txtnote.Text;
            oData.Checkboxaktif = true;
            return oData;
        }*/
        public void Addjurnal_Clicks(object sender, RoutedEventArgs e)
        {
           /* CashActivityBLL cashBLL = new CashActivityBLL();
                if (cashBLL.Addtranscash(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Add Order Cash Transaction successfully added !");
                    this.newCash.LoadDataAccount();
                }
                else
                {
                    MessageBox.Show("Add Order Cash Transaction failed to add !");
                }
            this.Close();*/
        }

        private void Cancel_Clicks(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

      
    }
}
