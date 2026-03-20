namespace ShopEasy.Models
{
    public class CustomerProfile
    {
        public int CustomerProfileId { get; set; }
        public int CustomerId { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public string? NationalId { get; set; }
 
        public Customer Customer { get; set; } = null!;
        public override string ToString()
        {
            return $"{{ CustomerProfileId: {CustomerProfileId}, CustomerId: {CustomerId}, Address: {Address ?? "N/A"}, City: {City ?? "N/A"}, PostalCode: {PostalCode ?? "N/A"}, NationalId: {NationalId ?? "N/A"} }}";
        }
    }
}