using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
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

namespace Reyuko.App.Views.TransactionCode
{
    /// <summary>


    public partial class TransactionCode : UserControl
    {
        public TransactionCode()
        {
            InitializeComponent();
            this.Init();
        }

        private IEnumerable<KodeTransaksi> kodeTransaksis { get; set; }
        private KodeTransaksi kodeTransaksiSelected { get; set; }
        private int pageIndex = 1;
        private int pageSize = 10;

        private void Init()
        {
            this.ClearForm();
            this.LoadKodeTransaksi();
        }

        private void ClearForm()
        {
            this.kodeTransaksiSelected = null;
        }

        public void LoadKodeTransaksi()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kodeTransaksis = uow.KodeTransaksi.GetAll();
                DGTransactionCode.ItemsSource = this.kodeTransaksis;
            }
        }


        private void BtnEditTransactionCode_Clicks(object sender, RoutedEventArgs e)
        {

        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

