using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class PurchasedeliveryBLL : BaseBLL, IPurchasedeliveryBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddPurchasedelivery(Purchasedelivery oData)
        {
            methodName = "AddPurchasedelivery";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        Purchasedelivery oNewPurchasedelivery = new Purchasedelivery();
                        oNewPurchasedelivery.IdReferalTransaksi = "26" + "." + oData.IdPengirimanBarangPembelian;
                        oNewPurchasedelivery.MapFrom(oData);
                        oNewPurchasedelivery = uow.PurchaseDelivery.Add(oNewPurchasedelivery);
                        uow.Save();

                        traceID = 3;
                        oData.IdReferalTransaksi = "26" + "." + oNewPurchasedelivery.IdPengirimanBarangPembelian;
                        oData.IdPengirimanBarangPembelian = oNewPurchasedelivery.IdPengirimanBarangPembelian;
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new AppException(500, methodName, traceID, ex);
                    }
                }
            }

            return oData.IdPengirimanBarangPembelian;
        }

        public bool EditPurchasedelivery(Purchasedelivery oData)
        {
            methodName = "EditPurchasedelivery";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.PurchaseDelivery.Get(oData.IdPengirimanBarangPembelian);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.PurchaseDelivery.Update(oDBData);
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

        public bool RemovePurchasedelivery(int id)
        {
            methodName = "RemovePurchasedelivery";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        Purchasedelivery oDBPurchasedelivery = uow.PurchaseDelivery.SingleOrDefault(m => m.IdPengirimanBarangPembelian == id);
                        if (oDBPurchasedelivery != null)
                        {
                            traceID = 3;
                            uow.PurchaseDelivery.Remove(id);
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
        public bool EditOrderProdukbeli(OrderProdukBeli oData, Purchasedelivery oDatas)
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
