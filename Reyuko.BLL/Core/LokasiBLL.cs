using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class LokasiBLL : BaseBLL, ILokasiBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddLokasi(Lokasi oData)
        {
            methodName = "AddLokasi";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        Lokasi oNewLokasi = new Lokasi();
                        oNewLokasi.MapFrom(oData);
                        oNewLokasi = uow.Lokasi.Add(oNewLokasi);
                        uow.Save();

                        traceID = 3;
                        oData.Id = oNewLokasi.Id;
                        if (oData.Id > 0)
                        {
                            traceID = 4;
                            ListLokasi oNewListLokasi = new ListLokasi();
                            oNewListLokasi.MapFrom(oData);
                            oNewListLokasi.IdLokasi = oData.Id;
                            oNewListLokasi.NegaraLokasi = oData.NamaNegara;
                            uow.ListLokasi.Add(oNewListLokasi);
                        }

                        traceID = 5;
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

        public bool EditLokasi(Lokasi oData)
        {
            methodName = "EditLokasi";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.Lokasi.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.Lokasi.Update(oDBData);

                            traceID = 4;
                            var oDBListData = uow.ListLokasi.SingleOrDefault(m => m.IdLokasi == oData.Id);
                            if (oDBListData != null)
                            {
                                traceID = 5;
                                int idListLokasi = oDBListData.Id;
                                oDBListData.MapFrom(oData);
                                oDBListData.Id = idListLokasi;
                                oDBListData.IdLokasi = oData.Id;
                                oDBListData.NegaraLokasi = oData.NamaNegara; 

                                traceID = 6;
                                uow.ListLokasi.Update(oDBListData);
                            }
                            else
                            {
                                ListLokasi oNewListLokasi = new ListLokasi();
                                oNewListLokasi.MapFrom(oData);
                                oNewListLokasi.IdLokasi = oData.Id;
                                oNewListLokasi.NegaraLokasi = oData.NamaNegara;
                                uow.ListLokasi.Add(oNewListLokasi);
                            }

                            traceID = 7;
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

        public bool RemoveLokasi(int id)
        {
            methodName = "RemoveLokasi";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        Lokasi oDBLokasi = uow.Lokasi.SingleOrDefault(m => m.Id == id);
                        if (oDBLokasi != null)
                        {
                            traceID = 3;
                            uow.Lokasi.Remove(id);

                            var oDBListLokasi = uow.ListLokasi.SingleOrDefault(m => m.IdLokasi == id);
                            if (oDBListLokasi != null)
                                uow.ListLokasi.Remove(oDBListLokasi.Id);

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
