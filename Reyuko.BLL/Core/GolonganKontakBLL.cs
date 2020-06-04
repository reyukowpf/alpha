using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class GolonganKontakBLL : BaseBLL, IGolonganKontakBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddGolonganKontak(GolonganKontak oData)
        {
            methodName = "AddGolonganKontak";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        GolonganKontak oNewGolonganKontak = new GolonganKontak();
                        oNewGolonganKontak.MapFrom(oData);
                        oNewGolonganKontak = uow.GolonganKontak.Add(oNewGolonganKontak);
                        uow.Save();

                        traceID = 3;
                        oData.Id = oNewGolonganKontak.Id;
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

        public bool EditGolonganKontak(GolonganKontak oData)
        {
            methodName = "EditGolonganKontak";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.GolonganKontak.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.GolonganKontak.Update(oDBData);
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

        public bool RemoveGolonganKontak(int id)
        {
            methodName = "RemoveGolonganKontak";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        GolonganKontak oDBGolonganKontak = uow.GolonganKontak.SingleOrDefault(m => m.Id == id);
                        if (oDBGolonganKontak != null)
                        {
                            traceID = 3;
                            uow.GolonganKontak.Remove(id);
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
