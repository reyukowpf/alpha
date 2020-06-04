using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class DataMataUangBLL : BaseBLL, IDataMataUangBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddMataUang(DataMataUang oData)
        {
            methodName = "AddMataUang";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        DataMataUang oNewData = new DataMataUang();
                        oNewData.MapFrom(oData);
                        oNewData.CheckBoxAktif = true;
                        oNewData = uow.DataMataUang.Add(oNewData);
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

        public bool EditMataUang(DataMataUang oData)
        {
            methodName = "EditMataUang";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.DataMataUang.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oData.MapTo(oDBData);
                            uow.DataMataUang.Update(oDBData);

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

        public bool RemoveMataUang(int id)
        {
            methodName = "RemoveMataUang";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        uow.DataMataUang.Remove(id);

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

        public int AddKurs(KursMataUang oData)
        {
            methodName = "AddKurs";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        KursMataUang oNewData = new KursMataUang();
                        oNewData.MapFrom(oData);
                        oNewData = uow.KursMataUang.Add(oNewData);
                        uow.Save();

                        oData.Id = oNewData.Id;
                        DataMataUang oDBMataUang = uow.DataMataUang.SingleOrDefault(m=> m.Id == oData.IdDataMataUang);
                        if (oDBMataUang != null)
                        {
                            oDBMataUang.KursTukar = oData.Exrate;
                            oDBMataUang.TglKursMataUang = oData.Tanggal;
                            uow.DataMataUang.Update(oDBMataUang);
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

        public bool EditKurs(KursMataUang oData)
        {
            methodName = "EditKurs";
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
                        uow.KursMataUang.Remove(id);

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
