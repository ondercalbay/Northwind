using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Northwind.Entities;

namespace Northwind.MVCWebUI.Models
{
    public class ProductViewModel
    {
        public List<Product> Products { get; internal set; }
        public PagingInfo PagingInfo { get; set; }
    }
}