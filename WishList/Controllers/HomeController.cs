using Microsoft.AspNetCore.Mvc;
using System.Web.Mvc;

namespace WishList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(Index);
        }

        public ActionResult Error()
        {
            return View(Error);
        }
    }
}
