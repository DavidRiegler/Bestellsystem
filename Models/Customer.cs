namespace Bestellsystem_API.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string? CustomerLastName { get; set; }

        public string? CustomerFirstName { get; set; }

        public string? CustomerEmail { get; set; }

        public string? Address { get; set; }

        public string? ZipCode { get; set; }

        public string? City { get; set; }

        public string? Notes { get; set; }
    }
}