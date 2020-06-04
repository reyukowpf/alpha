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

namespace Reyuko.App.Views.Sales
{
    /// <summary>
    
    /// </summary>
    public partial class InternalNote : Window
    {
        public InternalNote()
        {
            InitializeComponent();
        }

        private void Savesales_Click(object sender, RoutedEventArgs e)
        {
            if (srcustomer.Name == "" || txtRefereneNumber.Text == "" || txtNoteType.Text == "" || dtNote.Text == "" || txtNoteTitle.Text == "" || dtReminder.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("TextBoc Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

        private void StockList_Click(object sender, RoutedEventArgs e)
        {
            StockList v = new StockList();
            v.Show();
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
            this.Close();
        }
        private void notes_Click(object sender, RoutedEventArgs e)
        {

        }
        private void saveasdraft_Click(object sender, RoutedEventArgs e)
        {

        }
        private void saveaspdf_Click(object sender, RoutedEventArgs e)
        {

        }
        private void duplicate_Click(object sender, RoutedEventArgs e)
        {

        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Product_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TxtRefereneNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtRefereneNumber.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Harus Diisi Numerik");
                    txtRefereneNumber.Text = "";
                    return;
                }

            }
        }

        private void TxtNoteType_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtNoteType.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Harus Diisi Numerik");
                    txtNoteType.Text = "";
                    return;
                }

            }
        }

        private void TxtNoteTitle_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtNoteTitle.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Harus Diisi Numerik");
                    txtNoteTitle.Text = "";
                    return;
                }

            }
        }
    }
}
             
    

