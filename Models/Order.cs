using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace liaqati_master.Models
{

    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم الطلبية")]
        public string Id { get; set; }
        //  [Required, Display(Tilte = "Last Tilte"), StringLength(50, MinimumLength = 2, ErrorMessage = "Please enter at least two characters")]
        //  public string Title { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "تاريخ الطلبية")]
        [DataType(DataType.DateTime)]
        public DateTime? OrderDate { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "مجموع الاسعار")]
        public double TotalPrice { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم الديليفري")]
        public int UserIdDelivery { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم صاحب الطلب")]
        public int UserIdResiver { get; set; }

        //ForignKsy User Model
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم المستخدم")]
        public string UserId { get; set; }
        public User? User { get; set; }



        public List<Order_Details>? Order_Details { get; set; }



    }

}

