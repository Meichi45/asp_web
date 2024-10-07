using Microsoft.AspNetCore.Mvc;

namespace BaiKiemTra03_02.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
