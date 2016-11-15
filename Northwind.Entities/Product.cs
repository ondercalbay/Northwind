using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.Entities
{    
    public class Product
    {        
        public int ProductID { get; set; }

        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [DisplayName("Unite In Stock")]
        public Int16 UnitsInStock { get; set; }

        [DisplayName("Unite Price")]
        public decimal UnitPrice { get; set; }
                
        public int CategoryID { get; set; }
    }
}
