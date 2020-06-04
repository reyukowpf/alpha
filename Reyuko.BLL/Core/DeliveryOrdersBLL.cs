using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class DeliveryOrdersBLL : BaseBLL, IDeliveryOrdersBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddDeliveryOrder(Deliveryorders oData)
        {
            methodName = "AddDeliveryOrder";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        Deliveryorders oNewDeliveryOrder = new Deliveryorders();
                        oNewDeliveryOrder.MapFrom(oData);
                        oNewDeliveryOrder = uow.DeliveryOrder.Add(oNewDeliveryOrder);
                        uow.Save();

                        traceID = 3;
                        oData.Id = oNewDeliveryOrder.Id;
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

        public bool EditDeliveryOrder(Deliveryorders oData)
        {
            methodName = "EditDeliveryOrder";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.DeliveryOrder.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.DeliveryOrder.Update(oDBData);
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
        
        public bool RemoveDeliveryOrder(int id)
        {
            methodName = "RemoveDeliveryOrder";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        Deliveryorders oDBDeliveryOrder = uow.DeliveryOrder.SingleOrDefault(m => m.Id == id);
                        if (oDBDeliveryOrder != null)
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
        public bool EditOrderProdukjual(OrderProdukJual oData, Deliveryorders oDatas)
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
