using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetName()
        {
            var myName = new { Name = "Somyani Ghimire" }; 
            return Ok(myName);
        }
    }
}
