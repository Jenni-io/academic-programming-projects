using System.ComponentModel.DataAnnotations;

namespace Ch4Lab2.Models {
    public class Ancestry {

        // will be PK in DB
        public int AncestryId { get; set; }
        [Required(ErrorMessage = "Please enter the character's Origin.")]
        public string Origin { get; set; } = string.Empty;

        public string Slug => Origin?.Replace(' ', '-').ToLower().ToString();
    }
}
