using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface ITypelistRepo : IRepository<Typelist>
    {
        IEnumerable<Typelist> GetPaged(int pageIndex, int pageSize);
    }
}
