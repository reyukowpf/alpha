using Reyuko.BLL.Core;
using Reyuko.DAL.Domain;
using Reyuko.DAL;
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
using System.Collections.ObjectModel;

namespace Reyuko.App.Views.Document
{
    /// <summary>
    /// </summary>
    public partial class NewDocument : UserControl
    {
        public NewDocument(Documents documentform)
        {
            InitializeComponent();
            Switcher.pageSwitchNewDocument = this;
            this.documentform = documentform;
            this.Init();
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
        public IEnumerable<TypeDokumen> TypeDokumens { get; set; }
        public TypeDokumen TypeDokumenSelected { get; set; }
        public Dokumen dokumenSelected;
        public IEnumerable<Kontak> Kontaks { get; set; }
        public Kontak KontakSelected { get; set; }
        public IEnumerable<DataDepartemen> dataDepartemens { get; set; }
        public DataDepartemen Selectdepartment { get; set; }
        public IEnumerable<DataProyek> dataProyeks { get; set; }
        public DataProyek Selectproyek { get; set; }
        private Documents documentform;
        private string UploadFileA { get; set; }
        private string UploadFileB { get; set; }
        private string UploadFileC { get; set; }
        private string UploadFileD { get; set; }
        private void Init()
        {
            this.ClearForm();
            this.LoadTypeDocument();
            this.LoadKontak();
            if (this.documentform.isEdit == true)
                this.LoadDokumen();

        }
        private void ClearForm()
        {
            txtDocumentNo.Text = "";
            cbDocumentTipe.SelectedIndex = -1;
            dtTanggalDokumen.Text = DateTime.Now.ToShortDateString();
            cbNamakontak.SelectedIndex = -1;
            cbdepartment.SelectedIndex = -1;
            cbproyek.SelectedIndex = -1;
            txtDescription.Text = "";
            this.KontakSelected = null;
            this.Selectdepartment = null;
            this.TypeDokumenSelected = null;
        }

        private void CbTypedokumen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.TypeDokumenSelected = null;
            if (cbDocumentTipe.SelectedItem != null)
            {
                this.TypeDokumenSelected = (TypeDokumen)cbDocumentTipe.SelectedItem;
            }
        }

        private void CbNamaKontak_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.KontakSelected = null;
            if (cbNamakontak.SelectedItem != null)
            {
                this.KontakSelected = (Kontak)cbNamakontak.SelectedItem;
            }
        }

