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