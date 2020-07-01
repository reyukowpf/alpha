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

namespace Reyuko.App.Views.GeneralJournal
{
    /// <summary>
   
    /// </summary>
    public partial class Account : Window
    {
        public Account(NewGeneralJournal newGeneralJournal)
        {
            InitializeComponent();
            this.newGeneralJournal = newGeneralJournal;
            this.Init();
        }

        private void ClearForm()
        {
            cbaccount.SelectedIndex = -1;
            cbjob.SelectedIndex = -1;
            txtdebit.Text = "0";
            txtkredit.Text = "0";
        }

        private void Init()
        {
            this.ClearForm();
            this.LoadComboRekening();
    //        this.LoadComboCountry();
        }
        public IEnumerable<RekeningPerkiraan> rekeningPerkiraans { get; set; }
        public RekeningPerkiraan rekeningPerkiraanSelected;
        public NewGeneralJournal newGeneralJournal;
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
        public OrderJurnalUmum GetData()
        {
            OrderJurnalUmum oData = new OrderJurnalUmum();
            if (this.rekeningPerkiraanSelected != null)
            {
                oData.IdRekeningPerkiraan = this.rekeningPerkiraanSelected.Id;
                oData.NoRekeningPerkiraan = this.rekeningPerkiraanSelected.KodeRekening;
                oData.NamaRekeningPerkiraan = this.rekeningPerkiraanSelected.NamaRekeningPerkiraan;
                oData.IdKlasifikasi = this.rekeningPerkiraanSelected.IdKlasifikasiRekeningPerkiraan;
                oData.KlasifikasiRekeningPerkiraan = this.rekeningPerkiraanSelected.KlasifikasiRekeningPerkiraan;
            }
            oData.Debit = double.Parse(txtdebit.Text);
            oData.Kredit = double.Parse(txtkredit.Text);
            oData.Chkaktif = true;
            return oData;
        }
        public void Addjurnal_Clicks(object sender, RoutedEventArgs e)
        {
            TransaksiJurnalUmumBLL jurnalBLL = new TransaksiJurnalUmumBLL();
                if (jurnalBLL.AddJurnalUmum(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Add Order Journal successfully added !");
                    this.newGeneralJournal.LoadDataAccount();
                }
                else
                {
                    MessageBox.Show("Add Order Journal failed to add !");
                }
            this.Close();
        }

        private void Cancel_Clicks(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

      
    }
}
