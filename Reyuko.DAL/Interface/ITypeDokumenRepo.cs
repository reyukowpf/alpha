using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface ITypeDokumenRepo : IRepository<TypeDokumen>
    {
        IEnumerable<TypeDokumen> GetPaged(int pageIndex, int pageSize);
    }
}
