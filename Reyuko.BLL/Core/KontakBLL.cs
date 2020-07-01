using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class KontakBLL : BaseBLL, IKontakBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddKontak(Kontak oData)
        {
            methodName = "AddKontak";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        Kontak oNewKontak = new Kontak();
                        oNewKontak.MapFrom(oData);
                        oNewKontak = uow.Kontak.Add(oNewKontak);
                        uow.Save();

                        traceID = 3;
                        oData.Id = oNewKontak.Id;
                        if (oData.Id > 0)
                        {
                            traceID = 4;
                            ListKontak oNewListKontak = new ListKontak();
                            oNewListKontak.MapFrom(oData);
                            oNewListKontak.IdKontak = oData.Id;
                            uow.ListKontak.Add(oNewListKontak);
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

        public bool EditKontak(Kontak oData)
        {
            methodName = "EditKontak";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.Kontak.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.Kontak.Update(oDBData);

                            traceID = 4;
                            var oDBListData = uow.ListKontak.SingleOrDefault(m => m.IdKontak == oData.Id);
                            if (oDBListData != null)
                            {
                                traceID = 5;
                                int idListKontak = oDBListData.Id;
                                oDBListData.MapFrom(oData);
                                oDBListData.Id = idListKontak;
                                oDBListData.IdKontak = oData.Id;

                                traceID = 6;
                                uow.ListKontak.Update(oDBListData);
                            }
                            else
                            {
                                ListKontak oNewListKontak = new ListKontak();
                                oNewListKontak.MapFrom(oData);
                                oNewListKontak.IdKontak = oData.Id;
                                uow.ListKontak.Add(oNewListKontak);
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

        public bool RemoveKontak(int id)
        {
            methodName = "RemoveKontak";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        Kontak oDBKontak = uow.Kontak.SingleOrDefault(m => m.Id == id);
                        if (oDBKontak != null)
                        {
                            traceID = 3;
                            uow.Kontak.Remove(id);

                            var oDBListKontak = uow.ListKontak.SingleOrDefault(m => m.IdKontak == id);
                            if (oDBListKontak != null)
                                uow.ListKontak.Remove(oDBListKontak.Id);

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
