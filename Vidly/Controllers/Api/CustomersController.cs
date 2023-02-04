using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vidly.Data;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CustomersController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CustomerDto>> GetCustomers() =>
            Ok(_context.Customers.Include(c => c.MembershipType).ToList().Select(_mapper.Map<Customer, CustomerDto>));

        [HttpGet("{id:int}", Name = "GetCustomer")]
        public ActionResult<CustomerDto> GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null) return NotFound();

            return Ok(_mapper.Map<Customer, CustomerDto>(customer));
        }

        [HttpPost]
        public ActionResult<CustomerDto> PostCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            var customer = _mapper.Map<CustomerDto, Customer>(customerDto);
            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDto.Id = customer.Id;
            return CreatedAtRoute("GetCustomer", new { id = customerDto.Id }, customerDto);
        }

        [HttpPut]
        public ActionResult<CustomerDto> PutCustomer(int id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null) return NotFound();

            _mapper.Map(customerDto, customerInDb);

            _context.SaveChanges();

            return Ok(_mapper.Map<Customer, CustomerDto>(customerInDb));
        }

        [HttpDelete]
        public ActionResult<CustomerDto> DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null) return NotFound();

            _context.Customers.Remove(customerInDb);

            _context.SaveChanges();

            return NoContent();
        }
    }
}
