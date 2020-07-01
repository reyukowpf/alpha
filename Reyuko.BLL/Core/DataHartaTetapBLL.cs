using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class DataHartaTetapBLL : BaseBLL, IDataHartaTetapBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddDataHartaTetap(DataHartaTetap oData)
        {
            methodName = "AddDataHartaTetap";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        DataHartaTetap oNewData = new DataHartaTetap();
                        oNewData.MapFrom(oData);
                        oNewData = uow.DataHartaTetap.Add(oNewData);
                        uow.Save();

                        oData.Id = oNewData.Id;
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

        public bool EditDataHartaTetap(DataHartaTetap oData)
        {
            methodName = "EditDataHartaTetap";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.DataHartaTetap.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oData.MapTo(oDBData);
                            uow.DataHartaTetap.Update(oDBData);

                            uow.Save();
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

        public bool RemoveDataHartaTetap(int id)
        {
            methodName = "RemoveDataHartaTetap";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        uow.DataHartaTetap.Remove(id);

                        uow.Save();
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

        public int AddKelompok(KelompokHartaTetap oData)
        {
            methodName = "AddKelompok";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        KelompokHartaTetap oNewData = new KelompokHartaTetap();
                        oNewData.MapFrom(oData);
                        oNewData = uow.KelompokHartaTetap.Add(oNewData);
                        uow.Save();

                        oData.Id = oNewData.Id;
                        DataHartaTetap oDBMataUang = uow.DataHartaTetap.SingleOrDefault(m => m.IdKelompokHartaTetap == oData.Id);
                        if (oDBMataUang != null)
                        {
                          //  oDBMataUang.NamaHartaTetap = oData.NamaKelompokHartaTetap;
                    //        oDBMataUang.TglKursMataUang = oData.Tanggal;
                            uow.DataHartaTetap.Update(oDBMataUang);
                        }

                        uow.Save();
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

        public bool EditKelompok(KelompokHartaTetap oData)
        {
            methodName = "EditKelompok";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.KursMataUang.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oData.MapTo(oDBData);
                            uow.KursMataUang.Update(oDBData);

                            uow.Save();
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

        public bool RemoveKurs(int id)
        {
            methodName = "RemoveKurs";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        uow.KelompokHartaTetap.Remove(id);

                        uow.Save();
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
