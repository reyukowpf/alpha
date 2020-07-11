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

namespace Reyuko.App.Views.Note
{
    /// <summary>
    
    /// </summary>
    public partial class InternalNotes : UserControl
    {
        public InternalNotes()
        {
            InitializeComponent();
            Switcher.pageSwitcherNote = this;
            this.Init();
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        public IEnumerable<DataDepartemen> dataDepartemens { get; set; }
        public IEnumerable<DataProyek> dataProyeks { get; set; }
        public IEnumerable<Kontak> kontaks { get; set; }
        public IEnumerable<InternalNote> internalNotes { get; set; }
        public InternalNote internalnoteSelected { get; set; }
        public IEnumerable<NoteType> TipeNotes { get; set; }
        public NoteType TypeNoteSelected { get; set; }
        public bool isEdit = false;
        private void Init()
        {
            this.LoadTypeNote();
            this.LoadInternalnote();
            this.LoadUser();
        }

        public void LoadUser()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.kontaks = uow.Kontak.GetAll().Where(m => m.TypeKontak.ToLower() == "employee");
                sruser.ItemsSource = this.kontaks;
            }
        }

        public void LoadInternalnote()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.internalNotes = uow.InternalNote.GetAll();
                DGInternalNote.ItemsSource = this.internalNotes;
                srkontak.ItemsSource = this.internalNotes;
            }
        }

        public void LoadDepartmen()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dataDepartemens = uow.DataDepartemen.GetAll();
                cbDeprtament.ItemsSource = this.dataDepartemens;
                cbDeprtament.SelectedValuePath = "KodeDepartemen";
                cbDeprtament.DisplayMemberPath = "NamaDepartemen";
            }
        }

        public void LoadProyek()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dataProyeks = uow.DataProyek.GetAll();
                cbDeprtament.ItemsSource = this.dataProyeks;
                cbDeprtament.SelectedValuePath = "NomorProyek";
                cbDeprtament.DisplayMemberPath = "NamamProyek";
            }
        }
        public void LoadTypeNote()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.TipeNotes = uow.NoteType.GetAll();
                cbNoteType.ItemsSource = this.TipeNotes;
                cbNoteType.SelectedValuePath = "Id";
                cbNoteType.DisplayMemberPath = "Type";
            }
        }

        public void Newinternalnote_Click(object sender, RoutedEventArgs e)
        {
            //NewInternalNote v = new NewInternalNote(this);
            //Switcher.Switchnote(v);



        }

        private void Detail_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

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
             
    

