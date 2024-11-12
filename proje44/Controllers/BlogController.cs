using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proje44.Controllers
{
   
    public class BlogController : Controller
    {
        private CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        private WriterManager wm = new WriterManager(new EfYazarRepository());
        private BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        [AllowAnonymous]
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }
        [AllowAnonymous]
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var values = bm.GetBlogByID(id);
            return View(values);
        }
        public IActionResult BlogListByWriter()
        {
            var userName = User.Identity.Name;
            var userMail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = c.yazars.Where(x => x.yazarMail == userMail).Select(y => y.yazarID)
                .FirstOrDefault();
            var values = bm.GetBlogListByWriter(writerId);
            return View(values);
        }
        [HttpGet]
        public IActionResult BlogAdd()
        {
           
            List<SelectListItem> categoryvalues = (from x in cm.GetList() select new SelectListItem { Text = x.kategoriAd, Value = x.kategoriID.ToString() }).ToList();
            ViewBag.cv = categoryvalues;
            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd(Blog p)
        {
            var userMail = User.Identity.Name;
            var writerId = wm.GetList(userMail).Select(w => w.yazarID).FirstOrDefault();
            var writerValues = wm.GetById(writerId);
            BlogValidator blogValidator = new BlogValidator();
            ValidationResult validationResult = blogValidator.Validate(p);
            if (validationResult.IsValid)
            {
                p.BlogDurum = true;
                p.BlogTarih = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.yazarID = writerId;
                bm.TAdd(p);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            GetCategoryList();
            return View();

        }
        public IActionResult DeleteBlog(int id)
        {
            var blogvalue = bm.GetById(id);
            bm.TDelete(blogvalue);
            return RedirectToAction("BlogListByWriter");
        }

        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            var blogvalue = bm.GetById(id);
            List<SelectListItem> categoryvalues = (from x in cm.GetList() select new SelectListItem { Text = x.kategoriAd, Value = x.kategoriID.ToString() }).ToList();
            ViewBag.cv = categoryvalues;
            return View(blogvalue);
        }
        [HttpPost]
        public IActionResult EditBlog(Blog p)
        {
            var userMail = User.Identity.Name;

            var writerID = c.yazars.Where(x => x.yazarMail == userMail).Select(y => y.yazarID).FirstOrDefault();
            ViewBag.v2 = writerID;
            p.yazarID = writerID;
            p.BlogTarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.BlogDurum = true;
            bm.TUpdate(p);
            return RedirectToAction("BlogListByWriter");
        }
        public void GetCategoryList()
        {
            List<SelectListItem> categories = (from c in cm.GetList()
                                               select new SelectListItem
                                               {
                                                   Text = c.kategoriAd,
                                                   Value = c.kategoriID.ToString()
                                               }).ToList();
            ViewBag.categoriesList = categories;
        }
    }
}
