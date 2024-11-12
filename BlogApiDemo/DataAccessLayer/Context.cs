using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApiDemo.DataAccessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-VBTGKOM\\SQLEXPRESS; database=BlogSayfasiDb; integrated security=true");
        }

        public DbSet<Yazar> Yazars { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
