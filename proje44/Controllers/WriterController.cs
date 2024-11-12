using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using proje44.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace proje44.Controllers
{
    
    public class WriterController : Controller
    {
        Context c = new Context();
        WriterManager wm = new WriterManager(new EfYazarRepository());
        private readonly UserManager<AppUser> _userManager;

        public WriterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [Authorize]
        public IActionResult Index()
        {
            var userMail = User.Identity.Name;
            ViewBag.userMail = userMail;
            
            var writerName = c.yazars.Where(x => x.yazarMail == userMail).Select(y => y.yazarAd).FirstOrDefault();
            ViewBag.v2 = writerName;
            return View();
        }
        public ActionResult WriterProfile()
        {
            return View();
        }
      
        public ActionResult WriterMail()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }
        [AllowAnonymous]
        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }
        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public async Task<IActionResult> WriterEditProfile()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserUpdateViewModel model = new UserUpdateViewModel();
            model.Mail = values.Email;
            model.NameSurname = values.NameSurname;
            model.Username = values.UserName;
            model.ImageUrl = values.ImgUrl;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> WriterEditProfile(UserUpdateViewModel userUpdateViewModel)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            values.NameSurname = userUpdateViewModel.NameSurname;
            values.ImgUrl = userUpdateViewModel.ImageUrl;
            values.Email = userUpdateViewModel.Mail;
            values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, userUpdateViewModel.Password);
            var result = await _userManager.UpdateAsync(values);
            return RedirectToAction("Index", "Dashboard");
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage addProfileImage)
        {
            Yazar writer = new Yazar();
            if (addProfileImage.yazarImg != null)
            {
                var extension = Path.GetExtension(addProfileImage.yazarImg.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                addProfileImage.yazarImg.CopyTo(stream);
                writer.yazarImg = newImageName;
            }
            writer.yazarMail = addProfileImage.yazarMail;
            writer.yazarAd = addProfileImage.yazarAd;
            writer.yazarSifre = addProfileImage.yazarSifre;
            //writer.yaz = addProfileImage.WriterPasswordRepeat;
            writer.yazarDurum = true;
            writer.yazarHakkinda = addProfileImage.yazarHakkinda;
            wm.TAdd(writer);
            
            return RedirectToAction("Index", "Dashboard");
        }

    }
}
