using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IOrderJurnalUmumRepo : IRepository<OrderJurnalUmum>
    {
        IEnumerable<OrderJurnalUmum> GetPaged(int pageIndex, int pageSize);
       
    }
}
