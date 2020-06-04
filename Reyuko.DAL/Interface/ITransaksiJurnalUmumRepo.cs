using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface ITransaksiJurnalUmumRepo : IRepository<TransaksiJurnalUmum>
    {
        IEnumerable<TransaksiJurnalUmum> GetPaged(int pageIndex, int pageSize);
       
    }
}