        public void LoadTypeDocument()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.TypeDokumens = uow.TypeDokumen.GetAll();
                cbDocumentTipe.ItemsSource = this.TypeDokumens;
                cbDocumentTipe.SelectedValuePath = "Id";
                cbDocumentTipe.DisplayMemberPath = "Type";
            }
        }

        public void LoadKontak()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.Kontaks = uow.Kontak.GetAll();
                cbNamakontak.ItemsSource = this.Kontaks;
                cbNamakontak.SelectedValuePath = "Id";
                cbNamakontak.DisplayMemberPath = "NamaA";
            }
        }

        private void LoadDokumen()
        {
            if (this.documentform != null && this.documentform.dokumenSelected != null)
            {
                txtDocumentNo.Text = this.documentform.dokumenSelected.NoReferensiDokumen;
                cbDocumentTipe.SelectedValue = this.documentform.dokumenSelected.IdTypeDokumen;
                dtTanggalDokumen.Text = this.documentform.dokumenSelected.TanggalDokumen.GetValueOrDefault().ToShortDateString();
                cbNamakontak.SelectedValue = this.documentform.dokumenSelected.IdKontak;
                cbdepartment.SelectedValue = this.documentform.dokumenSelected.IdDepartmen;
                {
                    Departmen.IsChecked = true;
                    cbdepartment.SelectedValue = this.documentform.dokumenSelected.IdDepartmen;
                    {
                        Projec.IsChecked = true;
                        cbproyek.SelectedValue = this.documentform.dokumenSelected.IdProyek;
                    }
             
                }
                
                txtDescription.Text = this.documentform.dokumenSelected.KeteranganDokumen;
                this.KontakSelected = this.Kontaks.Where(m => m.Id == this.documentform.dokumenSelected.IdKontak).FirstOrDefault();
                this.TypeDokumenSelected = this.TypeDokumens.Where(m => m.Id == this.documentform.dokumenSelected.IdTypeDokumen).FirstOrDefault();
            }
        }

        private void department_selectionchange(object sender, SelectionChangedEventArgs e)
        {
            this.Selectdepartment = null;
            if (cbdepartment.SelectedItem != null)
            {
                Selectdepartment = (DataDepartemen)cbdepartment.SelectedItem;
            }           
        }
        private void proyek_selectionchange(object sender, SelectionChangedEventArgs e)
        {
            this.Selectproyek = null;
            if (cbproyek.SelectedItem != null)
            {
                Selectproyek = (DataProyek)cbproyek.SelectedItem;
            }
        }

        public void LoadDepartmen()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dataDepartemens = uow.DataDepartemen.GetAll();
                cbdepartment.ItemsSource = this.dataDepartemens;
                cbdepartment.SelectedValuePath = "Id";
                cbdepartment.DisplayMemberPath = "NamaDepartemen";
            }
        }

        public void LoadProyek()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dataProyeks = uow.DataProyek.GetAll();
                cbproyek.ItemsSource = this.dataProyeks;
                cbproyek.SelectedValuePath = "Id";
                cbproyek.DisplayMemberPath = "NamaProyek";
            }
        }

        public void Departmen_Checked(object sender, EventArgs e)
        {
            this.Departmen.IsChecked = true;
            {
                cbdepartment.Visibility = Visibility.Visible;
                cbproyek.Visibility = Visibility.Hidden;
                this.LoadDepartmen();
            }
        }

        public void Proyek_Checked(object sender, EventArgs e)
        {
            this.Projec.IsChecked = true;
            {
                cbproyek.Visibility = Visibility.Visible;
                cbdepartment.Visibility = Visibility.Hidden;
                this.LoadProyek();
            }
        }

        private void UploadFileA_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;
            dlg.Filter = Helper.UploadFilter(Helper.enUploadType.Files);

            if ((bool)dlg.ShowDialog())
            {
                Stream file = dlg.OpenFile();
                string filename = dlg.SafeFileName;
                this.UploadFileA = Helper.UploadFile(Helper.enUploadType.Files, file, filename);
            }
            else
            {
                MessageBox.Show("File not selected");
            }
        }
        private void UploadFileB_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;
            dlg.Filter = Helper.UploadFilter(Helper.enUploadType.Files);

            if ((bool)dlg.ShowDialog())
            {
                Stream file = dlg.OpenFile();
                string filename = dlg.SafeFileName;
                this.UploadFileB = Helper.UploadFile(Helper.enUploadType.Files, file, filename);
            }
            else
            {
                MessageBox.Show("File not selected");
            }
        }
        private void UploadFileC_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;
            dlg.Filter = Helper.UploadFilter(Helper.enUploadType.Files);

            if ((bool)dlg.ShowDialog())
            {
                Stream file = dlg.OpenFile();
                string filePath = dlg.SafeFileName;
               
                this.UploadFileC = Helper.UploadFile(Helper.enUploadType.Files, file, filePath);
                FileToImageIconConverter some = new FileToImageIconConverter(filePath);
                ImageSource imgSource = some.Icon;
                myFilesList.Add(new MyFiles { FileName = dlg.SafeFileName, FileIcon = imgSource });
            }
            else
            {
                MessageBox.Show("File not selected");
            }
        }
        private void UploadFileD_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;
            dlg.Filter = Helper.UploadFilter(Helper.enUploadType.Files);

            if ((bool)dlg.ShowDialog())
            {
                Stream file = dlg.OpenFile();
                string filename = dlg.SafeFileName;
                this.UploadFileD = Helper.UploadFile(Helper.enUploadType.Files, file, filename);
            }
            else
            {
                MessageBox.Show("File not selected");
            }
        }
        private Dokumen GetData()
        {
            Dokumen oData = new Dokumen();

            oData.NoReferensiDokumen = txtDocumentNo.Text;
            if (this.TypeDokumenSelected != null)
            {
                oData.IdTypeDokumen = this.TypeDokumenSelected.Id;
                oData.TypeDokumen = this.TypeDokumenSelected.Type;
            }
            if (!string.IsNullOrEmpty(dtTanggalDokumen.Text))
                oData.TanggalDokumen = DateTime.Parse(dtTanggalDokumen.Text);
            oData.KeteranganDokumen = txtDescription.Text;
            if (this.KontakSelected != null)
            {
                oData.IdKontak = this.KontakSelected.Id;
                oData.PelangganDokumen = this.KontakSelected.NamaA;
            }
            if (this.Selectdepartment != null)
            {
                oData.IdDepartmen = this.Selectdepartment.Id;
            }
            if (this.Selectproyek != null)
            {
                oData.IdProyek = this.Selectproyek.Id;
            }
            oData.UploadFile1 = this.UploadFileA;
            oData.UploadFile2 = this.UploadFileB;
            oData.UploadFile3 = this.UploadFileC;
            oData.UploadFile4 = this.UploadFileD;
            if (this.documentform.dokumenSelected != null)
                oData.Id = this.documentform.dokumenSelected.Id;

            return oData;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (cbDocumentTipe.Text == "" || txtDocumentNo.Text == "" || dtTanggalDokumen.Text == "" || cbNamakontak.Text == "" || cbdepartment.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            DokumenBLL DokumenBLL = new DokumenBLL();
            if (this.documentform.isEdit == false)
            {
                if (DokumenBLL.AddDokumen(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Document added successfully !");
                    this.documentform.LoadDokumen();
                }
                else
                {
                    MessageBox.Show("Document failed to add !");
                }
            }
            else
            {
                if (DokumenBLL.EditDokumen(this.GetData()) == true)
                {
                    this.ClearForm();
                    MessageBox.Show("Document changed successfully !");
                    this.documentform.LoadDokumen();
                }
                else
                {
                    MessageBox.Show("Document failed to change !");
                }
            }
            Documents dokumens = new Documents();
            Switcher.SwitchNewDocument(dokumens);
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Documents v = new Documents();
            Switcher.SwitchNewDocument(v);
        }

        ObservableCollection<MyFiles> myFilesList = new ObservableCollection<MyFiles>();
        #region MyFiles
        public class MyFiles
        {
            public string FileName { get; set; }
            public ImageSource FileIcon { get; set; }
        }
        #endregion

        #region FileToImageIconConverter
        public class FileToImageIconConverter
        {
            private string filePath;
            private System.Windows.Media.ImageSource icon;

            public string FilePath { get { return filePath; } }

            public System.Windows.Media.ImageSource Icon
            {
                get
                {
                    if (icon == null && System.IO.File.Exists(FilePath))
                    {
                        using (System.Drawing.Icon sysicon = System.Drawing.Icon.ExtractAssociatedIcon(FilePath))
                        {
                            icon = System.Windows.Interop.Imaging.CreateBitmapSourceFromHIcon(
                                      sysicon.Handle,
                                      System.Windows.Int32Rect.Empty,
                                      System.Windows.Media.Imaging.BitmapSizeOptions.FromEmptyOptions());
                        }
                    }

                    return icon;
                }
            }

            public FileToImageIconConverter(string filePath)
            {
                this.filePath = filePath;
            }
        }
        #endregion

        private void TxtDocumentNo_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtDocumentNo.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtDocumentNo.Text = "";
                    return;
                }

            }
        }

        private void TxtDescription_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
