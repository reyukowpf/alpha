using Reyuko.BLL.Core;
using Reyuko.DAL.Domain;
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
    public partial class NewAccounLevel : Window
    {
        public NewAccounLevel(AccountData AccountDataForm)
        {
            InitializeComponent();
            this.AccountDataForm = AccountDataForm;
            this.Init();
        }

        public object UserControl { get; internal set; }
        private AccountData AccountDataForm { get; set; }


        private void Init()
        {
            this.ClearForm();
            this.LoadKlasifikasiAkun();
        }

        private void ClearForm()
        {
            lblAccountLevel.Text = "Account L1";
            txtAccountcode.Text = "";
            txtAccountName.Text = "";
        }

        private void LoadKlasifikasiAkun()
        {
            this.ClearForm();
            if (this.AccountDataForm != null && this.AccountDataForm.KlasifikasiAkunSelected != null)
            {
                if (this.AccountDataForm.isEdit == true)
                {
                    lblAccountLevel.Text = "Account L" + (this.AccountDataForm.KlasifikasiAkunSelected.AkunLevel.GetValueOrDefault(0)).ToString();
                    txtAccountcode.Text = this.AccountDataForm.KlasifikasiAkunSelected.Kode;
                    txtAccountName.Text = this.AccountDataForm.KlasifikasiAkunSelected.KategoriKA;
                }
                else
                {
                    lblAccountLevel.Text = "Account L" + (this.AccountDataForm.KlasifikasiAkunSelected.AkunLevel.GetValueOrDefault(0) + 1).ToString();
                    var child = this.AccountDataForm.KlasifikasiAkuns.Where(m => m.IdParentKategoriKA == this.AccountDataForm.KlasifikasiAkunSelected.Id).OrderByDescending(m => m.Kode).FirstOrDefault();
                    if (child == null)
                    {
                        txtAccountcode.Text = this.AccountDataForm.KlasifikasiAkunSelected.Kode + ".100";
                    }
                    else
                    {
                        var arKode = child.Kode.Split('.');
                        var lastKode = int.Parse(arKode[arKode.Length - 1]) + 100;
                        txtAccountcode.Text = this.AccountDataForm.KlasifikasiAkunSelected.Kode + "." + lastKode.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("The Account Has Not Been Selected \n");
            }
        }

        private KlasifikasiAkun GetData()
        {
            KlasifikasiAkun oData = new KlasifikasiAkun();
            oData.AkunLevel = this.AccountDataForm.KlasifikasiAkunSelected.AkunLevel + 1;
            oData.IdParentKategoriKA = this.AccountDataForm.KlasifikasiAkunSelected.Id;
            oData.Kode = txtAccountcode.Text;
            oData.KategoriKA = txtAccountName.Text;
            if (this.AccountDataForm.isEdit == true)
            {
                oData.IdParentKategoriKA = this.AccountDataForm.KlasifikasiAkunSelected.IdParentKategoriKA;
                oData.AkunLevel = this.AccountDataForm.KlasifikasiAkunSelected.AkunLevel;
                oData.Id = this.AccountDataForm.KlasifikasiAkunSelected.Id;
            }

            return oData;
        }

        private void savelevel_Click(object sender, RoutedEventArgs e)
        {
            string message = "";
            if (string.IsNullOrEmpty(txtAccountName.Text))
                message += "Account Name cannot be empty \n";
            if (string.IsNullOrEmpty(txtAccountcode.Text))
                message += "Account Code cannot be empty \n";
            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message);
                return;
            }

            KlasifikasiAkunBLL KlasifikasiAkunBLL = new KlasifikasiAkunBLL();
            if (this.AccountDataForm.isEdit == false)
            {
                if (KlasifikasiAkunBLL.AddKlasifikasiAkun(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Account successfully added !");
                    this.AccountDataForm.LoadKlasifikasiAkun();
                }
                else
                {
                    MessageBox.Show("Account failed to add !");
                }
            }
            else
            {
                if (KlasifikasiAkunBLL.EditKlasifikasiAkun(this.GetData()) == true)
                {
                    this.ClearForm();
                    MessageBox.Show("Account successfully changed !");
                    this.AccountDataForm.LoadKlasifikasiAkun();
                }
                else
                {
                    MessageBox.Show("Account failed to change !");
                }
            }
            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TxtAccountName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtAccountName.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Character");
                    txtAccountName.Text = "";
                    return;
                }

            }
        }

        private void TxtAccountcode_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
