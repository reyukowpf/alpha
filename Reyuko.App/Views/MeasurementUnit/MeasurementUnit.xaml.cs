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

namespace Reyuko.App.Views.MeasurementUnit
{
    /// <summary>


    public partial class MeasurementUnit : UserControl
    {
        public MeasurementUnit()
        {
            InitializeComponent();
            this.Init();
        }
        
        public bool isEdit = false;
        private int pageIndex = 1;
        private int pageSize = 10;
        private IEnumerable<SatuanDasar> SatuanDasarChilds { get; set; }
        public IEnumerable<SatuanDasar> SatuanDasars { get; set; }
        public SatuanDasar SatuanDasarSelected { get; set; }

        private void Init()
        {
            this.ClearForm();
            this.LoadSatuanDasar();
        }

        private void ClearForm()
        {
            this.SatuanDasarSelected = null;
        }

        public void LoadSatuanDasar()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.SatuanDasars = uow.SatuanDasar.GetAll();
                DGMeasurementUnit.ItemsSource = this.SatuanDasars;                
            }
        }

        private void BtnNewMeasurementUnit_Clicks(object sender, RoutedEventArgs e)
        {
            this.isEdit = false;
            {
                bool isWindowOpen = false;

                foreach (Window w in Application.Current.Windows)
                {
                    if (w is NewMeasurementUnit)
                    {
                        isWindowOpen = true;
                        w.Activate();
                    }
                }

                if (!isWindowOpen)
                {
                    NewMeasurementUnit newMeasurement = new NewMeasurementUnit(this);
                    newMeasurement.Show();
                }


            }
        }

        private void BtnEditMeasurementUnit_Clicks(object sender, RoutedEventArgs e)
        {
            this.isEdit = true;
            NewMeasurementUnit v = new NewMeasurementUnit(this);
            v.Show();
        }

        private void DGMeasurementUnit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.SatuanDasarSelected = null;
            if (DGMeasurementUnit.SelectedItem != null)
            {
                this.SatuanDasarSelected = (SatuanDasar)DGMeasurementUnit.SelectedItem;
            }
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (this.SatuanDasarSelected == null)
            {
                MessageBox.Show("Measurement Unit not selected !");
            }
            else
            {
                SatuanDasarBLL SatuanDasarBLL = new SatuanDasarBLL();
                if (SatuanDasarBLL.RemoveSatuanDasar(this.SatuanDasarSelected.Id) == true)
                {
                    MessageBox.Show("Measurement Unit successfully deleted");
                    this.LoadSatuanDasar();
                    this.SatuanDasarSelected = null;
                }
            }
        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

