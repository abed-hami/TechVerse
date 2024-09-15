namespace TechVerse_backend.Resources
{
    public class ProductResources
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Brand { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Img { get; set; } = null!;

        public int BasePrice { get; set; }

        public string Label { get; set; } = null!;

        public int Quantity { get; set; }

        public int CategoryId { get; set; }
    }
}
