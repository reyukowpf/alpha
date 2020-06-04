using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class ReceivedGoodsBLL : BaseBLL, IReceivedGoodsBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddReceivedGoods(Receivedgood oData)
        {
            methodName = "AddReceivedGoods";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        Receivedgood oNewReceivedGoods = new Receivedgood();
                        oNewReceivedGoods.MapFrom(oData);
                        oNewReceivedGoods = uow.Receivedgood.Add(oNewReceivedGoods);
                        uow.Save();

                        traceID = 3;
                        oData.IdOrder = oNewReceivedGoods.IdOrder;
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new AppException(500, methodName, traceID, ex);
                    }
                }
            }

            return oData.IdOrder;
        }

        public bool EditReceivedGoods(Receivedgood oData)
        {
            methodName = "EditReceivedGoods";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.Receivedgood.Get(oData.IdOrder);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.Receivedgood.Update(oDBData);
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
        
        public bool RemoveReceivedGoods(int id)
        {
            methodName = "RemoveReceivedGoods";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        Receivedgood oDBReceivedGoods = uow.Receivedgood.SingleOrDefault(m => m.IdOrder == id);
                        if (oDBReceivedGoods != null)
                        {
                            traceID = 3;
                            uow.Receivedgood.Remove(id);
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
