using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IKodeTransaksiBLL
    {
        int AddKodeTransaksi(KodeTransaksi oData);
        bool EditKodeTransaksi(KodeTransaksi oData);
        bool RemoveKodeTransaksi(int id);

    }
}
