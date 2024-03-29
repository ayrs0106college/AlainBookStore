﻿using AlainBookStore.DataAccess.Repository.IRepository;
using AlainBookStore.Models;
using AlainBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlainBookStore.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(CoverType coverType)
        {
            var objFromDb = _db.CoverType.FirstOrDefault(s => s.Id == coverType.Id);
            if(objFromDb!=null)
            {
                objFromDb.Name = coverType.Name;
            }
        }
    }
}