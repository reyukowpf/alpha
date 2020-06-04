using Reyuko.BLL.Core;
using Reyuko.DAL.Domain;
using Reyuko.DAL;
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
using Reyuko.Utils;

namespace Reyuko.App.Views.Project
{
    /// <summary>

    /// </summary>
    public partial class NewProject : UserControl
    {
        public NewProject(Project ProjectForm)
        {
            InitializeComponent();
            this.ProjectForm = ProjectForm;
            Switcher.pageSwitchernewproject = this;
            this.Init();
        }
        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        public object UserControl { get; internal set; }
        private Project ProjectForm;
        private IEnumerable<ListKontak> Kontaks { get; set; }
        private ListKontak CustomerSelected { get; set; }
        private ListKontak PICSelected { get; set; }
        private IEnumerable<ListDataMataUang> MataUangs { get; set; }
        private ListDataMataUang MataUangSelected { get; set; }
        private List<Combo> Statuses { get; set; }
        private Combo Status { get; set; }


        private void ClearForm()
        {
            this.CustomerSelected = null;
            this.PICSelected = null;
            this.MataUangSelected = null;
            this.Status = null;

            txtProjectno.Text = "";
            txtProjectName.Text = "";
            CbCustomer.SelectedIndex = -1;
            CbPIC.SelectedIndex = -1;
            CbCurrency.SelectedIndex = -1;
            DpStartDate.Text = DateTime.Now.ToShortDateString();
            DpEndDate.Text = DateTime.Now.ToShortDateString();
            txtContractPrice.Text = "0";
            CbStatus.SelectedIndex = -1;
            txtRemarks.Text = "";
            ChkInactive.IsChecked = false;
        }

        private void Init()
        {
            this.ClearForm();
            this.LoadListKontak();
            this.LoadComboCustomer();
            this.LoadComboPIC();
            this.LoadComboCurrency();
            this.LoadComboStatus();
            if (this.ProjectForm.isEdit == true)
                this.LoadDataProyek();
        }

