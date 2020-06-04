using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IShopingchartRepo : IRepository<Shopingchart>
    {
        IEnumerable<Shopingchart> GetPaged(int pageIndex, int pageSize);
    }
}
