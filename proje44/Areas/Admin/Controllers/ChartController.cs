using Microsoft.AspNetCore.Mvc;
using proje44.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proje44.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();
            list.Add(new CategoryClass
            {
                CategoryName = "Teknoloji",
                CategoryCount = 14
            });
            list.Add(new CategoryClass
            {
                CategoryName = "Yazılım",
                CategoryCount = 5
            });
            list.Add(new CategoryClass
            {
                CategoryName = "Spor",
                CategoryCount = 2
            });
            list.Add(new CategoryClass
            {
                CategoryName = "Sinema",
                CategoryCount = 8
            });
            return Json(new { jsonlist = list });
        }
    }
}
