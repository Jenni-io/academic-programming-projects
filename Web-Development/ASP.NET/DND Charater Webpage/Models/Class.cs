using System.ComponentModel.DataAnnotations;

namespace Ch4Lab2.Models {

    public class Class {

        // will be PK in DB
        public int ClassId { get; set; }

        [Required(ErrorMessage ="Please enter the Class Name.")]
        public string Name { get; set; } = string.Empty;

        public string Slug => Name?.Replace(' ', '-').ToLower().ToString();

    }
}