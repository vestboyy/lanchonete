
using Microsoft.AspNetCore.Mvc;

namespace LanchoneteMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
