namespace ShopEasy.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string SKU { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public bool IsActive { get; set; } = true;
        public int CategoryId { get; set; }
        public string DisplayName { set; get; } = string.Empty;
 
        public Category Category { get; set; } = null!;
        public ProductImage? ProductImage { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public ICollection<ProductTag> ProductTags { get; set; } = new List<ProductTag>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public override string ToString()
        {
            return $"{{ ProductId: {ProductId}, Name: {Name}, SKU: {SKU}, Price: {Price}, StockQuantity: {StockQuantity}, IsActive: {IsActive}, CategoryId: {CategoryId} }}";
        }
    }
}