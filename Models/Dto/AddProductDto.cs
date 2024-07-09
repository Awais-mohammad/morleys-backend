namespace morleys_backend.Models.Dto
{
    public class AddProductDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime AddedAt { get; set; } = DateTime.UtcNow; // Default on creation
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow; // Default on creation and update
        public string Category { get; set; }
        public string ImageUrl { get; set; }
        public decimal? Discount { get; set; } // Nullable for optional discounts

    }
}
