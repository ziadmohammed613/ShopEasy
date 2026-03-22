namespace ShopEasy.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
 
        public Product Product { get; set; } = null!;
        public Customer Customer { get; set; } = null!;
        public override string ToString()
        {
            return $"ReviewId: {ReviewId}, ProductId: {ProductId}, CustomerId: {CustomerId}, Rating: {Rating}, Comment: {Comment}, CreatedAt: {CreatedAt}";
        }
    }
}