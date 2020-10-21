using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class Family
    {
        public Family()
        {
            Adults = new List<Adult>();
            Children = new List<Child>();
            Pets = new List<Pet>();
        }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public int Id { get; set; }

        [Required] [MaxLength(128)] public string StreetName { get; set; }

        [Required] public int HouseNumber { get; set; }

        [Required] public List<Adult> Adults { get; set; }

        [Required] public List<Child> Children { get; set; }

        public List<Pet> Pets { get; set; }
    }
}