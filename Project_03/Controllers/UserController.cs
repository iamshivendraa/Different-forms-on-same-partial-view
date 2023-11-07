using Microsoft.AspNetCore.Mvc;

namespace Project_03.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PartialView1()
        {
            return PartialView("_AddUser");
        }
    }
}
