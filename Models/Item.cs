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

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }

        [StringLength(256, MinimumLength = 8)]
        public string Description { get; set; }

        private DateTime createdAt;

        [Editable(false)]
        [Display(Name = "Created At"), DataType(DataType.Date)]
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

        [Required]
        public Category Category { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Required]
        [Range(0, 5)]
        public int Rating { get; set; }
    }
}
