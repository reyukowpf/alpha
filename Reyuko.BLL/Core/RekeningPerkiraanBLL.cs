using Reyuko.BLL.Interface;
using Reyuko.DAL;
using Reyuko.DAL.Domain;
using Reyuko.Utils;
using Reyuko.Utils.Common;
using Reyuko.Utils.Error;
using System;

namespace Reyuko.BLL.Core
{
    public class RekeningPerkiraanBLL : BaseBLL, IRekeningPerkiraanBLL
    {
        private string methodName = "";
        private int traceID = 0;

        public int AddRekeningPerkiraan(RekeningPerkiraan oData, KlasifikasiAkun oKlasifikasi)
        {
            methodName = "AddRekeningPerkiraan";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        if (oData.IdKlasifikasiRekeningPerkiraan.GetValueOrDefault(0) == 0)
                        {
                            KlasifikasiAkun oNewKlasifikasi = new KlasifikasiAkun();
                            oNewKlasifikasi.KategoriKA = oData.NamaRekeningPerkiraan;
                            oNewKlasifikasi.IdParentKategoriKA = oKlasifikasi.Id;
                            oNewKlasifikasi.AkunLevel = 4;
                            oNewKlasifikasi.Kode = oData.KodeRekening;
                            oNewKlasifikasi.CheckboxLock = oData.CheckboxPasswordLock;
                            oNewKlasifikasi.LabaRugi = "";
                            oNewKlasifikasi = uow.KlasifikasiAkun.Add(oNewKlasifikasi);
                            uow.Save();

                            oData.IdKlasifikasiRekeningPerkiraan = oNewKlasifikasi.Id;
                            oData.KlasifikasiRekeningPerkiraan = oKlasifikasi.KategoriKA;
                        }
                        else
                        {
                            KlasifikasiAkun oDBKlasifikasi = uow.KlasifikasiAkun.Get(oData.IdKlasifikasiRekeningPerkiraan.GetValueOrDefault(0));
                            if (oDBKlasifikasi != null)
                            {
                                oDBKlasifikasi.KategoriKA = oData.KlasifikasiRekeningPerkiraan;
                                oDBKlasifikasi.Kode = oData.KodeRekening;
                                oDBKlasifikasi.CheckboxLock = oData.CheckboxPasswordLock;
                                uow.KlasifikasiAkun.Update(oDBKlasifikasi);
                                uow.Save();
                            }
                        }

                        RekeningPerkiraan oNewRekeningPerkiraan = new RekeningPerkiraan();
                        oNewRekeningPerkiraan.MapFrom(oData);
                        oNewRekeningPerkiraan = uow.RekeningPerkiraan.Add(oNewRekeningPerkiraan);
                        uow.Save();

                        traceID = 3;
                        oData.Id = oNewRekeningPerkiraan.Id;
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
        public bool EditRekening(RekeningPerkiraan oData)
        {
            methodName = "EditRekening";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.RekeningPerkiraan.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {
                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.RekeningPerkiraan.Update(oDBData);
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
        public bool EditRekeningPerkiraan(RekeningPerkiraan oData)
        {
            methodName = "EditRekeningPerkiraan";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                traceID = 2;
                var oDBData = uow.RekeningPerkiraan.Get(oData.Id);
                if (oDBData != null)
                {
                    using (var trans = uow.BeginTransaction())
                    {
                        try
                        {

                            KlasifikasiAkun oDBKlasifikasi = uow.KlasifikasiAkun.Get(oData.IdKlasifikasiRekeningPerkiraan.GetValueOrDefault(0));
                            if (oDBKlasifikasi != null)
                            {
                                oDBKlasifikasi.KategoriKA = oData.NamaRekeningPerkiraan;
                                oDBKlasifikasi.Kode = oData.KodeRekening;
                                oDBKlasifikasi.CheckboxLock = oData.CheckboxPasswordLock;
                                uow.KlasifikasiAkun.Update(oDBKlasifikasi);
                                uow.Save();
                            }

                            traceID = 3;
                            oDBData.MapFrom(oData);
                            uow.RekeningPerkiraan.Update(oDBData);
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

        public bool RemoveRekeningPerkiraan(int id, int idReplace)
        {
            methodName = "RemoveRekeningPerkiraan";
            traceID = 1;

            using (var uow = new UnitOfWork(AppConfig.Current.ContextName))
            {
                using (var trans = uow.BeginTransaction())
                {
                    try
                    {
                        traceID = 2;
                        RekeningPerkiraan oDBRekeningPerkiraan = uow.RekeningPerkiraan.SingleOrDefault(m => m.Id == id);
                        if (oDBRekeningPerkiraan != null)
                        {
                            traceID = 3;
                            oDBRekeningPerkiraan.CheckboxTidakAktif = true;
                            uow.RekeningPerkiraan.Update(oDBRekeningPerkiraan);
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
