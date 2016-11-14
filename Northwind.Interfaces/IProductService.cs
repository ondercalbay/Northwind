using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product Get(int productId);
        void Add(Product product);
        void Update(Product product);
        void Delete(int productId);
    }
}
