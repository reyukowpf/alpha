using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface ISatuanDasarBLL
    {
        int AddSatuanDasar(SatuanDasar oData);
        bool EditSatuanDasar(SatuanDasar oData);
        bool RemoveSatuanDasar(int id);

    }
}
