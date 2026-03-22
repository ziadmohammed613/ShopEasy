namespace ShopEasy.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
        public decimal TotalAmount { get; set; }
        public DateTime PlacedAt { get; set; } = DateTime.UtcNow;
        public DateTime? ShippedAt { get; set; }
 
        public Customer Customer { get; set; } = null!;
        public Payment? Payment { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public override string ToString()
        {
            return $"{{ OrderId: {OrderId}, CustomerId: {CustomerId}, Status: {Status}, TotalAmount: {TotalAmount:C}, PlacedAt: {PlacedAt:yyyy-MM-dd}, ShippedAt: {ShippedAt?.ToString("yyyy-MM-dd") ?? "N/A"} }}";
        }
    }
    public enum OrderStatus
    {
        Pending ,
        Cancelled ,
        Refunded ,
        Shipped ,
        Delivered
    }
}