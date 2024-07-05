namespace morleys_backend.Models.DbModels
{
    public class Attachment
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string imageURL { get; set; }
        public virtual Product Product { get; set; }

    }
}
