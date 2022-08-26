using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Shop.Server.Models;
using Shop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Server.Data
{
    public class DataContext : DbContext
    {
  

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Size> Sizes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Rukavice", Url = "rukavice", Icon = "book" },
                new Category { Id = 2, Name = "Kacige", Url = "kacige", Icon = "camera-slr" },
                new Category { Id = 3, Name = "Kostobrani", Url = "kostobrani", Icon = "aperture" },
                new Category { Id = 4, Name = "Kikovi", Url = "kikovi", Icon = "book" },
                new Category { Id = 5, Name = "Kimona", Url = "kimona", Icon = "book" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "Rukavice",
                    Description = "Rukavice za boks 10oz",
                    Image = "https://www.pride.hr/images/thumbs/0000925_4033-pride-pro-training-and-sparring-gloves_1000.jpeg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },

                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Title = "Rukavice Adidas",
                    Description = "Rukavice marke Adidas 12oz",
                    Image = "https://www.pride.hr/images/thumbs/0001782_a7150-adidas-boxing-gloves-speed-50_1000.jpeg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 1,
                    Title = "Rukavice Adidas 14oz",
                    Description = "Rukavice marke Adidas 14oz",
                    Image = "https://www.pride.hr/images/thumbs/0001782_a7150-adidas-boxing-gloves-speed-50_1000.jpeg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                }
        
            );

            modelBuilder.Entity<Size>().HasData(
                new Size { Id = 1, Name = "8oz" },
                new Size { Id = 2, Name = "10oz" },
                new Size { Id = 3, Name = "12oz" },
                new Size { Id = 4, Name = "14oz" },
                new Size { Id = 5, Name = "16oz" },
                new Size { Id = 6, Name = "XXS" },
                new Size { Id = 7, Name = "XS"},
                new Size { Id = 8, Name = "S" },
                new Size { Id = 9, Name = "M" },
                new Size { Id = 10, Name = "L" },
                new Size { Id = 11, Name = "XL" },
                new Size { Id = 12, Name = "2XL" },
                new Size { Id = 13, Name = "3XL" }
                );


            modelBuilder.SharedTypeEntity<Dictionary<string, object>>("ProductSize").HasData(
                new { ProductsId = 1, SizesId = 2},
                new { ProductsId = 1, SizesId = 3},
                new { ProductsId = 1, SizesId = 4},
                new { ProductsId = 2, SizesId = 2},
                new { ProductsId = 2, SizesId = 3},
                new { ProductsId = 2, SizesId = 4},
                new { ProductsId = 3, SizesId = 1},
                new { ProductsId = 3, SizesId = 2},
                new { ProductsId = 3, SizesId = 3},
                new { ProductsId = 3, SizesId = 4},
                new { ProductsId = 4, SizesId = 8},
                new { ProductsId = 4, SizesId = 9},
                new { ProductsId = 4, SizesId = 10},
                new { ProductsId = 4, SizesId = 11}

                );
        }
    }
}
