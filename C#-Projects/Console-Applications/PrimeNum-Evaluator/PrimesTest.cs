/* 
----------------------------------------------------------------
<Program Title> Primes test Driver Class
----------------------------------------------------------------
Developer:     Jenni Morales Jeronimo
Creation date: 3/12/25
Last modified: 3/19/25
Email address: jamoralesjeronimo@senators.ws.edu
-----------------------------------------------------------------
Purpose:
This program allows the user to check if a number is prime, view the first 
X prime numbers, view all prime numbers in specified range, 
or view the xth prime num. 
DOES NOT CONTAIN FULL VALIDATION
-----------------------------------------------------------------
*/


public class PrimesTest {

    static void Main()
    {
        Primes Primes = new Primes();

        // A bunch of constant varibles cause they don't and won't be changed
        const long CHECK_IF_PRIME = 1;
        const long VEIW_FIRST_X_PRIME_NUM = 2;
        const long VIEW_RANGE_OF_PRIME_NUM = 3;
        const long VIEW_XTH_PRIME_NUM = 4;
        const long EXIT = 5;

        long choice;
        //  tells user whats happening
        Console.WriteLine("Prime Number Operations");
        Console.WriteLine("Enter the number of the operation to perform that operation.\n");

        while (true) {
            try {

                Console.WriteLine("Operations");
                Console.WriteLine("1: Check if number is prime");
                Console.WriteLine("2: View first X prime numbers");
                Console.WriteLine("3: View all prime numbers in range of numbers");
                Console.WriteLine("4: View Xth prime number");
                Console.WriteLine("5: Exit");

                // Get and Validate choice from user
                Console.Write("\nChoice: ");
                 choice = long.Parse(Console.ReadLine());

                if (choice < CHECK_IF_PRIME || choice > EXIT) {
                    throw new Exception ("Invalid option. Enter ethier 1, 2, 3, 4, or 5.\n");
                }

                break;
            } catch (FormatException) {
                    Console.WriteLine("Invalid option. Please enter a number\n");
                    
            } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
            }

        }
        // based on their choice what methods will be called and used
        switch (choice) {
            case CHECK_IF_PRIME:
                CheckIfNumberIsPrime();
                break;
            case VEIW_FIRST_X_PRIME_NUM:
                ViewFirstXPrimeNumbers();
                break;
            case VIEW_RANGE_OF_PRIME_NUM:
                ViewRangeOfPrimeNumbers();
                break;
            case VIEW_XTH_PRIME_NUM:
                ViewXthPrimeNumbers();
                break;
            case EXIT:
                Environment.Exit(0); 
                break;
        }

    }


        public static void CheckIfNumberIsPrime() {
            Primes Primes = new Primes();
            Console.WriteLine("Operation 1: Check if number is prime");
            Console.Write("Enter a non-negative integer value: ");
            long number = long.Parse(Console.ReadLine());

            // Validates input value
            while (number < 0)
            {
                Console.WriteLine("The specified value can not be negative.");
                Console.Write("Enter a non-negative integer value: ");
                number = long.Parse(Console.ReadLine());
            }

            // verfies if is prime or not
            Console.WriteLine();
            if (Primes.IsPrime(number) == true) {
                Console.WriteLine($"\n{number} is a prime number");
            } else {
                Console.WriteLine($"\n{number} is not a prime number");
            }
        }

        public static void ViewFirstXPrimeNumbers() {
            Primes Primes = new Primes();
            Console.WriteLine("Operation 2: View first X prime numbers");
            Console.Write("Enter a non-negative integer value: ");
            long numberOfPrimes = long.Parse(Console.ReadLine());

            // validates input
            while (numberOfPrimes < 1)
            {
                Console.WriteLine("The specified value can not be negative.");
                Console.Write("Enter a non-negative integer value: ");
                numberOfPrimes = long.Parse(Console.ReadLine());
            }

            // soooo this cast numbersOfPrimes to int and then calls the GetPrimes method to get string of first primes.
            string primes = Primes.GetPrimes((int)numberOfPrimes);

            Console.WriteLine($"\n First {numberOfPrimes} prime numbers: {primes}");


        }

        public static void ViewRangeOfPrimeNumbers() {
            
            Primes Primes = new Primes();
            
            // Gets and Validates start range 
            Console.WriteLine("Operation 3: View all prime numbers in range of numbers");
            Console.Write("Enter a non-negative integer value for the beginning range: ");
            long startRange = long.Parse(Console.ReadLine());

            
            while (startRange < 0)
            {

                Console.WriteLine("Start range cannot be negative");
                Console.Write("Enter a noninteger value for the beginning range: ");
                startRange = long.Parse(Console.ReadLine());
            }

        // Gets and Validates end range 
        Console.Write("Enter a non-negative integer value for the ending range: ");
            long endRange = long.Parse(Console.ReadLine());
            
            while (endRange <= startRange) {

                Console.WriteLine("End range must be greater than start range. Please enter a valid value.");
                Console.Write("Enter a non-negative integer value for the ending range: ");
                endRange = long.Parse(Console.ReadLine());
                
            }

            // gets the primes in specified range
            string primesInRange = Primes.GetPrimes(startRange, endRange);
            Console.WriteLine($"\nPrime numbers between {startRange} and {endRange}: {primesInRange}");
        }

        public static void ViewXthPrimeNumbers() {

            Primes Primes = new Primes();

            Console.WriteLine("4: View Xth prime number");
            Console.Write("Enter an integer value greater than zero: ");     
            short primetoGet = short.Parse(Console.ReadLine());
            
            // Validate prime num to get 
            while (primetoGet <= 0) {
                Console.WriteLine("The value must be greater than zero.");
                Console.Write("\"Enter an integer value greater than zero: \"");
                primetoGet = short.Parse(Console.ReadLine());
            }

            // this adds the correct end/suffix to the postion of num ex: 1st place
              string end = "";
            if (primetoGet == 1) {
                end = "st";
            } else if (primetoGet == 2) {
                end = "nd";
            } else if (primetoGet == 3) {
                 end = "rd";
            } else {
                end = "th";
            }

            // get that special Xth prime num from GetSpecificPrime method
            long Xthprime = Primes.GetSpecificPrime(primetoGet);
            Console.WriteLine($"\n{Xthprime} is the {primetoGet}{end} prime number.");

         }
}