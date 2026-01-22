/* 
----------------------------------------------------------------
<Program Title> Deck of playing Cards
----------------------------------------------------------------
Developer:     Jenni Morales Jeronimo
Creation date: 4/2/2025
Last modified: 4/4/2025
Email address: jamoralesjeronimo@senators.ws.edu
-----------------------------------------------------------------
Purpose:
Program initalizes the properties and assigns varables to them as well as 
create the name of each card concatenated.
-----------------------------------------------------------------
*/
using System.Drawing;
using System.Net.Security;

public class Card
{
    // initalizes properties 
    public string Face { get; }
    public string Color { get; }
    public string Suit { get; }
    public int Value { get; }

    // multi argument constructer assings passed
    // parameters to their respective properties
    public Card(string face, string color, string suit, int value)
    {
        Face = face;
        Color = color;
        Suit = suit;
        Value = value;
    }// end constructer

    public string ToLongString()
    {
        return $"{Face} of {Color} {Suit} ({Value})";
    }// end method

    public override string ToString()
    {
        return $"{Face} of {Suit}";
    }// end method
}