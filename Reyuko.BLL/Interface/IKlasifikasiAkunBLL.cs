using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IKlasifikasiAkunBLL
    {
        int AddKlasifikasiAkun(KlasifikasiAkun oData);
        bool EditKlasifikasiAkun(KlasifikasiAkun oData);
        bool RemoveKlasifikasiAkun(int id, int idReplace);

    }
}
