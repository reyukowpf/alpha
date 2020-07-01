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

namespace Reyuko.App.Views.AccountData
{
    /// <summary>
    /// </summary>
    public partial class DeleteAccounLevel : Window
    {
        public DeleteAccounLevel(AccountData AccountDataForm)
        {
            InitializeComponent();
            this.AccountDataForm = AccountDataForm;
            this.Init();
        }

        public object UserControl { get; internal set; }
        private AccountData AccountDataForm { get; set; }
        private KlasifikasiAkun KlasifikasiAkunSelected { get; set; }

        private void Init()
        {
            this.ClearForm();
            this.LoadComboKlasifikasiAKun();
            this.LoadKlasifikasiAkun();
        }

        private void ClearForm()
        {
            lblAccountLevel.Text = "Account L1";
            txtAccountcode.Text = "";
            cbAccountData.ItemsSource = null;
        }

        private void LoadComboKlasifikasiAKun()
        {
            cbAccountData.ItemsSource = this.AccountDataForm.KlasifikasiAkuns;
            cbAccountData.DisplayMemberPath = "Kode";
            cbAccountData.SelectedValuePath = "Id";
        }

        private void LoadKlasifikasiAkun()
        {
            if (this.AccountDataForm != null && this.AccountDataForm.KlasifikasiAkunSelected != null)
            {
                lblAccountLevel.Text = "Account L" + (this.AccountDataForm.KlasifikasiAkunSelected.AkunLevel.GetValueOrDefault(0)).ToString();
                txtAccountcode.Text = this.AccountDataForm.KlasifikasiAkunSelected.Kode;
            }
            else
            {
                MessageBox.Show("The Account Has Not Been Selected \n");
            }

        }

        private void savelevel_Click(object sender, RoutedEventArgs e)
        {
            string message = "";
            if (this.AccountDataForm == null)
                message += "The Account Has Not Been Selected \n";
            if (this.KlasifikasiAkunSelected == null)
                message += "A Replacement Account Has Not Been Selected \n";
            //var childs = this.AccountDataForm.KlasifikasiAkuns.Where(m => m.IdParentKategoriKA == this.AccountDataForm.KlasifikasiAkunSelected.Id);
            //if (childs != null && childs.Count() > 0)
            //    message += "Akun ini masih memliki child \n";
            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message);
                return;
            }

            KlasifikasiAkunBLL KlasifikasiAkunBLL = new KlasifikasiAkunBLL();
            if (KlasifikasiAkunBLL.RemoveKlasifikasiAkun(this.AccountDataForm.KlasifikasiAkunSelected.Id, this.KlasifikasiAkunSelected.Id) == true)
            {
                this.ClearForm();
                MessageBox.Show("Account was Successfully Deleted !");
                this.AccountDataForm.LoadKlasifikasiAkun();
            }
            else
            {
                MessageBox.Show("Account Failed to Delete !");
            }


        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CbAccountData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.KlasifikasiAkunSelected = null;
            if (cbAccountData.SelectedItem != null)
            {
                this.KlasifikasiAkunSelected = (KlasifikasiAkun)cbAccountData.SelectedItem;
            }
        }

       
        private void TxtAccountcode_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
