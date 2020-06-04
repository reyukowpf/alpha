using Reyuko.BLL.Core;
using Reyuko.DAL.Domain;
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

namespace Reyuko.App.Views.MeasurementUnit
{
    /// <summary>
    /// </summary>
    public partial class NewMeasurementUnit : Window
    {
        public NewMeasurementUnit(MeasurementUnit measurementUnitForm)
        {
            InitializeComponent();
            this.measurementUnitForm = measurementUnitForm;
            this.Init();
        }

        public object UserControl { get; internal set; }
        private MeasurementUnit measurementUnitForm;

        private IEnumerable<SatuanDasar> SatuanDasars { get; set; }
        private SatuanDasar SatuanDasarSelected { get; set; }

        private void ClearForm()
        {
            chkUnitDasar.IsChecked = false;
            CBTipeUnit.SelectedIndex = -1;
            txtUnitCode.Text = "";
            txtUnitName.Text = "";
            txtUnitTotal.Text = "0";
            txtUnitDetail.Text = "";
            txtNote.Text = "";

            this.SatuanDasarSelected = null;
        }

        private void Init()
        {
            this.ClearForm();
            this.LoadComboSatuanDasarParent();
            this.LoadComboTipeUnit();
            if (this.measurementUnitForm.isEdit == true)
                this.LoadSatuanDasar();
        }

        private void LoadComboSatuanDasarParent()
        {
            this.SatuanDasars = this.measurementUnitForm.SatuanDasars;
        }

        private void LoadComboTipeUnit()
        {
            var tipeUnits = new List<object>();
            tipeUnits.Add(new { text = "Measurement", value = "0" });
            tipeUnits.Add(new { text = "Time", value = "1" });

            CBTipeUnit.ItemsSource = tipeUnits;
            CBTipeUnit.DisplayMemberPath = "text";
            CBTipeUnit.SelectedValuePath = "value";
        }

        private void LoadSatuanDasar()
        {
            this.ClearForm();
            if (this.measurementUnitForm != null && this.measurementUnitForm.SatuanDasarSelected != null)
            {
                chkUnitDasar.IsChecked = this.measurementUnitForm.SatuanDasarSelected.CheckboxUnitDasar;
                CBTipeUnit.SelectedValue = this.measurementUnitForm.SatuanDasarSelected.TipeUnit.GetValueOrDefault(0);
                txtUnitCode.Text = this.measurementUnitForm.SatuanDasarSelected.KodeSatuan;
                txtUnitName.Text = this.measurementUnitForm.SatuanDasarSelected.NamaSatuan;
                txtUnitTotal.Text = this.measurementUnitForm.SatuanDasarSelected.JumlahSatuan.GetValueOrDefault(0).ToString();
                txtUnitDetail.Text = this.measurementUnitForm.SatuanDasarSelected.DetailSatuan;
                txtNote.Text = this.measurementUnitForm.SatuanDasarSelected.Keterangan;

                this.SatuanDasarSelected = this.SatuanDasars.Where(m => m.Id == this.measurementUnitForm.SatuanDasarSelected.ParentId.GetValueOrDefault(0)).FirstOrDefault();
            }
        }

        private SatuanDasar GetData()
        {
            SatuanDasar oData = new SatuanDasar();
            oData.CheckboxUnitDasar = chkUnitDasar.IsChecked;
            oData.TipeUnit = int.Parse(CBTipeUnit.SelectedValue.ToString());
            oData.KodeSatuan = txtUnitCode.Text;
            oData.NamaSatuan = txtUnitName.Text;
            oData.JumlahSatuan = double.Parse(txtUnitTotal.Text);
            oData.DetailSatuan = txtUnitDetail.Text;
            if (this.SatuanDasarSelected != null)
                oData.ParentId = this.SatuanDasarSelected.Id;
            oData.Keterangan = txtNote.Text;
            if (this.measurementUnitForm.SatuanDasarSelected != null)
                oData.Id = this.measurementUnitForm.SatuanDasarSelected.Id;

            return oData;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (CBTipeUnit.Text == "" || txtUnitCode.Text == "" || txtUnitName.Text == "" || txtUnitTotal.Text == "" || txtUnitDetail.Text == "" || txtNote.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            SatuanDasarBLL SatuanDasarBLL = new SatuanDasarBLL();
            if (this.measurementUnitForm.isEdit == false)
            {
                if (SatuanDasarBLL.AddSatuanDasar(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Basic Unit successfully added !");
                    this.measurementUnitForm.LoadSatuanDasar();
                }
                else
                {
                    MessageBox.Show("Basic Unit failed to be added !");
                }
            }
            else
            {
                if (SatuanDasarBLL.EditSatuanDasar(this.GetData()) == true)
                {
                    this.ClearForm();
                    MessageBox.Show("Basic Unit successfully changed !");
                    this.measurementUnitForm.LoadSatuanDasar();
                }
                else
                {
                    MessageBox.Show("The Basic Unit failed to change !");
                }
            }
            this.Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.ClearForm();
            this.Close();
        }

        private void TxtUnitCode_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtUnitCode.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtUnitCode.Text = "";
                    return;
                }

            }
        }

        private void TxtUnitTotal_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtUnitTotal.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtUnitTotal.Text = "";
                    return;
                }

            }
        }

        private void TxtUnitName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtUnitName.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtUnitName.Text = "";
                    return;
                }

            }
        }

        private void TxtUnitDetail_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtUnitDetail.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtUnitDetail.Text = "";
                    return;
                }

            }
        }

        private void TxtNote_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
