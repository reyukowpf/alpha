using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IInternalNoteRepo : IRepository<InternalNote>
    {
        IEnumerable<InternalNote> GetPaged(int pageIndex, int pageSize);
       
    }
}
