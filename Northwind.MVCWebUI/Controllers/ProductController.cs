using Northwind.Entities;
using Northwind.Interfaces;
using Northwind.MVCWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Northwind.MVCWebUI.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public int _pageSize = 5;
        public ViewResult Index(int page = 1,int category = 0)
        {
            List<Product> products = _productService.GetAll().Where(p => p.CategoryID == category || category == 0).ToList();
            return View(new ProductViewModel
            {
                Products = products.Skip((page - 1) * _pageSize).Take(_pageSize).ToList(),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = _pageSize,
                    TotalItems = products.Count(),
                    Query = String.Format("Category={0}", category)
                }
            });
        }

        
         
    }
}