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
using Microsoft.Win32;
using System.IO;
using Path = System.IO.Path;
using Reyuko.Utils.Common;


namespace Reyuko.App.Views.FixedAssetData
{
    /// <summary>

    /// </summary>
    public partial class NewFixedAssetData : UserControl
    {
        public NewFixedAssetData(FixedAssetData fixedassetdataForm)
        {
            InitializeComponent();
            this.fixedassetdataForm = fixedassetdataForm;
            Switcher.pageSwitchernewassetdata = this;
            this.Init();
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }


        private void Init()
        {
            this.ClearForm();
            this.LoadComboKategori();
            this.LoadCombolokasi();
            this.LoadKontak();
            this.LoadComboDepartmen();
            this.LoadComboEarnby();
            this.LoadComboAkun();
            if (this.fixedassetdataForm.isEdit == true)
                this.LoadKelompokHartaTetap();
        }

        public object UserControl { get; internal set; }
        public FixedAssetData fixedassetdataForm;
        private IEnumerable<KelompokHartaTetap> kelompokHartaTetaps { get; set; }
        private KelompokHartaTetap kelompokHartaTetapSelected;
        private IEnumerable<Lokasi> lokasis { get; set; }
        private Lokasi lokasiSelected;
        private IEnumerable<Kontak> kontaks { get; set; }
        private Kontak kontakselected;
        private string UploadFile { get; set; }
        private IEnumerable<DataDepartemen> dataDepartemens { get; set; }
        private DataDepartemen dataDepartemenSelected;
        private IEnumerable<DataHartaTetap> dataHartaTetaps { get; set; }
        private DataHartaTetap dataHartaTetap;
        private DataHartaTetap DataHartaTetapSelected;
        private IEnumerable<Diperoleh> diperolehs { get; set; }
        public Diperoleh diperolehSelected;
        private IEnumerable<RekeningPerkiraan> rekeningPerkiraans { get; set; }
        public RekeningPerkiraan rekeningPerkiraanSelected;
        private void ClearForm()
        {
            txtnoasset.Text = "";
            txtnamaasset.Text = "";
            cbcategoryasset.SelectedIndex = -1;
            tglbeli.Text = DateTime.Now.ToShortDateString();
            txtHargabeli.Text = "";
            txtsalvage.Text = "";
            cblokasi.SelectedIndex = -1;
            cbearn.SelectedIndex = -1;
            cbvendor.SelectedIndex = -1;
            cbakun.SelectedIndex = -1;
            cbdepartmen.SelectedIndex = -1;
            chkafter15.IsChecked = false;
            txtbook.Text = "";
            txtmonth.Text = "";
            chkinclud.IsChecked = false;

            this.kelompokHartaTetapSelected = null;
        }
        private void LoadComboKategori()
        {
            this.kelompokHartaTetaps = new List<KelompokHartaTetap>();
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kelompokHartaTetaps = uow.KelompokHartaTetap.GetAll();
                cbcategoryasset.DisplayMemberPath = "NamaKelompokHartaTetap";
                cbcategoryasset.SelectedValuePath = "Id";
                cbcategoryasset.ItemsSource = this.kelompokHartaTetaps;
            }
        }

