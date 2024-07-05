namespace morleys_backend.Models.DbModels
{
    public class User
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // Securely store hashed password
        public DateTime  CreatedAt { get; set; } = DateTime.UtcNow; // Default on creation
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow; // Default on creation and update
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Role { get; set; }
        public DateTime? LastLogin { get; set; } // Nullable for optional login time
        // Navigation property for one-to-many relationship with Orders
        public ICollection<Order> Orders { get; set; }
        public Cart Cart { get; set; }

    }
}
