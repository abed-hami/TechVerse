namespace TechVerse_backend.Resources
{
    public class OrderResources
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public DateOnly Date { get; set; }

        public string Address { get; set; } = null!;

        public string Status { get; set; } = null!;

        public int? CouponId { get; set; }
    }
}
