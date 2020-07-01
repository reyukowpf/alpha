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

                        if (oNewumum.IdOrderProduction > 0)
                        {
                            traceID = 3;
                            oData.IdOrderProduction = oNewumum.IdOrderProduction;
                            ListOrderProduction oNewListOrderJual = new ListOrderProduction();
                            oNewListOrderJual.MapFrom(oData);

                            traceID = 4;
                            oNewListOrderJual.IdOrder = oData.IdOrderProduction;
                            oNewListOrderJual.Jumlah = oData.JumlahProduk;
                            oNewListOrderJual.TotalOrder = oData.TotalOrderProduk;
                            uow.ListOrderProduction.Add(oNewListOrderJual);
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

            return oData.IdOrderProduction;
        }
        public bool EditProductioninput(ListOrderProduction oData, production oDatas)
        {
            methodName = "EditProductioninput";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.ListOrderProduction.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.ListOrderProduction.Update(oDBData);

                            traceID = 4;
                            OrderProductioninput oDBListorderjual = uow.OrderProductioninput.SingleOrDefault(m => m.IdOrderProduction == oData.IdOrder);
                            if (oDBListorderjual != null)
                            {
                                traceID = 5;
                                oDBListorderjual.MapFrom(oData);

                                traceID = 6;
                                uow.OrderProductioninput.Update(oDBListorderjual);
                            }
                            else
                            {
                                traceID = 7;
                                OrderProductioninput oNewListorderjual = new OrderProductioninput();
                                oNewListorderjual.MapFrom(oData);

                                traceID = 8;
                                uow.OrderProductioninput.Add(oNewListorderjual);
                            }
                            traceID = 9;
                            OrderProductioncustom oDBListorderjual1 = uow.OrderProductioncustom.SingleOrDefault(m => m.IdOrderProductionCustom == oData.IdOrder);
                            if (oDBListorderjual1 != null)
                            {
                                traceID = 10;
                                oDBListorderjual1.MapFrom(oData);

                                traceID = 11;
                                uow.OrderProductioncustom.Update(oDBListorderjual1);
                            }
                            else
                            {
                                traceID = 12;

                                traceID = 13;
                            }
                            traceID = 14;
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

                        if (oNewumum.IdOrderProductionCustom > 0)
                        {
                            traceID = 3;
                            oData.IdOrderProductionCustom = oNewumum.IdOrderProductionCustom;
                            ListOrderProduction oNewListOrderJual = new ListOrderProduction();
                            oNewListOrderJual.MapFrom(oData);

                            traceID = 4;
                            oNewListOrderJual.IdOrder = oData.IdOrderProductionCustom;
                           // oNewListOrderJual.Jumlah = oData.JumlahCustom;
                            oNewListOrderJual.Sku = oData.NamaCustom;
                        //    oNewListOrderJual.HargaPokok = oData.HargaCustom;
                          //  oNewListOrderJual.SatuanDasar = oData.SatuanCustom;
                            oNewListOrderJual.TotalOrder = oData.TotalCustom;
                            uow.ListOrderProduction.Add(oNewListOrderJual);
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

            return oData.IdOrderProductionCustom;
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
