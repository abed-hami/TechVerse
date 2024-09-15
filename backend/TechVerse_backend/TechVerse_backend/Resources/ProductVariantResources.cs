namespace TechVerse_backend.Resources
{
    public class ProductVariantResources
    {
        public int Id { get; set; }

        public string Color { get; set; } = null!;

        public string ColorValue { get; set; } = null!;

        public int Quantity { get; set; }

        public string Attribute { get; set; } = null!;

        public string AttributeValue { get; set; } = null!;

        public string Code { get; set; } = null!;

        public string Img { get; set; } = null!;

        public int ProductId { get; set; }
    }
}
