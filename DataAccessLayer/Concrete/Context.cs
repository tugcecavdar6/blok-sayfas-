﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
   public class Context:IdentityDbContext<AppUser, AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-VBTGKOM\\SQLEXPRESS; database=BlogSayfasiDb; integrated security=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message2>()
                .HasOne(w => w.SenderUserWriter)
                .WithMany(w => w.WriterSender)
                .HasForeignKey(m => m.SenderId)
                .OnDelete(deleteBehavior: DeleteBehavior.ClientSetNull);

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Message2>()
                .HasOne(w => w.ReceiverUserWriter)
                .WithMany(w => w.WriterRecevier)
                .HasForeignKey(m => m.ReceiverId)
                .OnDelete(deleteBehavior: DeleteBehavior.ClientSetNull);
        }


        public DbSet<hakkimda> hakkimdas { get; set; }
        public DbSet<Blog> blogs { get; set; }
        public DbSet<Category> categories { get; set; }
      
        public DbSet<iletisim1> iletisims { get; set; }
        public DbSet<Yazar> yazars { get; set; }
        public DbSet<yorumlar> yorumlars { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<BlogRayting> BlogRaytings { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Message2> Messages2 { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}
