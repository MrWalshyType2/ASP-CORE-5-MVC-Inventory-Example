using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryAppMvc.Models
{
    public class ItemViewModel
    {
        public List<Item> Items { get; set; }
        public SelectList Categories { get; set; }
        public string ItemCategory { get; set; }
        public string SearchTerm { get; set; }
    }
}
