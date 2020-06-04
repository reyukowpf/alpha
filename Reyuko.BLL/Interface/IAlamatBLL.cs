using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IAlamatBLL
    {
        int AddAlamat(Alamat oData);
        bool EditAlamat(Alamat oData);
        bool RemoveAlamat(int id);

    }
}
