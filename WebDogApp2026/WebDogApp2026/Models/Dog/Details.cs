using System.ComponentModel.DataAnnotations;

namespace WebDogApp2026.Models.Dog
{
    public class Details
    {
        public int Id { get; set; }

        [Display(Name = "Dog Name")]
        public string Name { get; set; } = null!;

        [Display(Name = "Age")]
        public int Age { get; set; }

        [Display(Name = "Breed")]
        public string BreedName { get; set; } = null!;

        [Display(Name = "Dog Picture")]
        public string Picture { get; set; } = null!;
    }
}
