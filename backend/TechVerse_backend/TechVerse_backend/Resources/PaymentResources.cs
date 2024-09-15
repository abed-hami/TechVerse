namespace TechVerse_backend.Resources
{
    public class PaymentResources
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int OrderId { get; set; }

        public int Amount { get; set; }

        public string PaymentMethod { get; set; } = null!;

        public DateTime Date { get; set; }

        public string Status { get; set; } = null!;
    }
}
