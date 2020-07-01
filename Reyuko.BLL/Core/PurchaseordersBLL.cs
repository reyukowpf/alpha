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

                        if (oNewPurchaseorder.IdTransaksi == null)
                        {
                            traceID = 3;
                            oData.IdOrderPembelian = oNewPurchaseorder.IdOrderPembelian;
                            oNewPurchaseorder.MapFrom(oData);

                            traceID = 4;
                            oNewPurchaseorder.IdTransaksi = oData.IdOrderPembelian;
                            uow.PurchaseOrder.Update(oNewPurchaseorder);
                        }

                        traceID = 5;
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
    
        public bool EditOrderProdukbeli(ListOrderBeli oData, PurchaseOrder oDatas)
        {
            methodName = "EditOrderProdukbeli";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.ListOrderBeli.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.ListOrderBeli.Update(oDBData);

                            traceID = 4;
                            OrderProdukBeli oDBListorderbeli = uow.OrderProdukBeli.SingleOrDefault(m => m.IdOrderProdukBeli == oData.IdOrderBeli);
                            if (oDBListorderbeli != null)
                            {
                                traceID = 5;
                                oDBListorderbeli.MapFrom(oData);

                                traceID = 6;
                                uow.OrderProdukBeli.Update(oDBListorderbeli);
                            }
                            else
                            {
                                traceID = 7;
                                OrderProdukBeli oNewListorderbeli = new OrderProdukBeli();
                                oNewListorderbeli.MapFrom(oData);

                                traceID = 8;
                                uow.OrderProdukBeli.Add(oNewListorderbeli);
                            }
                            traceID = 9;
                            OrderJasaBeli oDBListorderbeli1 = uow.OrderJasaBeli.SingleOrDefault(m => m.IdOrderJasa == oData.IdOrderBeli);
                            if (oDBListorderbeli1 != null)
                            {
                                traceID = 10;
                                oDBListorderbeli1.MapFrom(oData);

                                traceID = 11;
                                //         oDBListorderbeli1.TanggalStartdate = oData.TanggalPengiriman;
                                uow.OrderJasaBeli.Update(oDBListorderbeli1);
                            }
                            else
                            {
                                traceID = 12;

                                traceID = 13;
                            }
                            traceID = 14;
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
