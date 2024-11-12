using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proje44.Controllers
{
   
    public class DashboardController : Controller
    {
        

         BlogManager _blogManager = new BlogManager(new EfBlogRepository());
         CategoryManager _categoryManager = new CategoryManager(new EfCategoryRepository());
        [AllowAnonymous]
        public IActionResult Index()
        {
            Context context = new Context();
            var userName = User.Identity.Name;
            var userMail = context.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = context.yazars.Where(x => x.yazarMail == userMail).Select(y => y.yazarID).FirstOrDefault();
            
            ViewBag.blogsCount = _blogManager.GetList().Count;
            ViewBag.blogCountByWriter = _blogManager.GetBlogListByWriter(writerId).Count;
            ViewBag.categoriesCount = _categoryManager.GetList().Count;
            return View();
            
        }
    }
}
