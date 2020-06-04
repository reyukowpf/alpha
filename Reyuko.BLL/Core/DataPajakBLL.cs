using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class DataPajakBLL : BaseBLL, IDataPajakBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddPajak(DataPajak oData)
        {
            methodName = "AddPajak";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        DataPajak oNewDataPajak = new DataPajak();
                        oNewDataPajak.MapFrom(oData);
                        oNewDataPajak = uow.DataPajak.Add(oNewDataPajak);
                        uow.Save();

                        if (oNewDataPajak.Id > 0)
                        {
                            traceID = 3;
                            oData.Id = oNewDataPajak.Id;
                            ListDataPajak oNewListDataPajak = new ListDataPajak();
                            oNewListDataPajak.MapFrom(oData);

                            traceID = 4;
                            oNewListDataPajak.IdPajak = oData.Id;
                            uow.ListDataPajak.Add(oNewListDataPajak);
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

        public bool EditPajak(DataPajak oData)
        {
            methodName = "EditPajak";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.DataPajak.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.DataPajak.Update(oDBData);

                            traceID = 4;
                            ListDataPajak oDBListDataPajak = uow.ListDataPajak.SingleOrDefault(m => m.IdPajak == oData.Id);
                            if(oDBListDataPajak != null)
                            {
                                traceID = 5;
                                oDBListDataPajak.MapFrom(oData);

                                traceID = 6;
                                uow.ListDataPajak.Update(oDBListDataPajak);
                            }
                            else
                            {
                                traceID = 7;
                                ListDataPajak oNewListDataPajak = new ListDataPajak();
                                oNewListDataPajak.MapFrom(oData);

                                traceID = 8;
                                uow.ListDataPajak.Add(oNewListDataPajak);
                            }

                            traceID = 9;
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

        public bool RemovePajak(int id)
        {
            methodName = "RemovePajak";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        DataPajak oDBDataPajak = uow.DataPajak.SingleOrDefault(m => m.Id == id);
                        if (oDBDataPajak != null)
                        {
                            traceID = 3;
                            uow.ListDataPajak.Remove(m => m.IdPajak == id);

                            traceID = 4;
                            uow.DataPajak.Remove(id);
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

            return true;
        }


    }
}
