using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IDropdownPPTBarangRepo : IRepository<DropdownPPTBarang>
    {
        IEnumerable<DropdownPPTBarang> GetPaged(int pageIndex, int pageSize);
    }
}
