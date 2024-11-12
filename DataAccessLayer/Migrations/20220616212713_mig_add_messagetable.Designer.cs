﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220616212713_mig_add_messagetable")]
    partial class mig_add_messagetable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.Blog", b =>
                {
                    b.Property<int>("BlogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BlogBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("BlogDurum")
                        .HasColumnType("bit");

                    b.Property<string>("BlogImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BlogTarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("Blogicerik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogkucukImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CategorykategoriID")
                        .HasColumnType("int");

                    b.Property<int>("kategoriID")
                        .HasColumnType("int");

                    b.Property<int>("yazarID")
                        .HasColumnType("int");

                    b.HasKey("BlogID");

                    b.HasIndex("CategorykategoriID");

                    b.HasIndex("yazarID");

                    b.ToTable("blogs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.BlogRayting", b =>
                {
                    b.Property<int>("BlogRaytingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<int>("BlogRaytingCount")
                        .HasColumnType("int");

                    b.Property<int>("BlogTotalScore")
                        .HasColumnType("int");

                    b.HasKey("BlogRaytingId");

                    b.ToTable("BlogRaytings");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Property<int>("kategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("kategoriAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kategoricerik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("kategoridurum")
                        .HasColumnType("bit");

                    b.HasKey("kategoriID");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Message", b =>
                {
                    b.Property<int>("MesajId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gonderen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Konu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MesajDetay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MesajDurum")
                        .HasColumnType("bit");

                    b.Property<DateTime>("MesajTarih")
                        .HasColumnType("datetime2");

                    b.HasKey("MesajId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Message2", b =>
                {
                    b.Property<int>("MesajId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AliciId")
                        .HasColumnType("int");

                    b.Property<int?>("GonderenId")
                        .HasColumnType("int");

                    b.Property<string>("Konu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MesajDetay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MesajDurum")
                        .HasColumnType("bit");

                    b.Property<DateTime>("MesajTarih")
                        .HasColumnType("datetime2");

                    b.HasKey("MesajId");

                    b.HasIndex("AliciId");

                    b.HasIndex("GonderenId");

                    b.ToTable("Message2s");
                });

            modelBuilder.Entity("EntityLayer.Concrete.NewsLetter", b =>
                {
                    b.Property<int>("MailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MailDurum")
                        .HasColumnType("bit");

                    b.HasKey("MailID");

                    b.ToTable("NewsLetters");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Notification", b =>
                {
                    b.Property<int>("NotificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NotificationDetay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("NotificationDurum")
                        .HasColumnType("bit");

                    b.Property<string>("NotificationRengi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NotificationTarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("NotificationTurSembolu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotificationTuru")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NotificationId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Yazar", b =>
                {
                    b.Property<int>("yazarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("yazarAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("yazarDurum")
                        .HasColumnType("bit");

                    b.Property<string>("yazarHakkinda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("yazarImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("yazarMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("yazarSifre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("yazarID");

                    b.ToTable("yazars");
                });

            modelBuilder.Entity("EntityLayer.Concrete.hakkimda", b =>
                {
                    b.Property<int>("hakkimdaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("hakkimdaDetay1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hakkimdaDetay2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("hakkimdaDurum")
                        .HasColumnType("bit");

                    b.Property<string>("hakkimdaHaritaLokasyon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hakkimdaImg1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hakkimdaImg2")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("hakkimdaID");

                    b.ToTable("hakkimdas");
                });

            modelBuilder.Entity("EntityLayer.Concrete.iletisim", b =>
                {
                    b.Property<int>("iletisimID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("iletisimBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("iletisimDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("iletisimDurum")
                        .HasColumnType("bit");

                    b.Property<string>("iletisimKullaniciAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("iletisimMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("iletisimMesaj")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("iletisimID");

                    b.ToTable("iletisims");
                });

            modelBuilder.Entity("EntityLayer.Concrete.yorumlar", b =>
                {
                    b.Property<int>("yorumID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogID")
                        .HasColumnType("int");

                    b.Property<int>("BlogScore")
                        .HasColumnType("int");

                    b.Property<string>("yorumAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("yorumBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("yorumDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("yorumDurum")
                        .HasColumnType("bit");

                    b.Property<string>("yorumicerik")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("yorumID");

                    b.HasIndex("BlogID");

                    b.ToTable("yorumlars");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Blog", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Category", "Category")
                        .WithMany("Blogs")
                        .HasForeignKey("CategorykategoriID");

                    b.HasOne("EntityLayer.Concrete.Yazar", "yazar")
                        .WithMany("blogs")
                        .HasForeignKey("yazarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("yazar");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Message2", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Yazar", "AliciUser")
                        .WithMany("WriterAlici")
                        .HasForeignKey("AliciId");

                    b.HasOne("EntityLayer.Concrete.Yazar", "GonderenUser")
                        .WithMany("WriterGonderen")
                        .HasForeignKey("GonderenId");

                    b.Navigation("AliciUser");

                    b.Navigation("GonderenUser");
                });

            modelBuilder.Entity("EntityLayer.Concrete.yorumlar", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Blog", "Blog")
                        .WithMany("yorumlars")
                        .HasForeignKey("BlogID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Blog", b =>
                {
                    b.Navigation("yorumlars");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Navigation("Blogs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Yazar", b =>
                {
                    b.Navigation("blogs");

                    b.Navigation("WriterAlici");

                    b.Navigation("WriterGonderen");
                });
#pragma warning restore 612, 618
        }
    }
}
