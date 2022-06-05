using BogusFakeData_WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BogusFakeData_WebApi.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> Get();
    }
}
