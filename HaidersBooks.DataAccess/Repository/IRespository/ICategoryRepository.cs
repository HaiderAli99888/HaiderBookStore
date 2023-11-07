using HaidersBooks.DataAccess.Repository.IRepository;
using HaidersBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaidersBooks.DataAccess.Repository.IRespository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(CategoryRepository category);
        void Update(Category category);
    }
}
