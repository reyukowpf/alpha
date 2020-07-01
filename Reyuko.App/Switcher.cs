using System.Windows.Controls;
using Reyuko.App.Views.Document;
using Reyuko.App.Views.Sales;
using Reyuko.App.Views.Note;
using Reyuko.App.Views.Produk;
using Reyuko.App.Views.NotesType;
using Reyuko.App.Views.Customer;
using Reyuko.App.Views.Vendor;
using Reyuko.App.Views.CashActivities;
using Reyuko.App.Views.Project;
using Reyuko.App.Views.GeneralJournal;
using Reyuko.App.Views.ReceivedGood;
using Reyuko.App.Views.Employee;
using Reyuko.App.Views.GroupProduct;
using Reyuko.App.Views.ImportantAccount;
using Reyuko.App.Views.AccountData;
using Reyuko.App.Views.Consigment;
using Reyuko.App.Views.InventoryAdjusment;
using Reyuko.App.Views.FixedAssetData;
using Reyuko.App.Views.StockOpname;
using Reyuko.App.Views.SalaryPayment;
using Reyuko.App.Views.Invoice;
using Reyuko.App.Views.DeliveryOrder;
using Reyuko.App.Views.SalesReturn;
using Reyuko.App.Views.PurchaseDocument;
using Reyuko.App.Views.PurchaseDelivery;
using Reyuko.App.Views.PurchaseReturn;
using Reyuko.App.Views.Service;
using Reyuko.App.Views.Production;
using Reyuko.App.Views.ReceivableAndPayable;
using Reyuko.App.Views.Company;

namespace Reyuko.App
{
  	public static class Switcher
  	{
        public static Documents pageSwitchDocuments;

    	public static void SwitchDocuments(UserControl newPage)
    	{
      		pageSwitchDocuments.Navigate(newPage);
    	}

        public static NewDocument pageSwitchNewDocument;

        public static void SwitchNewDocument(UserControl newPage)
        {
            pageSwitchNewDocument.Navigate(newPage);
        }
        public static SalesReturn pageSwitchSalesReturn;

        public static void SwitchSalesReturn(UserControl newPage)
        {
            pageSwitchSalesReturn.Navigate(newPage);
        }

        public static NewSalesReturn pageSwitchNewSalesReturn;

        public static void SwitchNewSalesReturn(UserControl newPage)
        {
            pageSwitchNewSalesReturn.Navigate(newPage);
        }
        public static Company pageSwitchCompany;

        public static void SwitchCompany(UserControl newPage)
        {
            pageSwitchCompany.Navigate(newPage);
        }

        public static NewCompany pageSwitchNewCompany;

        public static void SwitchNewCompany(UserControl newPage)
        {
            pageSwitchNewCompany.Navigate(newPage);
        }
        public static Production pageSwitchProduction;

        public static void SwitchProduction(UserControl newPage)
        {
            pageSwitchProduction.Navigate(newPage);
        }

        public static NewProduction pageSwitchNewProduction;

        public static void SwitchNewProduction(UserControl newPage)
        {
            pageSwitchNewProduction.Navigate(newPage);
        }
        public static Service pageSwitchService;

        public static void SwitchService(UserControl newPage)
        {
            pageSwitchService.Navigate(newPage);
        }

        public static NewService pageSwitchNewService;

        public static void SwitchNewService(UserControl newPage)
        {
            pageSwitchNewService.Navigate(newPage);
        }
        public static ReceivableAndPayable pageSwitchReceivableAndPayable;

        public static void SwitchReceivableAndPayable(UserControl newPage)
        {
            pageSwitchReceivableAndPayable.Navigate(newPage);
        }

        public static NewReceivableAndPayable pageSwitchNewReceivableAndPayable;

        public static void SwitchNewReceivableAndPayable(UserControl newPage)
        {
            pageSwitchNewReceivableAndPayable.Navigate(newPage);
        }
        public static PurchaseDelivery pageSwitchPurchaseDelivery;

        public static void SwitchPurchaseDelivery(UserControl newPage)
        {
            pageSwitchPurchaseDelivery.Navigate(newPage);
        }

        public static NewPurchaseDelivery pageSwitchNewPurchaseDelivery;

        public static void SwitchNewPurchaseDelivery(UserControl newPage)
        {
            pageSwitchNewPurchaseDelivery.Navigate(newPage);
        }
        public static PurchaseReturn pageSwitchPurchaseReturn;

        public static void SwitchPurchaseReturn(UserControl newPage)
        {
            pageSwitchPurchaseReturn.Navigate(newPage);
        }

