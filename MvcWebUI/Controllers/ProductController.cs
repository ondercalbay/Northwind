using Northwind.Bll;
using Northwind.Dal.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        ProductManager _productManager = new ProductManager(new EfProductDal());
        
        public ViewResult Index()
        {
            return View(_productManager.GetAll());
        }
    }
}