using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IDataHartaTetapBLL
    {
        int AddDataHartaTetap(DataHartaTetap oData);
        bool EditDataHartaTetap(DataHartaTetap oData);
        bool RemoveDataHartaTetap(int id);

        int AddKelompok(KelompokHartaTetap oData);
        bool EditKelompok(KelompokHartaTetap oData);
        bool RemoveKurs(int id);



    }
}
