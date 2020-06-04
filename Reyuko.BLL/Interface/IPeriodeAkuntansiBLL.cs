using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IPeriodeAkuntansiBLL
    {
        int AddPeriodeAkuntansi(PeriodeAkuntansi oData);
        bool EditPeriodeAkuntansi(PeriodeAkuntansi oData);
        bool RemovePeriodeAkuntansi(int id);

    }
}
