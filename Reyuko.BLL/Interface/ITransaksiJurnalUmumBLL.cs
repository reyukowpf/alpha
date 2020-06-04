using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface ITransaksiJurnalUmumBLL
    {
        int AddTransaksiJurnalUmum(TransaksiJurnalUmum oData);
        bool EditTransaksiJurnalUmum(TransaksiJurnalUmum oData);
        bool RemoveTransaksiJurnalUmum(int id);
        int AddJurnalUmum(OrderJurnalUmum oData);
        bool EditJurnalUmum(OrderJurnalUmum oData, TransaksiJurnalUmum oDatas);
       
    }
}
