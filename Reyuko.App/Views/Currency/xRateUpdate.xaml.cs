using Reyuko.BLL.Core;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Reyuko.App.Views.Currency
{
    /// <summary>
    /// Interaction logic for xRateUpdate.xaml
    /// </summary>
    public partial class xRateUpdate : Window
    {
        public xRateUpdate()
        {
            InitializeComponent();
            this.currencyForm = currencyForm;
        }

        private Currency currencyForm { get; set; }
        private IEnumerable<DataMataUang> dataMataUangs { get; set; }

        public void Init(Currency currencyForm)
        {
            this.ClearForm();
            this.currencyForm = currencyForm;
            if (this.currencyForm.dataMataUangSelected != null)
                txtCurrency.Text = this.currencyForm.dataMataUangSelected.NamaMataUang;
        }

        private void ClearForm()
        {
            TXTExRate.Text = "0";
            DPTanggal.Text = DateTime.Now.ToShortDateString();
            txtCurrency.Text = "";
        }
        
        private void Simpan_Clicks(object sender, RoutedEventArgs e)
        {
            string message = "";
            if (Helper.IsNumeric(TXTExRate.Text) == false)
                message += "The rate must be a number\n";
            if (Helper.IsDateTime(DPTanggal.Text) == false)
                message += "Date format is incorrect\n";

            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message);
                return;
            }

            DataMataUangBLL dataMataUangBLL = new DataMataUangBLL();
            KursMataUang oNewData = new KursMataUang();

            oNewData.IdDataMataUang = this.currencyForm.dataMataUangSelected.Id;
            oNewData.KodeMataUang = this.currencyForm.dataMataUangSelected.KodeMataUang;
            oNewData.Tanggal = DateTime.Parse(DPTanggal.Text);
            oNewData.Exrate = double.Parse(TXTExRate.Text);

            if (dataMataUangBLL.AddKurs(oNewData) > 0)
            {
                this.ClearForm();
                this.currencyForm.LoadDataMataUang();
                MessageBox.Show("Exchange rate successfully added");
            }
            else
            {
                MessageBox.Show("Exchange rate failed to add");
            }
            this.Close();
        }

        private void Cancel_Clicks(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
