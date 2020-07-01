using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IReceivedgoodRepo : IRepository<Receivedgood>
    {
        IEnumerable<Receivedgood> GetPaged(int pageIndex, int pageSize);
    }
}
