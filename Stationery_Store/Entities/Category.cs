using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery_Store.Entities
{
    public class Category
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
