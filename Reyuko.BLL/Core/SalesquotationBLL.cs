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

                        /*  if (oNewSalesquotation.Id > 0)
                          {
                              traceID = 3;
                              oData.Id = oNewSalesquotation.Id;
                              SalesOrder oNewsalesorder = new SalesOrder();
                              oNewsalesorder.MapFrom(oData);

                              traceID = 4;
                              oNewsalesorder.IdTransaksi = oData.Id;
                              uow.SalesOrder.Add(oNewsalesorder);
                          }

                          if (oNewSalesquotation.Id > 0)
                          {
                              traceID = 3;
                              oData.Id = oNewSalesquotation.Id;
                              Deliveryorders oNeworder = new Deliveryorders();
                              oNeworder.MapFrom(oData);

                              traceID = 4;
                              oNeworder.IdTransaksi = oData.Id;
                              uow.DeliveryOrder.Add(oNeworder);
                          }

                          if (oNewSalesquotation.Id > 0)
                          {
                              traceID = 3;
                              oData.Id = oNewSalesquotation.Id;
                              invoice oNewinvoice = new invoice();
                              oNewinvoice.MapFrom(oData);

                              traceID = 4;
                              oNewinvoice.IdTransaksi = oData.Id;
                              uow.Invoice.Add(oNewinvoice);
                          }

                          if (oNewSalesquotation.Id > 0)
                          {
                              traceID = 3;
                              oData.Id = oNewSalesquotation.Id;
                              Salesreturn oNewgood = new Salesreturn();
                              oNewgood.MapFrom(oData);

                              traceID = 4;
                              oNewgood.IdTransaksi = oData.Id;
                              uow.SalesReturn.Add(oNewgood);
                          }*/

                        traceID = 3;
                        oData.Id = oNewSalesquotation.Id;
                        oData.IdTransaksi = oNewSalesquotation.Id;
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
                        OrderProdukJual oNewOrderProdukJual = new OrderProdukJual();
                        oNewOrderProdukJual.MapFrom(oData);
                        oNewOrderProdukJual = uow.OrderProdukJual.Add(oNewOrderProdukJual);
                        uow.Save();

                        if (oNewOrderProdukJual.IdOrderProdukJual > 0)
                        {
                            traceID = 3;
                            oData.IdOrderProdukJual = oNewOrderProdukJual.IdOrderProdukJual;
                            ListOrderJual oNewListOrderJual = new ListOrderJual();
                            oNewListOrderJual.MapFrom(oData);

                            traceID = 4;
                            oNewListOrderJual.IdOrderJual = oData.IdOrderProdukJual;
                            oNewListOrderJual.Jumlah = oData.JumlahProduk;
                            oNewListOrderJual.Diskon = oData.DiskonProduk;
                            oNewListOrderJual.TotalPajak = oData.TotalPajakProduk;
                            oNewListOrderJual.TotalPajakProduk = oData.TotalPajakProduk;
                            oNewListOrderJual.TotalOrderProduk = oData.TotalOrderProduk;
                            oNewListOrderJual.HargaJual = oData.HargaJual;
                            oNewListOrderJual.TotalOrder = oData.TotalOrderProduk;
                            uow.ListOrderJual.Add(oNewListOrderJual);
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

            return oData.IdOrderProdukJual;
        }
        public int AddOrderJasajual(OrderJasaJual oData)
        {
            methodName = "AddOrderJasajual";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        OrderJasaJual oNewOrderProdukJual1 = new OrderJasaJual();
                        oNewOrderProdukJual1.MapFrom(oData);
                        oNewOrderProdukJual1 = uow.OrderJasaJual.Add(oNewOrderProdukJual1);
                        uow.Save();

                        if (oNewOrderProdukJual1.IdOrderJasa > 0)
                        {
                            traceID = 3;
                            oData.IdOrderJasa = oNewOrderProdukJual1.IdOrderJasa;
                            ListOrderJual oNewListOrderJual1 = new ListOrderJual();
                            oNewListOrderJual1.MapFrom(oData);

                            traceID = 4;
                            oNewListOrderJual1.IdOrderJual = oData.IdOrderJasa;
                            oNewListOrderJual1.Jumlah = oData.JumlahJasa;
                            oNewListOrderJual1.HargaJual = oData.HargaJasa;
                            oNewListOrderJual1.TotalOrder = oData.TotalOrderJasa;
                            oNewListOrderJual1.TotalOrderJasa = oData.TotalOrderJasa;
                            oNewListOrderJual1.TotalPajakJasa = oData.TotalPajakJasa;
                            oNewListOrderJual1.TotalPajak = oData.TotalPajakJasa;
                            uow.ListOrderJual.Add(oNewListOrderJual1);
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
        public bool EditOrderProdukjual(ListOrderJual oData, Salesquotation oDatas)
        {
            methodName = "EditOrderProdukjual";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.ListOrderJual.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.ListOrderJual.Update(oDBData);

                            traceID = 4;
                            OrderProdukJual oDBListorderjual = uow.OrderProdukJual.SingleOrDefault(m => m.IdOrderProdukJual == oData.IdOrderJual);
                            if (oDBListorderjual != null)
                            {
                                traceID = 5;
                                oDBListorderjual.MapFrom(oData);

                                traceID = 6;
                                uow.OrderProdukJual.Update(oDBListorderjual);
                            }
                            else
                            {
                                traceID = 7;
                               
                                traceID = 8;
                            }
                            traceID = 9;
                            OrderJasaJual oDBListorderjual1 = uow.OrderJasaJual.SingleOrDefault(m => m.IdOrderJasa == oData.IdOrderJual);
                            if (oDBListorderjual1 != null)
                            {
                                traceID = 10;
                                oDBListorderjual1.MapFrom(oData);

                                traceID = 11;
                                uow.OrderJasaJual.Update(oDBListorderjual1);
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

 