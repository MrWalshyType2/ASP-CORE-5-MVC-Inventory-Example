using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryAppMvc.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        private DateTime createdAt;

        //[ReadOnly(true)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}")]
        public DateTime CreatedAt
        {
            get
            {
                if (createdAt == DateTime.MinValue) createdAt = DateTime.Now;
                return createdAt;
            } 
            
            set
            {
                if (value != DateTime.MinValue) createdAt = value;
                else createdAt = new DateTime().Date;
            }
        }

        public Category Category { get; set; }

        public decimal Price { get; set; }
        public int Rating { get; set; }
    }
}
