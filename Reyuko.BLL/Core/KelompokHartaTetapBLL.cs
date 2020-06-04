using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class KelompokHartaTetapBLL : BaseBLL, IKelompokHartaTetapBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddKelompokHartaTetap(KelompokHartaTetap oData)
        {
            methodName = "AddKelompokHartaTetap";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        KelompokHartaTetap oNewKelompokHartaTetap = new KelompokHartaTetap();
                        oNewKelompokHartaTetap.MapFrom(oData);
                        oNewKelompokHartaTetap = uow.KelompokHartaTetap.Add(oNewKelompokHartaTetap);
                        uow.Save();

                        traceID = 3;
                        oData.Id = oNewKelompokHartaTetap.Id;
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

        public bool EditKelompokHartaTetap(KelompokHartaTetap oData)
        {
            methodName = "EditKelompokHartaTetap";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.KelompokHartaTetap.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.KelompokHartaTetap.Update(oDBData);
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

        public bool RemoveKelompokHartaTetap(int id)
        {
            methodName = "RemoveKelompokHartaTetap";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        KelompokHartaTetap oDBKelompokHartaTetap = uow.KelompokHartaTetap.SingleOrDefault(m => m.Id == id);
                        if (oDBKelompokHartaTetap != null)
                        {
                            traceID = 3;
                            uow.KelompokHartaTetap.Remove(id);
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
