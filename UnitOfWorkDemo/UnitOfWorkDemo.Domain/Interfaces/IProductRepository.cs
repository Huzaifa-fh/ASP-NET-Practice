using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkDemo.Domain.Entities;

namespace UnitOfWorkDemo.Domain.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {

    }
}
