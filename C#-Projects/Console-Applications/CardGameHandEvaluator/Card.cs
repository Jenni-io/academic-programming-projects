/* 
----------------------------------------------------------------
<Program Title> Card class
----------------------------------------------------------------
Developer:     Jenni Morales Jeronimo
Creation date: 4/27/2025
Last modified: 5/2/2025
Email address: jamoralesjeronimo@senators.ws.edu
-----------------------------------------------------------------
Purpose: This class assembles a single playing card with a face, suit, color,
and value. It is assigned and used by the Deck class to create a full deck.
-----------------------------------------------------------------
*/
public class Card {
    // Auto-implemented properties
    public string Face { get; }
    public string Color { get; }
    public string Suit { get; }
    public int Value { get; }

    // Constructor
    public Card(string face, string color, string suit, int value) {
        this.Face = face;
        this.Color = color;
        this.Suit = suit;
        this.Value = value;
    } // end constructor

    // ToLongString() method
    public string ToLongString() => $"{this.Face} of {this.Color} {this.Suit} ({this.Value})";

    // Overridden ToString() method
    public override string ToString() => $"{this.Face} of {this.Suit}";
} // end class