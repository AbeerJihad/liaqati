using System.ComponentModel.DataAnnotations;

namespace liaqati_master.Models
{

    public class Order
    {
        // [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int Id { get; set; }
        //  [Required, Display(Name = "Last Name"), StringLength(50, MinimumLength = 2, ErrorMessage = "Please enter at least two characters")]
        //  public string Title { get; set; }

        [DataType(DataType.DateTime), Required]
        public DateTime? OrderDate { get; set; }
        [Required]
        public double TotalPrice { get; set; }
        public int UserIdDelivery { get; set; }
        public int UserIdResiver { get; set; }
        //ForignKsy User Model
        public int UserId { get; set; }
        public User? User { get; set; }
        public List<Order_Details>? Order_Details { get; set; }
    }

}

