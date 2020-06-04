using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IKontakBLL
    {
        int AddKontak(Kontak oData);
        bool EditKontak(Kontak oData);
        bool RemoveKontak(int id);

    }
}
