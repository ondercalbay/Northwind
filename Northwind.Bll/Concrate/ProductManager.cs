using Northwind.Dal.Abstract;
using Northwind.Dal.Concrete.EntityFramework;
using Northwind.Entities;
using Northwind.Interfaces;
using System;
using System.Collections.Generic;

namespace Northwind.Bll.Concrate
{
    public class ProductManager : IProductService
    {
        IProductDal _productdal;

        public ProductManager(IProductDal productDal)
        {
            _productdal = productDal;
        }
        

        public void Add(Product product)
        {
            _productdal.Add(product);
        }

        public void Delete(int productId)
        {
            _productdal.Delete(productId);
        }

        public Product Get(int productId)
        {
            return _productdal.Get(productId);
        }

        public List<Product> GetAll()
        {
            return _productdal.GetAll();
        }

        public void Update(Product product)
        {
            _productdal.Update(product);
        }
    }
}
