namespace TechVerse_backend.Resources
{
    public class CouponResources
    {
        public int Id { get; set; }

        public string Code { get; set; } = null!;

        public string Type { get; set; } = null!;

        public int Value { get; set; }

        public DateTime ExpireyDate { get; set; }

        public int MinOrder { get; set; }

        public string Status { get; set; } = null!;
    }
}
