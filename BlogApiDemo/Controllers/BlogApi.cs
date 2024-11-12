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
    public class BlogApi : ControllerBase
    {
        [HttpGet]
        public IActionResult BlogList()
        {
            using var context = new Context();
            var values = context.Blogs.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult BlogAdd(Blog Blog)
        {
            using var context = new Context();
            context.Add(Blog);
            context.SaveChanges();
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult BlogGet(int id)
        {
            using var context = new Context();
            var blog = context.Blogs.Find(id);
            if (blog == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(blog);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult BlogDelete(int id)
        {
            using var context = new Context();
            var blog = context.Blogs.Find(id);
            if (blog == null)
            {
                return NotFound();
            }
            else
            {
                context.Remove(blog);
                context.SaveChanges();
                return Ok(blog);
            }
        }

        [HttpPut]
        public IActionResult BlogUpdate(Blog blog)
        {
            using var context = new Context();
            var blo = context.Find<Blog>(blog.yazarID);
            if (blo == null)
            {
                return NotFound();
            }
            else
            {
                blo.BlogBaslik = blog.BlogBaslik;
                context.Update(blo);
                context.SaveChanges();
                blo.Blogicerik = blog.Blogicerik;
                context.Update(blo);
                context.SaveChanges();
                blo.BlogImg = blog.BlogImg;
                context.Update(blo);
                context.SaveChanges();
                blo.BlogkucukImg = blog.BlogkucukImg;
                context.Update(blo);
                context.SaveChanges();
                blo.BlogTarih = blog.BlogTarih;
                context.Update(blo);
                context.SaveChanges();
                blo.Category.kategoriAd = blog.Category.kategoriAd;
                context.Update(blo);
                context.SaveChanges();
                blo.yazar.yazarAd = blog.yazar.yazarAd;
                context.Update(blo);
                context.SaveChanges();
                return Ok();
            }
        }
    }
}
