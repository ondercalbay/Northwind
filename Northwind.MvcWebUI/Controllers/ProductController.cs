using Northwind.Entities;
using Northwind.Interfaces;
using Northwind.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        private int _pageSize = 5;
        public ViewResult Index(int page = 1)
        {
            List<Product> products = _productService.GetAll();
            return View(
                            new ProductViewModel
                            {
                                Products = products.Skip((page - 1) * _pageSize).Take(_pageSize).ToList(),
                                PagingInfo = new PagingInfo
                                {
                                    ItemsPerPage = _pageSize,
                                    TotalItems = products.Count,
                                    CurrentPage = page
                                }
                            }

                );
        }
    }
}