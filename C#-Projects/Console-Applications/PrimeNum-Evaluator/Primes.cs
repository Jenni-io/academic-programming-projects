/* 
----------------------------------------------------------------
<Program Title> Is the number Prime
----------------------------------------------------------------
Developer:     Jenni Morales 
Creation date: 3/12/25
Last modified: 3/19/25
Email address: jamoralesjeronimo@senators.ws.edu
-----------------------------------------------------------------
Purpose: This program is the base of deciding if a number is prime and 
listing the first X number that are prime. The numbers wanted are base on input of user.
-----------------------------------------------------------------
*/

public class Primes
    {
    int number = 0;
    int numberOfPrimes = 0;

    public bool IsPrime(long number) {

        int index = 2; // sets start of prime numbers

        if (number < index) {
            return false; // if in
        } else {
            while (index < number) {
                if (number % index == 0) {
                    return false;
                } // end of nested if
                index++; // increments index by one

            } // end of while
            return true;
        } // end of if else
    } // end of method


    public string GetPrimes(int numberOfPrimes) {
        // validate input 


        int counter = 0;
        int list = 2; // list of first x prime num is acumulated 
        string result = "";

        // loop that ensures the first x num are prime
        while (counter < numberOfPrimes) {
            if (IsPrime(list)) {
                result += list + ", ";
                counter++;
            } // end of if
            list++;
        } // end of loop

        result = result.Remove(result.Length - 2); // takes off the trailing space and comma
        return result;
    } // end of method



    public string GetPrimes(long startRange, long endRange) {

        
        long list = startRange; // start num to check for primes
        string result = "";
        int counter = 0; // tracks num of primes foung

        // loop that ensures the first x num are prime
        while (list <= endRange)
        {
            if (IsPrime(list))
            {
                result += list + ", ";
                counter++;
            } // end of if
            list++;
        } // end of loop

        result = result.Remove(result.Length - 2); // takes off the trailing space and comma
        return result;

    }


    public long GetSpecificPrime(short primeToGet) {
        
        long count = 0;
        long number = 2; // prime nums start a 2 obviously now i know
        long specifiedPrime = 0;

        // loop to find Xth prime num 
        while (count < primeToGet) {
        
            if (IsPrime(number)) {
                count++;
                if (count == primeToGet) { // so if counter is same num as prime to get thats the Xth prime num.
                    specifiedPrime = number;
                }
            }

            number++;
        }
        return specifiedPrime; // returns that special number
    
    }


} // end of class
