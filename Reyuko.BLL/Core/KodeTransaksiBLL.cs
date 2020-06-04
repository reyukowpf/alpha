using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class KodeTransaksiBLL : BaseBLL, IKodeTransaksiBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddKodeTransaksi(KodeTransaksi oData)
        {
            methodName = "AddKodeTransaksi";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        KodeTransaksi oNewKodeTransaksi = new KodeTransaksi();
                        oNewKodeTransaksi.MapFrom(oData);
                        oNewKodeTransaksi = uow.KodeTransaksi.Add(oNewKodeTransaksi);
                        uow.Save();

                        traceID = 3;
                        oData.Id = oNewKodeTransaksi.Id;
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

        public bool EditKodeTransaksi(KodeTransaksi oData)
        {
            methodName = "EditKodeTransaksi";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.KodeTransaksi.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.KodeTransaksi.Update(oDBData);
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

        public bool RemoveKodeTransaksi(int id)
        {
            methodName = "RemoveKodeTransaksi";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        KodeTransaksi oDBKodeTransaksi = uow.KodeTransaksi.SingleOrDefault(m => m.Id == id);
                        if (oDBKodeTransaksi != null)
                        {
                            traceID = 3;
                            uow.KodeTransaksi.Remove(id);
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
