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

namespace Reyuko.App.Views.FixedAssetCategory
{
    /// <summary>
    /// Interaction logic for NewCurrency.xaml
    /// </summary>
    public partial class NewFixedAsset : Window
    {
        public NewFixedAsset(FixedAssetCategory fixedAssetCategoryForm)
        {
            InitializeComponent();
            this.fixedAssetCategoryForm = fixedAssetCategoryForm;
            this.Init();
        }

        public object UserControl { get; internal set; }

        private FixedAssetCategory fixedAssetCategoryForm;
        private IEnumerable<KelompokHartaTetap> kelompokHartaTetaps { get; set; }
        private KelompokHartaTetap kelompokHartaTetapSelected;
        private IEnumerable<TabelPenyusutan> tabelPenyusutans { get; set; }
        private TabelPenyusutan tabelPenyusutanSelected;

        private void Init()
        {
            this.ClearForm();
            this.LoadComboKelompokHartaTetap();
            this.LoadComboTabelPenyusutan();
            if (this.fixedAssetCategoryForm.isEdit == true)
                this.LoadKelompokHartaTetap();
        }
        private void ClearForm()
        {
            TxtNamaKelompokHartaTetap.Text = "";
            CBKelompokHartaTetapParent.SelectedIndex = -1;
            CBTabelPenyusutan.SelectedIndex = -1;
            TxtKeterangan.Text = "";
            LblUmurEkonomis.Content = "0";

            this.kelompokHartaTetapSelected = null;
            this.tabelPenyusutanSelected = null;
        }

        private void LoadKelompokHartaTetap()
        {
            this.ClearForm();
            if (this.fixedAssetCategoryForm != null && this.fixedAssetCategoryForm.kelompokHartaTetapSelected != null)
            {
                TxtNamaKelompokHartaTetap.Text = this.fixedAssetCategoryForm.kelompokHartaTetapSelected.NamaKelompokHartaTetap;
                CBKelompokHartaTetapParent.SelectedValue = this.fixedAssetCategoryForm.kelompokHartaTetapSelected.IdParent;
                CBTabelPenyusutan.SelectedValue = this.fixedAssetCategoryForm.kelompokHartaTetapSelected.IdTabelPenyusutan;
                TxtKeterangan.Text = this.fixedAssetCategoryForm.kelompokHartaTetapSelected.Keterangan;
                LblUmurEkonomis.Content = this.fixedAssetCategoryForm.kelompokHartaTetapSelected.UmurEkonomis.ToString();

                this.kelompokHartaTetapSelected = this.kelompokHartaTetaps.Where(m => m.Id == this.fixedAssetCategoryForm.kelompokHartaTetapSelected.IdParent.GetValueOrDefault(0)).FirstOrDefault();
                this.tabelPenyusutanSelected = this.tabelPenyusutans.Where(m => m.Id == this.fixedAssetCategoryForm.kelompokHartaTetapSelected.IdTabelPenyusutan.GetValueOrDefault(0)).FirstOrDefault();
            }
        }

        private void LoadComboKelompokHartaTetap()
        {
            this.kelompokHartaTetaps = new List<KelompokHartaTetap>();
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kelompokHartaTetaps = uow.KelompokHartaTetap.GetAll();
                CBKelompokHartaTetapParent.DisplayMemberPath = "NamaKelompokHartaTetap";
                CBKelompokHartaTetapParent.SelectedValuePath = "Id";
                CBKelompokHartaTetapParent.ItemsSource = this.kelompokHartaTetaps;
            }
        }

