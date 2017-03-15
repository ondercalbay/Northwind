using System.Collections.Generic;
using Northwind.Entities;

namespace MvcWebUI.Models
{
    class ProductViewModel
    {
        public PagingInfo PagingInfo { get; set; }
        public List<Product> Products { get; set; }
    }
}