using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class KategoriProdukBLL : BaseBLL, IKategoriProdukBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddKategoriProduk(KategoriProduk oData)
        {
            methodName = "AddKategoriProduk";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        KategoriProduk oNewKategoriProduk = new KategoriProduk();
                        oNewKategoriProduk.MapFrom(oData);
                        oNewKategoriProduk = uow.KategoriProduk.Add(oNewKategoriProduk);
                        uow.Save();

                        traceID = 3;
                        oData.Id = oNewKategoriProduk.Id;
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

        public bool EditKategoriProduk(KategoriProduk oData)
        {
            methodName = "EditKategoriProduk";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.KategoriProduk.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.KategoriProduk.Update(oDBData);
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

        public bool RemoveKategoriProduk(int id)
        {
            methodName = "RemoveKategoriProduk";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        KategoriProduk oDBKategoriProduk = uow.KategoriProduk.SingleOrDefault(m => m.Id == id);
                        if (oDBKategoriProduk != null)
                        {
                            traceID = 3;
                            uow.KategoriProduk.Remove(id);
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
