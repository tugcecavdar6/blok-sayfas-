using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proje44.Controllers
{
    [AllowAnonymous]
    public class MessageController : Controller
    {
        Message2Manager _message2Manager = new Message2Manager(new EfMessage2Repository());
        Context _context = new Context();
        public IActionResult InBox()
        {
            var userName = User.Identity.Name;
            var userMail = _context.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = _context.yazars.Where(x => x.yazarMail == userMail).Select(y => y.yazarID).FirstOrDefault();
            var values = _message2Manager.GetInBoxListMessageByWriter(writerId);
            if (values.Count() > 3)
            {
                values = values.TakeLast(3).ToList();
            }
            return View(values);
        }

        public IActionResult SendBox()
        {
            var userName = User.Identity.Name;
            var userMail = _context.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = _context.yazars.Where(x => x.yazarMail == userMail).Select(y => y.yazarID).FirstOrDefault();
            var values = _message2Manager.GetSendBoxListMessageByWriter(writerId);
            if (values.Count() > 3)
            {
                values = values.TakeLast(3).ToList();
            }
            return View(values);
        }

        public IActionResult MessageDetails(int id)
        {
            var value = _message2Manager.GetById(id);
            return View(value);
        }

        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(Message2 message)
        {
            var userName = User.Identity.Name;
            var userMail = _context.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerID = _context.yazars.Where(x => x.yazarMail == userMail).Select(y => y.yazarID).FirstOrDefault();
            message.SenderId = writerID;
            message.ReceiverId = 2;
            message.MessageStatus = true;
            message.MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            _message2Manager.TAdd(message);
            return RedirectToAction("Inbox");
        }

        //public IActionResult MessageDetails(int id)
        //{
        //    var values = _message2Manager.GetById(id);
           
        //    return View(values);
        //}
    }
}
