using InventoryAppMvc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryAppMvc.Data
{
    public class MvcItemContext : DbContext
    {
        public MvcItemContext(DbContextOptions<MvcItemContext> options) : base(options)
        {

        }

        public DbSet<Item> Item { get; set; }
    }
}
