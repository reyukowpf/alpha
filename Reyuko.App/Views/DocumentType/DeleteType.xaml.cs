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
    public partial class DeleteType : Window
    {
        public DeleteType()
        {
            InitializeComponent();
        }

        public object UserControl { get; internal set; }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (cbdocumenttype.Text == "" )
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
