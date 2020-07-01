using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class RppBLL : BaseBLL, IRppBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddRpp(Rpp oData)
        {
            methodName = "AddRpp";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        Rpp oNewRpp = new Rpp();
                        oNewRpp.MapFrom(oData);
                        oNewRpp = uow.Rpp.Add(oNewRpp);
                        uow.Save();

                        traceID = 3;
                        oData.IdRpp = oNewRpp.IdRpp;
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new AppException(500, methodName, traceID, ex);
                    }
                }
            }

            return oData.IdRpp;
        }

        public bool EditRpp(Rpp oData)
        {
            methodName = "EditRpp";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.Rpp.Get(oData.IdRpp);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.Rpp.Update(oDBData);
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

        public bool RemoveRpp(int id)
        {
            methodName = "RemoveRpp";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        Rpp oDBRpp = uow.Rpp.SingleOrDefault(m => m.IdRpp == id);
                        if (oDBRpp != null)
                        {
                            traceID = 3;
                            uow.CashActivity.Remove(id);
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

        public int Addtranscash(OrderTransaksiCash oData)
        {
            methodName = "Addtranscash";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        OrderTransaksiCash oNewumum = new OrderTransaksiCash();
                        oNewumum.MapFrom(oData);
                        oNewumum = uow.OrderTransaksiCash.Add(oNewumum);
                        uow.Save();

                        traceID = 3;
                        oData.IdOrderTransaksiCash = oNewumum.IdOrderTransaksiCash;
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new AppException(500, methodName, traceID, ex);
                    }
                }
            }

            return oData.IdOrderTransaksiCash;
        }
        public bool Edittranscash(OrderTransaksiCash oData, Rpp oDatas)
        {
            methodName = "Edittranscash";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.OrderTransaksiCash.Get(oData.IdOrderTransaksiCash);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.OrderTransaksiCash.Update(oDBData);

                         /*   if (oDBData.IdOrderJurnalUmum > 0)
                            {
                                traceID = 4;
                                oData.IdOrderJurnalUmum = oDBData.IdOrderJurnalUmum;
                                BukuBesar oNewTransjurnal = new BukuBesar();
                                oNewTransjurnal.MapFrom(oData);

                                traceID = 5;
                                oNewTransjurnal.IdRekeningPerkiraan = oData.IdRekeningPerkiraan;
                                oNewTransjurnal.NoRekningPerkiraan = oData.NoRekeningPerkiraan;
                                oNewTransjurnal.KodeTransaksi = "GJ";
                                oNewTransjurnal.IdKlasfikasi = oData.IdKlasifikasi;
                                oNewTransjurnal.KlasifikasiAkun = oData.KlasifikasiRekeningPerkiraan;
                                oNewTransjurnal.Deskripsi = oData.Keterangan;
                                oNewTransjurnal.KursTukar = oData.Kurs;
                                oNewTransjurnal.IdUserId = oData.IdUserId;
                                oNewTransjurnal.IdPeriodeAkuntansi = oData.IdPeriodeAkuntasi;
                                oNewTransjurnal.IdEmployee = oData.IdPetugas;
                                oNewTransjurnal.RealRecordingTime = DateTime.Now;
                                uow.BukuBesar.Add(oNewTransjurnal);
                            }*/


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
