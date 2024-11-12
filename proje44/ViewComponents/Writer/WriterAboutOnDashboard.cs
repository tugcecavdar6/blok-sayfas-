using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proje44.ViewComponents.Writer
{
    public class WriterAboutOnDashboard : ViewComponent
    {
        WriterManager _writerManager = new WriterManager(new EfYazarRepository());


        Context context = new Context();

       

        public IViewComponentResult Invoke()
        {

            var userName = User.Identity.Name;
            ViewBag.data = userName;
            var userMail = context.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerID = context.yazars.Where(x => x.yazarMail == userMail).Select(y => y.yazarID).FirstOrDefault();
            var values = _writerManager.GetListWriterById(writerID);
            return View(values);

        }

    }
}
