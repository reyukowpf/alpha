using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class RadiobuttonrekperRepo : Repository<Radiobuttonrekper>, IRadiobuttonrekperRepo
    {

        public RadiobuttonrekperRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<Radiobuttonrekper> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.Radiobuttonrekper
                .OrderByDescending(m => m.IdRadioButtonRekper)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public ReyukoContext ReyukoContext
        {
            get { return _context as ReyukoContext; }
        }


    }
}
