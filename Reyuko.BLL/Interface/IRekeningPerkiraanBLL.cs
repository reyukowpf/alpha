using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IRekeningPerkiraanBLL
    {
        int AddRekeningPerkiraan(RekeningPerkiraan oData, KlasifikasiAkun oKlasifikasi);
        bool EditRekeningPerkiraan(RekeningPerkiraan oData);
        bool RemoveRekeningPerkiraan(int id, int idReplace);

    }
}
