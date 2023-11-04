using System;
using System.Collections.Generic;
using System.Text;

namespace HaidersBooks.DataAccess.Repository.IRespository
{
    interface IUnitOfWork: IDisposable
    {
        ICategoryRepository Category { get; }
        ISP_Call SP_Call { get; }
    }
}
