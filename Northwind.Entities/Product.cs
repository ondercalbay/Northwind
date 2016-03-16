namespace Northwind.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int UnitStock { get; set; }
        public decimal UnitPrice { get; set; }
        public int CategoryID { get; set; }
    }
}
