using Bestellsystem_API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Bestellsystem_API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private static List<Customer> _customers = new List<Customer> { 
            new Customer { Id = 1, CustomerLastName="Schmitt", CustomerFirstName="Carine", CustomerEmail="carine.schmitt@gmail.com", Address="54, rue Royale", ZipCode="44000", City="Nantes", Notes="" },
            new Customer { Id = 2, CustomerLastName="Riegler", CustomerFirstName="David", CustomerEmail="david.riegler@intdev.ch", Address="Mühlestrasse 3q", ZipCode="8864", City="Reichenburg", Notes="" },

        };

        private readonly BestellsystemContext _context;

        public CustomerController(BestellsystemContext context)
        {
            _context = context;
        }

        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCustomer")]
        public IEnumerable<Customer> Get()
        {
            return _customers;
        }
        [HttpGet("{Id}")]
        public Customer GetById(int Id)
        {
            try
            {
                return _customers.Find(x => x.Id == Id);
            } catch (Exception ex) {
                throw;
            }
        }
    }
}
