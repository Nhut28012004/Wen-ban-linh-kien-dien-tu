using QLBH.Repository.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLBH.Models
{
    public class ContactModel
    {
        [Key]
        [Required(ErrorMessage = "Yêu cầu nhập tên cửa hàng")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập địa chỉ")]
        public string Map { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập số điện thoại")]

        public string Phone { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập mô tả")]

        public string Description { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập email ")]

        public string Email { get; set; }


        public string LogoImg { get; set; }

        [NotMapped]
        [FileExtention]
        public IFormFile ImageUpload { get; set; }

    }
}
