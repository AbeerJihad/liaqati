using System.ComponentModel.DataAnnotations;

namespace liaqati_master.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required, Display(Name = "Cetegory Name"), StringLength(50, MinimumLength = 2, ErrorMessage = "Please enter the category name")]

        public string Name { get; set; }
        public Target target { get; set; }

        //public string categoryFor { get; set; }
        public string? Image { get; set; }
        //public List<Products>? products { get; set; }
        public List<Service>? services { get; set; }

        public List<Articles>? articles { get; set; }
    }

    public enum Target
    {
        //prouducts,
    }
}
