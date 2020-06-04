using Reyuko.BLL.Core;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Reyuko.App.Views.SalaryPayment
{
    /// <summary>
   
    /// </summary>
    public partial class Employees : Window
    {
        public Employees(NewSalaryPayment newSalary)
        {
            InitializeComponent();
            this.newSalary = newSalary;
            this.Init();
        }
        public IEnumerable<Kontak> kontaks { get; set; }
        public Kontak kontakSelected;
        private void ClearForm()
        {
           
            // txtother.Text = "0";
            // txtother.Text = "0";
        }

        private void Init()
        {
            this.ClearForm();
            this.LoadEmployee();
            this.LoadKlasifikasiAkun();
        }
        public NewSalaryPayment newSalary;
        private void LoadKlasifikasiAkun()
        {
            this.ClearForm();
            if (this.newSalary != null && this.newSalary.orderPembayaranGajiSelected != null)
            {
                    var child = this.newSalary.orderPembayaranGajis.Where(m => m.Id == this.newSalary.orderPembayaranGajiSelected.Id).OrderByDescending(m => m.NoPembayaranGaji).FirstOrDefault();
                    if (child == null)
                    {
                        txtnosalary.Text = this.newSalary.orderPembayaranGajiSelected.NoPembayaranGaji + ".100";
                    }
                   
                }
           
        }
        private void LoadEmployee()
        {
             using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
             {
                    this.kontaks = uow.Kontak.GetAll().Where(m => m.TypeKontak.ToLower() == "employee");
                    sremployee.ItemsSource = this.kontaks;
             }
        }
        private void employee_selectedchange(object sender, SelectionChangedEventArgs e)
        {
            this.kontakSelected = null;
            if (sremployee.SelectedItem != null)
            {
                this.kontakSelected = (Kontak)sremployee.SelectedItem;
                txtemail.Text = this.kontakSelected.EmailA;
                txthp.Text = this.kontakSelected.NoHPA;
                txtsalary.Text = this.kontakSelected.GajiPokok.ToString();
                txttunjangan.Text = this.kontakSelected.Tunjangan.ToString();
                txtovertimehour.Text = this.kontakSelected.OvertimeHour.ToString();
            }
        }
        public OrderPembayaranGaji GetData()
        {
            OrderPembayaranGaji oData = new OrderPembayaranGaji();
            oData.NoPembayaranGaji = txtnosalary.Text;
            if (this.kontakSelected != null)
            {
                oData.IdKontak = this.kontakSelected.Id;
                oData.NamaEmployee = this.kontakSelected.NamaA;
                oData.IdGroup = this.kontakSelected.IdGolongan;
                oData.BankData = this.kontakSelected.NamaBankA;
            }
            oData.Tunjangan = double.Parse(txttunjangan.Text);
            oData.Overtime = double.Parse(txtovertime.Text);
            oData.OvertimeHour = double.Parse(txtovertimehour.Text);
            oData.Lainlain = txtother.Text;
            oData.TotalOvertime = double.Parse(txttotalovertime.Text);
            oData.Keterangan = txtnote.Text;
            oData.GajiPokok = double.Parse(txtsalary.Text);
            oData.Total = double.Parse(txttotal.Text);
            oData.KreditAkunPembGaji = double.Parse(txttotal.Text);
            oData.DebitAkunBiayaGaji = double.Parse(txttotal.Text);
            oData.CheckboxAktif = true;
            return oData;
        }
        public void Addorderpembayaran_Clicks(object sender, RoutedEventArgs e)
        {
            PembayaranGajiBLL bayarBLL = new PembayaranGajiBLL();
                if (bayarBLL.AddOrderPembayaranGaji(this.GetData()) > 0)
                {
                    this.ClearForm();
                    MessageBox.Show("Add Order Salary Payment successfully added !");
                    this.newSalary.LoadOrderPembayaranGaji();
                }
                else
                {
                    MessageBox.Show("Add Order Salary Payment failed to add !");
                }
            this.Close();
        }

        private void Cancel_Clicks(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtovertime_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtovertime.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtovertime.Text = "";
                    return;
                }
            }
            txttotalovertime.Text = (float.Parse(txtovertimehour.Text) * float.Parse(txtovertime.Text)).ToString();
            txttotal.Text = (float.Parse(txtsalary.Text) + float.Parse(txttunjangan.Text) + float.Parse(txttotalovertime.Text)).ToString();
        }
        private void load(object sender, EventArgs e)
        {
        }
       
        private void Txtother_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = txtother.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Must Have Numeric");
                    txtother.Text = "";
                    return;
                }
            }
            txttotal.Text = (float.Parse(txtother.Text) + float.Parse(txtsalary.Text) + float.Parse(txttunjangan.Text) + float.Parse(txttotalovertime.Text)).ToString();
        }
    }
}
