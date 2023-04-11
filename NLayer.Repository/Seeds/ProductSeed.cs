using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id = 1,
                CategoryId = 1,
                Name = "Kalem 1",
                Price = 100,
                Stock = 20,
                CreatedDate = DateTime.Now,
            },
               new Product
               {
                   Id = 2,
                   CategoryId = 1,
                   Name = "Kalem 2",
                   Price = 150,
                   Stock = 40,
                   CreatedDate = DateTime.Now,
               },
                   new Product
                   {
                       Id = 3,
                       CategoryId = 2,
                       Name = "Kitaplar 1",
                       Price = 210,
                       Stock = 10,
                       CreatedDate = DateTime.Now,
                   },
                   new Product
                   {
                       Id = 4,
                       CategoryId = 2,
                       Name = "Kitaplar 2",
                       Price = 300,
                       Stock = 100,
                       CreatedDate = DateTime.Now,
                   },
                   new Product
                   {
                       Id = 5,
                       CategoryId = 2,
                       Name = "Kitaplar 3",
                       Price = 250,
                       Stock = 20,
                       CreatedDate = DateTime.Now,
                   });
        }
    }
}
