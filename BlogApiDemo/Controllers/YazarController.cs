using BlogApiDemo.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YazarController : ControllerBase
    {
        [HttpGet]
        public IActionResult YazarList()
        {
            using var context = new Context();
            var values = context.Yazars.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult YazarAdd(Yazar yazar)
        {
            using var context = new Context();
            context.Add(yazar);
            context.SaveChanges();
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult YazarGet(int id)
        {
            using var context = new Context();
            var yazar = context.Yazars.Find(id);
            if (yazar == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(yazar);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult YazarDelete(int id)
        {
            using var context = new Context();
            var yazar = context.Yazars.Find(id);
            if (yazar == null)
            {
                return NotFound();
            }
            else
            {
                context.Remove(yazar);
                context.SaveChanges();
                return Ok(yazar);
            }
        }

        [HttpPut]
        public IActionResult YazarUpdate(Yazar yazar)
        {
            using var context = new Context();
            var yaz = context.Find<Yazar>(yazar.yazarID);
            if (yaz == null)
            {
                return NotFound();
            }
            else
            {
                yaz.yazarAd = yazar.yazarAd;
                context.Update(yaz);
                context.SaveChanges();
                yaz.yazarHakkinda = yazar.yazarHakkinda;
                context.Update(yaz);
                context.SaveChanges();
                yaz.yazarMail = yazar.yazarMail;
                context.Update(yaz);
                context.SaveChanges();
                yaz.yazarImg = yazar.yazarImg;
                context.Update(yaz);
                context.SaveChanges();
                yaz.yazarSifre = yazar.yazarSifre;
                context.Update(yaz);
                context.SaveChanges();
                return Ok();
            }
        }
    }
}
