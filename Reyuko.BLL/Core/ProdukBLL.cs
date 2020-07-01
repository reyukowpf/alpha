using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class ProdukBLL : BaseBLL, IProdukBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddProduk(produk oData)
        {
            methodName = "AddProduk";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        produk oNewProduk = new produk();
                        oNewProduk.MapFrom(oData);
                        oNewProduk = uow.produk.Add(oNewProduk);
                        uow.Save();

                        traceID = 3;
                        oData.IdProduk = oNewProduk.IdProduk;
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new AppException(500, methodName, traceID, ex);
                    }
                }
            }

            return oData.IdProduk;
        }

        public bool EditProduk(produk oData)
        {
            methodName = "EditProduk";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.produk.Get(oData.IdProduk);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.produk.Update(oDBData);
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

        public bool RemoveProduk(int id)
        {
            methodName = "RemoveProduk";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        produk oDBProduk = uow.produk.SingleOrDefault(m => m.IdProduk == id);
                        if (oDBProduk != null)
                        {
                            traceID = 3;
                            uow.InternalNote.Remove(id);
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
