using Reyuko.BLL.Core;
using Reyuko.DAL.Domain;
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

namespace Reyuko.App.Views.Tax
{
    /// <summary>
    /// Interaction logic for NewTax.xaml
    /// </summary>
    public partial class NewTax : Window
    {
        public NewTax(Tax taxForm)
        {
            InitializeComponent();
            this.taxForm = taxForm;
            this.ClearForm();
        }

        public object UserControl { get; internal set; }
        private Tax taxForm { get; set; }
        private void ClearForm()
        {
            TXTKodePajak.Text = "";
            TXTNamaPajak.Text = "";
            TXTPersentase.Text = "0";
            TXTKeterangan.Text = "";
            CHKAktif.IsChecked = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (TXTKodePajak.Text == "" || TXTNamaPajak.Text == "" || TXTPersentase.Text == "" || TXTKeterangan.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            DataPajakBLL dataPajakBLL = new DataPajakBLL();
            DataPajak oData = new DataPajak();
            oData.KodePajak = TXTKodePajak.Text;
            oData.NamaPajak = TXTNamaPajak.Text;
            oData.Persentase = double.Parse(TXTPersentase.Text);
            oData.IdAkunBeli = 0;
            oData.AkunBeli = "";
            oData.IdAkunJual = 0;
            oData.AkunJual = "";
            oData.Keterangan = TXTKeterangan.Text;
            oData.CheckBoxInAktif = CHKAktif.IsChecked;

            if (dataPajakBLL.AddPajak(oData) > 0)
            {
                this.ClearForm();
                this.taxForm.LoadListDataPajak();
                MessageBox.Show("Tax Data saved successfully");

            }
            else
            {
                MessageBox.Show("Tax Data failed to save");
            }
            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.ClearForm();
            this.Close();
        }

        private void TXTKodePajak_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TXTPersentase_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TXTPersentase.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TXTPersentase.Text = "";
                    return;
                }

            }
        }

        private void TXTNamaPajak_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TXTNamaPajak.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    TXTNamaPajak.Text = "";
                    return;
                }

            }
        }

        private void TXTKeterangan_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
