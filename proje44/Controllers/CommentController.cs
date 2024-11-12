using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;

namespace proje44.Controllers
{
    [AllowAnonymous]
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfYorumRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialAddComment(yorumlar yorumlar)
        {
            yorumlar.yorumDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            yorumlar.yorumDurum = true;
            yorumlar.BlogID = 2;
            cm.YorumAdd(yorumlar);
            return PartialView();
        }
        [HttpPost]
        public IActionResult CommentListByBlog(int id)
        {
            var comments = cm.GetList(id);
            return View();
        }
    }
}
