using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class InvoicesBLL : BaseBLL, IInvoicesBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddInvoices(invoice oData)
        {
            methodName = "AddInvoices";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        invoice oNewInvoices = new invoice();
                        oNewInvoices.MapFrom(oData);
                        oNewInvoices = uow.Invoice.Add(oNewInvoices);
                        uow.Save();

                        traceID = 3;
                        oData.IdInvoice = oNewInvoices.IdInvoice;
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new AppException(500, methodName, traceID, ex);
                    }
                }
            }

            return oData.IdInvoice;
        }

        public bool EditInvoices(invoice oData)
        {
            methodName = "EditInvoices";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.Invoice.Get(oData.IdInvoice);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.Invoice.Update(oDBData);
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
        
        public bool RemoveInvoices(int id)
        {
            methodName = "RemoveInvoices";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        invoice oDBInvoices = uow.Invoice.SingleOrDefault(m => m.IdInvoice == id);
                        if (oDBInvoices != null)
                        {
                            traceID = 3;
                            uow.Invoice.Remove(id);
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
        public bool EditOrderProdukJual(ListOrderJual oData, invoice oDatas)
        {
            methodName = "EditOrderProdukJual";
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
                                OrderProdukJual oNewListorderjual = new OrderProdukJual();
                                oNewListorderjual.MapFrom(oData);

                                traceID = 8;
                                uow.OrderProdukJual.Add(oNewListorderjual);
                            }
                            traceID = 9;
                            OrderJasaJual oDBListorderjual1 = uow.OrderJasaJual.SingleOrDefault(m => m.IdOrderJasa == oData.IdOrderJual);
                            if (oDBListorderjual1 != null)
                            {
                                traceID = 10;
                                oDBListorderjual1.MapFrom(oData);

                                traceID = 11;
                                oDBListorderjual1.TanggalStartdate = oData.TanggalPengiriman;
                                uow.OrderJasaJual.Update(oDBListorderjual1);
                            }
                            else
                            {
                                traceID = 12;
                    
                                traceID = 13;
                            }
                            traceID = 14;
                            OrderCustomJual oDBListorderjual2 = uow.OrderCustomJual.SingleOrDefault(m => m.IdOrderCustom == oData.IdOrderJual);
                            if (oDBListorderjual2 != null)
                            {
                                traceID = 15;
                                oDBListorderjual2.MapFrom(oData);

                                traceID = 16;
                                uow.OrderCustomJual.Update(oDBListorderjual2);
                            }
                            else
                            {
                                traceID = 17;

                                traceID = 18;
                            }
                            traceID = 19;
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
        public int AddOrderJasaJual(OrderJasaJual oData)
        {
            methodName = "AddOrderJasaJual";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        OrderJasaJual oNewOrderJasaJual = new OrderJasaJual();
                        oNewOrderJasaJual.MapFrom(oData);
                        oNewOrderJasaJual = uow.OrderJasaJual.Add(oNewOrderJasaJual);
                        uow.Save();

                        if (oNewOrderJasaJual.IdOrderJasa > 0)
                        {
                            traceID = 3;
                            oData.IdOrderJasa = oNewOrderJasaJual.IdOrderJasa;
                            ListOrderJual oNewListOrderJual = new ListOrderJual();
                            oNewListOrderJual.MapFrom(oData);

                            traceID = 4;
                            oNewListOrderJual.IdOrderJual = oData.IdOrderJasa;
                            oNewListOrderJual.HargaJual = oData.HargaJasa;
                            oNewListOrderJual.DiskonProduk = oData.DiskonJasa;
                            oNewListOrderJual.IdTypeProduk = oData.AkunJasa;
                            oNewListOrderJual.Jumlah = oData.JumlahJasa;
                            oNewListOrderJual.TotalOrder = oData.TotalOrderJasa;
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

            return oData.IdOrderJasa;
        }
        public int AddOrderCustomJual(OrderCustomJual oData)
        {
            methodName = "AddOrderCustomJual";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        OrderCustomJual oNewOrderProdukJual = new OrderCustomJual();
                        oNewOrderProdukJual.MapFrom(oData);
                        oNewOrderProdukJual = uow.OrderCustomJual.Add(oNewOrderProdukJual);
                        uow.Save();

                        if (oNewOrderProdukJual.IdOrderCustom > 0)
                        {
                            traceID = 3;
                            oData.IdOrderCustom = oNewOrderProdukJual.IdOrderCustom;
                            ListOrderJual oNewListOrderJual = new ListOrderJual();
                            oNewListOrderJual.MapFrom(oData);

                            traceID = 4;
                            oNewListOrderJual.IdOrderJual = oData.IdOrderCustom;
                            oNewListOrderJual.HargaJual = oData.HargaCustom;
                            oNewListOrderJual.Sku = oData.NamaCustom;
                            oNewListOrderJual.NamaProduk = oData.NamaCustom;
                            oNewListOrderJual.Jumlah = oData.JumlahCustom;
                            oNewListOrderJual.TotalOrder = oData.TotalCustom;
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

            return oData.IdOrderCustom;
        }
    }
}
