using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class ReceivedGoodsBLL : BaseBLL, IReceivedGoodsBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddReceivedGoods(Receivedgood oData)
        {
            methodName = "AddReceivedGoods";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        Receivedgood oNewReceivedGoods = new Receivedgood();
                        oNewReceivedGoods.MapFrom(oData);
                        oNewReceivedGoods = uow.Receivedgood.Add(oNewReceivedGoods);
                        uow.Save();

                        if (oNewReceivedGoods.IdTransaksi == null)
                        {
                            traceID = 3;
                            oData.IdOrder = oNewReceivedGoods.IdOrder;
                            oNewReceivedGoods.MapFrom(oData);

                            traceID = 4;
                            oNewReceivedGoods.IdTransaksi = oData.IdOrder;
                            uow.Receivedgood.Update(oNewReceivedGoods);
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

            return oData.IdOrder;
        }

        public bool EditReceivedGoods(Receivedgood oData)
        {
            methodName = "EditReceivedGoods";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.Receivedgood.Get(oData.IdOrder);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.Receivedgood.Update(oDBData);
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
        
        public bool RemoveReceivedGoods(int id)
        {
            methodName = "RemoveReceivedGoods";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        Receivedgood oDBReceivedGoods = uow.Receivedgood.SingleOrDefault(m => m.IdOrder == id);
                        if (oDBReceivedGoods != null)
                        {
                            traceID = 3;
                            uow.Receivedgood.Remove(id);
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
        public bool EditOrderProdukbeli(ListOrderBeli oData, Receivedgood oDatas)
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
