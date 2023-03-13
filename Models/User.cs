using System.ComponentModel.DataAnnotations;

namespace liaqati_master.Models
{
    public class User
    {
        //  [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int Id { get; set; }


        [Required, Display(Name = "First Name"), StringLength(50, MinimumLength = 2, ErrorMessage = "Please enter at least two characters")]
        public string Fname { get; set; }


        [Required, Display(Name = "Last Name"), StringLength(50, MinimumLength = 2, ErrorMessage = "Please enter at least two characters")]
        public string Lname { get; set; }

        [Required]
        public bool Active { get; set; }


        [Display(Name = "Experience Years"), MinLength(3, ErrorMessage = "Minimum 3 years of experience")]
        public int? Exp_Years { get; set; }

        [Required, MinLength(50, ErrorMessage = "Minimum 50  KG")]
        public int Wieght { get; set; }

        [Required, MinLength(100, ErrorMessage = "Minimum 100  SM")]
        public int Height { get; set; } //sm
        public Gender Gender { get; set; }


        public string Photograph { get; set; }

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

