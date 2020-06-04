﻿using System.Collections.Generic;
using System.Linq;
using Reyuko.DAL.Domain;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class NoteTypeRepo : Repository<NoteType>, INoteTypeRepo
    {

        public NoteTypeRepo(ReyukoContext context)
            : base(context)
        {

        }

        public IEnumerable<NoteType> GetPaged(int pageIndex, int pageSize = 10)
        {
            return ReyukoContext.NoteType
                .OrderByDescending(m => m.Id)
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
