using Northwind.Entities;
using System.Collections.Generic;

namespace Northwind.Dal.Abstract
{
    public interface IProductDal
    {
       void Add(Product product);
       void Delete(int productId);
       Product Get(int productId);
       List<Product> GetAll();
        void Update(Product product);
    }
}