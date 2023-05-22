﻿namespace liaqati_master.Models
{
    public class User : IdentityUser
    {

        [Required, Display(Name = "الاسم الاول"), StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل")]
        public string? Fname { get; set; }

        [Required, Display(Name = "الاسم الأخير"), StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءً أدخل حرفين على الاقل")]
        public string? Lname { get; set; }

        //[Required(ErrorMessage = " هذا الحقل مطلوب")]
        [Display(Name = "حالة النشاط")]
        public bool? Active { get; set; }


        [Display(Name = "سنوات الخبرة"), MinLength(3, ErrorMessage = "على الاقل ثلاث سنوات")]
        public int? Exp_Years { get; set; }

        //[MinLength(50, ErrorMessage = "خمسبن كليوجرام على الاقل  ")]
        [Display(Name = "الوزن")]
        public int? Wieght { get; set; }

        //[MinLength(100, ErrorMessage = "مئة سم على الاقل")]
        [Display(Name = "الطول")]
        public int? Height { get; set; } //sm
        public Gender Gender { get; set; }

        [Display(Name = "التخصص  ")]
        public string? Specialization { get; set; }
        [Display(Name = "الصورة الشخصية")]
        public string? Photo { get; set; }

        [Display(Name = "الفيس بوك")]
        public string? WhatsApp { get; set; }


        [Display(Name = " تويتر")]
        public string? Twitter { get; set; }

        [Display(Name = "الانستقرام  ")]
        public string? Instagram { get; set; }
        [Display(Name = "تاريخ الميلاد"), DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }


        public virtual List<Replyconsultation> Replyconsultation { get; set; }
        public virtual List<Consultation>? Consultation { get; set; }

        public virtual List<Achievement>? Achievements { get; set; }
        public virtual List<Order>? Orders { get; set; }

        public virtual List<ChatUser>? ChatUser { get; set; }
        public virtual List<CartItem>? Cart { get; set; }
        public virtual List<Favorite>? Favorite { get; set; }

        public User()
        {
            Gender = Gender.Male;
        }
    }

}

