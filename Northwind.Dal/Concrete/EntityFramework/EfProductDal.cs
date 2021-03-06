﻿using Northwind.Dal.Abstract;
using Northwind.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Northwind.Dal.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        private NorthwindContext _context = new NorthwindContext();
        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Delete(int productId)
        {
            _context.Products.Remove(Get(productId));
            _context.SaveChanges();
        }

        public Product Get(int productId)
        {
           return _context.Products.Where(p => p.ProductId == productId).FirstOrDefault();
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = Get(product.ProductId);
            
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            
            _context.SaveChanges();
        }
    }
}
