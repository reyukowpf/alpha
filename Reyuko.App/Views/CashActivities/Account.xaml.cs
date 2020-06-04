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

namespace Reyuko.App.Views.CashActivities
{
    /// <summary>
   
    /// </summary>
    public partial class Account : Window
    {
        public Account(NewCashActivities newCash)
        {
            InitializeComponent();
            this.newCash = newCash;
            this.Init();
        }

        private void ClearForm()
        {
            cbaccount.SelectedIndex = -1;
            cbjob.SelectedIndex = -1;
            txtdebit.Text = "0";
            txtnote.Text = "";
        }

        private void Init()
        {
            this.ClearForm();
            this.LoadComboRekening();
        }
        public IEnumerable<RekeningPerkiraan> rekeningPerkiraans { get; set; }
        public RekeningPerkiraan rekeningPerkiraanSelected;
        public NewCashActivities newCash;
        private void LoadComboRekening()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.rekeningPerkiraans = uow.RekeningPerkiraan.GetAll();
                cbaccount.ItemsSource = this.rekeningPerkiraans;
                cbaccount.DisplayMemberPath = "NamaRekeningPerkiraan";
                cbaccount.SelectedValuePath = "Id";
            }
        }
        private void LoadComboJob()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
            }
        }
        public void cbaccount_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.rekeningPerkiraanSelected = null;
            if (cbaccount.SelectedItem != null)
            {
                this.rekeningPerkiraanSelected = (RekeningPerkiraan)cbaccount.SelectedItem;
            }

        }
        public OrderTransaksiCash GetData()
        {
            OrderTransaksiCash oData = new OrderTransaksiCash();
            if (this.rekeningPerkiraanSelected != null)
            {
                oData.IdAkunHutangPiutangReferensi1 = this.rekeningPerkiraanSelected.Id;
                oData.NamaAkunHutangPiutang = this.rekeningPerkiraanSelected.NamaRekeningPerkiraan;
            }
            oData.Debit1 = double.Parse(txtdebit.Text);
            oData.Kredit = oData.Debit1;
            oData.Keterangan = txtnote.Text;
            oData.Checkboxaktif = true;
            return oData;
        }
        public void Addjurnal_Clicks(object sender, RoutedEventArgs e)
        {
            CashActivityBLL cashBLL = new CashActivityBLL();
                if (cashBLL.Addtranscash(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Add Order Cash Transaction successfully added !");
                    this.newCash.LoadDataAccount();
                }
                else
                {
                    MessageBox.Show("Add Order Cash Transaction failed to add !");
                }
            this.Close();
        }

        private void Cancel_Clicks(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

      
    }
}
