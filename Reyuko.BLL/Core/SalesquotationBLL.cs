using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class SalesquotationBLL : BaseBLL, ISalesquotationBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddSalesquotation(Salesquotation oData)
        {
            methodName = "AddSalesquotation";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        Salesquotation oNewSalesquotation = new Salesquotation();
                        oNewSalesquotation.MapFrom(oData);
                        oNewSalesquotation = uow.Salesquotation.Add(oNewSalesquotation);
                        uow.Save();

                        traceID = 3;
                        oData.Id = oNewSalesquotation.Id;
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new AppException(500, methodName, traceID, ex);
                    }
                }
            }

            return oData.Id;
        }

        public bool EditSalesquotation(Salesquotation oData)
        {
            methodName = "EditSalesquotation";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.Salesquotation.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.Salesquotation.Update(oDBData);
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

        public bool RemoveSalesquotation(int id)
        {
            methodName = "RemoveSalesquotation";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        Salesquotation oDBSalesquotation = uow.Salesquotation.SingleOrDefault(m => m.Id == id);
                        if (oDBSalesquotation != null)
                        {
                            traceID = 3;
                            uow.Salesquotation.Remove(id);
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
