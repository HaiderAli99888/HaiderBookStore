using HaidersBooks.DataAccess.Repository.IRepository;
using HaidersBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaidersBooks.DataAccess.Repository.IRespository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType coverType);
    }
}
