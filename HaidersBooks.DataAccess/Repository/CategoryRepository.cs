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

            
        }

        public void Update(Category category)
        {
            // Retrieve the existing category from the database
            var categoryToUpdate = _db.Categories.FirstOrDefault(c => c.Id == category.Id);

            // Check if category exists
            if (categoryToUpdate != null)
            {
                // Update the properties of the existing category with the new values
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Id = category.Id;
                // ... update other properties as needed

                // Save the changes to the database
                _db.SaveChanges();
            }
            else
            {
                // Handle the case when the category is not found
                // You can throw an exception or handle it in another way depending on your requirements
                throw new ArgumentException("Category not found");
            }
        }

    }

}
