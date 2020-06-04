using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class InvoicesBLL : BaseBLL, IInvoicesBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddInvoices(invoice oData)
        {
            methodName = "AddInvoices";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        invoice oNewInvoices = new invoice();
                        oNewInvoices.MapFrom(oData);
                        oNewInvoices = uow.Invoice.Add(oNewInvoices);
                        uow.Save();

                        traceID = 3;
                        oData.IdInvoice = oNewInvoices.IdInvoice;
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new AppException(500, methodName, traceID, ex);
                    }
                }
            }

            return oData.IdInvoice;
        }

        public bool EditInvoices(invoice oData)
        {
            methodName = "EditInvoices";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.Invoice.Get(oData.IdInvoice);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.Invoice.Update(oDBData);
                            uow.Save();

                            traceID = 4;
                            trans.Commit();
                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                            throw new AppException(500, methodName, traceID, ex);
                        }
                    }
                }
            }

            return true;
        }
        
        public bool RemoveInvoices(int id)
        {
            methodName = "RemoveInvoices";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        invoice oDBInvoices = uow.Invoice.SingleOrDefault(m => m.IdInvoice == id);
                        if (oDBInvoices != null)
                        {
                            traceID = 3;
                            uow.Invoice.Remove(id);
                            uow.Save();
                        }

                        traceID = 5;
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new AppException(500, methodName, traceID, ex);
                    }
                }
            }

            return true;
        }


    }
}
