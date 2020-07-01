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

namespace Reyuko.App.Views.AccountingPeriod
{
    /// <summary>
    /// Interaction logic for Currency.xaml
    /// </summary>
    public partial class AccountingPeriod : UserControl
    {
        public AccountingPeriod()
        {
            InitializeComponent();
            this.Init();
        }
        private IEnumerable<PeriodeAkuntansi> periodeAkuntansis { get; set; }
        public PeriodeAkuntansi periodeAkuntansiSelected { get; set; }
        public bool isEdit = false;
        private int pageIndex = 1;
        private int pageSize = 10;

        private void Init()
        {
            this.ClearForm();
            this.LoadPeriodeAkuntansi();
        }

        private void ClearForm()
        {
            this.periodeAkuntansis = new List<PeriodeAkuntansi>();
            DGAccountPeriod.ItemsSource = this.periodeAkuntansis;
        }

        public void LoadPeriodeAkuntansi()
        {
            this.periodeAkuntansis = new List<PeriodeAkuntansi>();
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.periodeAkuntansis = uow.PeriodeAkuntansi.GetAll();
                DGAccountPeriod.ItemsSource = this.periodeAkuntansis;
            }
        }


        private void NewAccountingPeriod_Clicks(object sender, RoutedEventArgs e)
        {
            this.isEdit = false;
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is NewPeriod)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                NewPeriod period = new NewPeriod(this);
                period.Show();
            }
        }

        private void EditAccountingPeriod_Clicks(object sender, RoutedEventArgs e)
        {
            this.isEdit = true;
            bool isWindowOpen = false;

            foreach (Window w in Application.Current.Windows)
            {
                if (w is NewPeriod)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                NewPeriod period = new NewPeriod(this);
                period.Show();
            }
        }

        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DGAccountPeriod_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.periodeAkuntansiSelected = null;
            this.isEdit = false;
            if (DGAccountPeriod.SelectedItem != null)
            {
                this.periodeAkuntansiSelected = (PeriodeAkuntansi)DGAccountPeriod.SelectedItem;
                this.isEdit = true;
            }
        }
    }
}
