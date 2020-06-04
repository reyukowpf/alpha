using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class PembayaranGajiBLL : BaseBLL, IPembayaranGajiBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddPembayaranGaji(PembayaranGaji oData)
        {
            methodName = "AddPembayaranGaji";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        PembayaranGaji oNewPembayaranGaji = new PembayaranGaji();
                        oNewPembayaranGaji.MapFrom(oData);
                        oNewPembayaranGaji = uow.PembayaranGaji.Add(oNewPembayaranGaji);
                        uow.Save();
                     
                        traceID = 3;
                        oData.IdPembayaranGaji = oNewPembayaranGaji.IdPembayaranGaji;
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new AppException(500, methodName, traceID, ex);
                    }
                }
            }

            return oData.IdPembayaranGaji;
        }

        public bool EditPembayaranGaji(PembayaranGaji oData)
        {
            methodName = "EditPembayaranGaji";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.PembayaranGaji.Get(oData.IdPembayaranGaji);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.PembayaranGaji.Update(oDBData);
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

        public bool RemovePembayaranGaji(int id)
        {
            methodName = "RemovePembayaranGaji";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        PembayaranGaji oDBPembayaranGaji = uow.PembayaranGaji.SingleOrDefault(m => m.IdPembayaranGaji == id);
                        if (oDBPembayaranGaji != null)
                        {
                            traceID = 3;
                            uow.PembayaranGaji.Remove(id);
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

        public int AddOrderPembayaranGaji(OrderPembayaranGaji oData)
        {
            methodName = "AddOrderPembayaranGaji";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        OrderPembayaranGaji oNewumum = new OrderPembayaranGaji();
                        oNewumum.MapFrom(oData);
                        oNewumum = uow.OrderPembayaranGaji.Add(oNewumum);
                        uow.Save();

                        traceID = 3;
                        oData.Id = oNewumum.Id;
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
        public bool EditOrderPembayaranGaji(OrderPembayaranGaji oData, PembayaranGaji oDatas)
        {
            methodName = "EditOrderPembayaranGaji";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.OrderPembayaranGaji.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.OrderPembayaranGaji.Update(oDBData);

                            
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
