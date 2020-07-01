using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class ReturBarangBLL : BaseBLL, IReturBarangBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddReturBarang(ReturBarang oData)
        {
            methodName = "AddReturBarang";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        ReturBarang oNewReturBarang = new ReturBarang();
                        oNewReturBarang.MapFrom(oData);
                        oNewReturBarang = uow.ReturBarang.Add(oNewReturBarang);
                        uow.Save();

                        traceID = 3;
                        oData.Id = oNewReturBarang.Id;
                        if (oData.Id > 0)
                        {
                            traceID = 4;
                            ListKonsinyasi oNewListKonsinyasi = new ListKonsinyasi();
                            oNewListKonsinyasi.MapFrom(oData);
                            oNewListKonsinyasi.IdPenerimaanRetur = 1;
                            oNewListKonsinyasi.PenerimaanRetur = "Return";
                            oNewListKonsinyasi.NoKonsinyasi = oData.NoReturBarangKonsinyasi;
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

            return oData.Id;
        }

        public bool EditReturBarang(ReturBarang oData)
        {
            methodName = "EditReturBarang";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.ReturBarang.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.ReturBarang.Update(oDBData);
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

        public bool RemoveReturBarang(int id)
        {
            methodName = "RemoveReturBarang";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        ReturBarang oDBReturBarang = uow.ReturBarang.SingleOrDefault(m => m.Id == id);
                        if (oDBReturBarang != null)
                        {
                            traceID = 3;
                            uow.ReturBarang.Remove(id);
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
        public bool EditInventory(OrderInventori oData, ReturBarang oDatas)
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

