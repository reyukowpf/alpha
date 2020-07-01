using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class NamaPenyusutanBLL : BaseBLL, INamaPenyusutanBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddNamaPenyusutan(NamaPenyusutan oData)
        {
            methodName = "AddNamaPenyusutan";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        NamaPenyusutan oNewNamaPenyusutan = new NamaPenyusutan();
                        oNewNamaPenyusutan.MapFrom(oData);
                        oNewNamaPenyusutan = uow.NamaPenyusutan.Add(oNewNamaPenyusutan);
                        uow.Save();

                        traceID = 3;
                        oData.Id = oNewNamaPenyusutan.Id;
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

        public bool EditNamaPenyusutan(NamaPenyusutan oData)
        {
            methodName = "EditNamaPenyusutan";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.NamaPenyusutan.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.NamaPenyusutan.Update(oDBData);
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

        public bool RemoveNamaPenyusutan(int id)
        {
            methodName = "RemoveNamaPenyusutan";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        NamaPenyusutan oDBNamaPenyusutan = uow.NamaPenyusutan.SingleOrDefault(m => m.Id == id);
                        if (oDBNamaPenyusutan != null)
                        {
                            traceID = 3;
                            uow.NamaPenyusutan.Remove(id);
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
