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

namespace Reyuko.App.Views.Currency
{
    /// <summary>
    /// Interaction logic for Currency.xaml
    /// </summary>
    public partial class Currency : UserControl
    {
        public Currency()
        {
            InitializeComponent();
            this.Init();
        }

        public DataMataUang dataMataUangSelected { get; set; }
        private IEnumerable<DataMataUang> dataMataUangs { get; set; }
        private IEnumerable<KursMataUang> kursMataUangs { get; set; }
        private int pageSize = 10;
        private int pageIndex = 1;


        private void Init()
        {
            this.LoadDataMataUang();
        }

        public void LoadDataMataUang()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dataMataUangs = uow.DataMataUang.GetAll().Where(m => m.CheckBoxAktif == true);
                LICurrency.ItemsSource = this.dataMataUangs;
            }
        }

        private void ClearForm()
        {
            this.kursMataUangs = null;
        }

        private void LoadKursMataUang(int idDataMataUang)
        {
            this.ClearForm();
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kursMataUangs = uow.KursMataUang.GetAll().Where(m => m.IdDataMataUang == idDataMataUang);
                DGCurrencyDetail.ItemsSource = this.kursMataUangs;
            }
        }


        private void LICurrency_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.dataMataUangSelected = null;
            if (LICurrency.SelectedItem != null)
            {
                this.dataMataUangSelected = (DataMataUang)LICurrency.SelectedItem;
                this.LoadKursMataUang(this.dataMataUangSelected.Id);
            }
        }

        private void DGCurrencyDetail_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void NewCurrency_Clicks(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is NewCurrency)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                NewCurrency newCurrency = new NewCurrency(this);
                newCurrency.Show();
            }

        }

        private void ExRateUp_Clicks(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is xRateUpdate)
                {
                    isWindowOpen = true;
                    var x = (xRateUpdate)w;
                    x.Activate();
                    x.Init(this);
                }
            }

            if (!isWindowOpen)
            {
                xRateUpdate xrateu = new xRateUpdate();
                xrateu.Show();
                xrateu.Init(this);
            }
        }

        private void Setasdefault_Click(object sender, RoutedEventArgs e)
        {
            if (this.dataMataUangSelected == null)
            {
                MessageBox.Show("Currency has not been selected!");
            }
            else
            {
                DataMataUangBLL dataMataUangBLL = new DataMataUangBLL();
                DataMataUang oData = new DataMataUang();
                using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
                    oData = uow.DataMataUang.SingleOrDefault(m => m.DefaultDataMataUang == 1);
                if (oData != null)
                {
                    oData.DefaultDataMataUang = 0;
                    dataMataUangBLL.EditMataUang(oData);
                }

                this.dataMataUangSelected.DefaultDataMataUang = 1;
                if (dataMataUangBLL.EditMataUang(this.dataMataUangSelected) == true)
                {
                    MessageBox.Show("Currency is successfully set as default");
                    this.LoadDataMataUang();
                    this.dataMataUangSelected = null;
                }
            }
        }

        private void Accountsetting_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Deactivate_Click(object sender, RoutedEventArgs e)
        {
            if (this.dataMataUangSelected == null)
            {
                MessageBox.Show("Currency has not been selected!");
            }
            else
            {
                DataMataUangBLL dataMataUangBLL = new DataMataUangBLL();
                this.dataMataUangSelected.CheckBoxAktif = false;
                if (dataMataUangBLL.EditMataUang(this.dataMataUangSelected) == true)
                {
                    MessageBox.Show("Successfully set currency is not active");
                    this.LoadDataMataUang();
                    this.dataMataUangSelected = null;
                }
            }
        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
