using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface ITermspembayaranBLL
    {
        int AddTermPembayaran(Termspembayaran oData);
        bool EditTermPembayaran(Termspembayaran oData);
        bool RemoveTermPembayaran(int id);

    }
}
