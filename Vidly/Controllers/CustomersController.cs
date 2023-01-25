using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vidly.Data;

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
    }
}
