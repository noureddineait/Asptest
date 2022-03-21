using Microsoft.AspNetCore.Mvc;

namespace ASPNET_TEST.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
