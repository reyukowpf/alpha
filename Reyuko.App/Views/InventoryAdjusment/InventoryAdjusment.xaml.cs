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

namespace Reyuko.App.Views.InventoryAdjusment
{
    /// <summary>
    
    /// </summary>
    public partial class InventoryAdjusment : UserControl
    {
        public InventoryAdjusment()
        {
            InitializeComponent();
            Switcher.pageSwitcherinventoryadjusmen = this;
            this.Init();
        }
        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
        private void Init()
        {
            this.LoadInventory();
        }
        public IEnumerable<PermPenyTransferBarang> permPenyTransferBarangs { get; set; }
        public PermPenyTransferBarang PermPenyTransferBarangSelected;
        public void LoadInventory()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.permPenyTransferBarangs = uow.PermPenyTransferBarang.GetAll();
                DGInventoryAdjusment.ItemsSource = this.permPenyTransferBarangs;
            }
        }
        private void Detail_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NewInvetoryAdjusment_Click(object sender, RoutedEventArgs e)
        {
            NewInventoryAdjusment v = new NewInventoryAdjusment();
            Switcher.Switchinventoryadjusmen(v);
        }

        private void Txtvalue_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtvalue.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
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
                    MessageBox.Show("Must be Numeric");
                    txtRange.Text = "";
                    return;
                }

            }
        }
    }
}
             
    

