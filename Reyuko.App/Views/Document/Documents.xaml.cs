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
using Path = System.IO.Path;


namespace Reyuko.App.Views.Document
{
    /// <summary>

    /// </summary>
    public partial class Documents : UserControl
    {
        public Documents()
        {
            InitializeComponent();
            Switcher.pageSwitchDocuments = this;
            this.Init();
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }


        public IEnumerable<TypeDokumen> TypeDokumens { get; set; }
        public TypeDokumen TypeDokumenSelected { get; set; }
        public Dokumen dokumenSelected { get; set; }
        public Dokumen dokument { get; set; }
        public DataDepartemen dataDepartemenSelected;
        public DataProyek dataProyekSelected;
        public IEnumerable<Dokumen> dokumens { get; set; }
        public bool isEdit;

        private int pageSize = 10;
        private int pageIndex = 1;

        private void Init()
        {
            this.LoadTypeDocument();
            this.LoadDokumen();
            this.LoadSearchNoDokument();
        }

        private void LoadSearchNoDokument()
        {

        }

        public void LoadTypeDocument()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.TypeDokumens = uow.TypeDokumen.GetAll();
                CbTipeDokumen.ItemsSource = this.TypeDokumens;
                CbTipeDokumen.SelectedValuePath = "Id";
                CbTipeDokumen.DisplayMemberPath = "Type";
            }
        }

        public void LoadDokumen()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.dokumens = uow.Dokumen.GetAll();
                LstDokumen.ItemsSource = this.dokumens;
            }
        }

        private void LIDokumen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LstDokumen.SelectedItem != null)
            {
                this.dokumenSelected = (Dokumen)LstDokumen.SelectedItem;
                if (this.dokumenSelected != null)
                {
                    using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
                    {
                        this.dokument = uow.Dokumen.Get(this.dokumenSelected.Id);
                        txtDocumentNo.Text = this.dokument.NoReferensiDokumen;
                        txtDocumentType.Text = this.dokument.TypeDokumen;
                        if (this.dokumenSelected.TanggalDokumen != null)
                            txtDate.Text = this.dokumenSelected.TanggalDokumen.GetValueOrDefault().ToShortDateString();
                  
                        txtContactName.Text = this.dokument.PelangganDokumen;
                        txtDescription.Text = this.dokument.KeteranganDokumen;
                        txtuploadfileA.Text = Path.GetFileName(this.dokument.UploadFile1);
                        txtuploadfileB.Text = Path.GetFileName(this.dokument.UploadFile2);
                        txtuploadfileC.Text = Path.GetFileName(this.dokument.UploadFile3);
                        txtuploadfileD.Text = Path.GetFileName(this.dokument.UploadFile4);
                    }
                }
            }
        }

        private void NewDocument_Click(object sender, RoutedEventArgs e)
        {
            this.isEdit = false;
            NewDocument newDocument = new NewDocument(this);
            Switcher.SwitchDocuments(newDocument);
        }

        private void EditDocument_Click(object sender, RoutedEventArgs e)
        {
            this.isEdit = true;
            NewDocument newDocument = new NewDocument(this);
            Switcher.SwitchDocuments(newDocument);
        }

        private void RefreshDocument_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}



