using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class TypeKontakBLL : BaseBLL, ITypeKontakBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddTypeKontak(TypeKontak oData)
        {
            methodName = "AddTypeKontak";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        TypeKontak oNewTypeKontak = new TypeKontak();
                        oNewTypeKontak.MapFrom(oData);
                        oNewTypeKontak = uow.TypeKontak.Add(oNewTypeKontak);
                        uow.Save();

                        traceID = 3;
                        oData.Id = oNewTypeKontak.Id;
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

        public bool EditTypeKontak(TypeKontak oData)
        {
            methodName = "EditTypeKontak";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.TypeKontak.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.TypeKontak.Update(oDBData);
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

        public bool RemoveTypeKontak(int id)
        {
            methodName = "RemoveTypeKontak";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        TypeKontak oDBTypeKontak = uow.TypeKontak.SingleOrDefault(m => m.Id == id);
                        if (oDBTypeKontak != null)
                        {
                            traceID = 3;
                            uow.TypeKontak.Remove(id);
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
