public class Fraction {

    ////comment or remove this Main method/Driver
    //static void Main()
    //{
    //    try
    //    {
    //        Fraction frac1 = new Fraction(7, 5);
    //        Fraction frac2 = new Fraction(7, 9);
    //        Console.WriteLine(frac2.ToDecimal());
    //        Console.WriteLine(frac1 + frac2);
    //        Console.WriteLine(frac1 - frac2);
    //        Console.WriteLine(frac1 * frac2);
    //        Console.WriteLine(frac1 / frac2);

    //    }
    //    catch (DivideByZeroException ex)
    //    {
    //        // Catch the specific DivideByZeroException
    //        Console.WriteLine($"Error: {ex.Message}");
    //    }//end method
    //}

    private int _numerator;
    private int _denominator;
    
    // could have been auto implemented
    public int Numerator {
        get { 
            return _numerator; 
        } set { 
            _numerator = value;
        }
    }

    public int Denominator {
        get { 
            return _denominator;
        } set { 
            if (value == 0) {
                throw new DivideByZeroException("Denominator cannot be zero. ( =");
                
            }
            _denominator = value;
        }
    }

    public Fraction () {
        // sets default Numer and Denom to 1
        Numerator = 1;
        Denominator = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        // sets numer and Denom to the values passed in 
        Numerator = numerator;
        Denominator = denominator;
    }

    public Fraction(Fraction thisFraction) {
        //  Copies the Numerator and Denominator property values of the
        // passed-in Fraction object to this Fraction

        Numerator = thisFraction.Numerator;
        Denominator = thisFraction.Denominator;
    }

    private void Reduce()
    {
        int lowestNum = 0;
        int checkNumer = 0;
        int checkDenom = 0;
        int holdNumer = Numerator;
        int holdDenom = Denominator;

        // first we find the range we can loop. the lowest num will be the Max num in the range.
        if (Numerator > Denominator) {
            lowestNum = Denominator;
        } else {
            lowestNum = Numerator;
        }
        // here we loop thru trying to find the Greatest common factor from the range 2 to 
        // the lowest num of fraction(can be numerator or denominator).
        for (int findGCF = lowestNum; findGCF > 1; findGCF--)
        {  
            checkDenom = Denominator % findGCF;
            checkNumer = Numerator % findGCF;

               // if the Numerator and Denominator is divisable by the same number divide
               // both numbers by said num
            if (checkDenom == 0 && checkNumer == 0)
            {
                Numerator = holdNumer / findGCF;
                Denominator = holdDenom / findGCF;
                break;
            }
            if (findGCF == 1) { // If numerator and denom arent both divisable
                            // by the same num they are already in its simples form
                Numerator = holdNumer; 
                Denominator = holdDenom;
                break;
            }
                               
        }
            
        
    }

    //Done tested addtion operator
    public static Fraction operator+(Fraction x, Fraction y) {

        // did this to if not needed, not have to make the numbers bigger
        if (x.Denominator == y.Denominator) { 
            Fraction addResult1 = new Fraction((x.Numerator + y.Numerator), x.Denominator);
            addResult1.Reduce();
            return addResult1;
        }
        else
        {
            
            int newDenominator = x.Denominator * y.Denominator;
            int newNumerator = (x.Numerator * y.Denominator) + (y.Numerator * x.Denominator);

            Fraction addResult2 = new Fraction(newNumerator, newDenominator);
             addResult2.Reduce(); // return reduces fraction

            return addResult2;
        }
        
    }

    //Done tested the SUBTRACT Operator
    public static Fraction operator -(Fraction x, Fraction y) {
        // did this to if not needed, not have to make the numbers bigger
        if (x.Denominator == y.Denominator)
        {
            //just subtracts the numerators
            Fraction subResult1 = new Fraction(x.Numerator - y.Numerator, x.Denominator);
            subResult1.Reduce();

            return subResult1;

        } else {
            
            int newDenominator = x.Denominator * y.Denominator;
            int newNumerator = (x.Numerator * y.Denominator) - (y.Numerator * x.Denominator);

            Fraction subResult2 = new Fraction(newNumerator, newDenominator);
            subResult2.Reduce();

            return subResult2;
        }

    }

    //Done tested the Multiplication Operator
    public static Fraction operator *(Fraction x, Fraction y) { 

        Fraction multiplyFracResult = new Fraction(x.Numerator * y.Numerator, x.Denominator * y.Denominator);
        multiplyFracResult.Reduce();

        return multiplyFracResult;
    }

    //Done tested the Division Operator
    public static Fraction operator /(Fraction x, Fraction y) {
        // I am using the Keep (Keep fraction x the same), change operator, and flip fraction y method to divide

        if (y.Numerator == 0) {
            throw new InvalidOperationException("Invalid numerator. Calculation requires division by Zero and math doesn't allow that >_<");
        }

        int oldDenominator = y.Denominator; // keeps passed in denominator 
        y.Denominator = y.Numerator; // makes passed in demonimator to numerator
        y.Numerator = oldDenominator; // makes numerator to pass in denominator

        Fraction divedFracResult = new Fraction(x.Numerator * y.Numerator, x.Denominator * y.Denominator);
        divedFracResult.Reduce();

        return divedFracResult;
    }

    public override string ToString()
    {
       return $"{Numerator}/{Denominator}"; // Wraps fraction together
    }

    public double ToDecimal(int decimalPlaces = 3) { 
        // returns the decimal form of the fraction with three decimal places
        double FractionToDecimal = (double)Numerator / Denominator;
        return Math.Round(FractionToDecimal, decimalPlaces, MidpointRounding.AwayFromZero); // return the decimal equivalent by 3 decimal places rounded
    }
}