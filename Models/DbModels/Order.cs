using System.ComponentModel.DataAnnotations.Schema;
namespace morleys_backend.Models.DbModels

{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; } // Foreign key referencing Users table
        public DateTime OrderedAt { get; set; } = DateTime.UtcNow; // Default on creation
        public string Status { get; set; }
        public int Quantity { get; set; } // Total quantity of items in the order
        public decimal TotalPrice { get; set; }
        public string ShippingAddress { get; set; }
        public string PaymentStatus { get; set; }
        public string TrackingNumber { get; set; }
        // Navigation property for referencing the user (optional)
        public User User { get; set; }
        // Navigation property for many-to-many relationship with Products (via OrderProducts)
        public ICollection<OrderProduct> OrderProducts { get; set; }

    }
}
