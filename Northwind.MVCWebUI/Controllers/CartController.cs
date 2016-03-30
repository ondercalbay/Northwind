using Northwind.Entities;
using Northwind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwind.MVCWebUI.Controllers
{
    public class CartController : Controller
    {
        IProductService _productService;


        public  CartController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {
            var cart = (Cart)Session["cart"];
            return View("Index", cart);
        }

        public ActionResult AddToCart(int productId)
        {
            Product product = _productService.Get(productId);
            Cart cart;
            if (Session["cart"]==null)
            {
                cart = new Cart();
                Session["cart"] = cart;
            }
            else
            {
                cart = (Cart)Session["cart"];
            }
             
            cart.AddToCart(product, 1);

            return RedirectToAction("Index",cart);
        }

        public ActionResult RemoveFromCart(int productId)
        {
            var cart = (Cart)Session["cart"];
            if (cart.Lines.Count == 0)
            {
                ModelState.AddModelError("", "Sepette bu ürün yok");
            }
            else
            {
                Product product = _productService.Get(productId);
                cart.RemoveFromCart(product);
            }

            return RedirectToAction("Index", cart);
        }
    }
}