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

namespace Reyuko.App.Views.ImportantAccount
{
    /// <summary>

    /// </summary>
    public partial class ImportantAccount : UserControl
    {
        public ImportantAccount()
        {
            InitializeComponent();
            Switcher.pageSwitcherimport = this;
            this.Init();
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
        private IEnumerable<KategoriProduk> KategoriProduks { get; set; }
        private KategoriProduk KategoriProdukSelected { get; set; }
        private IEnumerable<TypeProduk> TypeProduks { get; set; }
        private TypeProduk TypeProdukSelected { get; set; }
        private IEnumerable<DataMataUang> DataMataUangs { get; set; }
        private DataMataUang DataMataUangSelected { get; set; }
        private IEnumerable<DataPajak> DataPajaks { get; set; }
        private DataPajak DataPajakSelected { get; set; }
        private IEnumerable<KelompokHartaTetap> KelompokHartaTetaps { get; set; }
        private KelompokHartaTetap KelompokHartaTetapSelected { get; set; }
        private IEnumerable<RekeningPerkiraan> RekeningPerkiraans { get; set; }

        private void Init()
        {
            this.ClearForm();
            this.ClearForm1();
            this.LoadComboKategoriProduk();
            this.LoadComboTypeProduk();
            this.LoadComboDataMataUang();
            this.LoadComboDataPajak();
            this.LoadComboKelompokHartaTetap();
            this.LoadComboRekeningPerkiraan();
        }
        private void LoadComboKategoriProduk()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.KategoriProduks = uow.KategoriProduk.GetAll();
                cbCategory.ItemsSource = this.KategoriProduks;
                cbCategory.DisplayMemberPath = "ProdukKategori";
                cbCategory.SelectedValuePath = "Id";
            }
        }

