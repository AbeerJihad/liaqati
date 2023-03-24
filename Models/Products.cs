using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace liaqati_master.Models
{
     public class Products
      {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            public string Id { get; set; }

        //[Required, StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل حرفين على الاقل")]
        //[Display(Tilte = "اسم المنتج")]اسم الصنف
        //public string Pname { get; set; }

      //  [ StringLength(50, MinimumLength = 2, ErrorMessage = "رجاءًأدخل صورة")]
        [Display(Name = "صورة المنتج")]
        public string? imgUrl { get; set; } = "";

            [Required]
            
            [Display(Name = "الخصم")]
            public double Discount { get; set; }

        //public int? CategoryId { get; set; }
        //public Category? Category { get; set; }
        
           public Service services { get; set; }

             //public int UserId { get; set; }
             //public User? User { get; set; }

     }
}
