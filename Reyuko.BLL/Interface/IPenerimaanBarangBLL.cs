using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IPenerimaanBarangBLL
    {
        int AddPenerimaanBarang(PenerimaanBarang oData);
        bool EditPenerimaanBarang(PenerimaanBarang oData);
        bool RemovePenerimaanBarang(int id);
        int AddOrderInventori(OrderInventori oData);
        bool EditInventory(OrderInventori oData, PenerimaanBarang oDatas);

    }
}
