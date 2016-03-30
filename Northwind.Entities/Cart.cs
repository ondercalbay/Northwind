using System.Collections.Generic;
using System.Linq;

namespace Northwind.Entities
{
    public class Cart
    {
        List<CartLine> _lines = new List<CartLine>();

        public void AddToCart(Product product, int quantity)
        {
            CartLine cartLine = _lines.FirstOrDefault(c => c.Product.ProductId == product.ProductId);

            if (cartLine == null)
            {
                _lines.Add(new CartLine { Product = product, Quantity = quantity });
            }
            else
            {
                cartLine.Quantity += quantity;
            }
        }
        public void RemoveFromCart(Product product)
        {
            _lines.RemoveAll(p => p.Product.ProductId == product.ProductId);
        }

        public decimal Total
        {
            get { return _lines.Sum(c => c.Product.UnitPrice * c.Quantity); }
        }

        public void Clear()
        {
            _lines.Clear();
        }

        public List<CartLine> Lines
        {
            get { return _lines; }
        }

    }

    

    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get { return this.Product.UnitPrice * this.Quantity; } }
    }
}
