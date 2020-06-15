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
    public partial class Skuother : Window
    {
        public Skuother(NewProduction newproduct)
        {
            InitializeComponent();
            this.newproduct = newproduct;
            this.Init();
        }
        private void ClearForm()
        {
        }

        private void Init()
        {
            this.ClearForm();
            this.LoadComboakun();
        }
        public NewProduction newproduct;
        public IEnumerable<RekeningPerkiraan> rekeningPerkiraans { get; set; }
        public RekeningPerkiraan rekeningPerkiraanSelected;
        private void LoadComboakun()
        {
            this.rekeningPerkiraans = new List<RekeningPerkiraan>();
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.rekeningPerkiraans = uow.RekeningPerkiraan.GetAll();
                cbAkun.DisplayMemberPath = "NamaRekeningPerkiraan";
                cbAkun.SelectedValuePath = "Id";
                cbAkun.ItemsSource = this.rekeningPerkiraans;
            }
        }

        public OrderProductioncustom GetData()
        {
            OrderProductioncustom oData = new OrderProductioncustom();
            oData.NamaCustom = txtnama.Text;
           // oData.SatuanCustom = txtunit.Text;
            //oData.HargaCustom = double.Parse(txtprice.Text);
   //         oData.JumlahCustom = double.Parse(txttotal.Text);
            oData.TotalCustom = double.Parse(txttotal1.Text);
            if (this.rekeningPerkiraanSelected != null)
            {
                oData.IdAkunCustom = this.rekeningPerkiraanSelected.Id;
                oData.AkunCustom = this.rekeningPerkiraanSelected.NamaRekeningPerkiraan;
            }
            oData.CheckboxAktif = true;
            return oData;
        }
        public void Addsku_Clicks(object sender, RoutedEventArgs e)
        {
            ProductionBLL productionBLL = new ProductionBLL();
                if (productionBLL.AddOrderProdutioncustom(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Add Order Production Custom successfully added !");
                    this.newproduct.LoadDataSku();
                }
                else
                {
                    MessageBox.Show("Add Order Production Custom failed to add !");
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
           /* string tString = txttotal.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txttotal.Text = "";
                    return;
                }

            }*/
         
        }

        private void txtprice_TextChanged(object sender, TextChangedEventArgs e)
        {
       //     txttotal1.Text = txtprice.Text.ToString();
        }

        private void cbAkun_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.rekeningPerkiraanSelected = null;
            if (cbAkun.SelectedItem != null)
            {
                this.rekeningPerkiraanSelected = (RekeningPerkiraan)cbAkun.SelectedItem;
            }
        }
    }
}
