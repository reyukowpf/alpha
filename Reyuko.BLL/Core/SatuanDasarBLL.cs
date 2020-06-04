using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class SatuanDasarBLL : BaseBLL, ISatuanDasarBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddSatuanDasar(SatuanDasar oData)
        {
            methodName = "AddSatuanDasar";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        SatuanDasar oNewSatuanDasar = new SatuanDasar();
                        oNewSatuanDasar.MapFrom(oData);
                        oNewSatuanDasar = uow.SatuanDasar.Add(oNewSatuanDasar);
                        uow.Save();

                        traceID = 3;
                        oData.Id = oNewSatuanDasar.Id;
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

        public bool EditSatuanDasar(SatuanDasar oData)
        {
            methodName = "EditSatuanDasar";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.SatuanDasar.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.SatuanDasar.Update(oDBData);
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

        public bool RemoveSatuanDasar(int id)
        {
            methodName = "RemoveSatuanDasar";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        SatuanDasar oDBSatuanDasar = uow.SatuanDasar.SingleOrDefault(m => m.Id == id);
                        if (oDBSatuanDasar != null)
                        {
                            traceID = 3;
                            uow.SatuanDasar.Remove(id);
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
