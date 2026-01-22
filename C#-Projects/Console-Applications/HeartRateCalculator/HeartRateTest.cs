/* 
----------------------------------------------------------------
<Program Title> Heart Rate test drive
----------------------------------------------------------------
Developer:     Jenni Morales Jeronimo
Creation date: 3/27/2025
Last modified: 4/2/2025
Email address: jamoralesjeronimo@senators.ws.edu
-----------------------------------------------------------------
Purpose:
A class that concats the stuff from Heart Rate.cs file 
and outputs calculated  heart rates also contains user validation methods depending on input.
-----------------------------------------------------------------
*/
class HeartRateTest
{
    static void Main()
    {
       bool Ans = true;
        Console.WriteLine("Target Heart-Rate Calculator\n");
        Console.WriteLine("Answer the following questions to determine your target heart rate.\n");
        while (Ans ) {
 
            // Get first name from user
            string name = "";
            while (true) {
                try { 
                    Console.Write("What is your name? ");
                    name = Console.ReadLine();

                    if (name.Length <= 0) {
                        throw new Exception("Invalid name: a name must have one or more characters. ");
                    }

                    break;
                }  catch (FormatException) {
                    Console.WriteLine("Invalid name: a birth year must be 4 digits," +
                            " less than the current year, and reasonable");
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }

            } // end

              // Get birth year from user
            int birthYear = 0;
            int currentYear = DateTime.Now.Year;
            while (true)  {
                try {
                    Console.Write("What is your birth year? ");
                    birthYear = int.Parse(Console.ReadLine());


                    

                    if (birthYear.ToString().Length != 4 || birthYear < (currentYear - 125) || birthYear >= currentYear) {
                        throw new Exception("Invalid name: a birth year must be 4 digits," +
                            " less than the current year, and reasonable");

                    }
                    break;

                }  catch (FormatException) {
                    Console.WriteLine("Invalid name: a birth year must be 4 digits," +
                            " less than the current year, and reasonable");
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }// end try

            // Create object of HeartRate class
            HeartRate userHeartRate = new HeartRate(birthYear);

            Console.WriteLine($"\nHeart Rate Information for {name}:");
            Console.WriteLine($"\t{"Age:",-30}{userHeartRate.GetAge()} years old");
            Console.WriteLine($"\t{"Maximum heart rate:",-30}{userHeartRate.GetMaxHeartRate()} beats/minute");
            Console.WriteLine($"\t{"Minimum target heart rate:",-30}{userHeartRate.GetMinTargetHeartRate()} beats/minute");
            Console.WriteLine($"\t{"Maximum target heart rate:",-30}{userHeartRate.GetMaxTargetHeartRate()} beats/minute");
            while (true)  {
                try
                {
                    Console.Write("Would you like to calculate another target heart rate? (Y/n): ");
                    string answer = Console.ReadLine().ToLower();

                    if (answer != "y"  && answer != "n")
                    {
                        throw new Exception("Invalid answer: Please enter y or n");
                       
                    }
                    if (answer == "n"){
                        Ans = false;
                    }
                    break;
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }
        } 

    }   // end method
} // end class
