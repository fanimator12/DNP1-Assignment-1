using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Assignment1.Models {
public class Family {
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
    public int Id { get; set; }
    [Required, MaxLength(128)]
    public string StreetName { get; set; }
    [Required]
    public int HouseNumber{ get; set; }
    [Required]
    public List<Person> Adults { get; set; }
    [Required]
    public List<Child> Children{ get; set; }
    public List<Pet> Pets{ get; set; }

    public Family() {
        Adults = new List<Person>();  
        Children = new List<Child>();
        Pets = new List<Pet>();
    }
}
}