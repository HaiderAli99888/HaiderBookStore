using HaiderBookStore.DataAccess.Data;
using HaidersBooks.DataAccess.Repository.IRespository;
using HaidersBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HaidersBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository

    {
        public string Name { get; private set; }
        public int Id { get; private set; }

        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

  

        public void Update(CategoryRepository category)
        {
            // use .NET LINQ to retrieve the first or default category object,
            // then pass the id as a generic entity which matches the category ID
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);

            if (objFromDb != null) // save changes if not null
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }

}
