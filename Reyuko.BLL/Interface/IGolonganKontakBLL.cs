using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IGolonganKontakBLL
    {
        int AddGolonganKontak(GolonganKontak oData);
        bool EditGolonganKontak(GolonganKontak oData);
        bool RemoveGolonganKontak(int id);

    }
}
