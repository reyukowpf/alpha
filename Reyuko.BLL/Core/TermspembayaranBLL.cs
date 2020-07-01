using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class TermspembayaranBLL : BaseBLL, ITermspembayaranBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddTermPembayaran(Termspembayaran oData)
        {
            methodName = "AddTermPembayaran";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        Termspembayaran oNewTermspembayaran = new Termspembayaran();
                        oNewTermspembayaran.MapFrom(oData);
                        oNewTermspembayaran = uow.Termspembayaran.Add(oNewTermspembayaran);
                        uow.Save();

                        traceID = 3;
                        oData.IdTermPembayaran = oNewTermspembayaran.IdTermPembayaran;
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new AppException(500, methodName, traceID, ex);
                    }
                }
            }

            return oData.IdTermPembayaran;
        }

        public bool EditTermPembayaran(Termspembayaran oData)
        {
            methodName = "EditTermPembayaran";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.Termspembayaran.Get(oData.IdTermPembayaran);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.Termspembayaran.Update(oDBData);
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

        public bool RemoveTermPembayaran(int id)
        {
            methodName = "RemoveTermPembayaran";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        Termspembayaran oDBTermPembayaran = uow.Termspembayaran.SingleOrDefault(m => m.IdTermPembayaran == id);
                        if (oDBTermPembayaran != null)
                        {
                            traceID = 3;
                            uow.Termspembayaran.Remove(id);
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
