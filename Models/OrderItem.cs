namespace ShopEasy.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
 
        public Order Order { get; set; } = null!;
        public Product Product { get; set; } = null!;
        public override string ToString()
        {
            return $"OrderItemId: {OrderItemId}, OrderId: {OrderId}, ProductId: {ProductId}, Quantity: {Quantity}, UnitPrice: {UnitPrice}";
        }
    }
}