        public static NewPurchaseReturn pageSwitchNewPurchaseReturn;

        public static void SwitchNewPurchaseReturn(UserControl newPage)
        {
            pageSwitchNewPurchaseReturn.Navigate(newPage);
        }
        public static PurchaseDocument pageSwitchPurchaseDocument;

        public static void SwitchPurchaseDocument(UserControl newPage)
        {
            pageSwitchPurchaseDocument.Navigate(newPage);
        }

        public static NewShopingchart pageSwitchNewShopingchart;

        public static void SwitchNewShopingchart(UserControl newPage)
        {
            pageSwitchNewShopingchart.Navigate(newPage);
        }
        public static NewQuotationRequest pageSwitchNewQuotationRequest;

        public static void SwitchNewQuotationRequest(UserControl newPage)
        {
            pageSwitchNewQuotationRequest.Navigate(newPage);
        }
        public static NewPurchasedOrder pageSwitchNewPurchasedOrder;

        public static void SwitchNewPurchasedOrder(UserControl newPage)
        {
            pageSwitchNewPurchasedOrder.Navigate(newPage);
        }
        public static Invoice pageSwitchInvoice;

        public static void SwitchInvoice(UserControl newPage)
        {
            pageSwitchInvoice.Navigate(newPage);
        }

        public static NewInvoice pageSwitchNewInvoice;

        public static void SwitchNewInvoice(UserControl newPage)
        {
            pageSwitchNewInvoice.Navigate(newPage);
        }
        public static Deliveryorder pageSwitchDeliveryorder;

        public static void SwitchDeliveryorder(UserControl newPage)
        {
            pageSwitchDeliveryorder.Navigate(newPage);
        }

        public static NewDeliveryOrder pageSwitchNewDeliveryorder;

        public static void SwitchNewDeliveryorder(UserControl newPage)
        {
            pageSwitchNewDeliveryorder.Navigate(newPage);
        }
        public static Vendor pageSwitchvendor;
        public static void Switchvendor(UserControl newPage)
        {
            pageSwitchvendor.Navigate(newPage);
        }
        public static NewVendors pageSwitchernewvendor;

        public static void Switchnewvendor(UserControl newPage)
        {
            pageSwitchernewvendor.Navigate(newPage);
        }

        public static Project pageSwitchproject;
        public static void Switchproject(UserControl newPage)
        {
            pageSwitchproject.Navigate(newPage);
        }
        public static NewProject pageSwitchernewproject;

        public static void Switchnewproject(UserControl newPage)
        {
            pageSwitchernewproject.Navigate(newPage);
        }
        public static Customers pageSwitchercustomers;

        public static void Switchcustomers(UserControl newPage)
        {
            pageSwitchercustomers.Navigate(newPage);
        }
        public static NewCustomer pageSwitchernewcustomers;

        public static void Switchnewcustomers(UserControl newPage)
        {
            pageSwitchernewcustomers.Navigate(newPage);
        }
        public static InternalNotes pageSwitcherNote;

        public static void Switchnote(UserControl newPage)
        {
            pageSwitcherNote.Navigate(newPage);
        }

        public static Produk pageSwitcherproduk;

        public static void Switchproduk(UserControl newPage)
        {
            pageSwitcherproduk.Navigate(newPage);
        }
        public static NewProduk pageSwitchernewproduk;

        public static void Switchnewproduk(UserControl newPage)
        {
            pageSwitchernewproduk.Navigate(newPage);
        }

        public static NotesType pageSwitcherNotetype;
        public static void Switchnotetype(UserControl newPage)
        {
            pageSwitcherNotetype.Navigate(newPage);
        }
        public static NewNoteType pageSwitchweNotetypes;
        public static void Switchnotetypes(UserControl newPage)
        {
            pageSwitchweNotetypes.Navigate(newPage);
        }

        public static NewInternalNote pageSwitcherNotes;

        public static void Switchnotes(UserControl newPage)
        {
            pageSwitcherNotes.Navigate(newPage);
        }

        public static Sales pageSwitcher1;
        
        public static void Switch1(UserControl newPage)
        {
            pageSwitcher1.Navigate(newPage);
        }

        public static NewSalesQuotation pageSwitcherSalesquotation;

        public static void Switch2(UserControl newPage)
        {
            pageSwitcherSalesquotation.Navigate(newPage);
        }
        public static NewSalesOrder pageSwitcherSalesorder;

        public static void Switchorder(UserControl newPage)
        {
            pageSwitcherSalesorder.Navigate(newPage);
        }
        public static CashActivities pageSwitcherCash;

