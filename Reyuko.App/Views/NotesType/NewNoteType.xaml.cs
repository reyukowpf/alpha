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

namespace Reyuko.App.Views.NotesType
{
    /// <summary>
    
    /// </summary>
    public partial class NewNoteType : UserControl
    {
        public NewNoteType(NotesType Typenoteform)
        {
            InitializeComponent();
            this.Typenoteform = Typenoteform;
            Switcher.pageSwitchweNotetypes = this;
            this.Init();
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        private NotesType Typenoteform;
        private string file { get; set; }
        private void Init()
        {
            this.ClearForm();
            if (this.Typenoteform.isEdit == true)
                this.LoadTipenote();
        }
        private void ClearForm()
        {
            txtDescription.Text = "";
            string ritc = new TextRange(_rtb.Document.ContentStart, _rtb.Document.ContentEnd).Text;
       //     Note.PreviewTextInput = null;
            
            txtNoteType.Text = "";
        }

        private void LoadTipenote()
        {
            if (this.Typenoteform != null && this.Typenoteform.NoteTypeSelected != null)
            {
                txtNoteType.Text = this.Typenoteform.NoteTypeSelected.Type;
                
                txtDescription.Text = this.Typenoteform.NoteTypeSelected.Keterangan;
             //   note.Text = this.Typenoteform.NoteTypeSelected.Template;
            }
        }

        private NoteType GetData()
        {
            NoteType oData = new NoteType();

            oData.Type = txtNoteType.Text;
            oData.Keterangan = txtDescription.Text;
            oData.Template = this.file;
            if (this.Typenoteform.NoteTypeSelected != null)
                oData.Id = this.Typenoteform.NoteTypeSelected.Id;

            return oData;
        }
        private string choosenFileName;
        private void Savenotetipe_Click(object sender, RoutedEventArgs e)
        {
            if (txtNoteType.Text == "" || txtDescription.Text == "" )
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
                Note.Document.ContentStart, Note.Document.ContentEnd);

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

            NoteTypeBLL NoteTypeBLL = new NoteTypeBLL();
            if (this.Typenoteform.isEdit == false)
            {
                if (NoteTypeBLL.AddNoteType(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Note Type successfully added !");
                    this.Typenoteform.LoadNoteType();
                }
                else
                {
                    MessageBox.Show("Note Type failed to add !");
                }
            }
            else
            {
                if (NoteTypeBLL.EditNoteType(this.GetData()) == true)
                {
                    this.ClearForm();
                    MessageBox.Show("Document changed successfully !");
                    this.Typenoteform.LoadNoteType();
                }
                else
                {
                    MessageBox.Show("Document failed to change !");
                }
            }
            NotesType v = new NotesType();
            Switcher.Switchnotetypes(v);
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            NotesType v = new NotesType();
            Switcher.Switchnotetypes(v);
        }

        private void TxtNoteType_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtNoteType.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtNoteType.Text = "";
                    return;
                }

            }
        }

        private void TxtDescription_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
             
    

