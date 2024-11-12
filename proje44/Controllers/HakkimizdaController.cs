using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proje44.Controllers
{
    [AllowAnonymous]
    public class HakkimizdaController : Controller
    {
        HakkimizdaManager hm = new HakkimizdaManager(new EfHakkimdaRepository());
        public IActionResult Index()
        {
            var values = hm.GetList();
            return View(values);
        }
        public PartialViewResult SocialMediaAbout()
        {
            
            return PartialView();
        }
    }
}
