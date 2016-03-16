using Northwind.Bll.Concrate;
using Northwind.Dal.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwind.MVCWebUI.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        ProductManager _productManager = new ProductManager(new EfProductDal());

        public ViewResult Index()
        {
            return View(_productManager.GetAll());
        }
         
    }
}