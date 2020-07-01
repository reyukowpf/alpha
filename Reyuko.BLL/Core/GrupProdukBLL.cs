using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class GrupProdukBLL : BaseBLL, IGrupProdukBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddGrupProduk(GrupProduk oData)
        {
            methodName = "AddGrupProduk";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        GrupProduk oNewGrupProduk = new GrupProduk();
                        oNewGrupProduk.MapFrom(oData);
                        oNewGrupProduk = uow.GrupProduk.Add(oNewGrupProduk);
                        uow.Save();

                        traceID = 3;
                        oData.Id = oNewGrupProduk.Id;
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

        public bool EditGrupProduk(GrupProduk oData)
        {
            methodName = "EditGrupProduk";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.GrupProduk.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.GrupProduk.Update(oDBData);
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

        public bool RemoveGrupProduk(int id)
        {
            methodName = "RemoveGrupProduk";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        GrupProduk oDBGrupProduk = uow.GrupProduk.SingleOrDefault(m => m.Id == id);
                        if (oDBGrupProduk != null)
                        {
                            traceID = 3;
                            uow.GrupProduk.Remove(id);
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
