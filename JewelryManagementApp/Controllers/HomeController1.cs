using Microsoft.AspNetCore.Mvc;

namespace JewelryManagementApp.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
