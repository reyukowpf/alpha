using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class KlasifikasiKontakBLL : BaseBLL, IKlasifikasiKontakBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddKlasifikasiKontak(KlasifikasiKontak oData)
        {
            methodName = "AddKlasifikasiKontak";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        KlasifikasiKontak oNewKlasifikasiKontak = new KlasifikasiKontak();
                        oNewKlasifikasiKontak.MapFrom(oData);
                        oNewKlasifikasiKontak = uow.KlasifikasiKontak.Add(oNewKlasifikasiKontak);
                        uow.Save();

                        traceID = 3;
                        oData.Id = oNewKlasifikasiKontak.Id;
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

        public bool EditKlasifikasiKontak(KlasifikasiKontak oData)
        {
            methodName = "EditKlasifikasiKontak";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.KlasifikasiKontak.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.KlasifikasiKontak.Update(oDBData);
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

        public bool RemoveKlasifikasiKontak(int id)
        {
            methodName = "RemoveKlasifikasiKontak";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        KlasifikasiKontak oDBKlasifikasiKontak = uow.KlasifikasiKontak.SingleOrDefault(m => m.Id == id);
                        if (oDBKlasifikasiKontak != null)
                        {
                            traceID = 3;
                            uow.KlasifikasiKontak.Remove(id);
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
