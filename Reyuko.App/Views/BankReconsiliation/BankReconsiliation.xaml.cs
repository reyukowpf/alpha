using Reyuko.BLL.Core;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
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

namespace Reyuko.App.Views.BankReconsiliation
{
    /// <summary>
    
    /// </summary>
    public partial class BankReconsiliation : UserControl
    {
        public BankReconsiliation()
        {
            InitializeComponent();
        }

        private void Adjusment_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AutoReconsiliation_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Reconsiliation_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {

        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Txtaccountbalance_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtaccountbalance.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtaccountbalance.Text = "";
                    return;
                }

            }
        }
    }

}
             
    

