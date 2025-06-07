using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery_Store.Entities
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string NationalID { get; set; }
        public string Phone { get; set; }
    }

}
