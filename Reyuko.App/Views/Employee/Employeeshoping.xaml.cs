﻿using Reyuko.BLL.Core;
using Reyuko.DAL.Domain;
using Reyuko.DAL;
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
using Microsoft.Win32;
using System.IO;
using Path = System.IO.Path;
using Reyuko.Utils.Common;
using System.Text.RegularExpressions;

namespace Reyuko.App.Views.Employee
{
    /// <summary>

    /// </summary>
    public partial class Employeeshoping : Window
    {
        public Employeeshoping(PurchaseDocument.NewShopingchart EmployeeForm)
        {
            InitializeComponent();
            this.EmployeeForm = EmployeeForm;
            this.Init();
        }

      
        public object UserControl { get; internal set; }
        private PurchaseDocument.NewShopingchart EmployeeForm;
        private TypeKontak TypeKontak { get; set; }
        private IEnumerable<KlasifikasiKontak> KlasifikasiKontaks { get; set; }
        private KlasifikasiKontak KlasifikasiKontakSelected { get; set; }
        
        private void Init()
        {
            this.ClearForm();
            this.LoadTypeKontak();
            this.LoadComboKasifikasiKontak();
        }

        private void ClearForm()
        {
            this.KlasifikasiKontakSelected = null;
           
            cbClasification.SelectedIndex = -1;
            txtEmployeeID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
        }


        private void LoadTypeKontak()
        {
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.TypeKontak = uow.TypeKontak.SingleOrDefault(m => m.Type.ToLower() == "employee");
            }
        }
        private void LoadComboKasifikasiKontak()
        {
            cbClasification.SelectedIndex = -1;
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.KlasifikasiKontaks = uow.KlasifikasiKontak.GetAll();
                cbClasification.ItemsSource = this.KlasifikasiKontaks;
                cbClasification.DisplayMemberPath = "NamaKlasifikasiKontak";
                cbClasification.SelectedValuePath = "Id";
            }
        }

        private Kontak GetData()
        {
            string message = "";
            if (this.KlasifikasiKontakSelected == null)
                message += "Klasifikasi kontak belum dipilih\n";
            if (string.IsNullOrEmpty(txtEmployeeID.Text))
                message += "Employee Id belum diisi\n";
            if (string.IsNullOrEmpty(txtName.Text))
                message += "Nama Employee belum diisi\n";

            Kontak oData = new Kontak();
            oData.IdTypeKontak = this.TypeKontak.Id;
            oData.TypeKontak = this.TypeKontak.Type;
            if (this.KlasifikasiKontakSelected != null)
            {
                oData.IdKlasifikasiKontak = this.KlasifikasiKontakSelected.Id;
                oData.KlasifikasiKontak = this.KlasifikasiKontakSelected.NamaKlasifikasiKontak;
            }
            oData.KontakID = txtEmployeeID.Text;
            oData.NamaA = txtName.Text;
            oData.NoHPA = txtPhone.Text;
            oData.EmailA = txtEmail.Text;
            oData.IdUserId = null;
            oData.RealTimeRecording = DateTime.Now;

            return oData;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (cbClasification.Text == "" || txtEmployeeID.Text == "" || txtName.Text == "" || txtPhone.Text == "" || txtEmail.Text == "" )
            {
                MessageBox.Show("please fill in the blank fields", ("Form Validation"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            KontakBLL KontakBLL = new KontakBLL();
                if (KontakBLL.AddKontak(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Employee successfully added !");
                    this.EmployeeForm.LoadEmployee();
                }
                else
                {
                    MessageBox.Show("Employee failed to add !");
                }
            this.Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
         }

        private void CbClasification_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.KlasifikasiKontakSelected = null;
            if (cbClasification.SelectedItem != null)
            {
                this.KlasifikasiKontakSelected = (KlasifikasiKontak)cbClasification.SelectedItem;
   
            }
        }


        private void TxtPhone_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtPhone.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must be Numeric");
                    txtPhone.Text = "";
                    return;
                }

            }
        }

        
        private void TxtEmail_OnLostFocus(object sender, RoutedEventArgs e)
        {
            // Baca inputan email menggunakan Lost Focus
            if (txtEmail.Text.Length == 0)
            {
                InfoMail.Content = "Empty";
            }
            else if (!Regex.IsMatch(txtEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                InfoMail.Content = "Invalid";
                txtEmail.Select(0, txtEmail.Text.Length);
            }

            else
            {
                InfoMail.Content = "OK";
            }
        }

            }
}
