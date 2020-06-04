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

namespace Reyuko.App.Views.DocumentType
{
    /// <summary>


    public partial class DocumentType : UserControl
    {
        public DocumentType()
        {
            InitializeComponent();
            this.Init();
        }

        private IEnumerable<TypeDokumen> typeDokumens { get; set; }
        private TypeDokumen typeDokumenSelected { get; set; }
        public bool isEdit = false;
        private int pageIndex = 1;
        private int pageSize = 10;

        private void Init()
        {
            this.ClearForm();
            this.LoadTypeDokumen();
        }

        private void ClearForm()
        {
            this.typeDokumenSelected = null;
        }

        public void LoadTypeDokumen()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.typeDokumens = uow.TypeDokumen.GetAll();
                DGDocumentType.ItemsSource = this.typeDokumens;
            }
        }


        private void NewDocumentType_Clicks(object sender, RoutedEventArgs e)
        {
            this.isEdit = false;
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is NewDocumentType)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                NewDocumentType period = new NewDocumentType(this);
                period.Show();
            }
        }

        private void EditDocumentType_Clicks(object sender, RoutedEventArgs e)
        {

        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (this.typeDokumenSelected == null)
            {
                MessageBox.Show("Document Type is not selected !");
            }
            else
            {
                TypeDokumenBLL TypeDokumenBLL = new TypeDokumenBLL();
                if (TypeDokumenBLL.RemoveTypeDokumen(this.typeDokumenSelected.Id) == true)
                {
                    MessageBox.Show("Document Type successfully deleted");
                    this.LoadTypeDokumen();
                    this.typeDokumenSelected = null;
                }
            }
        }

        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

