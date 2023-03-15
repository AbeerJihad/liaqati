using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace liaqati_master.Models
{
    public class Achievements
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "رقم الانجاز")]
        public string Id { get; set; }
       
        [Required, Display(Name = "الانجاز"), StringLength(50, MinimumLength = 2, ErrorMessage = "هذا الحقل مطلوب")]
        public string Title { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "تاريخ البدء ")]
        [DataType(DataType.DateTime)]
        public DateTime FromDate { get; set; }
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "الى تاريخ")]
        public DateTime ToDate { get; set; }
        [Display(Name = "وثائق الانجازات")]
        public string File { get; set; }

        //ForignKsy User Model
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم المستخدم")]
        public string UserId { get; set; }
        public User? User { get; set; }

    }
}

