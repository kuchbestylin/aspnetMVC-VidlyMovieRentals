using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vidly.Data;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CustomersController(ApplicationDbContext db)
        {
            _db = db;
        }

        protected override void Dispose(bool disposing)
        {
            //base.Dispose(disposing);
            _db.Dispose();
        }

        public IActionResult Index()
        {
            var customers = _db.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _db.Customers.Include(a => a.MembershipType).SingleOrDefault(c => c.Id == id);
            if (customer == null) return NotFound();
            return View(customer);
        }

        public IActionResult New()
        {
            var membershipTypes = _db.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel() { MembershipTypes = membershipTypes };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            _db.Customers.Add(customer);
            _db.SaveChanges();
            return RedirectToAction("Index", "Customers");
        }
    }
}
