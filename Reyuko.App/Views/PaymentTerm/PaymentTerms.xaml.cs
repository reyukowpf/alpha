using Reyuko.BLL.Core;
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

namespace Reyuko.App.Views.PaymentTerm
{
    /// <summary>
    
    /// </summary>
    public partial class PaymentTerms : UserControl
    {
        public PaymentTerms()
        {
            InitializeComponent();
            this.Init();
        }

        private IEnumerable<Termspembayaran> termsPembayarans { get; set; }
        public Termspembayaran termsPembayaranSelected { get; set; }
        public bool isEdit = false;
        private int pageIndex = 1;
        private int pageSize = 10;
        private void Init()
        {
            this.ClearForm();
            this.LoadTermspembayaran();
        }

        private void ClearForm()
        {
            this.termsPembayaranSelected = null;
        }

        public void LoadTermspembayaran()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.termsPembayarans = uow.Termspembayaran.GetPaged(this.pageIndex, this.pageSize);
                DGSPaymentTerm.ItemsSource = this.termsPembayarans;
            }
        }

        private void NewPaymentTerm_Click(object sender, RoutedEventArgs e)
        {
            this.isEdit = false;
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is NewPaymentTerm)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                NewPaymentTerm period = new NewPaymentTerm(this);
                period.Show();
            }
        }

        private void EditPaymentTerm_Click(object sender, RoutedEventArgs e)
        {
            this.isEdit = true;
            NewPaymentTerm v = new NewPaymentTerm(this);
            v.Show();
        }
        private void DGPaymentTerm_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.termsPembayaranSelected = null;
            if (DGSPaymentTerm.SelectedItem != null)
            {
                this.termsPembayaranSelected = (Termspembayaran)DGSPaymentTerm.SelectedItem;
            }
        }

        private void RefreshPaymentTerm_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (this.termsPembayaranSelected == null)
            {
                MessageBox.Show("Payment Terms not selected !");
            }
            else
            {
                TermspembayaranBLL TermsPembayaranBLL = new TermspembayaranBLL();
                if (TermsPembayaranBLL.RemoveTermPembayaran(this.termsPembayaranSelected.IdTermPembayaran) == true)
                {
                    MessageBox.Show("Payment Terms successfully deleted");
                    this.LoadTermspembayaran();
                    this.termsPembayaranSelected = null;
                }
            }
        }
        private void viewinactived_Click(object sender, RoutedEventArgs e)
        {

        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }

      
    }
}
             
    

