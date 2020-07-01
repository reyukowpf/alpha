using Microsoft.Win32;
using Reyuko.BLL.Core;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Reyuko.App.Views.Note
{
    /// <summary>
    
    /// </summary>
    public partial class NewInternalNote : UserControl
    {
        public NewInternalNote(InternalNotes internalnoteform)
        {
            InitializeComponent();
            this.internalnoteform = internalnoteform;
            Switcher.pageSwitcherNotes = this;
            this.Init();
        }

        public InternalNotes internalnoteform;
        public IEnumerable<Kontak> kontaks { get; set; }
        public IEnumerable<DataDepartemen> dataDepartemens { get; set; }
        public DataDepartemen Selectdepartment { get; set; }
        public  IEnumerable<DataProyek> dataProyeks { get; set; }
        public DataProyek Selectproyek { get; set; }
        public Kontak Selectkontak { get; set; }
        public IEnumerable<NoteType> noteTypes { get; set; }
        public NoteType selecttype { get; set; }
   
        private void Init()
        {
            this.ClearForm();
            this.LoadKontak();
            this.LoadTipeNote();
        }

        public void LoadKontak()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kontaks = uow.Kontak.GetAll();
                srkontak.ItemsSource = this.kontaks;
            }
        }

        public void LoadDepartmen()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dataDepartemens = uow.DataDepartemen.GetAll();
                cbdepartment.ItemsSource = this.dataDepartemens;
                cbdepartment.SelectedValuePath = "KodeDepartemen";
                cbdepartment.DisplayMemberPath = "NamaDepartemen";
            }
        }

        public void LoadProyek()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dataProyeks = uow.DataProyek.GetAll();
                cbdepartment.ItemsSource = this.dataProyeks;
                cbdepartment.SelectedValuePath = "NomorProyek";
                cbdepartment.DisplayMemberPath = "NamamProyek";
            }
        }

        public void LoadTipeNote()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.noteTypes = uow.NoteType.GetAll();
                cbNoteType.ItemsSource = this.noteTypes;
                cbNoteType.SelectedValuePath = "Id";
                cbNoteType.DisplayMemberPath = "Type";
            }
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        private void ClearForm()
        {
            this.srkontak.Text = "";
            this.cbNoteType.Text = "";
        }
        private string choosenFileName;
        private string file { get; set; }
        private void Savenote_Click(object sender, RoutedEventArgs e)
        {
            if (cbNoteType.Text == "" || dtNotedate.Text == "" || cbdepartment.Text == "" || txtNoteTitle.Text == "" || dtReminder.Text == "")
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            //display the dialog the first time the Save button is clicked only:
            if (string.IsNullOrEmpty(choosenFileName))
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "RichText Files (*.rtf)|*.rtf|All Files (*.*)|*.*";
                if (saveFile.ShowDialog() != true)
                    return;
                choosenFileName = saveFile.FileName;
            }

            // Create a TextRange around the entire document.
            TextRange documentTextRange = new TextRange(
                _rtb.Document.ContentStart, _rtb.Document.ContentEnd);

            // If this file exists, it's overwritten.
            using (FileStream fs = File.Create(choosenFileName))
            {
                if (System.IO.Path.GetExtension(choosenFileName).ToLower() == ".rtf")
                {
                    documentTextRange.Save(fs, DataFormats.Rtf);
                }
                else
                {
                    documentTextRange.Save(fs, DataFormats.Xaml);
                }
                this.file = choosenFileName;
            }
            InternalNoteBLL InternalNoteBLL = new InternalNoteBLL();
            if (this.internalnoteform.isEdit == false)
            {
                if (InternalNoteBLL.AddInternalNote(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Internal Note added successfully !");
                    this.internalnoteform.LoadInternalnote();
                }
                else
                {
                    MessageBox.Show("Internal Note failed to add !");
                }
            }
            else
            {
                if (InternalNoteBLL.EditInternalNote(this.GetData()) == true)
                {
                    this.ClearForm();
                    MessageBox.Show("Internal Note successfully changed !");
                    this.internalnoteform.LoadInternalnote();
                }
                else
                {
                    MessageBox.Show("Internal Note failed to change !");
                }
            }

        }


        private InternalNote GetData()
        {
            InternalNote oData = new InternalNote();

            if (this.Selectkontak != null)
            {
                oData.IdKontak = this.Selectkontak.Id;
                oData.NamaKontak = this.Selectkontak.NamaA;
            }
            if (this.selecttype != null)
            {
                oData.IdNoteType = this.selecttype.Id;
                oData.NoteType = this.selecttype.Type;
            }
            if (this.Selectdepartment != null)
            {
                oData.IdDepartemen = this.Selectdepartment.Id;
            }
            else if (this.Selectproyek !=null)
            {
                oData.IdProyek = this.Selectproyek.Id;
            }
            if (this.internalnoteform.internalnoteSelected != null)
                oData.Id = this.internalnoteform.internalnoteSelected.Id;

            return oData;
        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is Print.Print)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                Print.Print print = new Print.Print();
                print.Show();
            }
        }

        private void cb_selection_change(object sender, SelectionChangedEventArgs e)
        {
            this.Selectkontak = null;
            if (srkontak.SelectedItem != null)
            {
                this.Selectkontak = (Kontak)srkontak.SelectedItem;
            }
        }

        private void note_selectionchange(object sender, SelectionChangedEventArgs e)
        {
            this.selecttype = null;
            if (cbNoteType.SelectedItem != null)
            {
                this.selecttype = (NoteType)cbNoteType.SelectedItem;
            }
        }

        private void department_selectionchange(object sender, SelectionChangedEventArgs e)
        {
            if (cbdepartment.SelectedItem.ToString() == "dataDepartemens")
            {
                Selectdepartment = (DataDepartemen)cbdepartment.SelectedItem;
            }
            else if(cbdepartment.SelectedItem != null)
            {
                Selectproyek = (DataProyek)cbdepartment.SelectedItem;
            }
        }

        

        private void NoDokumen_Click(object sender, RoutedEventArgs e)
        {
            DocumentNo v = new DocumentNo();
            v.Show();
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            InternalNotes v = new InternalNotes();
            Switcher.Switchnotes(v);
        }
        
        public void Departmen_Checked(object sender, EventArgs e)
        {
           this.Project.IsChecked = false;
            {
                this.LoadDepartmen();
            }
        
        }

        public void Proyek_Checked(object sender, EventArgs e)
        {
            this.Departmen1.IsChecked = false;
            {
                this.LoadProyek();
            }

        }
    }
}
             
    

