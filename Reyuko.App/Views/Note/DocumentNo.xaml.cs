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

namespace Reyuko.App.Views.Note
{
    /// <summary>
    /// </summary>
    public partial class DocumentNo : Window
    {
        public DocumentNo()
        {
            InitializeComponent();
           
        }

        
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (cbDocumentTipe.Text == "" || date.Text == "" || txtDocumentNo.Text == "" || srcustomer.Name == "" || txtDescription.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TxtDocumentNo_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtDocumentNo.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtDocumentNo.Text = "";
                    return;
                }

            }
        }

        private void TxtDescription_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
