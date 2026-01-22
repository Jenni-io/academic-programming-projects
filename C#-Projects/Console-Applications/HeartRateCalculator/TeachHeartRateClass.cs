using System;
class HeartRate
{
    // Private member variables
    private int m_birthYear;
    
    // Property BirthYear handles access to m_birthYear member variable
    public int BirthYear
    {
        get
        {
            return m_birthYear;
        } // end get
        set
        {
            // If passed-in value is less than current year and exactly 4 characters
            if (value < DateTime.Now.Year && value.ToString().Length == 4)
            {
                m_birthYear = value;
            }
            else
            { // Otherwise, throw an exception
                throw new Exception("A birth year must be less than the current year and be exactly four digits.");
            } // end if
        } // end set
    } // end property

      // Multi-arg constructor
    public HeartRate(int birthYear)
    {
        this.BirthYear = birthYear;
    } // end constructor
      // Method calculates and returns user's age based on birth year
    public int GetAge()
    {
        return DateTime.Now.Year - this.BirthYear;
    } // end method

      // Method calculates and returns maximum heart rate
    public int GetMaxHeartRate()
    {
        return 220 - this.GetAge();
    } // end method

      // Method calculates and returns minimum target heart rate
    public double GetMinTargetHeartRate()
    {
        return GetMaxHeartRate() * 0.5;
    } // end method

      // Method calculates and returns maximum target heart rate
    public double GetMaxTargetHeartRate()
    {
        return GetMaxHeartRate() * 0.85;
    } // end method

} // end class