        private void LoadCombolokasi()
        {
            this.lokasis = new List<Lokasi>();
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.lokasis = uow.Lokasi.GetAll();
                cblokasi.DisplayMemberPath = "NamaTempatLokasi";
                cblokasi.SelectedValuePath = "Id";
                cblokasi.ItemsSource = this.lokasis;
            }
        }
        public void LoadKontak()
        {
            this.kontaks = new List<Kontak>();
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kontaks = uow.Kontak.GetAll().Where(m => m.TypeKontak.ToLower() == "vendor");
                cbvendor.DisplayMemberPath = "NamaA";
                cbvendor.SelectedValuePath = "Id";
                cbvendor.ItemsSource = this.kontaks;
            }
        }

        private void LoadComboDepartmen()
        {
            this.dataDepartemens = new List<DataDepartemen>();
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dataDepartemens = uow.DataDepartemen.GetAll();
                cbdepartmen.DisplayMemberPath = "NamaDepartemen";
                cbdepartmen.SelectedValuePath = "Id";
                cbdepartmen.ItemsSource = this.dataDepartemens;
            }
        }
        private void UploadFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;
            dlg.Filter = Helper.UploadFilter(Helper.enUploadType.Images);

            if ((bool)dlg.ShowDialog())
            {
                Stream file = dlg.OpenFile();
                string filename = dlg.SafeFileName;
                this.UploadFile = Helper.UploadFile(Helper.enUploadType.Images, file, filename);
            }
            else
            {
                MessageBox.Show("File not selected");
            }
        }
        private void LoadComboEarnby()
        {
            this.diperolehs = new List<Diperoleh>();
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.diperolehs = uow.Diperoleh.GetAll();
                cbearn.DisplayMemberPath = "diperoleh";
                cbearn.SelectedValuePath = "Idperoleh";
                cbearn.ItemsSource = this.diperolehs;
            }
        }
        private void LoadComboAkun()
        {
            this.rekeningPerkiraans = new List<RekeningPerkiraan>();
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.rekeningPerkiraans = uow.RekeningPerkiraan.GetAll();
                cbakun.DisplayMemberPath = "NamaRekeningPerkiraan";
                cbakun.SelectedValuePath = "Id";
                cbakun.ItemsSource = this.rekeningPerkiraans;
            }
        }
        private void Cbcategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.kelompokHartaTetapSelected = null;
            if (cbcategoryasset.SelectedItem != null)
            {
                this.kelompokHartaTetapSelected = (KelompokHartaTetap)cbcategoryasset.SelectedItem;
            }
        }
        private void Cblokasi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.lokasiSelected = null;
            if (cblokasi.SelectedItem != null)
            {
                this.lokasiSelected = (Lokasi)cblokasi.SelectedItem;
            }
        }

        private void Cbvendor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.kontakselected = null;
            if (cbvendor.SelectedItem != null)
            {
                this.kontakselected = (Kontak)cbvendor.SelectedItem;
            }
        }

        private void CbDepartment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.dataDepartemenSelected = null;
            if (cbdepartmen.SelectedItem != null)
            {
                this.dataDepartemenSelected = (DataDepartemen)cbdepartmen.SelectedItem;
            }
        }
        private void Cbearn_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.diperolehSelected = null;
            if (cbearn.SelectedItem != null)
            {
                this.diperolehSelected = (Diperoleh)cbearn.SelectedItem;
            }
        }
        private void Cbakun_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.rekeningPerkiraanSelected = null;
            if (cbakun.SelectedItem != null)
            {
                this.rekeningPerkiraanSelected = (RekeningPerkiraan)cbakun.SelectedItem;
            }
        }
        public void LoadKelompokHartaTetap()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                if (this.fixedassetdataForm.isEdit == true)
                {
                    var DataHartaTetap = uow.DataHartaTetap.SingleOrDefault(m => m.IdKelompokHartaTetap == this.fixedassetdataForm.KelompokhartatetapSelected.IdParent);
                    if (DataHartaTetap != null)
                    {
                        txtnoasset.Text = DataHartaTetap.NoHartaTetap.ToString();
                    }
                }
            }
        }

        private DataHartaTetap GetData()
        {
            DataHartaTetap oData = new DataHartaTetap();
            oData.NoHartaTetap = int.Parse(txtnoasset.Text);
            oData.NamaHartaTetap = txtnamaasset.Text;
            if (this.kelompokHartaTetapSelected != null)
            {
                oData.IdKelompokHartaTetap = this.kelompokHartaTetapSelected.Id;
                oData.NamaKelompokHartaTetap = this.kelompokHartaTetapSelected.NamaKelompokHartaTetap;
                oData.IdAkunAsset = this.kelompokHartaTetapSelected.IdAkunAsset;
                oData.KodeRekeningAsset = this.kelompokHartaTetapSelected.KodeRekeningAsset;
                oData.IdAkunAkumulasiDepresiasi = this.kelompokHartaTetapSelected.IdAkunAkumulasiPenyusutan;
                oData.KodeRekeningAkumulasiDepresiasi = this.kelompokHartaTetapSelected.KodeRekeningAkumulasiPenyusutan;
                oData.IdAkunDepresiasi = this.kelompokHartaTetapSelected.IdAkunPenyusutan;
                oData.KodeRekeningDepresiasi = this.kelompokHartaTetapSelected.KodeRekeningPenyusutan;
            }
            oData.TanggalBeli = DateTime.Parse(tglbeli.Text);
            oData.HargaBeli = int.Parse(txtHargabeli.Text);
            oData.NilaiResidu = int.Parse(txtsalvage.Text);
            if (this.lokasiSelected != null)
            {
                oData.IdLokasi = this.lokasiSelected.Id;
                oData.Lokasi = this.lokasiSelected.NamaTempatLokasi;
            }
            if (this.diperolehSelected != null)
            {
                oData.IdPeroleh = this.diperolehSelected.IdDiperoleh;
                oData.Diperoleh = this.diperolehSelected.diperoleh;
            }
            if (this.kontakselected != null)
            {
                oData.IdKontak = this.kontakselected.Id;
                oData.Vendor = this.kontakselected.NamaA;
            }
            if (this.rekeningPerkiraanSelected != null)
            {
                oData.IdAkun = this.rekeningPerkiraanSelected.Id;
                oData.NamaAkun = this.rekeningPerkiraanSelected.NamaRekeningPerkiraan;
            }

            if (this.dataDepartemenSelected != null)
            {
                oData.IdDepartment = this.dataDepartemenSelected.Id;
            }
            oData.Checkboxawalmingguke3 = chkafter15.IsChecked;
            oData.NilaiBuku = int.Parse(txtbook.Text);
            oData.AkumulasiBeban = int.Parse(txtmonth.Text);
            oData.checkboxincludedonserviceassignment = chkinclud.IsChecked;
            oData.UploadPhoto = this.UploadFile;
            oData.TerhitungTanggal = DateTime.Now;
            if (this.fixedassetdataForm.isEdit == true)
            {
                oData.Id = this.dataHartaTetap.Id;
                oData.IdKelompokHartaTetap = this.dataHartaTetap.IdKelompokHartaTetap;
                oData.NamaKelompokHartaTetap = this.dataHartaTetap.NamaKelompokHartaTetap;
            }

            return oData;
        }

        private void Btnsave_Click(object sender, RoutedEventArgs e)
        {
            if (txtnoasset.Text == "" || txtnamaasset.Text == "" || cbcategoryasset.Text == "" || tglbeli.Text == "" || txtHargabeli.Text == "" || txtsalvage.Text == "" || cblokasi.Text == "" || cbearn.Text == "" || cbvendor.Text == "" || cbakun.Text == "" || cbdepartmen.Text == "" || txtbook.Text == "" || txtmonth.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            DataHartaTetapBLL datahartaBLL = new DataHartaTetapBLL();
            DataHartaTetap oNewdatas = new DataHartaTetap();
            KelompokHartaTetap oNewData = new KelompokHartaTetap();
            KelompokHartaTetap dataMataUangSelected = (KelompokHartaTetap)cbcategoryasset.SelectedItem;
            oNewData.IdParent = dataMataUangSelected.Id;
            oNewData.NamaKelompokHartaTetap = txtnamaasset.Text;
            if (datahartaBLL.AddKelompok(oNewData) > 0)
            {
            }

            DataHartaTetapBLL DataHartaTetapBLL = new DataHartaTetapBLL();
            if (this.fixedassetdataForm.isEdit == false)
            {
                if (DataHartaTetapBLL.AddDataHartaTetap(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Fixed Assets Data added successfully !");
                    this.fixedassetdataForm.LoadFixedAsset();
                }
                else
                {
                    MessageBox.Show("Fixed Assets Data failed to be added !");
                }
            }
            else
            {
                if (DataHartaTetapBLL.EditDataHartaTetap(this.GetData()) == true)
                {
                    this.ClearForm();
                    MessageBox.Show("Fixed Assets Data successfully changed !");
                    this.fixedassetdataForm.LoadFixedAsset();
                }
                else
                {
                    MessageBox.Show("Fixed Assets Data failed to change !");
                }
            }
            FixedAssetData v = new FixedAssetData();
            Switcher.Switchanewssetdata(v);
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            FixedAssetData v = new FixedAssetData();
            Switcher.Switchanewssetdata(v);
        }

        private void Txtnoasset_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtnoasset.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtnoasset.Text = "";
                    return;
                }

            }
        }

        private void TxtHargabeli_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtHargabeli.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtHargabeli.Text = "";
                    return;
                }

            }
        }

        private void Txtsalvage_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtsalvage.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtsalvage.Text = "";
                    return;
                }

            }
        }

        private void Txtbook_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtbook.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtbook.Text = "";
                    return;
                }

            }
        }

        private void Txtmonth_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtmonth.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtmonth.Text = "";
                    return;
                }

            }
        }

        private void Txtnamaasset_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
