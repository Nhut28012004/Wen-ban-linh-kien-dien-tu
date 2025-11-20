using Microsoft.AspNetCore.Mvc;

namespace QLBH.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
