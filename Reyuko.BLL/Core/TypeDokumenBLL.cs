using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class TypeDokumenBLL : BaseBLL, ITypeDokumenBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddTypeDokumen(TypeDokumen oData)
        {
            methodName = "AddTypeDokumen";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        TypeDokumen oNewTypeDokumen = new TypeDokumen();
                        oNewTypeDokumen.MapFrom(oData);
                        oNewTypeDokumen = uow.TypeDokumen.Add(oNewTypeDokumen);
                        uow.Save();

                        traceID = 3;
                        oData.Id = oNewTypeDokumen.Id;
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

        public bool EditTypeDokumen(TypeDokumen oData)
        {
            methodName = "EditTypeDokumen";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.TypeDokumen.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.TypeDokumen.Update(oDBData);
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

        public bool RemoveTypeDokumen(int id)
        {
            methodName = "RemoveTypeDokumen";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        TypeDokumen oDBTypeDokumen = uow.TypeDokumen.SingleOrDefault(m => m.Id == id);
                        if (oDBTypeDokumen != null)
                        {
                            traceID = 3;
                            uow.TypeDokumen.Remove(id);
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
