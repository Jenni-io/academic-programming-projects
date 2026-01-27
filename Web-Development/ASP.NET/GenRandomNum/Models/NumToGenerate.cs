using GenRandomNum.Controllers;
using System.ComponentModel.DataAnnotations;

namespace GenRandomNum.Models
{
    public class NumToGenerate
    {
        [Required(ErrorMessage = "Please enter a valid number.")]
        public int startRange { get; set; }

        [Required(ErrorMessage = "Please enter a valid number.")] // Passes the name of the staring peoperty as a string to later locate
        [StartEndRangeValidation("startRange", ErrorMessage = "End range must be greater than the start range.")]
        public int endRange { get; set; }

        [Required(ErrorMessage = "Please enter a valid number")]
         public int numToGenerate { get; set; }


            Random rnd = new Random();
            public static List<string> numbers = new List<string>();

        // Method adds to list a randomly generated num
        public List<string> GetRandomNumFromRange() {
               
            numbers.Clear(); // clears list every time its call so no lingering numbers stay

            for (int i = 0; i < numToGenerate; i++)  {
                numbers.Add(rnd.Next(startRange, endRange + 1).ToString());
            }
            
            return numbers;
            }

        }
    }
