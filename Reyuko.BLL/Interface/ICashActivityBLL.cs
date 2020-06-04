using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface ICashActivityBLL
    {
        int AddCashActivity(CashActivity oData);
        bool EditCashActivity(CashActivity oData);
        bool RemoveCashActivity(int id);
        int Addtranscash(OrderTransaksiCash oData);
        bool Edittranscash(OrderTransaksiCash oData, CashActivity oDatas);
    }
}
