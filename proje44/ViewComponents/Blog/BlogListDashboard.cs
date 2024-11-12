using BusinessLayer.Concrete;

using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreCamp.ViewComponents.Blog
{
    public class BlogListDashboard : ViewComponent
    {
         BlogManager _blogManager = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            var blogs = _blogManager.GetBlogListWithCategory();
            return View(blogs);
        }
    }
}
