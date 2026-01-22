

using System;

class MathTest
{
    // Constants
    const int NUMBER_OF_PROBLEMS = 10;
    readonly static string[] POSITIVE_COMMENT = { "Correct!", "That's right!", "Yes!", "You got this", "" };
    readonly static string[] NEGATIVE_COMMENT = { "Incorrect.", "That's wrong.", "Nope." };
    readonly static Random m_rnd = new Random();
    static void Main()
    {
        Console.WriteLine(""); 
        Console.WriteLine("The Math Test\n");
        Console.WriteLine($"Enter the answer for the following {NUMBER_OF_PROBLEMS} math problems.\n");
        string repeat = "Y"; // Holds whether the user wants to do another Math Test
        while (repeat == "Y")
        {
            int numberCorrect = 0; // Holds the number of questions answered correctly
                                   // Output 10 questions
            try {

                for (int i = 0; i < NUMBER_OF_PROBLEMS; i++)
                {
                    Console.Write($"{i + 1}. {MathQuestion.GetProblem()}"); // Output a question

                    int userAnswer ; 

                    // Get answer from user and validate it
                    while (!int.TryParse(Console.ReadLine(), out userAnswer)) {
                        Console.WriteLine("Invalid value. Please enter only numbers.");
                    } // end while
                    int actualAnswer = MathQuestion.GetAnswer(); // Get actual answer



                    // Test if user's answer and actual answer are the same
                    if (userAnswer == actualAnswer)
                    {
                        numberCorrect++; // Increment number of correct answers
                        Console.WriteLine($"{GetPositiveComment()}\n");
                    } else {
                        Console.WriteLine($"{GetNegativeComment()}\n");
                    } // end if
                } // end for

            }catch (Exception ex) {
                    Console.WriteLine(ex.Message);
            }

              // Output results
            double percentage = ((double)numberCorrect / NUMBER_OF_PROBLEMS) * 100;
            Console.WriteLine($"You answered {numberCorrect} problems correctly: {percentage}%");
            // Determine if user wants to repeat Math Test
            Console.Write("Do you want to take another Math Test? (Y/n): ");
            repeat = Console.ReadLine().ToUpper();
            // Ensure to user either enters Y or N only
            while (!(repeat == "Y" || repeat == "N"))
            {
                Console.WriteLine("Enter 'Y' to take another Math Test or 'N' to exit.");
                Console.Write("Do you want to take another Math Test? (Y/n): ");
                repeat = Console.ReadLine().ToUpper();
            } // end while
        } // end while
    } // end method
    private static string GetPositiveComment()
    {
        return POSITIVE_COMMENT[m_rnd.Next(POSITIVE_COMMENT.Length)]; // Return a random positive comment
    } // end method
    private static string GetNegativeComment()
    {
        return NEGATIVE_COMMENT[m_rnd.Next(NEGATIVE_COMMENT.Length)]; // Return a random negative comment
    } // end method
} // end class
