using Microsoft.AspNetCore.Mvc;
using proje44.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proje44.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    Username="Tuğçe"
                },
                new UserComment
                {
                    ID=2,
                    Username="Ayşe"
                },
                new UserComment
                {
                    ID=3,
                    Username="Merve"
                }
            };
            return View(commentvalues);
        }
    }
}
