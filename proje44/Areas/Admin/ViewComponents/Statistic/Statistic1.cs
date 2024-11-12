using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace proje44.Areas.ViewComponents.Statistic
{
    public class Statistic1 : ViewComponent
    {
        BlogManager _blogManager = new BlogManager(new EfBlogRepository());
        Context context = new Context();

        public IViewComponentResult Invoke()
        {

            ViewBag.v1 = _blogManager.GetList().Count();
         //   ViewBag.v2 = context.iletisims.Count();
            ViewBag.v3 = context.yorumlars.Count();
            string api = "32c7deb9ff694209011dc15afbb6f748";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=Tokat&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument xDocument = XDocument.Load(connection);
            ViewBag.v4 = xDocument.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            return View();
        }

    }
}
