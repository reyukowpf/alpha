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

namespace Reyuko.App.Views.DocumentType
{
    /// <summary>
    /// </summary>
    public partial class NewDocumentType : Window
    {
        public NewDocumentType(DocumentType documentTypeForm)
        {
            InitializeComponent();
            this.documentTypeForm = documentTypeForm;
            this.ClearForm();
        }

        public object UserControl { get; internal set; }
        private DocumentType documentTypeForm { get; set; }

        private void ClearForm()
        {
            txtDocumentType.Text = "";
            txtDescription.Text = "";
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (txtDescription.Text == "" || txtDocumentType.Text == "" )
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            TypeDokumenBLL typeDokumenBLL = new TypeDokumenBLL();
            TypeDokumen oData = new TypeDokumen();
            oData.Type = txtDocumentType.Text;
            oData.Keterangan = txtDescription.Text;

            if (typeDokumenBLL.AddTypeDokumen(oData) > 0)
            {
                this.ClearForm();
                MessageBox.Show("Document Type successfully saved");
                this.documentTypeForm.LoadTypeDokumen();
            }
            else
            {
                MessageBox.Show("Document Type failed to save");
            }
            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.ClearForm();
            this.Close();
        }

        private void TxtDocumentType_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtDocumentType_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtDescription_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
