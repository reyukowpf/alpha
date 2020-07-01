using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IOptionAnnualRepo : IRepository<OptionAnnual>
    {
        IEnumerable<OptionAnnual> GetPaged(int pageIndex, int pageSize);

    }
}
