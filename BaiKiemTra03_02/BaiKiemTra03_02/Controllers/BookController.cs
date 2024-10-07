using BaiKiemTra03_02.Data;
using Microsoft.AspNetCore.Mvc;

namespace BaiKiemTra03_02.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BookController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var book = _db.Book.ToList();
            ViewBag.Book = book;
            return View();
        }
    }
}
