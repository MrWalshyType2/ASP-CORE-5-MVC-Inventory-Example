﻿using InventoryAppMvc.Data;
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
                    CreatedAt = DateTime.Now.Date,
                    Category = Category.FOOD,
                    Rating = 7
                },
                new Item
                {
                    Name = "Apple",
                    Description = "Fruit with a twang",
                    Price = 00.29M,
                    CreatedAt = DateTime.Now.Date,
                    Category = Category.FOOD,
                    Rating = 4
                },
                new Item
                {
                    Name = "Freddo",
                    Description = "The Freddo",
                    Price = 00.79M,
                    CreatedAt = DateTime.Now.Date,
                    Category = Category.FOOD,
                    Rating = 8
                },
                new Item
                {
                    Name = "Vimto",
                    Description = "The Vimto drink",
                    Price = 01.79M,
                    CreatedAt = DateTime.Now.Date,
                    Category = Category.DRINK,
                    Rating = 9
                },
                new Item
                {
                    Name = "Karakov",
                    Description = "Strong as all hell",
                    Price = 13.79M,
                    CreatedAt = DateTime.Now.Date,
                    Category = Category.ALCOHOL,
                    Rating = 6
                }
            );

            context.SaveChanges();
        }
    }
}
