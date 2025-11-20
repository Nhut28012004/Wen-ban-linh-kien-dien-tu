using System.ComponentModel.DataAnnotations;

namespace QLBH.Models
{
    public class CouPonModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Yêu cầu nhập tên khuyến mãi")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập mô tả khuyến mãi")]
        public string Description { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime ExpiryDate { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập số lượng mã khuyến mãi")]
        public int Quantity { get; set; }
        public int Status { get; set; }
    }
}
