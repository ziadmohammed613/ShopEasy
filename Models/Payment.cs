namespace ShopEasy.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public string Method { get; set; } = string.Empty;
        public PaymentStatus Status { get; set; } = PaymentStatus.Pending;
        public DateTime? PaidAt { get; set; }
        public decimal Amount { get; set; }
 
        public Order Order { get; set; } = null!;
    }
    public enum PaymentStatus
    {
        Pending ,
        Paid ,
        Refunded
    }
}