        private void LoadComboTypeProduk()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.TypeProduks = uow.TypeProduk.GetAll();
                cbTypeProduk.ItemsSource = this.TypeProduks;
                cbTypeProduk.DisplayMemberPath = "NamaTypeProduk";
                cbTypeProduk.SelectedValuePath = "Id";
            }
        }

        private void LoadComboDataMataUang()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.DataMataUangs = uow.DataMataUang.GetAll().Where(m => m.CheckBoxAktif == true);
                cbCurrency.ItemsSource = this.DataMataUangs;
                cbCurrency.DisplayMemberPath = "NamaMataUang";
                cbCurrency.SelectedValuePath = "Id";
            }
        }

        private void LoadComboDataPajak()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.DataPajaks = uow.DataPajak.GetAll();
                cbTax.ItemsSource = this.DataPajaks;
                cbTax.DisplayMemberPath = "NamaPajak";
                cbTax.SelectedValuePath = "Id";
            }
        }

        private void LoadComboKelompokHartaTetap()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.KelompokHartaTetaps = uow.KelompokHartaTetap.GetAll();
                cbAssetCategory.ItemsSource = this.KelompokHartaTetaps;
                cbAssetCategory.DisplayMemberPath = "NamaKelompokHartaTetap";
                cbAssetCategory.SelectedValuePath = "Id";
            }
        }
        private void LoadComboRekeningPerkiraan()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.RekeningPerkiraans = uow.RekeningPerkiraan.GetAll();

                cbCOGS.ItemsSource = this.RekeningPerkiraans;
                cbCOGS.DisplayMemberPath = "NamaRekeningPerkiraan";
                cbCOGS.SelectedValuePath = "Id";

                cbSales.ItemsSource = this.RekeningPerkiraans;
                cbSales.DisplayMemberPath = "NamaRekeningPerkiraan";
                cbSales.SelectedValuePath = "Id";

                cbInventory.ItemsSource = this.RekeningPerkiraans;
                cbInventory.DisplayMemberPath = "NamaRekeningPerkiraan";
                cbInventory.SelectedValuePath = "Id";

                cbpurchasedelivery.ItemsSource = this.RekeningPerkiraans;
                cbpurchasedelivery.DisplayMemberPath = "NamaRekeningPerkiraan";
                cbpurchasedelivery.SelectedValuePath = "Id";

                cbSalesdelivery.ItemsSource = this.RekeningPerkiraans;
                cbSalesdelivery.DisplayMemberPath = "NamaRekeningPerkiraan";
                cbSalesdelivery.SelectedValuePath = "Id";

                cbSalesreturn.ItemsSource = this.RekeningPerkiraans;
                cbSalesreturn.DisplayMemberPath = "NamaRekeningPerkiraan";
                cbSalesreturn.SelectedValuePath = "Id";

                cbService.ItemsSource = this.RekeningPerkiraans;
                cbService.DisplayMemberPath = "NamaRekeningPerkiraan";
                cbService.SelectedValuePath = "Id";

                cbAccountReceivable.ItemsSource = this.RekeningPerkiraans;
                cbAccountReceivable.DisplayMemberPath = "NamaRekeningPerkiraan";
                cbAccountReceivable.SelectedValuePath = "Id";

                cbAccountReceivable.ItemsSource = this.RekeningPerkiraans;
                cbAccountReceivable.DisplayMemberPath = "NamaRekeningPerkiraan";
                cbAccountReceivable.SelectedValuePath = "Id";

                cbAccountPayable.ItemsSource = this.RekeningPerkiraans;
                cbAccountPayable.DisplayMemberPath = "NamaRekeningPerkiraan";
                cbAccountPayable.SelectedValuePath = "Id";

                cbBankpayment.ItemsSource = this.RekeningPerkiraans;
                cbBankpayment.DisplayMemberPath = "NamaRekeningPerkiraan";
                cbBankpayment.SelectedValuePath = "Id";

                cbCashpayment.ItemsSource = this.RekeningPerkiraans;
                cbCashpayment.DisplayMemberPath = "NamaRekeningPerkiraan";
                cbCashpayment.SelectedValuePath = "Id";

                cbPurchasedownpayment.ItemsSource = this.RekeningPerkiraans;
                cbPurchasedownpayment.DisplayMemberPath = "NamaRekeningPerkiraan";
                cbPurchasedownpayment.SelectedValuePath = "Id";

                cbSalesdownpayment.ItemsSource = this.RekeningPerkiraans;
                cbSalesdownpayment.DisplayMemberPath = "NamaRekeningPerkiraan";
                cbSalesdownpayment.SelectedValuePath = "Id";

                cbReceivedpostdatecheque.ItemsSource = this.RekeningPerkiraans;
                cbReceivedpostdatecheque.DisplayMemberPath = "NamaRekeningPerkiraan";
                cbReceivedpostdatecheque.SelectedValuePath = "Id";

                cbPostdatecheque.ItemsSource = this.RekeningPerkiraans;
                cbPostdatecheque.DisplayMemberPath = "NamaRekeningPerkiraan";
                cbPostdatecheque.SelectedValuePath = "Id";

                cbAccountBuy.ItemsSource = this.RekeningPerkiraans;
                cbAccountBuy.DisplayMemberPath = "NamaRekeningPerkiraan";
                cbAccountBuy.SelectedValuePath = "Id";

                cbSellAccount.ItemsSource = this.RekeningPerkiraans;
                cbSellAccount.DisplayMemberPath = "NamaRekeningPerkiraan";
                cbSellAccount.SelectedValuePath = "Id";

                cbAssetaccount.ItemsSource = this.RekeningPerkiraans;
                cbAssetaccount.DisplayMemberPath = "NamaRekeningPerkiraan";
                cbAssetaccount.SelectedValuePath = "Id";

                cbAkumulasiAccounDept.ItemsSource = this.RekeningPerkiraans;
                cbAkumulasiAccounDept.DisplayMemberPath = "NamaRekeningPerkiraan";
                cbAkumulasiAccounDept.SelectedValuePath = "Id";

                cbDeprectiation.ItemsSource = this.RekeningPerkiraans;
                cbDeprectiation.DisplayMemberPath = "NamaRekeningPerkiraan";
                cbDeprectiation.SelectedValuePath = "Id";

                cbStockOpname.ItemsSource = this.RekeningPerkiraans;
                cbStockOpname.DisplayMemberPath = "NamaRekeningPerkiraan";
                cbStockOpname.SelectedValuePath = "Id";

                cbBankreconcialition.ItemsSource = this.RekeningPerkiraans;
                cbBankreconcialition.DisplayMemberPath = "NamaRekeningPerkiraan";
                cbBankreconcialition.SelectedValuePath = "Id";

                cbGeneraljurnal.ItemsSource = this.RekeningPerkiraans;
                cbGeneraljurnal.DisplayMemberPath = "NamaRekeningPerkiraan";
                cbGeneraljurnal.SelectedValuePath = "Id";

                cbEarning.ItemsSource = this.RekeningPerkiraans;
                cbEarning.DisplayMemberPath = "NamaRekeningPerkiraan";
                cbEarning.SelectedValuePath = "Id";

                cbCurrentEarning.ItemsSource = this.RekeningPerkiraans;
                cbCurrentEarning.DisplayMemberPath = "NamaRekeningPerkiraan";
                cbCurrentEarning.SelectedValuePath = "Id";
            }
        }
        private void CbCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.ClearForm();
        }
        private void CbTypeProduk_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbTypeProduk.SelectedItem != null)
            {
                this.TypeProdukSelected = (TypeProduk)cbTypeProduk.SelectedItem;
                using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
                {
                    var oData = uow.TypeProduk.Get(this.TypeProdukSelected.Id);
                    if (oData != null)
                    {
                        if (oData.NamaTypeProduk == "dijual")
                        {
                            this.ClearForm1();
                            cbCOGS.IsEnabled = false;
                            cbSales.SelectedValue = oData.IdAkunPenjualan;
                            cbInventory.IsEnabled = false;
                            cbpurchasedelivery.IsEnabled = false;
                            cbSalesdelivery.IsEnabled = false;
                            cbSalesreturn.SelectedValue = oData.IdAkunReturPenjualan;
                            cbService.IsEnabled = false;
                        }
                        else if (oData.NamaTypeProduk == "dibeli")
                        {
                            this.ClearForm1();
                            cbCOGS.SelectedValue = oData.IdAkunHargaPokok;
                            cbSales.IsEnabled = false;
                            cbInventory.IsEnabled = false;
                            cbpurchasedelivery.IsEnabled = false;
                            cbSalesdelivery.IsEnabled = false;
                            cbSalesreturn.IsEnabled = false;
                            cbService.IsEnabled = false;
                        }
                        else if (oData.NamaTypeProduk == "service")
                        {
                            this.ClearForm1();
                            cbCOGS.IsEnabled = false;
                            cbSales.IsEnabled = false;
                            cbInventory.IsEnabled = false;
                            cbpurchasedelivery.IsEnabled = false;
                            cbSalesdelivery.IsEnabled = false;
                            cbSalesreturn.IsEnabled = false;
                            cbService.SelectedValue = oData.IdAkunService;
                        }
                        else if (oData.NamaTypeProduk == "disimpan")
                        {
                            this.ClearForm1();
                            cbCOGS.IsEnabled = false;
                            cbSales.IsEnabled = false;
                            cbInventory.SelectedValue = oData.IdAkunPersediaan;
                            cbpurchasedelivery.IsEnabled = false;
                            cbSalesdelivery.SelectedValue = oData.IdAkunPengirimanJual;
                            cbSalesreturn.IsEnabled = false;
                            cbService.IsEnabled = false;
                        }
                        else if (oData.NamaTypeProduk == "konsinyasi")
                        {
                            this.ClearForm1();
                            cbCOGS.SelectedValue = oData.IdAkunHargaPokok;
                            cbSales.SelectedValue = oData.IdAkunPenjualan;
                            cbInventory.SelectedValue = oData.IdAkunPersediaan;
                            cbpurchasedelivery.IsEnabled = false;
                            cbSalesdelivery.SelectedValue = oData.IdAkunPengirimanJual;
                            cbSalesreturn.SelectedValue = oData.IdAkunReturPenjualan;
                            cbService.IsEnabled = false;
                        }
                        else if (oData.NamaTypeProduk == "dijual_dibeli")
                        {
                            this.ClearForm1();
                            cbCOGS.SelectedValue = oData.IdAkunHargaPokok;
                            cbSales.SelectedValue = oData.IdAkunPenjualan;
                            cbInventory.IsEnabled = false;
                            cbpurchasedelivery.IsEnabled = false;
                            cbSalesdelivery.IsEnabled = false;
                            cbSalesreturn.SelectedValue = oData.IdAkunReturPenjualan;
                            cbService.IsEnabled = false;
                        }
                        else if (oData.NamaTypeProduk == "dibeli_disimpan")
                        {
                            this.ClearForm1();
                            cbCOGS.SelectedValue = oData.IdAkunHargaPokok;
                            cbSales.IsEnabled = false;
                            cbInventory.SelectedValue = oData.IdAkunPersediaan;
                            cbpurchasedelivery.SelectedValue = oData.IdAkunPengirimanBeli;
                            cbSalesdelivery.SelectedValue = oData.IdAkunPengirimanJual;
                            cbSalesreturn.IsEnabled = false;
                            cbService.IsEnabled = false;
                        }
                        else if (oData.NamaTypeProduk == "disimpan_dijual")
                        {
                            this.ClearForm1();
                            cbCOGS.SelectedValue = oData.IdAkunHargaPokok;
                            cbSales.SelectedValue = oData.IdAkunPenjualan;
                            cbInventory.SelectedValue = oData.IdAkunPersediaan;
                            cbpurchasedelivery.IsEnabled = false;
                            cbSalesdelivery.SelectedValue = oData.IdAkunPengirimanJual;
                            cbSalesreturn.SelectedValue = oData.IdAkunReturPenjualan;
                            cbService.IsEnabled = false;
                        }
                        else if (oData.NamaTypeProduk == "dijual_dibeli_disimpan")
                        {
                            this.ClearForm1();
                            cbCOGS.SelectedValue = oData.IdAkunHargaPokok;
                            cbSales.SelectedValue = oData.IdAkunPenjualan;
                            cbInventory.SelectedValue = oData.IdAkunPersediaan;
                            cbpurchasedelivery.SelectedValue = oData.IdAkunPengirimanBeli;
                            cbSalesdelivery.SelectedValue = oData.IdAkunPengirimanJual;
                            cbSalesreturn.SelectedValue = oData.IdAkunReturPenjualan;
                            cbService.IsEnabled = false;
                        }
                    }

                }
            }
        }
        private void CbCurrency_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbCurrency.SelectedItem != null)
            {
                this.DataMataUangSelected = (DataMataUang)cbCurrency.SelectedItem;
                using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
                {
                    var oData = uow.DefaultAkunMataUang.SingleOrDefault(m => m.Id == this.DataMataUangSelected.IdDefaultMataUang);
                    if (oData != null)
                    {
                        cbAccountReceivable.SelectedValue = oData.IdPiutangUsaha;
                        cbAccountPayable.SelectedValue = oData.IdHutangUsaha;
                        cbBankpayment.SelectedValue = oData.IdPembayaranTunai;
                        cbCashpayment.SelectedValue = oData.IdPembayaranTunai;
                        cbPurchasedownpayment.SelectedValue = oData.IdUangMukaPembelian;
                        cbSalesdownpayment.SelectedValue = oData.IdUangMukaPenjualan;
                        cbReceivedpostdatecheque.SelectedValue = oData.IdPiutangGiro;
                        cbPostdatecheque.SelectedValue = oData.IdHutangGiro;
                    }
                }
            }
        }
        private void CbTax_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbTax.SelectedItem != null)
            {
                this.DataPajakSelected = (DataPajak)cbTax.SelectedItem;
                using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
                {
                    var oData = uow.DataPajak.Get(this.DataPajakSelected.Id);
                    if (oData != null)
                    {
                        cbAccountBuy.SelectedValue = oData.IdAkunBeli;
                        cbSellAccount.SelectedValue = oData.IdAkunJual;
                    }
                }
            }
        }
        private void CbAssetCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbAssetCategory.SelectedItem != null)
            {
                this.KelompokHartaTetapSelected = (KelompokHartaTetap)cbAssetCategory.SelectedItem;
                using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
                {
                    var oData = uow.KelompokHartaTetap.Get(this.KelompokHartaTetapSelected.Id);
                    if (oData != null)
                    {
                        cbAssetaccount.SelectedValue = oData.IdAkunAsset;
                        cbAkumulasiAccounDept.SelectedValue = oData.IdAkunAkumulasiPenyusutan;
                        cbDeprectiation.SelectedValue = oData.IdAkunPenyusutan;
                    }
                }
            }
        }
        private void ClearForm()
        {
            this.DataMataUangSelected = null;
            this.DataPajakSelected = null;
            this.KategoriProdukSelected = null;
            this.KelompokHartaTetapSelected = null;
            this.TypeProdukSelected = null;

            cbCategory.SelectedIndex = -1;
            cbTypeProduk.SelectedIndex = -1;
            cbCOGS.SelectedIndex = -1;
            cbSales.SelectedIndex = -1;
            cbInventory.SelectedIndex = -1;
            cbpurchasedelivery.SelectedIndex = -1;
            cbSalesreturn.SelectedIndex = -1;
            cbService.SelectedIndex = -1;

            cbCurrency.SelectedIndex = -1;
            cbAccountReceivable.SelectedIndex = -1;
            cbAccountPayable.SelectedIndex = -1;
            cbBankpayment.SelectedIndex = -1;
            cbCashpayment.SelectedIndex = -1;
            cbPurchasedownpayment.SelectedIndex = -1;
            cbSalesdownpayment.SelectedIndex = -1;
            cbReceivedpostdatecheque.SelectedIndex = -1;
            cbPostdatecheque.SelectedIndex = -1;

            cbTax.SelectedIndex = -1;
            cbAccountBuy.SelectedIndex = -1;
            cbSellAccount.SelectedIndex = -1;

            cbAssetCategory.SelectedIndex = -1;
            cbAssetaccount.SelectedIndex = -1;
            cbAkumulasiAccounDept.SelectedIndex = -1;
            cbDeprectiation.SelectedIndex = -1;

            cbStockOpname.SelectedIndex = -1;
            cbBankreconcialition.SelectedIndex = -1;
            cbGeneraljurnal.SelectedIndex = -1;
            cbEarning.SelectedIndex = -1;
            cbCurrentEarning.SelectedIndex = -1;
        }
        private void ClearForm1()
        {
            cbCOGS.SelectedIndex = -1;
            cbCOGS.IsEnabled = true;
            cbSales.SelectedIndex = -1;
            cbSales.IsEnabled = true;
            cbInventory.SelectedIndex = -1;
            cbInventory.IsEnabled = true;
            cbpurchasedelivery.SelectedIndex = -1;
            cbpurchasedelivery.IsEnabled = true;
            cbSalesdelivery.SelectedIndex = -1;
            cbSalesdelivery.IsEnabled = true;
            cbSalesreturn.SelectedIndex = -1;
            cbSalesreturn.IsEnabled = true;
            cbService.SelectedIndex = -1;
            cbService.IsEnabled = true;
        }


        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataMataUangSelected != null)
            {
                using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
                {
                    var oDBData = uow.DefaultAkunMataUang.Get(this.DataMataUangSelected.IdDefaultMataUang.GetValueOrDefault(0));
                    if (oDBData != null)
                    {
                        if (cbAccountReceivable.SelectedItem != null)
                            oDBData.IdPiutangUsaha = Convert.ToInt32(cbAccountReceivable.SelectedValue);
                        if (cbAccountPayable.SelectedItem != null)
                            oDBData.IdHutangUsaha = Convert.ToInt32(cbAccountPayable.SelectedValue);
                        if (cbBankpayment.SelectedItem != null)
                            oDBData.IdPembayaranBank = Convert.ToInt32(cbBankpayment.SelectedValue);
                        if (cbCashpayment.SelectedItem != null)
                            oDBData.IdPembayaranTunai = Convert.ToInt32(cbCashpayment.SelectedValue);
                        if (cbPurchasedownpayment.SelectedItem != null)
                            oDBData.IdUangMukaPembelian = Convert.ToInt32(cbPurchasedownpayment.SelectedValue);
                        if (cbSalesdownpayment.SelectedItem != null)
                            oDBData.IdUangMukaPenjualan = Convert.ToInt32(cbSalesdownpayment.SelectedValue);
                        if (cbReceivedpostdatecheque.SelectedItem != null)
                            oDBData.IdPiutangGiro = Convert.ToInt32(cbReceivedpostdatecheque.SelectedValue);
                        if (cbPostdatecheque.SelectedItem != null)
                            oDBData.IdHutangGiro = Convert.ToInt32(cbPostdatecheque.SelectedValue);
                        uow.DefaultAkunMataUang.Update(oDBData);
                        uow.Save();

                        MessageBox.Show("Important Account Currency berhasil diupdate ! \n");
                    }
                }
            }

            if (this.DataPajakSelected != null)
            {
                if (cbAccountBuy.SelectedItem != null)
                    this.DataPajakSelected.IdAkunBeli = Convert.ToInt32(cbAccountBuy.SelectedValue);
                if (cbSellAccount.SelectedItem != null)
                    this.DataPajakSelected.IdAkunJual = Convert.ToInt32(cbSellAccount.SelectedValue);

                DataPajakBLL DataPajakBLL = new DataPajakBLL();
                if (DataPajakBLL.EditPajak(this.DataPajakSelected) == true)
                {
                    MessageBox.Show("Important Account Tax berhasil diupdate ! \n");
                }
            }

            if (this.KelompokHartaTetapSelected != null)
            {
                if (cbAssetaccount.SelectedItem != null)
                    this.KelompokHartaTetapSelected.IdAkunAsset = Convert.ToInt32(cbAssetaccount.SelectedValue);
                if (cbAkumulasiAccounDept.SelectedItem != null)
                    this.KelompokHartaTetapSelected.IdAkunAkumulasiPenyusutan = Convert.ToInt32(cbAkumulasiAccounDept.SelectedValue);
                if (cbDeprectiation.SelectedItem != null)
                    this.KelompokHartaTetapSelected.IdAkunPenyusutan = Convert.ToInt32(cbDeprectiation.SelectedValue);

                KelompokHartaTetapBLL KelompokHartaTetapBLL = new KelompokHartaTetapBLL();
                if (KelompokHartaTetapBLL.EditKelompokHartaTetap(this.KelompokHartaTetapSelected) == true)
                {
                    MessageBox.Show("Important Account Fixed Asset Category berhasil diupdate ! \n");
                }
            }

            this.ClearForm();
            AccountData.AccountData v = new AccountData.AccountData();
            Switcher.Switchimport(v);
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.ClearForm();
            AccountData.AccountData v = new AccountData.AccountData();
            Switcher.Switchimport(v);
        }
        private void Accountlvlsetting_click(object sender, RoutedEventArgs e)
        {
            AccountData.AccountData v = new AccountData.AccountData();
            Switcher.Switchimport(v);
        }
    }

}









