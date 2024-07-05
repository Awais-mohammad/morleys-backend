namespace morleys_backend.Models.DbModels
{
    public class Cart
    {
        public int Id { get; set; } // Primary Key
        public int UserId { get; set; } // Foreign Key referencing Users table
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Default on creation

        // Navigation property for referencing the user (optional)
        public User User { get; set; }
        // You might consider adding a navigation property for CartItems (if applicable)
        public ICollection<CartItem> CartItems { get; set; }

    }
}
