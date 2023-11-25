using Bestellsystem_API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Bestellsystem_API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private static List<Product> _products = new List<Product> { 
            new Product { Id = 1, Name = "1969 Harley Davidson Ultimate Chopper", Description = "This replica features working kickstand, front suspension, gear-shift lever, footbrake lever, drive chain, wheels and steering. All parts are particularly delicate due to their precise scale and require special care and attention.", Category = "Motorcycles", ProductVendor = "Min Lin Diecast", ProductPrice = 48, UnitsInStock = 7933 },
            new Product { Id = 2, Name = "1952 Alpine Renault 1300", Description = "Turnable front wheels; steering function; detailed interior; detailed engine; opening hood; opening trunk; opening doors; and detailed chassis.", Category = "Classic Cars", ProductVendor = "Classic Metal Creations", ProductPrice = 98, UnitsInStock = 7305 },
            new Product { Id = 3, Name = "1996 Moto Guzzi 1100i", Description = "Official Moto Guzzi logos and insignias, saddle bags located on side of motorcycle, detailed engine, working steering, working suspension, two leather seats, luggage rack, dual exhaust pipes, small saddle bag located on handle bars, two-tone paint with chrome accents, superior die-cast detail , rotating wheels , working kick stand, diecast metal with plastic parts and baked enamel finish.", Category = "Motorcycles", ProductVendor = "Highway 66 Mini Classics", ProductPrice = 69, UnitsInStock = 6625 },
            new Product { Id = 4, Name = "2003 Harley-Davidson Eagle Drag Bike", Description = "Model features, official Harley Davidson logos and insignias, detachable rear wheelie bar, heavy diecast metal with resin parts, authentic multi-color tampo-printed graphics, separate engine drive belts, free-turning front fork, rotating tires and rear racing slick, certificate of authenticity, detailed engine, display stand, precision diecast replica, baked enamel finish, 1:10 scale model, removable fender, seat and tank cover piece for displaying the superior detail of the v-twin engine", Category = "Motorcycles", ProductVendor = "Red Start Diecast", ProductPrice = 91, UnitsInStock = 5582 },
            new Product { Id = 5, Name = "1972 Alfa Romeo GTA", Description = "Features include: Turnable front wheels; steering function; detailed interior; detailed engine; opening hood; opening trunk; opening doors; and detailed chassis.", Category = "Classic Cars", ProductVendor = "Motor City Art Classics", ProductPrice = 86, UnitsInStock = 3252 },
            new Product { Id = 6, Name = "1962 LanciaA Delta 16V", Description = "Features include: Turnable front wheels; steering function; detailed interior; detailed engine; opening hood; opening trunk; opening doors; and detailed chassis.", Category = "Classic Cars", ProductVendor = "Second Gear Diecast", ProductPrice = 103, UnitsInStock = 6791 },
            new Product { Id = 7, Name = "1968 Ford Mustang", Description = "Hood, doors and trunk all open to reveal highly detailed interior features. Steering wheel actually turns the front wheels. Color dark green.", Category = "Classic Cars", ProductVendor = "Autoart Studio Design", ProductPrice = 95, UnitsInStock = 68 },
            new Product { Id = 8, Name = "2001 Ferrari Enzo", Description = "Turnable front wheels; steering function; detailed interior; detailed engine; opening hood; opening trunk; opening doors; and detailed chassis.", Category = "Classic Cars", ProductVendor = "Second Gear Diecast", ProductPrice = 96, UnitsInStock = 3619 },
            new Product { Id = 9, Name = "1958 Setra Bus", Description = "Model features 30 windows, skylights & glare resistant glass, working steering system, original logos", Category = "Trucks and Buses", ProductVendor = "Welly Diecast Productions", ProductPrice = 78, UnitsInStock = 1579 },
            new Product { Id = 10, Name = "2002 Suzuki XREO", Description = "Official logos and insignias, saddle bags located on side of motorcycle, detailed engine, working steering, working suspension, two leather seats, luggage rack, dual exhaust pipes, small saddle bag located on handle bars, two-tone paint with chrome accents, superior die-cast detail , rotating wheels , working kick stand, diecast metal with plastic parts and baked enamel finish.", Category = "Motorcycles", ProductVendor = "Unimax Art Galleries", ProductPrice = 66, UnitsInStock = 9997 }
        };

        private readonly BestellsystemContext _context;

        public ProductController(BestellsystemContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetProduct")]
        public IEnumerable<Product> Get()
        {
            return _products;
        }
        [HttpGet("{Id}")]
        public Product GetById(int Id)
        {
            try
            {
                return _products.Find(x => x.Id == Id);
            } catch (Exception ex) {
                throw;
            }
        }
    }
}
