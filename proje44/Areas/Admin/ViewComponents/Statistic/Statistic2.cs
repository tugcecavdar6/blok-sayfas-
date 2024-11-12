using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proje44.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic2 : ViewComponent
    {
        Context _context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v2 = _context.blogs.OrderByDescending(x => x.BlogID).Select(x => x.BlogBaslik).Take(1).FirstOrDefault();
            ViewBag.v3 = _context.yorumlars.Count();
            return View();
        }
    
    }
}
