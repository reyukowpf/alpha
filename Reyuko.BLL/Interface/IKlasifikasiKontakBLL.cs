using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IKlasifikasiKontakBLL
    {
        int AddKlasifikasiKontak(KlasifikasiKontak oData);
        bool EditKlasifikasiKontak(KlasifikasiKontak oData);
        bool RemoveKlasifikasiKontak(int id);

    }
}
