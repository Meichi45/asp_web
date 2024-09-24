using BaiKiemTra02.Data;
using BaiKiemTra02.Data.Migrations;
using Microsoft.AspNetCore.Mvc;

namespace BaiKiemTra02.Controllers
{
    public class LopHocController : Controller
    {
        private readonly ApplicationDbContext _db;
        public LopHocController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var lophoc= _db.LopHoc.ToList();
            ViewBag.Lophoc = lophoc;
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(LopHoc lophoc)
        {
            if (ModelState.IsValid)
            {
                
                _db.LopHoc.Add(lophoc);
                
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();

        }

    }
}
