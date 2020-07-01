using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface ITypeKontakRepo : IRepository<TypeKontak>
    {
        IEnumerable<TypeKontak> GetPaged(int pageIndex, int pageSize);
    }
}
