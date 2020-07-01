using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class QuotationrequestBLL : BaseBLL, IQuotationrequestBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddQuotationrequests(Quotationrequest oData)
        {
            methodName = "AddQuotationrequests";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        Quotationrequest oNewQuotationrequest = new Quotationrequest();
                        oNewQuotationrequest.MapFrom(oData);
                        oNewQuotationrequest = uow.Quotationrequest.Add(oNewQuotationrequest);
                        uow.Save();

                        if (oNewQuotationrequest.IdTransaksi == null)
                        {
                            traceID = 3;
                            oData.IdPermintaanPenawaranHarga = oNewQuotationrequest.IdPermintaanPenawaranHarga;
                            oNewQuotationrequest.MapFrom(oData);

                            traceID = 4;
                            oNewQuotationrequest.IdTransaksi = oData.IdPermintaanPenawaranHarga;
                            uow.Quotationrequest.Update(oNewQuotationrequest);
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

            return oData.IdPermintaanPenawaranHarga;
        }

        public bool EditQuotationrequests(Quotationrequest oData)
        {
            methodName = "EditQuotationrequests";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.Quotationrequest.Get(oData.IdPermintaanPenawaranHarga);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.Quotationrequest.Update(oDBData);
                            traceID = 4;
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

        public bool RemoveQuotationrequests(int id)
        {
            methodName = "RemoveQuotationrequests";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        Quotationrequest oDBQuotationrequest = uow.Quotationrequest.SingleOrDefault(m => m.IdPermintaanPenawaranHarga == id);
                        if (oDBQuotationrequest != null)
                        {
                            traceID = 3;
                            uow.Quotationrequest.Remove(id);
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

        public bool EditOrderProdukBeli(ListOrderBeli oData, Quotationrequest oDatas)
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
