using BusinessAccessLayer.IService;
using DataAccessLayer.IRepo;
using DataAccessLayer.Model;
using Microsoft.AspNetCore.Mvc;

namespace Application_Layer.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IServices _dataget;

        public CustomerController(IServices dataget)
        { 
            _dataget = dataget;
        }
        public IActionResult Index()
        {
            var data=_dataget.GetDetails();
            return View(data);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
        public IActionResult CreateCustomer(Customer esc)
        {
            _dataget.CreateCustomers(esc);
            return RedirectToAction("Index");  
        }
    }
}
