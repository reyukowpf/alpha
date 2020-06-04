using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class ProductionBLL : BaseBLL, IProductionBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddProduction(production oData)
        {
            methodName = "AddProduction";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        production oNewProduction = new production();
                        oNewProduction.MapFrom(oData);
                        oNewProduction = uow.Production.Add(oNewProduction);
                        uow.Save();

                        traceID = 3;
                        oData.Id = oNewProduction.Id;
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

        public bool EditProduction(production oData)
        {
            methodName = "EditProduction";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.Production.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.Production.Update(oDBData);
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

        public bool RemoveProduction(int id)
        {
            methodName = "RemoveProduction";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        production oDBProduction = uow.Production.SingleOrDefault(m => m.Id == id);
                        if (oDBProduction != null)
                        {
                            traceID = 3;
                            uow.Production.Remove(id);
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

        public int AddOrderProdutioninput(OrderProductioninput oData)
        {
            methodName = "AddOrderProductioninput";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        OrderProductioninput oNewumum = new OrderProductioninput();
                        oNewumum.MapFrom(oData);
                        oNewumum = uow.OrderProductioninput.Add(oNewumum);
                        uow.Save();

                        traceID = 3;
                        oData.IdOrderProduction = oNewumum.IdOrderProduction;
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new AppException(500, methodName, traceID, ex);
                    }
                }
            }

            return oData.IdOrderProduction;
        }
        public bool EditProductioninput(OrderProductioninput oData, production oDatas)
        {
            methodName = "EditProductioninput";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.OrderProductioninput.Get(oData.IdOrderProduction);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.OrderProductioninput.Update(oDBData);

                            traceID = 6;
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
        public int AddOrderProdutioncustom(OrderProductioncustom oData)
        {
            methodName = "AddOrderProductioncustom";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        OrderProductioncustom oNewumum = new OrderProductioncustom();
                        oNewumum.MapFrom(oData);
                        oNewumum = uow.OrderProductioncustom.Add(oNewumum);
                        uow.Save();

                        traceID = 3;
                        oData.IdOrderProductionCustom = oNewumum.IdOrderProductionCustom;
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new AppException(500, methodName, traceID, ex);
                    }
                }
            }

            return oData.IdOrderProductionCustom;
        }
        public bool EditProductioncustom(OrderProductioncustom oData, production oDatas)
        {
            methodName = "EditProductioncustom";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.OrderProductioncustom.Get(oData.IdOrderProductionCustom);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.OrderProductioncustom.Update(oDBData);

                            traceID = 6;
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
        public int AddOrderFinishedproduk(OrderFinishedproduk oData)
        {
            methodName = "AddOrderFinishedproduk";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        OrderFinishedproduk oNewumum = new OrderFinishedproduk();
                        oNewumum.MapFrom(oData);
                        oNewumum = uow.OrderFinishedproduk.Add(oNewumum);
                        uow.Save();

                        traceID = 3;
                        oData.IdOrderFinishProduk = oNewumum.IdOrderFinishProduk;
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new AppException(500, methodName, traceID, ex);
                    }
                }
            }

            return oData.IdOrderFinishProduk;
        }
        public bool EditFinishedproduk(OrderFinishedproduk oData, production oDatas)
        {
            methodName = "EditFinishedproduk";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.OrderFinishedproduk.Get(oData.IdOrderFinishProduk);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.OrderFinishedproduk.Update(oDBData);

                            traceID = 6;
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
    }
}
