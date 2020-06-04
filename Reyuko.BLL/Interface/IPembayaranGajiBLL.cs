using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IPembayaranGajiBLL
    {
        int AddPembayaranGaji(PembayaranGaji oData);
        bool EditPembayaranGaji(PembayaranGaji oData);
        bool RemovePembayaranGaji(int id);
        int AddOrderPembayaranGaji(OrderPembayaranGaji oData);
        bool EditOrderPembayaranGaji(OrderPembayaranGaji oData, PembayaranGaji oDatas);
    }
}
