using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IDokumenRepo : IRepository<Dokumen>
    {
        IEnumerable<Dokumen> GetPaged(int pageIndex, int pageSize);
       
    }
}
