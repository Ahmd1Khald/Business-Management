using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery_Store.Entities
{
    public enum Role { Admin,User }
    public class User
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "اسم المستخدم مطلوب")]
        [StringLength(50, ErrorMessage = "اسم المستخدم يجب ألا يتجاوز 50 حرفًا")]
        [Display(Name = "اسم المستخدم")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "كلمة المرور مطلوبة")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "كلمة المرور يجب أن تكون بين 6 و 100 حرف")]
        //[DataType(DataType.Password)]
        [Display(Name = "كلمة المرور")]
        public string Password { get; set; }

        [Required(ErrorMessage = "الرقم القومي مطلوب")]
        [StringLength(14, MinimumLength = 14, ErrorMessage = "الرقم القومي يجب أن يكون 14 رقمًا")]
        [RegularExpression(@"^\d{14}$", ErrorMessage = "الرقم القومي يجب أن يحتوي على 14 رقمًا")]
        [Display(Name = "الرقم القومي")]
        public string NationalID { get; set; }

        [Required(ErrorMessage = "رقم الهاتف مطلوب")]
        [Phone(ErrorMessage = "رقم الهاتف غير صالح")]
        [Display(Name = "رقم الهاتف")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "الدور مطلوب")]
        [Display(Name = "الدور")]
        public Role UserRole { get; set; }
    }

}
