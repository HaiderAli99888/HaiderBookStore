using HaidersBooks.DataAccess.Repository.IRepository;
using HaidersBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HaidersBooks.DataAccess.Repository.IRespository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}