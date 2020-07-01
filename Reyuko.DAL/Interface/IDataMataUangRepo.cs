using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IDataMataUangRepo : IRepository<DataMataUang>
    {
        IEnumerable<DataMataUang> GetPaged(int pageIndex, int pageSize);
    }
}
