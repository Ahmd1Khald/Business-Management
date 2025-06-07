using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery_Store.Entities
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
