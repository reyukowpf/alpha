using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class SalesOrderBLL : BaseBLL, ISalesOrderBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddSalesOrder(SalesOrder oData)
        {
            methodName = "AddSalesOrder";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        SalesOrder oNewSalesOrder = new SalesOrder();
                        oNewSalesOrder.MapFrom(oData);
                        oNewSalesOrder = uow.SalesOrder.Add(oNewSalesOrder);
                        uow.Save();

                        traceID = 3;
                        oData.IdOrderPenjualan = oNewSalesOrder.IdOrderPenjualan;
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new AppException(500, methodName, traceID, ex);
                    }
                }
            }

            return oData.IdOrderPenjualan;
        }

        public bool EditSalesOrder(SalesOrder oData)
        {
            methodName = "EditSalesOrder";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.SalesOrder.Get(oData.IdOrderPenjualan);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.SalesOrder.Update(oDBData);
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

        public bool RemoveSalesOrder(int id)
        {
            methodName = "RemoveSalesOrder";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        SalesOrder oDBSalesOrder = uow.SalesOrder.SingleOrDefault(m => m.IdOrderPenjualan == id);
                        if (oDBSalesOrder != null)
                        {
                            traceID = 3;
                            uow.SalesOrder.Remove(id);
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
