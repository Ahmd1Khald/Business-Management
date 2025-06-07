using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery_Store.Entities
{
    public class Order
    {
        [Key]
        public int ID { get; set; }

        public DateTime Date { get; set; }
        public int TotalAmount { get; set; }
        public double TotalPrice { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
