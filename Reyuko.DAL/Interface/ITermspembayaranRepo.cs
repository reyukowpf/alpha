using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface ITermspembayaranRepo : IRepository<Termspembayaran>
    {
        IEnumerable<Termspembayaran> GetPaged(int pageIndex, int pageSize);
    }
}
