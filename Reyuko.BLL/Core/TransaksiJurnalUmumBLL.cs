using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class TransaksiJurnalUmumBLL : BaseBLL, ITransaksiJurnalUmumBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddTransaksiJurnalUmum(TransaksiJurnalUmum oData)
        {
            methodName = "AddTransaksiJurnalUmum";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        TransaksiJurnalUmum oNewData = new TransaksiJurnalUmum();
                        oNewData.MapFrom(oData);
                        oNewData = uow.TransaksiJurnalUmum.Add(oNewData);
                        uow.Save();

                        oData.IdTransaksiJurnalUmum = oNewData.IdTransaksiJurnalUmum;
                        OrderJurnalUmum oDBMataUang = uow.OrderJurnalUmum.SingleOrDefault(m => m.IdTransaksiJurnalUmum == oData.IdTransaksiJurnalUmum);
                        if (oDBMataUang != null)
                        {
                            oDBMataUang.MapFrom(oData);
                             oDBMataUang.IdTransaksiJurnalUmum = oData.IdTransaksiJurnalUmum;
                            //        oDBMataUang.TglKursMataUang = oData.Tanggal;
                            uow.OrderJurnalUmum.Update(oDBMataUang);
                        }

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

            return oData.IdTransaksiJurnalUmum;
        }

        public bool EditTransaksiJurnalUmum(TransaksiJurnalUmum oData)
        {
            methodName = "EditTransaksiJurnalUmum";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.TransaksiJurnalUmum.Get(oData.IdTransaksiJurnalUmum);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.TransaksiJurnalUmum.Update(oDBData);
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

        public bool RemoveTransaksiJurnalUmum(int id)
        {
            methodName = "RemoveTransaksiJurnalUmum";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        TransaksiJurnalUmum oDBTransaksiJurnalUmum = uow.TransaksiJurnalUmum.SingleOrDefault(m => m.IdTransaksiJurnalUmum == id);
                        if (oDBTransaksiJurnalUmum != null)
                        {
                            traceID = 3;
                            uow.TransaksiJurnalUmum.Remove(id);
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
        public int AddJurnalUmum(OrderJurnalUmum oData)
        {
            methodName = "AddJurnalUmum";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        OrderJurnalUmum oNewumum = new OrderJurnalUmum();
                        oNewumum.MapFrom(oData);
                        oNewumum = uow.OrderJurnalUmum.Add(oNewumum);
                        uow.Save();

                        traceID = 3;
                        oData.IdOrderJurnalUmum = oNewumum.IdOrderJurnalUmum;
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new AppException(500, methodName, traceID, ex);
                    }
                }
            }

            return oData.IdOrderJurnalUmum;
        }
        public bool EditJurnalUmum(OrderJurnalUmum oData, TransaksiJurnalUmum oDatas)
        {
            methodName = "EditJurnalUmum";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.OrderJurnalUmum.Get(oData.IdOrderJurnalUmum);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.OrderJurnalUmum.Update(oDBData);

                            if (oDBData.IdOrderJurnalUmum > 0)
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
                            }

                         
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
