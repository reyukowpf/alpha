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

namespace Reyuko.App.Views.Company
{
    /// <summary>
    
    /// </summary>
    public partial class Company : UserControl
    {
        public Company()
        {
            InitializeComponent();
            Switcher.pageSwitchCompany = this;
        }
        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
        private void NewCompany_Click(object sender, RoutedEventArgs e)
        {
            NewCompany newCompany = new NewCompany();
            Switcher.SwitchCompany(newCompany);
        }

        private void EditCompany_Click(object sender, RoutedEventArgs e)
        {

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

        private void NewDocument_Click(object sender, RoutedEventArgs e)
        {
            //Document.Document v = new Document.Document();
           // v.Show();
        }
        private void NewInternalNotes_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
             
    

