using Reyuko.BLL.Core;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
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
    /// Interaction logic for NewCurrency.xaml
    /// </summary>
    public partial class NewCurrency : Window
    {
        private IEnumerable<DataMataUang> dataMataUangs { get; set; }
        private Currency currencyForm { get; set; }
        public NewCurrency(Currency currencyForm)
        {
            InitializeComponent();
            this.currencyForm = currencyForm;
            this.dataMataUangs = new List<DataMataUang>();
            this.ClearForm();
        }

        private void ClearForm()
        {
            this.LoadDataMataUang();
        }

        private void LoadDataMataUang()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dataMataUangs = uow.DataMataUang.GetAll();
                DGCurrencyDetail.ItemsSource = this.dataMataUangs;
            }
        }

        private void AddCurrency_Clicks(object sender, RoutedEventArgs e)
        {
            if (DGCurrencyDetail.Items.Count > 0)
            {
                bool isSucceed = false;
                foreach (var item in DGCurrencyDetail.Items)
                {
                    if (item is DataMataUang)
                    {
                        DataMataUang oData = (DataMataUang)item;
                        if (!string.IsNullOrEmpty(oData.KodeMataUang))
                        {
                            DataMataUangBLL dataMataUangBLL = new DataMataUangBLL();
                            if (dataMataUangBLL.EditMataUang(oData) == true)
                            {
                                isSucceed = true;
                            }
                            else
                            {
                                isSucceed = false;
                                break;
                            }
                        }
                    }
                }

                if (isSucceed == true)
                {
                    this.ClearForm();
                    this.currencyForm.LoadDataMataUang();
                    MessageBox.Show("Currency successfully changed");
                }
                else
                {
                    MessageBox.Show("Currency failed to change");
                }
                this.Close();
                // todo : close new window, load data mata uangs
            }
        }

        private void Cancel_Clicks(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
