using Northwind.Interfaces;
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

        public ViewResult Index()
        {
            return View(_productService.GetAll());
        }
         
    }
}