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

namespace Reyuko.App.Views.Production
{
    /// <summary>
    
    /// </summary>
    public partial class Production : UserControl
    {
        public Production()
        {
            InitializeComponent();
            Switcher.pageSwitchProduction = this;
            this.Init();
        }

       

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
        public IEnumerable<production> productions { get; set; }
        public bool isEdit = false;
        private void Init()
        {
            this.LoadProduction();
        }
        public void LoadProduction()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.productions = uow.Production.GetAll();
                DGProduction.ItemsSource = this.productions;
            }
        }
        private void NewProduction_Click(object sender, RoutedEventArgs e)
        {
            this.isEdit = false;
            NewProduction newProduction = new NewProduction(this);
            Switcher.SwitchProduction(newProduction);
        }

        private void EditProduction_Click(object sender, RoutedEventArgs e)
        {
            this.isEdit = true;
            NewProduction newProduction = new NewProduction(this);
            Switcher.SwitchProduction(newProduction);
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

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {

        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Txtvalue_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtvalue.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Harus Diisi Numerik");
                    txtvalue.Text = "";
                    return;
                }

            }
        }

        private void TxtRange_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtRange.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Harus Diisi Numerik");
                    txtRange.Text = "";
                    return;
                }

            }
        }
    }
}
             
    

