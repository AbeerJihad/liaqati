using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace liaqati_master.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم المستخدم")]
        public string Id { get; set; }


        [Required , Display(Name ="الاسم الاول"),StringLength(50,MinimumLength =2,ErrorMessage = "رجاءًأدخل حرفين على الاقل")]
        public string Fname { get; set; }


        [Required, Display(Name = "الاسم الأخير"), StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءً أدخل حرفين على الاقل")]
        public string Lname { get; set; }

        [Required (ErrorMessage = " هذا الحقل مطلوب")]
        [Display(Name ="حالة النشاط")]
        public bool Active { get; set; }


        [ Display(Name = "سنوات الخبرة"),MinLength(3,ErrorMessage = "على الاقل ثلاث سنوات")]
        public int? Exp_Years { get; set; }

        [Required , MinLength(50, ErrorMessage = "خمسبن كليوجرام على الاقل  ")]
        [Display(Name = "الوزن")]
        public int Wieght { get; set; } 

        [Required, MinLength(100, ErrorMessage = "مئة سم على الاقل")]
        [Display(Name = "الطول")]
        public int Height { get; set; } //sm
        public Gender Gender { get; set; }

        [Display(Name = "الصورة الشخصية")]
        public string Photograph { get; set; }

        [Display(Name = "صورة الغلاف")]
        public string Cover_photo { get; set; }

        public List<Achievements>? Achievements { get; set; }
        public List<Order>? Orders { get; set; }

        public List<ChatUser>? ChatUser { get; set; }




        public User()
        {
            Gender = Gender.Male;

        }


    }

}

