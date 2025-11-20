namespace QLBH.Models
{
    public class CartItemModel
    {
        public int ProductId { get; set; } // change from long to int
        public string ProductName { get; set; }

        public int Quantity { get; set; }   

        public decimal Price { get; set; }

        public decimal Total
            {
            get { return Quantity * Price; }
        }
        public string Image { get; set; }
        public CartItemModel() { }
        public CartItemModel(ProductModel product)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));
            ProductId = product.Id;
            ProductName = product.Name;
            Price = product.Price;
            Image = product.Image;
            Quantity = 1;
        }
    }
}
