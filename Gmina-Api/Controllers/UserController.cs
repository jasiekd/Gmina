using Microsoft.AspNetCore.Mvc;

namespace Gmina_Api.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
