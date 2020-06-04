using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IPermPenyTransferBarangBLL
    {
        int AddPermPenyTransferBarang(PermPenyTransferBarang oData);
        bool EditPermPenyTransferBarang(PermPenyTransferBarang oData);
        bool RemovePermPenyTransferBarang(int id);
        int AddOrderInventori(OrderInventori oData);
        bool EditInventory(OrderInventori oData, PermPenyTransferBarang oDatas);

    }
}
