namespace QLBH.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string OrderCode { get; set; }

        public decimal ShippingCost { get; set; }

        public string Username { get; set; }

        public int Status { get; set; }

        public DateTime CreateDate { get; set; }
        public string CouponCode { get; set; }
    }
}
