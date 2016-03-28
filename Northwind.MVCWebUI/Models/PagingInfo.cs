namespace Northwind.MVCWebUI.Models
{
    public class PagingInfo
    {
        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        private string query = "";
        public string Query { get { return query == "" ? "" : query + "&"; } set { query = value; } }
        public int TotalItems { get; set; }
        public int TotalPage { get { return (int)System.Math.Ceiling((decimal)this.TotalItems / this.ItemsPerPage); } }
    }
}