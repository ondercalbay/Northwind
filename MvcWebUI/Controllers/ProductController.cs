using Northwind.Bll;
using Northwind.Dal.Concrete.EntityFramework;
using Northwind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ViewResult Index()
        {
            return View(_productService.GetAll());
        }
    }
}