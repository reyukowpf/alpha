using System.Collections.Generic;
using Reyuko.DAL.Domain;

namespace Reyuko.DAL.Interface
{
    public interface IDropdownBankKasRepo : IRepository<DropdownBankKas>
    {
        IEnumerable<DropdownBankKas> GetPaged(int pageIndex, int pageSize);
    }
}
