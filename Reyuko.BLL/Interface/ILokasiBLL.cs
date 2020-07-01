using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface ILokasiBLL
    {
        int AddLokasi(Lokasi oData);
        bool EditLokasi(Lokasi oData);
        bool RemoveLokasi(int id);

    }
}
