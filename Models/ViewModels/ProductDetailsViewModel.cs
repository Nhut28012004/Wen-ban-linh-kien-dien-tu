using System.ComponentModel.DataAnnotations;

namespace QLBH.Models.ViewModels
{
    public class ProductDetailsViewModel
    {
        public ProductModel ProductDetails { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập bình luận")]
        public string Comment { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập tên người đánh giá sản phẩm")]

        public string Name { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập email người đánh giá sản phẩm")]

        public string Email { get; set; }
    }
}
