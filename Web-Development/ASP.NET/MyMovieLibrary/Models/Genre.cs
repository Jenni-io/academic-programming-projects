
using System.ComponentModel.DataAnnotations;
namespace MovieList.Models {
    public class Genre {

        
        public int GenreId { get; set; } 
        public string Name { get; set; } = string.Empty;

        public string Slug => Name?.Replace(' ', '-').ToLower().ToString();

     


    }// end class
} // end namespace 
