using System.ComponentModel.DataAnnotations;

namespace Final_Project_GoW.Models
{
 	public class Abilities
    {
    public int AbilitiesID {get; set;} 

    [Required]
    [StringLength(40, MinimumLength =4)]

    public string Title {get; set;} = string.Empty;
    }
}