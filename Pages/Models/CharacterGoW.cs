using System.ComponentModel.DataAnnotations;

namespace Final_Project_GoW.Models
{
	public class CharacterGoW
    {
    public int CharacterGoWID {get; set;} //Primary Key

    [Required]
    [StringLength(40, MinimumLength =4)]

    public string Title {get; set;} = string.Empty;
    }
}