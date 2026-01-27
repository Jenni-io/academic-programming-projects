using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
// Required to turn off validation for Genre property
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace MovieList.Models
{
    public class Movie
    {
        // EF Core will configure the database to generate this value
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a year.")]
        [Range(1889, 2999, ErrorMessage = "Year must be after 1889.")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Please enter a rating.")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public int? Rating { get; set; }

        // Specifying a foreign key property when adding Genre Property 
        [Required(ErrorMessage ="Please enter a genre.")]
        public int GenreId { get; set; } 

        public string Slug => Name?.Replace(' ', '-').ToLower() + '-' + Year?.ToString();

        //Adding a Genre property to the Movie class
        [ValidateNever] // Turning off data validation for Genre property 
        public Genre Genre { get; set; } = null!;

      

    }// end class
} // end namespace
