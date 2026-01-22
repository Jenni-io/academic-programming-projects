using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Ch4Lab2.Models {

    public class Character {

        // Will be PK column in database
        public int CharacterID { get; set; }

        [Required(ErrorMessage = "Please enter the character's first name.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter the character's last name.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter the character's strength stat.")]
        [Range(0, 30, ErrorMessage = "The strength stat must be between 0 and 30.")]
        public int? Strength { get; set; }

        [Required(ErrorMessage = "Please enter the character's intelligence stat.")]
        [Range(0, 30, ErrorMessage = "The intelligence stat must be between 0 and 30.")]
        public int? Intelligence { get; set; }
       
        // Specifying a foreign key property when adding Class Property 
        [Required(ErrorMessage = "Please enter a class.")]
        public int ClassId { get; set; }

        //Adding a Class property to the Character class
        [ValidateNever] // Turning off data validation for class property 
        public Class Class { get; set; } = null!;

        // Specifying a foreign key property when adding Ancestry Property 
        [Required(ErrorMessage = "Please enter a Ancestry.")]
        public int AncestryId { get; set; }

        //Adding a Ancestry property to the Character class
        [ValidateNever] // Turning off data validation for Ancestry property 
        public Ancestry Ancestry { get; set; } = null!;

        public string Slug => LastName?.Replace(' ', '-').ToLower().ToString();
    } // end class
} // end namespace