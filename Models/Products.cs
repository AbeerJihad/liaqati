using System.ComponentModel.DataAnnotations;

namespace liaqati_master.Models
{


    public class Products
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "prouduct Name")]
        public string Pname { get; set; }

        [Required]
        [Display(Name = "Product Image")]
        public string imgUrl { get; set; }
        [Required]
        public double Price { get; set; }
        public double Discount { get; set; }

        //public int? CategoryId { get; set; }
        //public Category? Category { get; set; }

        public int? servicesId { get; set; }

        public Service? services { get; set; }

        //public int UserId { get; set; }
        //public User? User { get; set; }

    }
}
