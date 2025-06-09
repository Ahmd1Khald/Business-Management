using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery_Store.Entities
{
    public class OrderItem
    {
        [Key]
        public int ID { get; set; }

        public int Quantity { get; set; }
        public double UnitPrice { get; set; }

        [ForeignKey("Product")]
        public int? ProductId { get; set; }  // لازم نخليها nullable عشان نحذف المنتج بعدين
        public virtual Product? Product { get; set; }

        public string ProductName { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }


}
