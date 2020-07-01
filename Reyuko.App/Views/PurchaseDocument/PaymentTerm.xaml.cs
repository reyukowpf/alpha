using Reyuko.App.Views.Invoice;
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

namespace Reyuko.App.Views.PurchaseDocument
{
    /// <summary>
    /// </summary>
    public partial class PaymentTerm : Window
    {
        

        public PaymentTerm(NewQuotationRequest paymentTermForm)
        {
            InitializeComponent();
            this.paymentTermForm = paymentTermForm;
            this.Init();
        }

        public PaymentTerm(NewPurchasedOrder newPurchased)
        {
            InitializeComponent();
            this.newPurchased = newPurchased;
            this.Init();
        }

        public object UserControl { get; internal set; }
        public NewQuotationRequest paymentTermForm;
        public NewPurchasedOrder newPurchased;
        private IEnumerable<OptionAnnual> optionAnnuals { get; set; }
        private OptionAnnual optionAnnualSelected { get; set; }
        private IEnumerable<Termspembayaran> termspembayarans { get; set; }
        public Termspembayaran termspembayaranSelected { get; set; }
        public bool isEdit = false;

        private void ClearForm()
        {
            txtSchemeName.Text = "";
            txtGradePeriode.Text = "";
            txtDownPayment.Text = "";
            this.optionAnnualSelected = null;

            cbanuality.SelectedIndex = -1;
            txtDuration.Text = "";
            txtInterest.Text = "";
        }
        private void Init()
        {
            this.ClearForm();
            this.LoadPaymentTerm();
            this.LoadTermspembayaran();
        }

        private void LoadPaymentTerm()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.optionAnnuals = uow.OptionAnnual.GetAll();
                cbanuality.ItemsSource = this.optionAnnuals;
                cbanuality.SelectedValuePath = "IdOptionAnnual";
                cbanuality.DisplayMemberPath = "Annual";
            }
        }
        private void CbAnnual_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.optionAnnualSelected = null;
            if (cbanuality.SelectedItem != null)
            {
                this.optionAnnualSelected = (OptionAnnual)cbanuality.SelectedItem;
            }
        }

        private void LoadTermspembayaran()
        {
            this.ClearForm();
            if (this.paymentTermForm != null && this.paymentTermForm.termspembayaranSelected != null)
            {
                txtSchemeName.Text = this.paymentTermForm.termspembayaranSelected.NamaSkema;
                txtGradePeriode.Text = this.paymentTermForm.termspembayaranSelected.GracePeriod.GetValueOrDefault(0).ToString(); 
                txtDownPayment.Text = this.paymentTermForm.termspembayaranSelected.UangMuka.GetValueOrDefault(0).ToString(); 
                cbanuality.SelectedValue = this.paymentTermForm.termspembayaranSelected.IdOptionAnnual;
                txtDuration.Text = this.paymentTermForm.termspembayaranSelected.TermPembayaran.GetValueOrDefault(0).ToString(); 
                txtInterest.Text = this.paymentTermForm.termspembayaranSelected.BungaPerBulan.GetValueOrDefault(0).ToString(); 

                this.optionAnnualSelected = this.optionAnnuals.Where(m => m.IdOptionAnnual == this.paymentTermForm.termspembayaranSelected.IdOptionAnnual).FirstOrDefault();
            }
        }

        private Termspembayaran GetData()
        {
            Termspembayaran oData = new Termspembayaran();
            
            oData.NamaSkema = txtSchemeName.Text;
            oData.GracePeriod = double.Parse(txtGradePeriode.Text);
            oData.UangMuka = double.Parse(txtDownPayment.Text);
            if (this.optionAnnualSelected != null)
            {
                oData.IdOptionAnnual = this.optionAnnualSelected.IdOptionAnnual;
                oData.Annual = this.optionAnnualSelected.Annual;
            }
            oData.TermPembayaran = int.Parse(txtDuration.Text);
            oData.BungaPerBulan = double.Parse(txtInterest.Text);
            if (this.paymentTermForm.termspembayaranSelected != null)
                oData.IdTermPembayaran = this.paymentTermForm.termspembayaranSelected.IdTermPembayaran;
      
            return oData;
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (txtSchemeName.Text == "" || txtGradePeriode.Text == "" || txtDownPayment.Text == "" || cbanuality.Text == "" || txtDuration.Text == "" || txtInterest.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            TermspembayaranBLL TermspembayaranBLL = new TermspembayaranBLL();
            {
                if (TermspembayaranBLL.AddTermPembayaran(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Payment Term added successfully !");
                  
                }
                else
                {
                    MessageBox.Show("Payment Term failed to add !");
                }
            }
          }
        

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.ClearForm();
            this.Close();
        }

        private void TxtDownPayment_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtDownPayment.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtDownPayment.Text = "";
                    return;
                }

            }
        }

        private void TxtDuration_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtDuration.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtDuration.Text = "";
                    return;
                }

            }
        }

        private void TxtInterest_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtInterest.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtInterest.Text = "";
                    return;
                }

            }
        }

        private void TxtSchemeName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtSchemeName.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtSchemeName.Text = "";
                    return;
                }

            }
        }

        private void TxtGradePeriode_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
