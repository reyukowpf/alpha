using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class PeriodeAkuntansiBLL : BaseBLL, IPeriodeAkuntansiBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddPeriodeAkuntansi(PeriodeAkuntansi oData)
        {
            methodName = "AddPeriodeAkuntansi";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        PeriodeAkuntansi oNewPeriodeAkuntansi = new PeriodeAkuntansi();
                        oNewPeriodeAkuntansi.MapFrom(oData);
                        oNewPeriodeAkuntansi = uow.PeriodeAkuntansi.Add(oNewPeriodeAkuntansi);
                        uow.Save();

                        traceID = 3;
                        oData.Id = oNewPeriodeAkuntansi.Id;
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

        public bool EditPeriodeAkuntansi(PeriodeAkuntansi oData)
        {
            methodName = "EditPeriodeAkuntansi";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.PeriodeAkuntansi.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.PeriodeAkuntansi.Update(oDBData);
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

        public bool RemovePeriodeAkuntansi(int id)
        {
            methodName = "RemovePeriodeAkuntansi";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        PeriodeAkuntansi oDBPeriodeAkuntansi = uow.PeriodeAkuntansi.SingleOrDefault(m => m.Id == id);
                        if (oDBPeriodeAkuntansi != null)
                        {
                            traceID = 3;
                            uow.PeriodeAkuntansi.Remove(id);
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
