using System.ComponentModel.DataAnnotations.Schema;
using QLBH.Models;

namespace QLBH.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string OrderCode { get; set; }

        // Changed from long to int to match ProductModel.Id (int)
        public int ProductId { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }

        [ForeignKey("ProductId")]
        public ProductModel Product { get; set; }
    }
}
