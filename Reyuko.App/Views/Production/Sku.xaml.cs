using Reyuko.BLL.Core;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class Sku : Window
    {
        public Sku(NewProduction newproduct)
        {
            InitializeComponent();
            this.newproduct = newproduct;
            this.Init();
        }
        public IEnumerable<produk> produks { get; set; }
        public produk produkSelected;
        public IEnumerable<DataDepartemen> dataDepartemens { get; set; }
        public DataDepartemen Selectdepartment { get; set; }
        public IEnumerable<DataProyek> dataProyeks { get; set; }
        public DataProyek Selectproyek { get; set; }
        private void ClearForm()
        {
        }

        private void Init()
        {
            this.ClearForm();
            this.Loadproduk();
        }
        public NewProduction newproduct;
        private void Loadproduk()
        {
             using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
             {
                    this.produks = uow.produk.GetAll();
                    srsku.ItemsSource = this.produks;
             }
        }
        public void LoadDepartmen()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dataDepartemens = uow.DataDepartemen.GetAll();
                cbdepartmen.ItemsSource = this.dataDepartemens;
                cbdepartmen.SelectedValuePath = "Id";
                cbdepartmen.DisplayMemberPath = "NamaDepartemen";
            }
        }
        public void LoadProyek()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dataProyeks = uow.DataProyek.GetAll();
                cbproject.ItemsSource = this.dataProyeks;
                cbproject.SelectedValuePath = "Id";
                cbproject.DisplayMemberPath = "NamaProyek";
            }
        }
        private void produk_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.produkSelected = null;
            if (srsku.SelectedItem != null)
            {
                this.produkSelected = (produk)srsku.SelectedItem;
                txtunit.Text = this.produkSelected.SatuanDasar;
                txtprice.Text = this.produkSelected.HargaPokokAverage.ToString();
            }
        }
        private void department_selectionchange(object sender, SelectionChangedEventArgs e)
        {
            this.Selectdepartment = null;
            if (cbdepartmen.SelectedItem != null)
            {
                Selectdepartment = (DataDepartemen)cbdepartmen.SelectedItem;
            }
        }
        private void proyek_selectionchange(object sender, SelectionChangedEventArgs e)
        {
            this.Selectproyek = null;
            if (cbproject.SelectedItem != null)
            {
                Selectproyek = (DataProyek)cbproject.SelectedItem;
            }
        }
        public void Departmen_Checked(object sender, EventArgs e)
        {
            this.rbdepartmen.IsChecked = true;
            {
                cbdepartmen.Visibility = Visibility.Visible;
                cbproject.Visibility = Visibility.Hidden;
                cbproject.SelectedIndex = -1;
                this.LoadDepartmen();
            }
        }

        public void Proyek_Checked(object sender, EventArgs e)
        {
            this.rbproject.IsChecked = true;
            {
                cbproject.Visibility = Visibility.Visible;
                cbdepartmen.Visibility = Visibility.Hidden;
                cbdepartmen.SelectedIndex = -1;
                this.LoadProyek();
            }

        }
        public OrderProductioninput GetData()
        {
            OrderProductioninput oData = new OrderProductioninput();
            if (this.produkSelected != null)
            {
                oData.IdProduk = this.produkSelected.IdProduk;
                oData.Sku = this.produkSelected.SKU;
                oData.SatuanDasar = this.produkSelected.SatuanDasar;
                oData.HargaPokok = this.produkSelected.HargaPokokAverage;
                oData.NamaProduk = this.produkSelected.NamaProduk;
                oData.IdAkunPersediaan = this.produkSelected.IdAkunPersediaan;
            }
            if (this.Selectdepartment != null)
            {
                oData.IdDepartemen = this.Selectdepartment.Id;
            }
            if (this.Selectproyek != null)
            {
                oData.IdProyek = this.Selectproyek.Id;
            }
            oData.JumlahProduk = double.Parse(txttotal.Text);
            oData.TotalOrderProduk = double.Parse(txttotal1.Text);
            oData.CheckboxAktif = true;
            return oData;
        }
        public void Addsku_Clicks(object sender, RoutedEventArgs e)
        {
            ProductionBLL productionBLL = new ProductionBLL();
                if (productionBLL.AddOrderProdutioninput(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Add Order Production Input successfully added !");
                    this.newproduct.LoadDataSku();
                }
                else
                {
                    MessageBox.Show("Add Order Production Input failed to add !");
                }
            this.Close();
        }

        private void Cancel_Clicks(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void load(object sender, EventArgs e)
        {
        }

        private void txttotal_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txttotal.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txttotal.Text = "";
                    return;
                }

            }
            txttotal1.Text = ((float.Parse(txttotal.Text.ToString()) * float.Parse(txtprice.Text.ToString()))).ToString();
        }
            
       
    }
}
