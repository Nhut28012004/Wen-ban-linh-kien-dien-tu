using Microsoft.AspNetCore.Mvc;
using QLBH.Repository.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLBH.Models
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }
        [Required( ErrorMessage = "Yêu cầu nhập tên Danh mục")]
        public string Name { get; set; }
        [Required( ErrorMessage = "Yêu cầu nhập mô tả Danh mục")]
        public string Description { get; set; }

        public string Slug { get; set; }
        [Required( ErrorMessage = "Yêu cầu nhập giá sản phẩm")]
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int Quantity { get; set; }
        public int Sold { get; set; }

        public string Image { get; set; }

        public RatingModel Ratings { get; set; }

        [NotMapped]
        [FileExtention]
        [Required(ErrorMessage = "Vui lòng chọn hình ảnh sản phẩm")]
        public IFormFile? ImageUpload { get; set; }

        public CategoryModel Category { get; set; }
        public BrandModel Brand { get; set; }


    }
}
