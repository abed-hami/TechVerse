namespace TechVerse_backend.Resources
{
    public class CartItemResources
    {
        public int Id { get; set; }

        public int CartId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public int TotalPrice { get; set; }
    }
}
