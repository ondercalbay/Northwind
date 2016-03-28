using Northwind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwind.MVCWebUI.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService _catecoryService;

        public CategoryController (ICategoryService catecoryService)
        {
            _catecoryService = catecoryService;
        }

        // GET: Category
        public PartialViewResult List(int category = 0)
        {
            ViewBag.CurrentCategory = category;
            return PartialView(_catecoryService.GetAll());
        }
    }
}