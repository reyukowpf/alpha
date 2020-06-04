using Reyuko.BLL.Core;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace Reyuko.App.Views.DeprectiationTable
{
    /// <summary>
    /// </summary>
    public partial class NewDeprectiationTable : Window
    {
        public NewDeprectiationTable(DeprectiationTable deprectiationTableForm)
        {
            InitializeComponent();
            this.deprectiationTableForm = deprectiationTableForm;
            this.Init();
        }

        public object UserControl { get; internal set; }
        public DeprectiationTable deprectiationTableForm { get; set; }
        private IEnumerable<NamaPenyusutan> namaPenyusutans { get; set; }
        private NamaPenyusutan namaPenyusutanSelected { get; set; }
        private List<MappingBinding> MappingBindings { get; set; }

        private void ClearForm()
        {
            this.namaPenyusutanSelected = null;

            CbNamaPenyusutan.SelectedIndex = -1;
            TxtNamaPenyusutan.Text = "";
            TxtUmur.Text = "0";
            TxtTotal.Text = "0";
            TxtTotal.IsEnabled = false;
            TxtTahun1.Text = "0";
            TxtTahun2.Text = "0";
            TxtTahun3.Text = "0";
            TxtTahun4.Text = "0";
            TxtTahun5.Text = "0";
            TxtTahun6.Text = "0";
            TxtTahun7.Text = "0";
            TxtTahun8.Text = "0";
            TxtTahun9.Text = "0";
            TxtTahun10.Text = "0";
            TxtTahun11.Text = "0";
            TxtTahun12.Text = "0";
            TxtTahun13.Text = "0";
            TxtTahun14.Text = "0";
            TxtTahun15.Text = "0";
            TxtTahun16.Text = "0";
            TxtTahun17.Text = "0";
            TxtTahun18.Text = "0";
            TxtTahun19.Text = "0";
            TxtTahun20.Text = "0";
            TxtTahun21.Text = "0";
            TxtTahun22.Text = "0";
            TxtTahun23.Text = "0";
            TxtTahun24.Text = "0";
            TxtTahun25.Text = "0";
            TxtTahun26.Text = "0";
            TxtTahun27.Text = "0";
            TxtTahun28.Text = "0";
            TxtTahun29.Text = "0";
            TxtTahun30.Text = "0";
        }

        private void Init()
        {
            this.ClearForm();
            this.LoadNamaPenyusutan();
            this.MappingBinding();
            if (this.deprectiationTableForm.isEdit == true)
                this.LoadTablePenyusutan();
        }

        private void MappingBinding()
        {
            this.MappingBindings = new List<MappingBinding>();
            this.MappingBindings.Add(new MappingBinding() { Name = "Tahun1", Type = "textbox", Control = TxtTahun1 });
            this.MappingBindings.Add(new MappingBinding() { Name = "Tahun2", Type = "textbox", Control = TxtTahun2 });
            this.MappingBindings.Add(new MappingBinding() { Name = "Tahun3", Type = "textbox", Control = TxtTahun3 });
            this.MappingBindings.Add(new MappingBinding() { Name = "Tahun4", Type = "textbox", Control = TxtTahun4 });
            this.MappingBindings.Add(new MappingBinding() { Name = "Tahun5", Type = "textbox", Control = TxtTahun5 });
            this.MappingBindings.Add(new MappingBinding() { Name = "Tahun6", Type = "textbox", Control = TxtTahun6 });
            this.MappingBindings.Add(new MappingBinding() { Name = "Tahun7", Type = "textbox", Control = TxtTahun7 });
            this.MappingBindings.Add(new MappingBinding() { Name = "Tahun8", Type = "textbox", Control = TxtTahun8 });
            this.MappingBindings.Add(new MappingBinding() { Name = "Tahun9", Type = "textbox", Control = TxtTahun9 });
            this.MappingBindings.Add(new MappingBinding() { Name = "Tahun10", Type = "textbox", Control = TxtTahun10 });
            this.MappingBindings.Add(new MappingBinding() { Name = "Tahun11", Type = "textbox", Control = TxtTahun11 });
            this.MappingBindings.Add(new MappingBinding() { Name = "Tahun12", Type = "textbox", Control = TxtTahun12 });
            this.MappingBindings.Add(new MappingBinding() { Name = "Tahun13", Type = "textbox", Control = TxtTahun13 });
            this.MappingBindings.Add(new MappingBinding() { Name = "Tahun14", Type = "textbox", Control = TxtTahun14 });
            this.MappingBindings.Add(new MappingBinding() { Name = "Tahun15", Type = "textbox", Control = TxtTahun15 });
            this.MappingBindings.Add(new MappingBinding() { Name = "Tahun16", Type = "textbox", Control = TxtTahun16 });
            this.MappingBindings.Add(new MappingBinding() { Name = "Tahun17", Type = "textbox", Control = TxtTahun17 });
            this.MappingBindings.Add(new MappingBinding() { Name = "Tahun18", Type = "textbox", Control = TxtTahun18 });
            this.MappingBindings.Add(new MappingBinding() { Name = "Tahun19", Type = "textbox", Control = TxtTahun19 });
            this.MappingBindings.Add(new MappingBinding() { Name = "Tahun20", Type = "textbox", Control = TxtTahun20 });
            this.MappingBindings.Add(new MappingBinding() { Name = "Tahun21", Type = "textbox", Control = TxtTahun21 });
            this.MappingBindings.Add(new MappingBinding() { Name = "Tahun22", Type = "textbox", Control = TxtTahun22 });
            this.MappingBindings.Add(new MappingBinding() { Name = "Tahun23", Type = "textbox", Control = TxtTahun23 });
            this.MappingBindings.Add(new MappingBinding() { Name = "Tahun24", Type = "textbox", Control = TxtTahun24 });
            this.MappingBindings.Add(new MappingBinding() { Name = "Tahun25", Type = "textbox", Control = TxtTahun25 });
            this.MappingBindings.Add(new MappingBinding() { Name = "Tahun26", Type = "textbox", Control = TxtTahun26 });
            this.MappingBindings.Add(new MappingBinding() { Name = "Tahun27", Type = "textbox", Control = TxtTahun27 });
            this.MappingBindings.Add(new MappingBinding() { Name = "Tahun28", Type = "textbox", Control = TxtTahun28 });
            this.MappingBindings.Add(new MappingBinding() { Name = "Tahun29", Type = "textbox", Control = TxtTahun29 });
            this.MappingBindings.Add(new MappingBinding() { Name = "Tahun30", Type = "textbox", Control = TxtTahun30 });
        }


        private void LoadNamaPenyusutan()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.namaPenyusutans = uow.NamaPenyusutan.GetAll();
                CbNamaPenyusutan.ItemsSource = this.namaPenyusutans;
                CbNamaPenyusutan.SelectedValuePath = "Id";
                CbNamaPenyusutan.DisplayMemberPath = "Nama";
            }
        }

        private void LoadTablePenyusutan()
        {
            this.ClearForm();
            if (this.deprectiationTableForm != null && this.deprectiationTableForm.tabelPenyusutanSelected != null)
            {

                this.namaPenyusutanSelected = this.namaPenyusutans.Where(m => m.Id == this.deprectiationTableForm.tabelPenyusutanSelected.IdNamaPenyusutan).FirstOrDefault();

                CbNamaPenyusutan.SelectedValue = this.deprectiationTableForm.tabelPenyusutanSelected.IdNamaPenyusutan;
                TxtNamaPenyusutan.Text = this.deprectiationTableForm.tabelPenyusutanSelected.NamaPenyusutan;
                TxtUmur.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Umur.ToString();
                TxtTotal.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Total.ToString();
                TxtTahun1.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Tahun1.ToString();
                TxtTahun2.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Tahun2.ToString();
                TxtTahun3.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Tahun3.ToString();
                TxtTahun4.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Tahun4.ToString();
                TxtTahun5.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Tahun5.ToString();
                TxtTahun6.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Tahun6.ToString();
                TxtTahun7.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Tahun7.ToString();
                TxtTahun8.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Tahun8.ToString();
                TxtTahun9.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Tahun9.ToString();
                TxtTahun10.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Tahun10.ToString();
                TxtTahun11.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Tahun11.ToString();
                TxtTahun12.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Tahun12.ToString();
                TxtTahun13.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Tahun13.ToString();
                TxtTahun14.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Tahun14.ToString();
                TxtTahun15.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Tahun15.ToString();
                TxtTahun16.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Tahun16.ToString();
                TxtTahun17.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Tahun17.ToString();
                TxtTahun18.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Tahun18.ToString();
                TxtTahun19.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Tahun19.ToString();
                TxtTahun20.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Tahun20.ToString();
                TxtTahun21.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Tahun21.ToString();
                TxtTahun22.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Tahun22.ToString();
                TxtTahun23.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Tahun23.ToString();
                TxtTahun24.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Tahun24.ToString();
                TxtTahun25.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Tahun25.ToString();
                TxtTahun26.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Tahun26.ToString();
                TxtTahun27.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Tahun27.ToString();
                TxtTahun28.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Tahun28.ToString();
                TxtTahun29.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Tahun29.ToString();
                TxtTahun30.Text = this.deprectiationTableForm.tabelPenyusutanSelected.Tahun30.ToString();

            }
        }

        private TabelPenyusutan GetData()
        {
            TabelPenyusutan oData = new TabelPenyusutan();
            oData.Umur = int.Parse(TxtUmur.Text);
            oData.Total = int.Parse(TxtTotal.Text);
            oData.Tahun1 = double.Parse(TxtTahun1.Text);
            oData.Tahun2 = double.Parse(TxtTahun2.Text);
            oData.Tahun3 = double.Parse(TxtTahun3.Text);
            oData.Tahun4 = double.Parse(TxtTahun4.Text);
            oData.Tahun5 = double.Parse(TxtTahun5.Text);
            oData.Tahun6 = double.Parse(TxtTahun6.Text);
            oData.Tahun7 = double.Parse(TxtTahun7.Text);
            oData.Tahun8 = double.Parse(TxtTahun8.Text);
            oData.Tahun9 = double.Parse(TxtTahun9.Text);
            oData.Tahun10 = double.Parse(TxtTahun10.Text);
            oData.Tahun11 = double.Parse(TxtTahun11.Text);
            oData.Tahun12 = double.Parse(TxtTahun12.Text);
            oData.Tahun13 = double.Parse(TxtTahun13.Text);
            oData.Tahun14 = double.Parse(TxtTahun14.Text);
            oData.Tahun15 = double.Parse(TxtTahun15.Text);
            oData.Tahun16 = double.Parse(TxtTahun16.Text);
            oData.Tahun17 = double.Parse(TxtTahun17.Text);
            oData.Tahun18 = double.Parse(TxtTahun18.Text);
            oData.Tahun19 = double.Parse(TxtTahun19.Text);
            oData.Tahun20 = double.Parse(TxtTahun20.Text);
            oData.Tahun21 = double.Parse(TxtTahun21.Text);
            oData.Tahun22 = double.Parse(TxtTahun22.Text);
            oData.Tahun23 = double.Parse(TxtTahun23.Text);
            oData.Tahun24 = double.Parse(TxtTahun24.Text);
            oData.Tahun25 = double.Parse(TxtTahun25.Text);
            oData.Tahun26 = double.Parse(TxtTahun26.Text);
            oData.Tahun27 = double.Parse(TxtTahun27.Text);
            oData.Tahun28 = double.Parse(TxtTahun28.Text);
            oData.Tahun29 = double.Parse(TxtTahun29.Text);
            oData.Tahun30 = double.Parse(TxtTahun30.Text);
            oData.NamaPenyusutan = TxtNamaPenyusutan.Text;

            if (this.namaPenyusutanSelected != null)
            {
                oData.IdNamaPenyusutan = this.namaPenyusutanSelected.Id;
            }
            if (this.deprectiationTableForm.tabelPenyusutanSelected != null)
                oData.Id = this.deprectiationTableForm.tabelPenyusutanSelected.Id;

            return oData;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (CbNamaPenyusutan.Text == "" || TxtNamaPenyusutan.Text == "" || TxtUmur.Text == "" || TxtTotal.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            double total = 0;
            for (int i = 0; i < MappingBindings.Count; i++)
            {
                var txt = (TextBox)this.MappingBindings[i].Control;
                total += double.Parse(txt.Text);
            }

            if (total != 100)
            {
                MessageBox.Show("Total cannot be more than 100%!");
                return;
            }

            TabelPenyusutanBLL tabelPenyusutanBLL = new TabelPenyusutanBLL();
            if (this.deprectiationTableForm.isEdit == false)
            {
                if (tabelPenyusutanBLL.AddTabelPenyusutan(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Depreciation Table added successfully !");
                    this.deprectiationTableForm.LoadTabelPenyusutan();
                }
                else
                {
                    MessageBox.Show("Depreciation Table failed to add !");
                }
            }
            else
            {
                if (tabelPenyusutanBLL.EditTabelPenyusutan(this.GetData()) == true)
                {
                    this.ClearForm();
                    MessageBox.Show("Depreciation Tables successfully changed !");
                    this.deprectiationTableForm.LoadTabelPenyusutan();
                }
                else
                {
                    MessageBox.Show("Depreciation Table failed to change !");
                }
            }
            this.Close();
        }

        private void CbNamaPenyusutan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CbNamaPenyusutan.SelectedItem != null)
            {
                this.namaPenyusutanSelected = (NamaPenyusutan)CbNamaPenyusutan.SelectedItem;
                TxtNamaPenyusutan.Text = namaPenyusutanSelected.Nama;
            }
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.ClearForm();
            this.Close();
        }

        private void TxtUmur_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtUmur.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtUmur.Text = "";
                    return;
                }

            }



            if (!string.IsNullOrEmpty(TxtUmur.Text))
            {
                int umur = int.Parse(TxtUmur.Text);
                if (umur > 30)
                {
                    MessageBox.Show("Life cannot be more than 30 years old !");
                    return;
                }
                if (umur == 0)
                    return;

                double maxTotal = 100,
                    total = 0,
                    div = maxTotal / umur;

                for (int i = 0; i < MappingBindings.Count; i++)
                {
                    var txt = (TextBox)this.MappingBindings[i].Control;
                    txt.IsEnabled = false;
                    txt.Text = "0";

                    if (i < umur)
                    {
                        txt.IsEnabled = true;
                        txt.Text = div.ToString();
                        total += div;
                    }
                }

                TxtTotal.Text = total.ToString();
                if (this.namaPenyusutanSelected != null)
                    TxtNamaPenyusutan.Text = this.namaPenyusutanSelected.Nama + " " + TxtUmur.Text;
            }
        }

        private void TxtTahun1_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtTahun1.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtTahun1.Text = "";
                    return;
                }

            }
        }

        private void TxtTahun6_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtTahun6.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtTahun6.Text = "";
                    return;
                }

            }
        }

        private void TxtTahun11_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtTahun11.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtTahun11.Text = "";
                    return;
                }

            }
        }

        private void TxtTahun16_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtTahun16.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtTahun16.Text = "";
                    return;
                }

            }
        }

        private void TxtTahun21_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtTahun21.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtTahun21.Text = "";
                    return;
                }

            }
        }

        private void TxtTahun26_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtTahun26.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtTahun26.Text = "";
                    return;
                }

            }
        }

        private void TxtTahun2_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtTahun2.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtTahun2.Text = "";
                    return;
                }

            }
        }

        private void TxtTahun7_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtTahun7.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtTahun7.Text = "";
                    return;
                }

            }
        }

        private void TxtTahun12_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtTahun12.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtTahun12.Text = "";
                    return;
                }

            }
        }

        private void TxtTahun17_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtTahun17.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtTahun17.Text = "";
                    return;
                }

            }
        }

        private void TxtTahun22_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtTahun22.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtTahun22.Text = "";
                    return;
                }

            }
        }

        private void TxtTahun27_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtTahun27.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtTahun27.Text = "";
                    return;
                }

            }
        }

        private void TxtTahun3_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtTahun3.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtTahun3.Text = "";
                    return;
                }

            }
        }

        private void TxtTahun8_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtTahun8.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtTahun8.Text = "";
                    return;
                }

            }
        }

        private void TxtTahun13_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtTahun13.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtTahun13.Text = "";
                    return;
                }

            }
        }

        private void TxtTahun18_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtTahun18.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtTahun18.Text = "";
                    return;
                }

            }
        }

        private void TxtTahun23_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtTahun23.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtTahun23.Text = "";
                    return;
                }

            }
        }

        private void TxtTahun28_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtTahun28.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtTahun28.Text = "";
                    return;
                }

            }
        }

        private void TxtTahun4_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtTahun4.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtTahun4.Text = "";
                    return;
                }

            }
        }

        private void TxtTahun9_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtTahun9.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtTahun9.Text = "";
                    return;
                }

            }
        }

        private void TxtTahun14_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtTahun14.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtTahun14.Text = "";
                    return;
                }

            }
        }

        private void TxtTahun19_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtTahun19.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtTahun19.Text = "";
                    return;
                }

            }
        }

        private void TxtTahun24_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtTahun24.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtTahun24.Text = "";
                    return;
                }

            }
        }

        private void TxtTahun29_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtTahun29.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtTahun29.Text = "";
                    return;
                }

            }
        }

        private void TxtTahun5_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtTahun5.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtTahun5.Text = "";
                    return;
                }

            }
        }

        private void TxtTahun10_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtTahun10.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtTahun10.Text = "";
                    return;
                }

            }
        }

        private void TxtTahun15_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtTahun15.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtTahun15.Text = "";
                    return;
                }

            }
        }

        private void TxtTahun20_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtTahun20.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtTahun20.Text = "";
                    return;
                }

            }
        }

        private void TxtTahun25_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtTahun25.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtTahun25.Text = "";
                    return;
                }

            }
        }

        private void TxtTahun30_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtTahun30.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtTahun30.Text = "";
                    return;
                }

            }
        }

        private void TxtNamaPenyusutan_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtNamaPenyusutan.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    TxtNamaPenyusutan.Text = "";
                    return;
                }

            }
        }

        private void TxtTotal_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = TxtTotal.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    TxtTotal.Text = "";
                    return;
                }

            }
        }
    }

    public class MappingBinding
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public object Control { get; set; }
    }
}
