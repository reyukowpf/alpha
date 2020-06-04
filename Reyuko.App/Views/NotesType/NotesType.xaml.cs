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

namespace Reyuko.App.Views.NotesType
{
    /// <summary>


    public partial class NotesType : UserControl
    {
        public NotesType()
        {
            InitializeComponent();
            Switcher.pageSwitcherNotetype = this;
            this.Init();
        }
        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
        private IEnumerable<NoteType> NoteTypes { get; set; }
        public NoteType NoteTypeSelected { get; set; }
        private int pageIndex = 1;
        private int pageSize = 10;
        public bool isEdit { get; internal set; }

        private void Init()
        {
            this.ClearForm();
            this.LoadNoteType();
        }

        private void ClearForm()
        {
            this.NoteTypeSelected = null;
        }

        public void LoadNoteType()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.NoteTypes = uow.NoteType.GetPaged(this.pageIndex, this.pageSize);
                DGNotesType.ItemsSource = this.NoteTypes;
            }
        }

        private void DGNoteType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.NoteTypeSelected = null;
            if (DGNotesType.SelectedItem != null)
            {
                this.NoteTypeSelected = (NoteType)DGNotesType.SelectedItem;
            }
        }

        private void NewNotesType_Clicks(object sender, RoutedEventArgs e)
        {
            this.isEdit = false;
            NewNoteType v = new NewNoteType(this);
            Switcher.Switchnotetype(v);
        }

        private void EditNotesType_Clicks(object sender, RoutedEventArgs e)
        {
            this.isEdit = true;
            NewNoteType newNoteType = new NewNoteType(this);
            Switcher.Switchnotetype(newNoteType);
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }
    } 
    }

