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

namespace Reyuko.App.Views.StockOpname   
{
    /// <summary>
    
    /// </summary>
    public partial class NewInventoryChecking : UserControl
    {
        public NewInventoryChecking()
        {
            InitializeComponent();
            Switcher.pageSwitchernewcheking = this;
        }
        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        private void SaveInventoryChecking_Click(object sender, RoutedEventArgs e)
        {
            if (txtReferenceNumber.Text == "" || DocumentReference.Name == "" || cbAccount.Text == "" || date.Text == "" || Staf.Name == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is Print.Print)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                Print.Print print = new Print.Print();
                print.Show();
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            InventoryChecking v = new InventoryChecking();
            Switcher.Switchnewcheking(v);
        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TxtReferenceNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
             
    

