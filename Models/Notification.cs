﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace liaqati_master.Models
{
    public class Notification
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }


        [Required, Display(Name = "العتوان"), StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءاًأدخل حرفين على الاقل")]
        public string Title { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = " تاريخ الاشعار")]
        [DataType(DataType.DateTime)]
        public DateTime DATE { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "وقت الاشعار")]
        [DataType(DataType.DateTime)]
        public DateTime Time { get; set; }

        [Required, StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل")]
        [Display(Name = "المحتوى")]
        public string Text { get; set; }

        //ForignKsy User Model
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم المستخدم")]
        public string UserId { get; set; }
        public User? User { get; set; }

    }
}
