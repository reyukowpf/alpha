using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class DataDepartemenBLL : BaseBLL, IDataDepartemenBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddDataDepartemen(DataDepartemen oData)
        {
            methodName = "AddDataDepartemen";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        DataDepartemen oNewDataDepartemen = new DataDepartemen();
                        oNewDataDepartemen.MapFrom(oData);
                        oNewDataDepartemen = uow.DataDepartemen.Add(oNewDataDepartemen);
                        uow.Save();

                        traceID = 3;
                        oData.Id = oNewDataDepartemen.Id;
                        if (oData.Id > 0)
                        {
                            traceID = 4;
                            ListDataDepartemen oNewListDataDepartemen = new ListDataDepartemen();
                            oNewListDataDepartemen.MapFrom(oData);
                            oNewListDataDepartemen.IdDepartemen = oData.Id;
                            uow.ListDataDepartemen.Add(oNewListDataDepartemen);
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

        public bool EditDataDepartemen(DataDepartemen oData)
        {
            methodName = "EditDataDepartemen";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.DataDepartemen.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.DataDepartemen.Update(oDBData);

                            traceID = 4;
                            var oDBListData = uow.ListDataDepartemen.SingleOrDefault(m => m.IdDepartemen == oData.Id);
                            if (oDBListData != null)
                            {
                                traceID = 5;
                                oDBListData.NamaDepartemen = oData.NamaDepartemen;
                                oDBListData.IdDepartemen = oData.Id;
                                oDBListData.PenanggungJawab = oData.PenanggungJawab;

                                traceID = 6;
                                uow.ListDataDepartemen.Update(oDBListData);
                            }
                            else
                            {
                                ListDataDepartemen oNewListDataDepartemen = new ListDataDepartemen();
                                oNewListDataDepartemen.MapFrom(oData);
                                oNewListDataDepartemen.IdDepartemen = oData.Id;
                                uow.ListDataDepartemen.Add(oNewListDataDepartemen);
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

        public bool RemoveDataDepartemen(int id)
        {
            methodName = "RemoveDataDepartemen";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        DataDepartemen oDBDataDepartemen = uow.DataDepartemen.SingleOrDefault(m => m.Id == id);
                        if (oDBDataDepartemen != null)
                        {
                            traceID = 3;
                            uow.DataDepartemen.Remove(id);

                            var oDBListDataDepartemen = uow.ListDataDepartemen.SingleOrDefault(m => m.IdDepartemen == id);
                            if (oDBListDataDepartemen != null)
                                uow.ListDataDepartemen.Remove(oDBListDataDepartemen.Id);

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
