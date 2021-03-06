﻿using SecondProjectEFCoreAttributes.Contexts;
using SecondProjectEFCoreAttributes.InferaStructure.IRepositories;
using System.Collections.Generic;
using System.Linq;

namespace SecondProjectEFCoreAttributes.InferaStructure.Repositories
{
    public class TagRepository : ITagRepository
    {
        private readonly ProjectContext _db;

        public TagRepository(ProjectContext db)
        {
            _db = db;
        }
        public int DeleteById(int id)
        {
            var result = _db.Tag.Where(x => x.VendorId == id).FirstOrDefault();
            _db.Tag.Remove(result);
            return _db.SaveChanges();
        }
    }
}
