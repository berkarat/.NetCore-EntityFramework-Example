using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkExample.Models
{
    public class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            AppDbContext context = app.ApplicationServices.GetRequiredService<AppDbContext>();
            context.Database.Migrate();

            if (!context.Products.Any())
            {
                     context.Products.AddRange(
                     new Product() { ProductName = "Prd1", Price = 100 },
                     new Product() { ProductName = "Prd2", Price = 200 },
                     new Product() { ProductName = "Prd3", Price = 300 }
                                        );
                context.SaveChanges();
            }
        }

    }
}
