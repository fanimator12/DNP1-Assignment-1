using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models {
public class Family {
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
    public int UserId { get; set; }
    public int FamilyId { get; set; }
    [Required, MaxLength(128)]
    public string Title { get; set; }
}
}