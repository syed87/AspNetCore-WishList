using Microsoft.AspNetCore.Mvc;


namespace WishList.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("View");
        }

        public IActionResult Error()
        {
            return View("Error");
        }
    }
}
