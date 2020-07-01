using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface INoteTypeRepo : IRepository<NoteType>
    {
        IEnumerable<NoteType> GetPaged(int pageIndex, int pageSize);
    }
}
