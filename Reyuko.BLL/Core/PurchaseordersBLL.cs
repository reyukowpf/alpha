using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class PurchaseordersBLL : BaseBLL, IPurchaseordersBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddPurchaseorders(PurchaseOrder oData)
        {
            methodName = "AddPurchaseorders";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        PurchaseOrder oNewPurchaseorder = new PurchaseOrder();
                        oNewPurchaseorder.MapFrom(oData);
                        oNewPurchaseorder = uow.PurchaseOrder.Add(oNewPurchaseorder);
                        uow.Save();

                        traceID = 3;
                        oData.IdOrderPembelian = oNewPurchaseorder.IdOrderPembelian;
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new AppException(500, methodName, traceID, ex);
                    }
                }
            }

            return oData.IdOrderPembelian;
        }

        public bool EditPurchaseorders(PurchaseOrder oData)
        {
            methodName = "EditPurchaseorders";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.PurchaseOrder.Get(oData.IdOrderPembelian);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.PurchaseOrder.Update(oDBData);
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

        public bool RemovePurchaseorders(int id)
        {
            methodName = "RemovePurchaseorders";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        PurchaseOrder oDBPurchaseorder = uow.PurchaseOrder.SingleOrDefault(m => m.IdOrderPembelian == id);
                        if (oDBPurchaseorder != null)
                        {
                            traceID = 3;
                            uow.PurchaseOrder.Remove(id);
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
        public int AddOrderProdukbeli(OrderProdukBeli oData)
        {
            methodName = "AddOrderProdukbeli";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        OrderProdukBeli oNewumum = new OrderProdukBeli();
                        oNewumum.MapFrom(oData);
                        oNewumum = uow.OrderProdukBeli.Add(oNewumum);
                        uow.Save();

                        traceID = 3;
                        oData.IdOrderProdukBeli = oNewumum.IdOrderProdukBeli;
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new AppException(500, methodName, traceID, ex);
                    }
                }
            }

            return oData.IdOrderProdukBeli;
        }
        public bool EditOrderProdukbeli(OrderProdukBeli oData, PurchaseOrder oDatas)
        {
            methodName = "EditOrderProdukbeli";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.OrderProdukBeli.Get(oData.IdOrderProdukBeli);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.OrderProdukBeli.Update(oDBData);

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