        private void LoadComboTabelPenyusutan()
        {
            this.tabelPenyusutans = new List<TabelPenyusutan>();
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.tabelPenyusutans = uow.TabelPenyusutan.GetAll();
                CBTabelPenyusutan.DisplayMemberPath = "NamaPenyusutan";
                CBTabelPenyusutan.SelectedValuePath = "Id";
                CBTabelPenyusutan.ItemsSource = this.tabelPenyusutans;
            }
        }

        private KelompokHartaTetap GetData()
        {
            this.kelompokHartaTetapSelected = (KelompokHartaTetap)CBKelompokHartaTetapParent.SelectedItem;
            this.tabelPenyusutanSelected = (TabelPenyusutan)CBTabelPenyusutan.SelectedItem;

            KelompokHartaTetap oData = new KelompokHartaTetap();
            oData.NamaKelompokHartaTetap = TxtNamaKelompokHartaTetap.Text;
            if (this.kelompokHartaTetapSelected != null)
                oData.IdParent = this.kelompokHartaTetapSelected.Id;
            if (this.tabelPenyusutanSelected != null)
            {
                oData.IdTabelPenyusutan = this.tabelPenyusutanSelected.Id;
                oData.NamaPenyusutan = this.tabelPenyusutanSelected.NamaPenyusutan;
                oData.UmurEkonomis = this.tabelPenyusutanSelected.Umur;
            }
            oData.Keterangan = TxtKeterangan.Text;
            if (this.fixedAssetCategoryForm.kelompokHartaTetapSelected != null)
            {
                oData.Id = this.fixedAssetCategoryForm.kelompokHartaTetapSelected.Id;
                oData.KodeKelompokHartaTetap = this.fixedAssetCategoryForm.kelompokHartaTetapSelected.KodeKelompokHartaTetap;
                oData.IdAkunAsset = this.fixedAssetCategoryForm.kelompokHartaTetapSelected.IdAkunAsset;
                oData.KodeRekeningAsset = this.fixedAssetCategoryForm.kelompokHartaTetapSelected.KodeRekeningAsset;
                oData.IdAkunAkumulasiPenyusutan = this.fixedAssetCategoryForm.kelompokHartaTetapSelected.IdAkunAkumulasiPenyusutan;
                oData.KodeRekeningAkumulasiPenyusutan = this.fixedAssetCategoryForm.kelompokHartaTetapSelected.KodeRekeningAkumulasiPenyusutan;
                oData.IdAkunPenyusutan = this.fixedAssetCategoryForm.kelompokHartaTetapSelected.IdAkunPenyusutan;
                oData.KodeRekeningPenyusutan = this.fixedAssetCategoryForm.kelompokHartaTetapSelected.KodeRekeningPenyusutan;
                oData.UserId = this.fixedAssetCategoryForm.kelompokHartaTetapSelected.UserId;
            }

            return oData;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (TxtNamaKelompokHartaTetap.Text == "" || CBKelompokHartaTetapParent.Text == "" || CBTabelPenyusutan.Text == "" || TxtKeterangan.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            KelompokHartaTetapBLL kelompokHartaTetapBLL = new KelompokHartaTetapBLL();
            if (kelompokHartaTetapBLL.AddKelompokHartaTetap(this.GetData()) > 0)
            {
                this.ClearForm();
                MessageBox.Show("Fixed Assets Group successfully added !");
                this.fixedAssetCategoryForm.LoadKelompokHartaTetap();
            }
            else
            {
                MessageBox.Show("Fixed Assets Groups failed to be added !");
            }
            this.Close();
        }
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            KelompokHartaTetapBLL kelompokHartaTetapBLL = new KelompokHartaTetapBLL();
            if (kelompokHartaTetapBLL.EditKelompokHartaTetap(this.GetData()) == true)
            {
                this.ClearForm();
                MessageBox.Show("Fixed Assets Group successfully changed !");
                this.fixedAssetCategoryForm.LoadKelompokHartaTetap();
            }
            else
            {
                MessageBox.Show("Fixed Assets Group failed to change !");
            }
            this.Close();
        }

        private void CBTabelPenyusutan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.tabelPenyusutanSelected = null;
            if (CBTabelPenyusutan.SelectedItem != null)
            {
                this.tabelPenyusutanSelected = (TabelPenyusutan)CBTabelPenyusutan.SelectedItem;
                LblUmurEkonomis.Content = this.tabelPenyusutanSelected.Umur.ToString();
            }
        }

        private void TxtNamaKelompokHartaTetap_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtNamaKelompokHartaTetap.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    TxtNamaKelompokHartaTetap.Text = "";
                    return;
                }

            }
        }

        private void TxtKeterangan_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
