namespace morleys_backend.Models.DbModels
{
    public class CartItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? Price { get; set; } // Optional, allows storing price at order time
    }
}
