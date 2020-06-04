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

namespace Reyuko.App.Views.ReceivedPostDateChequeIssuance
{
    /// <summary>
    /// </summary>
    public partial class ChasingCheck : Window
    {
        public ChasingCheck(ReceivedPostDateChequeIssuance postDateChequeIssuance)
        {
            InitializeComponent();
            this.postDateChequeIssuance = postDateChequeIssuance;
            this.Init();
        }
        public IEnumerable<DropdownBankKas> dropdownBanks { get; set; }
        public DropdownBankKas dropdownBankKasSelected;

        private void Init()
        {
            this.ClearForm();
            this.LoadBank();
        }

        private void LoadBank()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dropdownBanks = uow.DropdownBankKas.GetAll();
                cbCash.ItemsSource = this.dropdownBanks;
                cbCash.SelectedValuePath = "Id";
                cbCash.DisplayMemberPath = "DropdownBankkas";
            }
        }

        private void ClearForm()
        {
            cbCash.SelectedIndex = -1;
        }

        private ReceivedPostDateChequeIssuance postDateChequeIssuance;
        public object UserControl { get; internal set; }
        public DataGiro GetData()
        {
            DataGiro oData = new DataGiro();
            oData.NomorRekeningGiro = double.Parse(txtChequeAccountNo.Text);
            oData.NomorGiro = double.Parse(txtChequeNo.Text);
            oData.NamaBank = txtBankName.Text;
            oData.JatuhTempoGiro = DateTime.Parse(tanggal.Text);            
            return oData;
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (cbCash.Text == "" )
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            DataGiroBLL bayarBLL = new DataGiroBLL();
            if (bayarBLL.AddDataGiro(this.GetData()) > 0)
            {
                this.ClearForm();
                MessageBox.Show("Add Data Giro successfully added !");
             //   this.newSalary.LoadOrderPembayaranGaji();
            }
            else
            {
                MessageBox.Show("Add Data Giro failed to add !");
            }
            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
