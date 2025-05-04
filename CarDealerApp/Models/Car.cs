using System.ComponentModel.DataAnnotations;

namespace CarDealerApp.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Display(Name = "Engine Type")]
        public string EngineType { get; set; }

        public string Color { get; set; }

        [Display(Name = "Horse Power")]
        public int HorsePower { get; set; }
    }
}
