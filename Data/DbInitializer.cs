using Bestellsystem_API.Models;

namespace Bestellsystem_API.Data
{
    public class DbInitializer
    {
        private readonly BestellsystemContext _context;

        public DbInitializer(BestellsystemContext context)
        {
            _context = context;
        }

        public void Run()
        {
            if (_context.Database.EnsureCreated())
            {
                // add intial data
                _context.Customers.Add(
                    new Customer
                    {
                        Id = 1,
                        CustomerLastName = "Riegler",
                        CustomerFirstName = "David",
                        CustomerEmail = "david.riegler@intdev.ch",
                        Address = "Mühlestrasse 3q",
                        ZipCode = "8864",
                        City = "Reichenburg",
                        Notes = ""
                    });

                _context.Products.Add(
                    new Product
                    {
                        Id = 1,
                        Name = "1969 Harley Davidson Ultimate Chopper",
                        Description = "This replica features working kickstand, front suspension, gear-shift lever, footbrake lever, drive chain, wheels and steering. All parts are particularly delicate due to their precise scale and require special care and attention.",
                        Category = "Motorcycles",
                        ProductVendor = "Min Lin Diecast",
                        ProductPrice = 48,
                        UnitsInStock = 7933
                    });
                // store everything to database
                _context.SaveChanges();
            }
        }
    }
}
