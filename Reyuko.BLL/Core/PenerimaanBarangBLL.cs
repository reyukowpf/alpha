using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class PenerimaanBarangBLL : BaseBLL, IPenerimaanBarangBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddPenerimaanBarang(PenerimaanBarang oData)
        {
            methodName = "AddPenerimaanBarang";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        PenerimaanBarang oNewPenerimaanBarang = new PenerimaanBarang();
                        oNewPenerimaanBarang.MapFrom(oData);
                        oNewPenerimaanBarang = uow.PenerimaanBarang.Add(oNewPenerimaanBarang);
                        uow.Save();

                        traceID = 3;
                        oData.IdPenerimaanBarangKonsinyasi = oNewPenerimaanBarang.IdPenerimaanBarangKonsinyasi;
                        if (oData.IdPenerimaanBarangKonsinyasi > 0)
                        {
                            traceID = 4;
                            ListKonsinyasi oNewListKonsinyasi = new ListKonsinyasi();
                            oNewListKonsinyasi.MapFrom(oData);
                            oNewListKonsinyasi.IdPenerimaanRetur = 1;
                            oNewListKonsinyasi.PenerimaanRetur = "Received";
                            oNewListKonsinyasi.NoKonsinyasi = oData.NoPenerimaanBarangKonsinyasi;
                            uow.ListKonsinyasi.Add(oNewListKonsinyasi);
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

            return oData.IdPenerimaanBarangKonsinyasi;
        }

        public bool EditPenerimaanBarang(PenerimaanBarang oData)
        {
            methodName = "EditPenerimaanBarang";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.PenerimaanBarang.Get(oData.IdPenerimaanBarangKonsinyasi);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.PenerimaanBarang.Update(oDBData);
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

        public bool RemovePenerimaanBarang(int id)
        {
            methodName = "RemovePenerimaanBarang";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        PenerimaanBarang oDBPenerimaanBarang = uow.PenerimaanBarang.SingleOrDefault(m => m.IdPenerimaanBarangKonsinyasi == id);
                        if (oDBPenerimaanBarang != null)
                        {
                            traceID = 3;
                            uow.PenerimaanBarang.Remove(id);
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

        public int AddOrderInventori(OrderInventori oData)
        {
            methodName = "AddOrderInventori";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        OrderInventori oNewumum = new OrderInventori();
                        oNewumum.MapFrom(oData);
                        oNewumum = uow.OrderInventori.Add(oNewumum);
                        uow.Save();

                        traceID = 3;
                        oData.IdOrderInventori = oNewumum.IdOrderInventori;
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new AppException(500, methodName, traceID, ex);
                    }
                }
            }

            return oData.IdOrderInventori;
        }
        public bool EditInventory(OrderInventori oData, PenerimaanBarang oDatas)
        {
            methodName = "EditInventory";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.OrderInventori.Get(oData.IdOrderInventori);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.OrderInventori.Update(oDBData);

              /*              if (oDBData.IdOrderInventori > 0)
                            {
                                traceID = 4;
                                oData.IdOrderInventori = oDBData.IdOrderInventori;
                                BukuBesar oNewinventori = new BukuBesar();
                                oNewinventori.MapFrom(oData);

                                traceID = 5;
                                oNewinventori.IdRekeningPerkiraan = oData.IdRekeningPerkiraan;
                                oNewinventori.NoRekningPerkiraan = oData.NoRekeningPerkiraan;
                                oNewinventori.KodeTransaksi = "GJ";
                                oNewinventori.IdKlasfikasi = oData.IdKlasifikasi;
                                oNewinventori.KlasifikasiAkun = oData.KlasifikasiRekeningPerkiraan;
                                oNewinventori.Deskripsi = oData.Keterangan;
                                oNewinventori.KursTukar = oData.Kurs;
                                oNewinventori.IdUserId = oData.IdUserId;
                                oNewinventori.IdPeriodeAkuntansi = oData.IdPeriodeAkuntasi;
                                oNewinventori.IdEmployee = oData.IdPetugas;
                                oNewinventori.RealRecordingTime = DateTime.Now;
                                uow.BukuBesar.Add(oNewinventori);
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

