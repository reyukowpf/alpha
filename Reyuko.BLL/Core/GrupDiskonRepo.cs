using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class GrupDiskonBLL : BaseBLL, IGrupDiskonBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddGrupDiskon(GrupDiskon oData)
        {
            methodName = "AddGrupDiskon";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        GrupDiskon oNewGrupDiskon = new GrupDiskon();
                        oNewGrupDiskon.MapFrom(oData);
                        oNewGrupDiskon = uow.GrupDiskon.Add(oNewGrupDiskon);
                        uow.Save();

                        traceID = 3;
                        oData.Id = oNewGrupDiskon.Id;
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

        public bool EditGrupDiskon(GrupDiskon oData)
        {
            methodName = "EditGrupDiskon";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.GrupDiskon.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.GrupDiskon.Update(oDBData);
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

        public bool RemoveGrupDiskon(int id)
        {
            methodName = "RemoveGrupDiskon";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        GrupDiskon oDBGrupDiskon = uow.GrupDiskon.SingleOrDefault(m => m.Id == id);
                        if (oDBGrupDiskon != null)
                        {
                            traceID = 3;
                            uow.GrupDiskon.Remove(id);
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
