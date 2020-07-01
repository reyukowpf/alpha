using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IDokumenBLL
    {
        int AddDokumen(Dokumen oData);
        bool EditDokumen(Dokumen oData);
        bool RemoveDokumen(int id);

    }
}
