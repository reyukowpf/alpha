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
        public int AddOrderProdukjual(OrderProdukJual oData)
        {
            methodName = "AddOrderProdukjual";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        OrderProdukJual oNewumum = new OrderProdukJual();
                        oNewumum.MapFrom(oData);
                        oNewumum = uow.OrderProdukJual.Add(oNewumum);
                        uow.Save();

                        traceID = 3;
                        oData.IdOrderProdukJual = oNewumum.IdOrderProdukJual;
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new AppException(500, methodName, traceID, ex);
                    }
                }
            }

            return oData.IdOrderProdukJual;
        }
        public bool EditOrderProdukjual(OrderProdukJual oData, Salesreturn oDatas)
        {
            methodName = "EditOrderProdukjual";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.OrderProdukJual.Get(oData.IdOrderProdukJual);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.OrderProdukJual.Update(oDBData);


                            traceID = 6;
                            uow.Save();
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

    }
}
