using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class ShopingchartBLL : BaseBLL, IShopingchartBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddShopingcharts(Shopingchart oData)
        {
            methodName = "AddShopingcharts";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        Shopingchart oNewShopingchart = new Shopingchart();
                        oNewShopingchart.MapFrom(oData);
                        oNewShopingchart = uow.Shopingchart.Add(oNewShopingchart);
                        uow.Save();

                        traceID = 3;
                        oData.IdPermintaanBarang = oNewShopingchart.IdPermintaanBarang;
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new AppException(500, methodName, traceID, ex);
                    }
                }
            }

            return oData.IdPermintaanBarang;
        }

        public bool EditShopingcharts(Shopingchart oData)
        {
            methodName = "EditShopingcharts";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.Shopingchart.Get(oData.IdPermintaanBarang);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.Shopingchart.Update(oDBData);
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
        
        public bool RemoveShopingcharts(int id)
        {
            methodName = "RemoveShopingcharts";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        Shopingchart oDBShopingchart = uow.Shopingchart.SingleOrDefault(m => m.IdPermintaanBarang == id);
                        if (oDBShopingchart != null)
                        {
                            traceID = 3;
                            uow.Shopingchart.Remove(id);
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
