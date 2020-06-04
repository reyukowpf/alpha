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

                        traceID = 3;
                        oData.IdPermintaanPenawaranHarga = oNewQuotationrequest.IdPermintaanPenawaranHarga;
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


    }
}
