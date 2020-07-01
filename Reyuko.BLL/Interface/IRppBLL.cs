using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IRppBLL
    {
        int AddRpp(Rpp oData);
        bool EditRpp(Rpp oData);
        bool RemoveRpp(int id);
        int Addtranscash(OrderTransaksiCash oData);
        bool Edittranscash(OrderTransaksiCash oData, Rpp oDatas);
    }
}
