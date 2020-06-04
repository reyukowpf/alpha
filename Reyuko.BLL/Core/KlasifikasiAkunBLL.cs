using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class KlasifikasiAkunBLL : BaseBLL, IKlasifikasiAkunBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddKlasifikasiAkun(KlasifikasiAkun oData)
        {
            methodName = "AddKlasifikasiAkun";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        KlasifikasiAkun oNewKlasifikasiAkun = new KlasifikasiAkun();
                        oNewKlasifikasiAkun.MapFrom(oData);
                        oNewKlasifikasiAkun = uow.KlasifikasiAkun.Add(oNewKlasifikasiAkun);
                        uow.Save();

                        traceID = 3;
                        oData.Id = oNewKlasifikasiAkun.Id;
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

        public bool EditKlasifikasiAkun(KlasifikasiAkun oData)
        {
            methodName = "EditKlasifikasiAkun";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.KlasifikasiAkun.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.KlasifikasiAkun.Update(oDBData);
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

        public bool RemoveKlasifikasiAkun(int id, int idReplace)
        {
            methodName = "RemoveKlasifikasiAkun";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        var oChilds = uow.KlasifikasiAkun.Find(m => m.IdParentKategoriKA == id);
                        if (oChilds != null)
                        {
                            foreach(var oChild in oChilds)
                            {
                                var oDBData = uow.KlasifikasiAkun.Get(oChild.Id);
                                if (oDBData != null)
                                {
                                    oDBData.IdParentKategoriKA = idReplace;
                                    uow.KlasifikasiAkun.Update(oDBData);
                                    uow.Save();
                                }
                            }
                        }

                        KlasifikasiAkun oDBKlasifikasiAkun = uow.KlasifikasiAkun.SingleOrDefault(m => m.Id == id);
                        if (oDBKlasifikasiAkun != null)
                        {
                            traceID = 3;
                            uow.KlasifikasiAkun.Remove(id);
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
