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
    public partial class NewPaymentTerm : Window
    {
        

        public NewPaymentTerm(PaymentTerms paymentTermForm)
        {
            InitializeComponent();
            this.paymentTermForm = paymentTermForm;
            this.Init();
        }

        

        public object UserControl { get; internal set; }
        private PaymentTerms paymentTermForm;
        private IEnumerable<OptionAnnual> optionAnnuals { get; set; }
        private OptionAnnual optionAnnualSelected { get; set; }
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
            if (this.paymentTermForm.isEdit == true)
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
            if (this.paymentTermForm != null && this.paymentTermForm.termsPembayaranSelected != null)
            {
                txtSchemeName.Text = this.paymentTermForm.termsPembayaranSelected.NamaSkema;
                txtGradePeriode.Text = this.paymentTermForm.termsPembayaranSelected.GracePeriod.GetValueOrDefault(0).ToString(); 
                txtDownPayment.Text = this.paymentTermForm.termsPembayaranSelected.UangMuka.GetValueOrDefault(0).ToString(); 
                cbanuality.SelectedValue = this.paymentTermForm.termsPembayaranSelected.IdOptionAnnual;
                txtDuration.Text = this.paymentTermForm.termsPembayaranSelected.TermPembayaran.GetValueOrDefault(0).ToString(); 
                txtInterest.Text = this.paymentTermForm.termsPembayaranSelected.BungaPerBulan.GetValueOrDefault(0).ToString(); 

                this.optionAnnualSelected = this.optionAnnuals.Where(m => m.IdOptionAnnual == this.paymentTermForm.termsPembayaranSelected.IdOptionAnnual).FirstOrDefault();
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
            oData.CheckBoxInactive = chkActive.IsChecked;
            if (this.paymentTermForm.termsPembayaranSelected != null)
                oData.IdTermPembayaran = this.paymentTermForm.termsPembayaranSelected.IdTermPembayaran;

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
            if (this.paymentTermForm.isEdit == false)
            {
                if (TermspembayaranBLL.AddTermPembayaran(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Payment Term added successfully !");
                    this.paymentTermForm.LoadTermspembayaran();
                }
                else
                {
                    MessageBox.Show("Payment Term failed to add !");
                }
            }
            else
            {
                if (TermspembayaranBLL.EditTermPembayaran(this.GetData()) == true)
                {
                    this.ClearForm();
                    MessageBox.Show("Payment Term successfully changed !");
                    this.paymentTermForm.LoadTermspembayaran();
                }
                else
                {
                    MessageBox.Show("Payment Term failed to change !");
                }
            }
            this.Close();
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
