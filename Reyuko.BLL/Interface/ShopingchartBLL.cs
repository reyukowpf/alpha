using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class ShopingchartBLL : BaseBLL, IShopingchartBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddShopingcharts(Shopingchart oData)
        {
            methodName = "AddShopingcharts";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        Shopingchart oNewShopingchart = new Shopingchart();
                        oNewShopingchart.MapFrom(oData);
                        oNewShopingchart = uow.Shopingchart.Add(oNewShopingchart);
                        uow.Save();

                        traceID = 3;
                        oData.IdPermintaanBarang = oNewShopingchart.IdPermintaanBarang;
                        oData.idTransaksi = oNewShopingchart.IdPermintaanBarang;
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

            return oData.IdPermintaanBarang;
        }

        public bool EditShopingcharts(Shopingchart oData)
        {
            methodName = "EditShopingcharts";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.Shopingchart.Get(oData.IdPermintaanBarang);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.Shopingchart.Update(oDBData);
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
        
        public bool RemoveShopingcharts(int id)
        {
            methodName = "RemoveShopingcharts";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        Shopingchart oDBShopingchart = uow.Shopingchart.SingleOrDefault(m => m.IdPermintaanBarang == id);
                        if (oDBShopingchart != null)
                        {
                            traceID = 3;
                            uow.Shopingchart.Remove(id);
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

                        if (oNewumum.IdOrderProdukBeli > 0)
                        {
                            traceID = 3;
                            oData.IdOrderProdukBeli = oNewumum.IdOrderProdukBeli;
                            ListOrderBeli oNewListOrderBeli = new ListOrderBeli();
                            oNewListOrderBeli.MapFrom(oData);

                            traceID = 4;
                            oNewListOrderBeli.IdOrderBeli = oData.IdOrderProdukBeli;
                            oNewListOrderBeli.Diskon = oData.DiskonProduk;
                            oNewListOrderBeli.IdAkunPajak = oData.IdAkunPajakProduk;
                            oNewListOrderBeli.TotalOrder = oData.TotalOrderProduk;
                            oNewListOrderBeli.TotalPajak = oData.TotalPajakProduk;
                            oNewListOrderBeli.Jumlah = oData.TotalProduk;
                            uow.ListOrderBeli.Add(oNewListOrderBeli);
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

            return oData.IdOrderProdukBeli;
        }
        public int AddOrderJasabeli(OrderJasaBeli oData)
        {
            methodName = "AddOrderJasabeli";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        OrderJasaBeli oNewumum = new OrderJasaBeli();
                        oNewumum.MapFrom(oData);
                        oNewumum = uow.OrderJasaBeli.Add(oNewumum);
                        uow.Save();

                        if (oNewumum.IdOrderJasa > 0)
                        {
                            traceID = 3;
                            oData.IdOrderJasa = oNewumum.IdOrderJasa;
                            ListOrderBeli oNewListOrderBeli = new ListOrderBeli();
                            oNewListOrderBeli.MapFrom(oData);

                            traceID = 4;
                            oNewListOrderBeli.IdOrderBeli = oData.IdOrderJasa;
                            oNewListOrderBeli.Diskon = oData.DiskonJasa;
                            oNewListOrderBeli.IdAkunPajak = oData.IdAkunPajakJasa;
                            oNewListOrderBeli.Jumlah = oData.TotalJasa;
                            oNewListOrderBeli.TotalOrderJasa = oData.TotalOrderJasa;
                            oNewListOrderBeli.TotalPajakJasa = oData.TotalPajakJasa;
                            oNewListOrderBeli.NamaProduk = oData.NamaJasa;
                            oNewListOrderBeli.TotalOrder = oData.TotalOrderJasa;
                            oNewListOrderBeli.TotalPajak = oData.TotalPajakJasa;
                            oNewListOrderBeli.HargaBeli = oData.HargaJasa;
                            oNewListOrderBeli.IdAkunJasa = oData.IdAkunJasa;
                            uow.ListOrderBeli.Add(oNewListOrderBeli);
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

            return oData.IdOrderJasa;
        }
        public int AddOrderCustombeli(OrderCustomBeli oData)
        {
            methodName = "AddOrderCustombeli";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        OrderCustomBeli oNewumum = new OrderCustomBeli();
                        oNewumum.MapFrom(oData);
                        oNewumum = uow.OrderCustomBeli.Add(oNewumum);
                        uow.Save();

                        if (oNewumum.IdOrderCustom > 0)
                        {
                            traceID = 3;
                            oData.IdOrderCustom = oNewumum.IdOrderCustom;
                            ListOrderBeli oNewListOrderBeli = new ListOrderBeli();
                            oNewListOrderBeli.MapFrom(oData);

                            traceID = 4;
                            oNewListOrderBeli.IdOrderBeli = oData.IdOrderCustom;                           
                            oNewListOrderBeli.TotalOrder = oData.TotalCustom;
                            oNewListOrderBeli.Jumlah = oData.JumlahCustom;
                            oNewListOrderBeli.Sku = oData.NamaCustom;
                            oNewListOrderBeli.HargaBeli = oData.HargaCustom;
                            uow.ListOrderBeli.Add(oNewListOrderBeli);
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

            return oData.IdOrderCustom;
        }
        public bool EditOrderProdukBeli(ListOrderBeli oData, Shopingchart oDatas, produk oDatap)
        {
            methodName = "EditOrderProdukBeli";
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
                      
                                traceID = 8;
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
                            traceID = 4;
                            produk oDproduk = uow.produk.SingleOrDefault(m => m.IdProduk == oData.IdProduk);
                            if (oDproduk != null)
                            {
                                traceID = 5;
                                oDproduk.MapFrom(oData);

                                traceID = 6;
                                oDproduk.JumlahStok = oDproduk.JumlahStok + oData.Jumlah;
                                uow.produk.Update(oDproduk);
                            }
                            else
                            {
                                traceID = 7;

                                traceID = 8;
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
