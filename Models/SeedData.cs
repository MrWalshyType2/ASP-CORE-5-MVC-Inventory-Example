using InventoryAppMvc.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryAppMvc.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new MvcItemContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcItemContext>>());

            if (context.Item.Any()) return;

            context.Item.AddRange(
                new Item
                {
                    Name = "Orange",
                    Description = "A fruit with a zest",
                    Price = 00.29M,
                    CreatedAt = DateTime.Now.Date
                },
                new Item
                {
                    Name = "Apple",
                    Description = "Fruit with a twang",
                    Price = 00.29M,
                    CreatedAt = DateTime.Now.Date
                },
                new Item
                {
                    Name = "Freddo",
                    Description = "The Freddo",
                    Price = 00.79M,
                    CreatedAt = DateTime.Now.Date
                }
            );

            context.SaveChanges();
        }
    }
}
