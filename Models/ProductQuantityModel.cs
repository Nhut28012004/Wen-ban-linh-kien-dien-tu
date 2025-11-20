using System.ComponentModel.DataAnnotations;

namespace QLBH.Models
{
    public class ProductQuantityModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Yêu cầu không bỏ trống số lượng")]
        public int Quantity { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
