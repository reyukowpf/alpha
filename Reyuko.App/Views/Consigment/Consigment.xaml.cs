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

namespace Reyuko.App.Views.Consigment
{
    /// <summary>
    
    /// </summary>
    public partial class Consigment : UserControl
    {
        public Consigment()
        {
            InitializeComponent();
            Switcher.pageSwitcherconsigment = this;
            this.Init();
        }    

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
        private IEnumerable<Kontak> kontaks { get; set; }
        public Kontak kontakSelected { get; set; }
        public IEnumerable<PenerimaanBarang> penerimaanBarangs { get; set; }
        public PenerimaanBarang penerimaanBarangSelected { get; set; }
        public IEnumerable<ListKonsinyasi> listKonsinyasi { get; set; }
        public ListKonsinyasi listKonsinyasiSelected;
        public bool isEdit = false;

        private void Init()
        {
            this.LoadVendor();
            this.LoadConsigment();
        }

        private void LoadConsigment()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.listKonsinyasi = uow.ListKonsinyasi.GetAll();
                DGConsigment.ItemsSource = this.listKonsinyasi;
            }
        }

        public void LoadVendor()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kontaks = uow.Kontak.GetAll().Where(m => m.TypeKontak.ToLower() == "vendor");
                srvendor.ItemsSource = this.kontaks;
            }
        }
        private void EditConsigment_Click(object sender, RoutedEventArgs e)
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

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NewReturn_Click(object sender, RoutedEventArgs e)
        {
            NewConsigmentReturn v = new NewConsigmentReturn(this);
            Switcher.Switchconsigment(v);
        }
        private void NewReceive_Click(object sender, RoutedEventArgs e)
        {
            NewConsigmentReceive v = new NewConsigmentReceive(this);
            Switcher.Switchconsigment(v);
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
             
    

