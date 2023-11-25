namespace Bestellsystem_API.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? Category { get; set; }

        public string? ProductVendor { get; set; }

        public int ProductPrice { get; set; }

        public int UnitsInStock { get; set; }
    }
}
