using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class SalesreturnBLL : BaseBLL, ISalesreturnBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddSalesreturns(Salesreturn oData)
        {
            methodName = "AddSalesreturns";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        Salesreturn oNewSalesreturn = new Salesreturn();
                        oNewSalesreturn.MapFrom(oData);
                        oNewSalesreturn = uow.SalesReturn.Add(oNewSalesreturn);
                        uow.Save();

                        traceID = 3;
                        oData.IdReturPenjualan = oNewSalesreturn.IdReturPenjualan;
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new AppException(500, methodName, traceID, ex);
                    }
                }
            }

            return oData.IdReturPenjualan;
        }

        public bool EditSalesreturns(Salesreturn oData)
        {
            methodName = "EditSalesreturns";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.SalesReturn.Get(oData.IdReturPenjualan);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.SalesReturn.Update(oDBData);
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
        
        public bool RemoveSalesreturns(int id)
        {
            methodName = "RemoveSalesreturns";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        Salesreturn oDBSalesreturn = uow.SalesReturn.SingleOrDefault(m => m.IdReturPenjualan == id);
                        if (oDBSalesreturn != null)
                        {
                            traceID = 3;
                            uow.SalesReturn.Remove(id);
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
