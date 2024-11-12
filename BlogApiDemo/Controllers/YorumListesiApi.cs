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
    public class YorumListesiApi : ControllerBase
    {
        [HttpGet]
        public IActionResult YorumList()
        {
            using var context = new Context();
            var values = context.Yorumlars.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult YorumAdd(Yorumlar yorumlar)
        {
            using var context = new Context();
            context.Add(yorumlar);
            context.SaveChanges();
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult YorumGet(int id)
        {
            using var context = new Context();
            var yorum = context.Yorumlars.Find(id);
            if (yorum == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(yorum);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult YorumDelete(int id)
        {
            using var context = new Context();
            var yorum = context.Yorumlars.Find(id);
            if (yorum == null)
            {
                return NotFound();
            }
            else
            {
                context.Remove(yorum);
                context.SaveChanges();
                return Ok(yorum);
            }
        }

        [HttpPut]
        public IActionResult YorumUpdate(Yorumlar yorum)
        {
            using var context = new Context();
            var yor = context.Find<Yorumlar>(yorum.yorumID);
            if (yor == null)
            {
                return NotFound();
            }
            else
            {
                yor.yorumAd = yorum.yorumAd;
                context.Update(yor);
                context.SaveChanges();
                yor.yorumBaslik = yorum.yorumBaslik;
                context.Update(yor);
                context.SaveChanges();
                yor.yorumicerik = yorum.yorumicerik;
                context.Update(yor);
                context.SaveChanges();
                yor.yorumDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                context.Update(yor);
                context.SaveChanges();

                return Ok();
            }
        }
    }
}
