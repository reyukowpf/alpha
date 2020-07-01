using Reyuko.BLL.Core;
using Reyuko.DAL.Domain;
using Reyuko.Utils.Common;
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
    public partial class EditTax : Window
    {
        public EditTax(DataPajak dataPajak)
        {
            InitializeComponent();
            this.dataPajak = dataPajak;
            this.Init();            
        }

        public object UserControl { get; internal set; }
        private DataPajak dataPajak { get; set; }

        private void Init()
        {
            this.LoadDataPajak();
        }

        private void ClearForm()
        {
            TXTKodePajak.Text = "";
            TXTNamaPajak.Text = "";
            TXTPersentase.Text = "0";
            TXTKeterangan.Text = "";
            CHKAktif.IsChecked = false;
        }

        private void LoadDataPajak()
        {
            this.ClearForm();
            TXTKodePajak.Text = this.dataPajak.KodePajak;
            TXTNamaPajak.Text = this.dataPajak.NamaPajak;
            TXTPersentase.Text = this.dataPajak.Persentase.ToString();
            TXTKeterangan.Text = this.dataPajak.Keterangan;
            CHKAktif.IsChecked = this.dataPajak.CheckBoxInAktif;
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
            if (this.dataPajak != null)
            {
                DataPajakBLL dataPajakBLL = new DataPajakBLL();
                DataPajak oData = new DataPajak();
                oData.MapFrom(this.dataPajak);
                oData.KodePajak = TXTKodePajak.Text;
                oData.NamaPajak = TXTNamaPajak.Text;
                oData.Persentase = double.Parse(TXTPersentase.Text);
                oData.AkunBeli = "";
                oData.AkunJual = "";
                oData.Keterangan = TXTKeterangan.Text;

                if (dataPajakBLL.EditPajak(oData) == true)
                {
                    MessageBox.Show("Tax Data successfully edited");
                }
                else
                {
                    MessageBox.Show("Tax Data failed to edit");
                }
            }
            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.LoadDataPajak();
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
