using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class TabelPenyusutanBLL : BaseBLL, ITabelPenyusutanBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddTabelPenyusutan(TabelPenyusutan oData)
        {
            methodName = "AddTabelPenyusutan";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        TabelPenyusutan oNewTabelPenyusutan = new TabelPenyusutan();
                        oNewTabelPenyusutan.MapFrom(oData);
                        oNewTabelPenyusutan = uow.TabelPenyusutan.Add(oNewTabelPenyusutan);
                        uow.Save();

                        traceID = 3;
                        oData.Id = oNewTabelPenyusutan.Id;
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

        public bool EditTabelPenyusutan(TabelPenyusutan oData)
        {
            methodName = "EditTabelPenyusutan";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.TabelPenyusutan.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.TabelPenyusutan.Update(oDBData);
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

        public bool RemoveTabelPenyusutan(int id)
        {
            methodName = "RemoveTabelPenyusutan";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        TabelPenyusutan oDBTabelPenyusutan = uow.TabelPenyusutan.SingleOrDefault(m => m.Id == id);
                        if (oDBTabelPenyusutan != null)
                        {
                            traceID = 3;
                            uow.TabelPenyusutan.Remove(id);
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
