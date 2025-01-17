﻿// <auto-generated />
using System;
using BlogApiDemo.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogApiDemo.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220620095633_mig2")]
    partial class mig2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlogApiDemo.DataAccessLayer.Blog", b =>
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

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("BlogApiDemo.DataAccessLayer.Category", b =>
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

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("BlogApiDemo.DataAccessLayer.Yazar", b =>
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

                    b.ToTable("Yazars");
                });

            modelBuilder.Entity("BlogApiDemo.DataAccessLayer.Yorumlar", b =>
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

                    b.ToTable("Yorumlars");
                });

            modelBuilder.Entity("BlogApiDemo.DataAccessLayer.Blog", b =>
                {
                    b.HasOne("BlogApiDemo.DataAccessLayer.Category", "Category")
                        .WithMany("Blogs")
                        .HasForeignKey("CategorykategoriID");

                    b.HasOne("BlogApiDemo.DataAccessLayer.Yazar", "yazar")
                        .WithMany("Blogs")
                        .HasForeignKey("yazarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("yazar");
                });

            modelBuilder.Entity("BlogApiDemo.DataAccessLayer.Yorumlar", b =>
                {
                    b.HasOne("BlogApiDemo.DataAccessLayer.Blog", "Blog")
                        .WithMany("yorumlars")
                        .HasForeignKey("BlogID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("BlogApiDemo.DataAccessLayer.Blog", b =>
                {
                    b.Navigation("yorumlars");
                });

            modelBuilder.Entity("BlogApiDemo.DataAccessLayer.Category", b =>
                {
                    b.Navigation("Blogs");
                });

            modelBuilder.Entity("BlogApiDemo.DataAccessLayer.Yazar", b =>
                {
                    b.Navigation("Blogs");
                });
#pragma warning restore 612, 618
        }
    }
}
