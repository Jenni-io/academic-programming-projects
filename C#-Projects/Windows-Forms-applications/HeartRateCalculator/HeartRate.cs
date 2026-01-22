

public class HeartRate
{

    private const int MAX_HEART_RATE = 220;

    private DateTime _birthDate; // holds users birth year

    public DateTime BirthDate
    {
        get
        {
            return _birthDate;

        }
        set
        {
            if (value.Year > DateTime.Now.Year )
            {
                _birthDate = value;
            }
            else
            { // Otherwise, throw an exception
                throw new Exception("A birth year must be less than the current year and be exactly four digits.");
            } // end if
            _birthDate = value;
           
        }
    }

    public int Age
    {
        get
        {
            DateTime today = DateTime.Today;
            int age = today.Year - BirthDate.Year;
            

            // Adjust age if the birthday hasn't occurred yet this year
            if (BirthDate.Date > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    }

    public int MaxHeartRate
    {
        get
        {
            int MaxHearRate = 220 - Age;
            return MaxHearRate;
        }
    }

    public double MinTargetHeartRate
    {
        get
        {
            double MinTargetHeartRate = MaxHeartRate * .5;
            return Math.Round(MinTargetHeartRate);
        }
    }

    public double MaxTargetHeartRate
    {
        get
        {
            double MaxTargetHeartRate = MaxHeartRate * 0.85;
            return Math.Round(MaxTargetHeartRate);
        }
    }

    // constructor
    public HeartRate(DateTime BirthDate)
    {

        _birthDate = BirthDate ;

    }

    public override string ToString()
    {
        string output = "";
        output = $"Age: {Age} years old\n" + $"Maximum heart rate: {MaxHeartRate} beats/minute\n" +
            $"Minumum target rate: {MinTargetHeartRate} beats/minute\n" +
            $"Maximum target heart rate: {MaxTargetHeartRate} beats/minute \n \n" +
            $"Based on your age, keep your heart rate between {MinTargetHeartRate} and {MaxTargetHeartRate} while exercising";
       
        return output;
    }


}