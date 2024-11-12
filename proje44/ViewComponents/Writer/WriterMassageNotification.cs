using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proje44.ViewComponents.Writer
{
    public class WriterMassageNotification : ViewComponent
    {
        private Message2Manager _message2Manager = new Message2Manager(new EfMessage2Repository());
        private Context _context = new Context();
        public IViewComponentResult Invoke()
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
    }
}
