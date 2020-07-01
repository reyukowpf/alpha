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


    public partial class AccountData : UserControl
    {
        public AccountData()
        {
            InitializeComponent();
            Switcher.pageSwitcheraccountdata = this;
            this.Init();
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        public IEnumerable<KlasifikasiAkun> KlasifikasiAkuns { get; set; }
        public KlasifikasiAkun KlasifikasiAkunSelected { get; set; }
        public bool isEdit = false;
        private int pageIndex = 1;
        private int pageSize = 10;

        private void Init()
        {
            this.ClearForm();
            this.LoadKlasifikasiAkun();
        }

        private void ClearForm()
        {
            tvAccountData.ItemsSource = null;
            liAccountChild.ItemsSource = null;

            lblAccountLevel.Content = "";
            lblAccountCode.Content = "";
            this.HideLv4();

            tvAccountData.Items.Clear();
        }

        private void HideLv4()
        {
            lblAccountName.Content = "";
            lblDepartment.Content = "";
            lblCurrency.Content = "";
            lblAccountType.Content = "";
            lblStatus.Content = "";
        }

        public void LoadKlasifikasiAkun()
        {
            tvAccountData.Items.Clear();
            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                this.KlasifikasiAkuns = uow.KlasifikasiAkun.GetAll();
                var roots = this.KlasifikasiAkuns.Where(m => m.IdParentKategoriKA.GetValueOrDefault(0) == 0);
                if (roots != null)
                {
                    foreach (var root in roots)
                    {
                        TreeViewItem node = new TreeViewItem() { Header = root.KategoriKA, TabIndex = root.Id };
                        this.AddChild(node, root.Id);
                        tvAccountData.Items.Add(node);
                    }
                }
            }
        }

        private TreeViewItem AddChild(TreeViewItem node, int parentId)
        {
            var items = this.KlasifikasiAkuns.Where(m => m.IdParentKategoriKA == parentId);
            if (items != null)
            {
                foreach (var item in items)
                {
                    TreeViewItem leaf = new TreeViewItem() { Header = item.KategoriKA, TabIndex = item.Id };
                    this.AddChild(leaf, item.Id);
                    node.Items.Add(leaf);
                }
            }

            return node;
        }

        private void LoadKlasifikasiAkunDetail()
        {
            lblAccountLevel.Content = "Level 1";
            lblAccountCode.Content = "";
            liAccountChild.ItemsSource = null;

            if (this.KlasifikasiAkunSelected != null)
            {
                lblAccountLevel.Content = "Level " + this.KlasifikasiAkunSelected.AkunLevel.ToString();
                if (this.KlasifikasiAkunSelected.AkunLevel != 4)
                {
                    lblAccountCode.Content = this.KlasifikasiAkunSelected.Kode + " - " + this.KlasifikasiAkunSelected.KategoriKA;
                    var childs = this.KlasifikasiAkuns.Where(m => m.IdParentKategoriKA == this.KlasifikasiAkunSelected.Id);
                    liAccountChild.ItemsSource = childs;
                    liAccountChild.DisplayMemberPath = "KategoriKA";
                    liAccountChild.SelectedValuePath = "Id";
                }
                else
                {
                    using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
                    {
                        var RekeningPerkiraan = uow.RekeningPerkiraan.SingleOrDefault(m => m.IdKlasifikasiRekeningPerkiraan == this.KlasifikasiAkunSelected.Id);
                        if (RekeningPerkiraan != null)
                        {
                            lblAccountCode.Content = "Account Code \t: " + RekeningPerkiraan.KodeRekening;
                            lblAccountName.Content = "Account Name \t: " + RekeningPerkiraan.NamaRekeningPerkiraan;
                            lblDepartment.Content = "Department \t: " + RekeningPerkiraan.NamaDepartemen;
                            lblCurrency.Content = "Currency \t: " + RekeningPerkiraan.MataUang;
                            lblAccountType.Content = "Account Type \t: ";
                            if (RekeningPerkiraan.RadioButtonStandarKasBankDebtLoan.ToString() == "2")
                                lblAccountType.Content = "Account Type \t: Kas / Bank";
                            else if (RekeningPerkiraan.RadioButtonStandarKasBankDebtLoan.ToString() == "3")
                                lblAccountType.Content = "Account Type \t: Debt / Loan";
                            else
                                lblAccountType.Content = "Account Type \t: Standard";
                            lblStatus.Content = "Status \t: Active";
                            if (RekeningPerkiraan.CheckboxTidakAktif == true)
                                lblStatus.Content = "Status \t: Not Active";

                        }
                    }
                }
            }
        }

        private void tvAccountData_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<Object> e)
        {
            this.KlasifikasiAkunSelected = null;
            if (tvAccountData.SelectedItem != null)
            {
                TreeViewItem node = (TreeViewItem)tvAccountData.SelectedItem;
                this.KlasifikasiAkunSelected = this.KlasifikasiAkuns.Where(m => m.Id == node.TabIndex).FirstOrDefault();
                this.LoadKlasifikasiAkunDetail();
            }
        }

        private void NewAccoundata_Click(object sender, RoutedEventArgs e)
        {
            if (this.KlasifikasiAkunSelected == null)
            {
                MessageBox.Show("The Account Has Not Been Selected !");
            }
            else
            {
                this.isEdit = false;
                if (this.KlasifikasiAkunSelected.AkunLevel == 1 | this.KlasifikasiAkunSelected.AkunLevel == 2)
                {
                    bool isWindowOpen = false;

                    foreach (Window w in Application.Current.Windows)
                    {
                        if (w is NewAccounLevel)
                        {
                            isWindowOpen = true;
                            w.Activate();
                        }
                    }

                    if (!isWindowOpen)
                    {
                        NewAccounLevel newaccounlevel = new NewAccounLevel(this);
                        newaccounlevel.Show();
                    }
                }
                else if (this.KlasifikasiAkunSelected.AkunLevel == 3)
                {
                    bool isWindowOpen = false;

                    foreach (Window w in Application.Current.Windows)
                    {
                        if (w is NewAccounLevel4)
                        {
                            isWindowOpen = true;
                            w.Activate();
                        }
                    }

                    if (!isWindowOpen)
                    {
                        NewAccounLevel4 newlevel4 = new NewAccounLevel4(this);
                        newlevel4.Show();
                    }
                }
                else
                {
                    MessageBox.Show("The maximum level is 4 !");
                }
            }
        }
        private void Editaccountdata_Click(object sender, RoutedEventArgs e)
        {
            if (this.KlasifikasiAkunSelected == null)
            {
                MessageBox.Show("The Account Has Not Been Selected !");
            }
            else
            {
                if (this.KlasifikasiAkunSelected.AkunLevel != 4)
                {
                    this.isEdit = true;
                    bool isWindowOpen = false;

                    foreach (Window w in Application.Current.Windows)
                    {
                        if (w is NewAccounLevel)
                        {
                            isWindowOpen = true;
                            w.Activate();
                        }
                    }

                    if (!isWindowOpen)
                    {
                        NewAccounLevel newaccounlevel = new NewAccounLevel(this);
                        newaccounlevel.Show();
                    }
                }
                else
                {
                    this.isEdit = true;
                    bool isWindowOpen = false;

                    foreach (Window w in Application.Current.Windows)
                    {
                        if (w is NewAccounLevel4)
                        {
                            isWindowOpen = true;
                            w.Activate();
                        }
                    }

                    if (!isWindowOpen)
                    {
                        NewAccounLevel4 newlevel4 = new NewAccounLevel4(this);
                        newlevel4.Show();
                    }
                }
            }

        }
        public void importantaccount_Click(object sender, RoutedEventArgs e)
        {
            ImportantAccount.ImportantAccount v = new ImportantAccount.ImportantAccount();
            Switcher.Switchnaccountdata(v);
        }
        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (this.KlasifikasiAkunSelected == null)
            {
                MessageBox.Show("The Account Has Not Been Selected !");
            }
            else
            {
                if (this.KlasifikasiAkunSelected.AkunLevel != 4)
                {
                    DeleteAccounLevel v = new DeleteAccounLevel(this);
                    v.Show();
                }
                else
                {
                    MessageBox.Show("Level 4 Accounts Cannot be Deleted, Please Set the Account to Inactive !");
                }
            }
        }
        private void playtutorial_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

