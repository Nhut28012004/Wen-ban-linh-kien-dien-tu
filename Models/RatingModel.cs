using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLBH.Models
{
    public class RatingModel
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Yêu cầu đánh giá sản phẩm")]
        public string Comment { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập tên người đánh giá sản phẩm")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập email người đánh giá sản phẩm")]

        public string Email { get; set; }
        [Required(ErrorMessage = "Yêu cầu số sao đánh giá sản phẩm")]

        public int Stars { get; set; }
        [ForeignKey("ProductId")]

        public ProductModel Product { get; set; }
    }
}