        public static void SwitchCash(UserControl newPage)
        {
            pageSwitcherCash.Navigate(newPage);
        }

        public static NewCashActivities pageSwitcherNewcash;
        public static void Switchnewcash(UserControl newPage)
        {
            pageSwitcherNewcash.Navigate(newPage);
        }
        
        public static GroupProducts pageSwitchergrupproduk;

        public static void Switchgrupproduk(UserControl newPage)
        {
            pageSwitchergrupproduk.Navigate(newPage);
        }

        public static NewGroupProduct pageSwitcherNewgrupproduk;
        public static void Switchnewgrupproduk(UserControl newPage)
        {
            pageSwitcherNewgrupproduk.Navigate(newPage);
        }
        public static Employee pageSwitcheremployee;

        public static void Switchemployee(UserControl newPage)
        {
            pageSwitcheremployee.Navigate(newPage);
        }

        public static NewEmployee pageSwitcherNewemployee;
        public static void Switchnewemployee(UserControl newPage)
        {
            pageSwitcherNewemployee.Navigate(newPage);
        }
        public static GeneralJournal pageSwitcherjurnal;

        public static void Switchjurnal(UserControl newPage)
        {
            pageSwitcherjurnal.Navigate(newPage);
        }

        public static NewGeneralJournal pageSwitcherNewjurnal;
        public static void Switchnewjurnal(UserControl newPage)
        {
            pageSwitcherNewjurnal.Navigate(newPage);
        }
        public static ReceivedGood pageSwitcherreceivedgood;

        public static void Switchreceivedgood(UserControl newPage)
        {
            pageSwitcherreceivedgood.Navigate(newPage);
        }

        public static NewReceivedGood pageSwitcherNewreceived;
        public static void Switchnewreceived(UserControl newPage)
        {
            pageSwitcherNewreceived.Navigate(newPage);
        }
        public static Views.GroupProduct.GroupProduct pageSwitchergrupproduks;
        public static Consigment pageSwitcherconsigment;

        public static void Switchconsigment(UserControl newPage)
        {
            pageSwitcherconsigment.Navigate(newPage);
        }

        public static NewConsigmentReceive pageSwitcherNewreceive;
        public static void Switchnewreceive(UserControl newPage)
        {
            pageSwitcherNewreceive.Navigate(newPage);
        }
        public static NewConsigmentReturn pageSwitcherNewreturn;
        public static void Switchnewreturn(UserControl newPage)
        {
            pageSwitcherNewreturn.Navigate(newPage);
        }
        public static AccountData pageSwitcheraccountdata;
        public static void Switchnaccountdata(UserControl newPage)
        {
            pageSwitcheraccountdata.Navigate(newPage);
        }
        public static ImportantAccount pageSwitcherimport;
        public static void Switchimport(UserControl newPage)
        {
            pageSwitcherimport.Navigate(newPage);
        }
        public static FixedAssetData pageSwitcherassetdata;
        public static void Switchassetdata(UserControl newPage)
        {
            pageSwitcherassetdata.Navigate(newPage);
        }
        public static NewFixedAssetData pageSwitchernewassetdata;
        public static void Switchanewssetdata(UserControl newPage)
        {
            pageSwitchernewassetdata.Navigate(newPage);
        }
        public static InventoryChecking pageSwitchercheking;
        public static void Switchcheking(UserControl newPage)
        {
            pageSwitchercheking.Navigate(newPage);
        }
        public static NewInventoryChecking pageSwitchernewcheking;
        public static void Switchnewcheking(UserControl newPage)
        {
            pageSwitchernewcheking.Navigate(newPage);
        }
        public static SalaryPayment pageSwitchersalary;
        public static void Switchsalary(UserControl newPage)
        {
            pageSwitchersalary.Navigate(newPage);
        }
        public static NewSalaryPayment pageSwitchernewsalary;
        public static void Switchnewsalary(UserControl newPage)
        {
            pageSwitchernewsalary.Navigate(newPage);
        }
        public static InventoryAdjusment pageSwitcherinventoryadjusmen;
        public static void Switchinventoryadjusmen(UserControl newPage)
        {
            pageSwitcherinventoryadjusmen.Navigate(newPage);
        }
        public static NewInventoryAdjusment pageSwitchernewinventoryadjusmen;
        public static void Switchnewinventoryadjusmen(UserControl newPage)
        {
            pageSwitchernewinventoryadjusmen.Navigate(newPage);
        }
        public static Skushopingchart pageSwitchernewskushoping;
        public static void Switchnewskushoping(UserControl newPage)
        {
            pageSwitchernewskushoping.Navigate(newPage);
        }
    }
}
