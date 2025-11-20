using QLBH.Repository.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLBH.Models
{
    public class SliderModle
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Yêu cầu nhập tên Slider")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Yêu cầu nhập mô tả")]
        public string Description { get; set; }
        public string Image { get; set; }
        [NotMapped]
        [FileExtention]
        public IFormFile ImageUpload { get; set; }

        [Required(ErrorMessage ="Yêu cầu nhập trạng thái")]
        public int Status { get; set; }
    }
}
