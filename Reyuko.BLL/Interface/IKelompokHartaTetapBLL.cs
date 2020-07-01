using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IKelompokHartaTetapBLL
    {
        int AddKelompokHartaTetap(KelompokHartaTetap oData);
        bool EditKelompokHartaTetap(KelompokHartaTetap oData);
        bool RemoveKelompokHartaTetap(int id);

    }
}
