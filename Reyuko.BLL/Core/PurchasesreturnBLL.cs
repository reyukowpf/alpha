using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class PurchasereturnBLL : BaseBLL, IPurchasereturnBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddPurchasereturn(Purchasereturn oData)
        {
            methodName = "AddPurchasereturn";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        Purchasereturn oNewPurchasereturn = new Purchasereturn();
                        oNewPurchasereturn.MapFrom(oData);
                        oNewPurchasereturn = uow.PurchaseReturn.Add(oNewPurchasereturn);
                        uow.Save();

                        traceID = 3;
                        oData.IdReturPembelian = oNewPurchasereturn.IdReturPembelian;
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new AppException(500, methodName, traceID, ex);
                    }
                }
            }

            return oData.IdReturPembelian;
        }

        public bool EditPurchasereturn(Purchasereturn oData)
        {
            methodName = "EditPurchasereturn";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.PurchaseReturn.Get(oData.IdReturPembelian);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.PurchaseReturn.Update(oDBData);
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

        public bool RemovePurchasereturn(int id)
        {
            methodName = "RemovePurchasereturn";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        Purchasereturn oDBPurchasereturn = uow.PurchaseReturn.SingleOrDefault(m => m.IdReturPembelian == id);
                        if (oDBPurchasereturn != null)
                        {
                            traceID = 3;
                            uow.PurchaseReturn.Remove(id);
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

        public bool EditOrderCustomBeli(ListOrderBeli oData, Purchasereturn oDatas)
        {
            methodName = "EditOrderCustomBeli";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.ListOrderBeli.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.ListOrderBeli.Update(oDBData);

                            traceID = 4;
                            OrderCustomBeli oDBListorderbeli = uow.OrderCustomBeli.SingleOrDefault(m => m.IdOrderCustom == oData.IdOrderBeli);
                            if (oDBListorderbeli != null)
                            {
                                traceID = 5;
                                oDBListorderbeli.MapFrom(oData);

                                traceID = 6;
                                uow.OrderCustomBeli.Update(oDBListorderbeli);
                            }
                            else
                            {
                                traceID = 7;

                                traceID = 8;
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
    }
}
