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

namespace Reyuko.App.Views.Tax
{
    /// <summary>
    /// Interaction logic for Tax.xaml
    /// </summary>
    public partial class Tax : UserControl
    {
        public Tax()
        {
            InitializeComponent();
            this.Init();
        }

        private IEnumerable<ListDataPajak> listDataPajaks { get; set; }
        private ListDataPajak listDataPajakSelected { get; set; }
        private DataPajak dataPajak { get; set; }
        private int pageSize = 10;
        private int pageIndex = 1;


        private void Init()
        {
            this.LoadListDataPajak();
        }

        private void ClearForm()
        {
            txtKodePajak.Text = "";
            txtNamaPajak.Text = "";
            txtPersentase.Text = "";
            txtAkunBeli.Text = "";
            txtAkunJual.Text = "";
            txtStatus.Text = "";
            txtKeterangan.Text = "";

            this.dataPajak = null;
        }

        public void LoadListDataPajak()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.listDataPajaks = uow.ListDataPajak.GetAll();
                LstDataPajak.ItemsSource = this.listDataPajaks;
            }
        }

        private void LoadDataPajak(int idPajak)
        {
            this.ClearForm();
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dataPajak = uow.DataPajak.SingleOrDefault(m => m.Id == idPajak);
            }

            if (this.dataPajak != null)
            {
                txtKodePajak.Text = this.dataPajak.KodePajak;
                txtNamaPajak.Text = this.dataPajak.NamaPajak;
                txtPersentase.Text = this.dataPajak.Persentase.ToString();
                txtAkunBeli.Text = this.dataPajak.AkunBeli;
                txtAkunJual.Text = this.dataPajak.AkunJual;
                txtStatus.Text = "";
                txtKeterangan.Text = this.dataPajak.Keterangan;
            }
        }


        private void LstDataPajak_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.listDataPajakSelected = null;
            if (LstDataPajak.SelectedItem != null)
            {
                this.listDataPajakSelected = (ListDataPajak)LstDataPajak.SelectedItem;
                this.LoadDataPajak(this.listDataPajakSelected.IdPajak.GetValueOrDefault(0));
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (this.dataPajak != null)
            {
                bool isWindowOpen = false;

                foreach (Window w in Application.Current.Windows)
                {
                    if (w is EditTax)
                    {
                        isWindowOpen = true;
                        w.Activate();
                    }
                }

                if (!isWindowOpen)
                {
                    EditTax newlokasi = new EditTax(this.dataPajak);
                    newlokasi.Show();
                }
            }
        }
        private void New_Click(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is NewTax)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                NewTax newtax = new NewTax(this);
                newtax.Show();
            }
        }

        private void Accountsetting_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (this.dataPajak == null)
            {
                MessageBox.Show("Tax not selected !");
            }
            else
            {
                DataPajakBLL DataPajakBLL = new DataPajakBLL();
                this.dataPajak.CheckBoxInAktif = true;
                if (DataPajakBLL.EditPajak(this.dataPajak) == true)
                {
                    MessageBox.Show("Successfully set tax is not active");
                    this.LoadListDataPajak();
                    this.listDataPajakSelected = null;
                    this.dataPajak = null;
                }
            }
        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}



