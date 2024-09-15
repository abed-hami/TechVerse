namespace TechVerse_backend.Resources
{
    public class GiftCardResources
    {
        public int Id { get; set; }

        public string Code { get; set; } = null!;

        public int Value { get; set; }

        public DateTime ExpireyDate { get; set; }

        public string Status { get; set; } = null!;
    }
}
