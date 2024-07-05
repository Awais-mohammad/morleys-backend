namespace morleys_backend.Models.DbModels
{
    public class OrderProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; }


        public int OrderId { get; set; }

        public int Quantity { get; set; }
        public decimal? Price { get; set; } // Optional, allows storing price at order time
                                            // Navigation property to Orders table
        public Order Order { get; set; }
        // Navigation property to Products table
        public Product Product { get; set; }
    }
}
