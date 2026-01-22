/* 
----------------------------------------------------------------
<Program Title> Deck of playing Cards
----------------------------------------------------------------
Developer:     Jenni Morales Jeronimo
Creation date: 4/2/2025
Last modified: 4/4/2025
Email address: jamoralesjeronimo@senators.ws.edu
-----------------------------------------------------------------
Purpose: Actually sets up the stack of cards, suffles them,
AND counts how many are left in said deck. 
-----------------------------------------------------------------
*/
public class Deck {
    private const int NUMBER_OF_CARDS = 52;
    private Card[] _deckOfCards;
    private int _currentCardIndex;
    public int NumCardsInDeck { get { return _currentCardIndex + 1;} }
    
    public Deck(bool buildDeck = true) {
         _deckOfCards = new Card[NUMBER_OF_CARDS];

        if (buildDeck) {
            BuildDeck();
            Shuffle();
        }
        
    }// end constructer 

    private void BuildDeck() {
        _currentCardIndex = NUMBER_OF_CARDS - 1;
        string[] faces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

        // assignes the 12 card sets to their said suit (Only loops 4 times)
        // so this creats each 13 cards acording to the order of suit
        for (int i = 0; i < suits.Length; i++) {

            // temporarily  holds the "cards" value of the current suit
            string suit = suits[i];
            string color; // temporarily holds the color val of card (ex. black or red)

            if (suit == "Hearts" || suit == "Diamonds") { // Only the Card of Hearts
                color = "Red";                            // and Diamodns are red
            }
            else {
                color = "Black"; //Assigns color to card based on suit
            }

            // loops till the length of elements in the faces array 13 times
            for (int m = 0; m < faces.Length; m++) {
                int value = m + 2; // Cause Face val starts at 2 
                // This FINALLY creats the CARD and inserts it in the 51 position till the top 0
                _deckOfCards[_currentCardIndex--] = new Card(faces[m], color, suit, value);
            }

        }// end for loop
        
    }// end method

    public void Shuffle(int numberOfShuffles = 5) {
        _currentCardIndex = NUMBER_OF_CARDS - 1;

        Random RND = new Random();
      
        // shuffles the deck of card X num of times
        for (int i = 0; i < numberOfShuffles; i++) {

            for (int thisIndex = _currentCardIndex; thisIndex > 0; thisIndex--) {

                // picks random number from 0 to 52 
                int randomIndex = RND.Next(NUMBER_OF_CARDS);

                // holds the iteam in such position
                Card tempCard = _deckOfCards[thisIndex];
                // switches a iteam from other postion
                _deckOfCards[thisIndex] = _deckOfCards[randomIndex];
                _deckOfCards[randomIndex] = tempCard;

            } // end of for
        }// end of for

    }// end of method

    public Card DealCard() {
        // Returns the "top" (i.e., last) Card object from _deckOfCards array.
        return _deckOfCards[_currentCardIndex--];
    
    }

    public override string ToString() {
        // tells you how many card are left in deck?
        return $"{NumCardsInDeck} cards remaining in the deck";
    }

}

