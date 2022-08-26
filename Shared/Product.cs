using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Shared
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; } = "https://www.pride.hr/images/thumbs/0000925_4033-pride-pro-training-and-sparring-gloves_1000.jpeg";
        [Column(TypeName = "decimal(18,2")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(18,2")]
        public decimal OriginalPrice { get; set; }
        public bool IsPublic { get; set; }

        public bool IsDeleted { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public List<Size> Sizes { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DatuUpdated { get; set; }
    }
}