        private void LoadListKontak()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.Kontaks = uow.ListKontak.GetAll();
            }
        }

        private void LoadComboCustomer()
        {
            CbCustomer.SelectedIndex = -1;
            if (this.Kontaks != null)
            {
                var customers = this.Kontaks.Where(m => m.TypeKontak.ToLower() == "pelanggan");
                CbCustomer.ItemsSource = customers;
                CbCustomer.DisplayMemberPath = "NamaA";
                CbCustomer.SelectedValuePath = "IdKontak";
            }
        }

        private void LoadComboPIC()
        {
            CbPIC.SelectedIndex = -1;
            if (this.Kontaks != null)
            {
                var employees = this.Kontaks.Where(m => m.TypeKontak.ToLower() == "employee");
                CbPIC.ItemsSource = employees;
                CbPIC.DisplayMemberPath = "NamaA";
                CbPIC.SelectedValuePath = "IdKontak";
            }
        }

        private void LoadComboCurrency()
        {
            CbCurrency.SelectedIndex = -1;
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.MataUangs = uow.ListDataMataUang.GetAll();
                CbCurrency.ItemsSource = this.MataUangs;
                CbCurrency.DisplayMemberPath = "NamaMataUang";
                CbCurrency.SelectedValuePath = "IdDataMataUang";
            }
        }

        private void LoadComboStatus()
        {
            CbStatus.SelectedIndex = -1;
            this.Statuses = new List<Combo>();
            this.Statuses.Add(new Combo() { Text = "New", Value = 1 });
            this.Statuses.Add(new Combo() { Text = "Progress", Value = 2 });
            this.Statuses.Add(new Combo() { Text = "Finished", Value = 3 });

            CbStatus.ItemsSource = this.Statuses;
            CbStatus.DisplayMemberPath = "Text";
            CbStatus.SelectedValuePath = "Value";
        }

        private void LoadDataProyek()
        {
            this.ClearForm();
            if (this.ProjectForm != null && this.ProjectForm.DataProyekSelected != null)
            {

                txtProjectno.Text = this.ProjectForm.DataProyekSelected.NomorProyek;
                txtProjectName.Text = this.ProjectForm.DataProyekSelected.NamaProyek;
                CbCustomer.SelectedValue = this.ProjectForm.DataProyekSelected.IdKontakPemesan;
                CbPIC.SelectedValue = this.ProjectForm.DataProyekSelected.IdKontakPIC;
                CbCurrency.SelectedValue = this.ProjectForm.DataProyekSelected.IdMataUang;
                CbStatus.SelectedValue = this.ProjectForm.DataProyekSelected.idStatus;
                txtContractPrice.Text = this.ProjectForm.DataProyekSelected.NilaiProyek.ToString();
                DpStartDate.Text = this.ProjectForm.DataProyekSelected.TanggalMulai.ToString();
                DpEndDate.Text = this.ProjectForm.DataProyekSelected.TanggalBerakhir.ToString();
                txtRemarks.Text = this.ProjectForm.DataProyekSelected.Keterangan;
                ChkInactive.IsChecked = this.ProjectForm.DataProyekSelected.CheckboxInAtive;

                this.CustomerSelected = Kontaks.Where(m => m.IdKontak == this.ProjectForm.DataProyekSelected.IdKontakPemesan).FirstOrDefault();
                this.PICSelected = Kontaks.Where(m => m.IdKontak == this.ProjectForm.DataProyekSelected.IdKontakPIC).FirstOrDefault();
                this.MataUangSelected = MataUangs.Where(m => m.IdDataMataUang == this.ProjectForm.DataProyekSelected.IdMataUang).FirstOrDefault();
            }
        }

        private DataProyek GetData()
        {
            DataProyek oData = new DataProyek();
            oData.NomorProyek = txtProjectno.Text;
            oData.NamaProyek = txtProjectName.Text;
            oData.NilaiProyek = double.Parse(txtContractPrice.Text);
            oData.TanggalMulai = DateTime.Parse(DpStartDate.Text);
            oData.TanggalBerakhir = DateTime.Parse(DpEndDate.Text);
            if (this.CustomerSelected != null)
            {
                oData.IdKontakPemesan = this.CustomerSelected.IdKontak;
                oData.PemesanKontak = this.CustomerSelected.NamaA;
            }
            if (this.PICSelected != null)
            {
                oData.IdKontakPIC = this.PICSelected.IdKontak;
                oData.PICKontak = this.PICSelected.NamaA;
            }
            if (this.MataUangSelected != null)
            {
                oData.IdMataUang = this.MataUangSelected.IdDataMataUang;
                oData.MataUang = this.MataUangSelected.NamaMataUang;
            }
            oData.idStatus = this.Status.Value;
            oData.Status = this.Status.Text;
            oData.Keterangan = txtRemarks.Text;
            oData.CheckboxInAtive = ChkInactive.IsChecked;
            if (this.ProjectForm.DataProyekSelected != null)
                oData.Id = this.ProjectForm.DataProyekSelected.Id;

            return oData;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtProjectno.Text == "" || txtProjectName.Text == "" || CbCustomer.Text == "" || CbPIC.Text == "" || CbCurrency.Text == "" || txtContractPrice.Text == "" || DpStartDate.Text == "" || DpEndDate.Text == "" || CbStatus.Text == "" || txtRemarks.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            DataProyekBLL DataProyekBLL = new DataProyekBLL();
            if (this.ProjectForm.isEdit == false)
            {
                if (DataProyekBLL.AddDataProyek(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Project successfully added !");
                    this.ProjectForm.LoadDataProyek("");
                }
                else
                {
                    MessageBox.Show("Project failed to add !");
                }
            }
            else
            {
                if (DataProyekBLL.EditDataProyek(this.GetData()) == true)
                {
                    this.ClearForm();
                    MessageBox.Show("Project successfully changed !");
                    this.ProjectForm.LoadDataProyek("");
                }
                else
                {
                    MessageBox.Show("Project failed to change !");
                }
            }
            Project v = new Project();
            Switcher.Switchnewproject(v);
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Project v = new Project();
            Switcher.Switchnewproject(v);
        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CbCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.CustomerSelected = null;
            if (CbCustomer.SelectedItem != null)
            {
                this.CustomerSelected = (ListKontak)CbCustomer.SelectedItem;
            }
        }

        private void CBPIC_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.PICSelected = null;
            if (CbPIC.SelectedItem != null)
            {
                this.PICSelected = (ListKontak)CbPIC.SelectedItem;
            }
        }

        private void CbCurrency_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.MataUangSelected = null;
            if (CbCurrency.SelectedItem != null)
            {
                this.MataUangSelected = (ListDataMataUang)CbCurrency.SelectedItem;
            }
        }

        private void CbStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.Status = null;
            if(CbStatus.SelectedItem != null)
            {
                this.Status = (Combo)CbStatus.SelectedItem;
            }
        }

        private void TxtProjectno_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtProjectno.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtProjectno.Text = "";
                    return;
                }

            }
        }

        private void TxtContractPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtContractPrice.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtContractPrice.Text = "";
                    return;
                }

            }
        }

        private void TxtProjectName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtProjectName.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtProjectName.Text = "";
                    return;
                }

            }
        }
    }
}
