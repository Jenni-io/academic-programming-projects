public class Card {

    public string Color { get; set; }
    public string Face { get; set; }
    public string Suit { get; set; }

    public static int Count { get; set; } = 0;

    public Card(string color, string face, string suit) {
        this.Color = color;
        this.Face = face;
        this.Suit = suit;

        Count++;
    }

    // "2 of Hearts"

    public string ToString() {
        return $"{this.Face}of {this.Suit}";
    }

}
    