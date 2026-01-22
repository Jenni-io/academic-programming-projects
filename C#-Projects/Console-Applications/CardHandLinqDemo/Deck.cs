using System;
using System.Collections.Generic;

public class Deck {
    // Private constants
    private const int NUMBER_OF_CARDS = 52;
    private readonly string[] CARD_RANKS = { "2", "3", "4", "5", "6", "7", "8", "9", "10",
                                             "Jack", "Queen", "King", "Ace" };
    private readonly string[] CARD_COLORS = { "Red", "Black" };
    private readonly string[] CARD_SUITS = { "Hearts", "Diamonds", "Spades", "Clubs" };
    private readonly int[] CARD_VALUES = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

    // Private member variables
    List<Card> m_deckOfCards;   // Creates a memory location for Card objects
    
    // Property to return number of cards remaining in deck
    public int NumCardsInDeck {
        get {
            return m_deckOfCards.Count;
        } // end get
    } // end property

    // Constructor
    public Deck(bool buildDeck = true) {
        // Initialize an array of 52 null Card objects
        m_deckOfCards = new List<Card>();

        // If this is a new deck to be built
        if (buildDeck) {
            this.BuildDeck();   // Create all 52 playing cards
            this.Shuffle();
        } // end if
    } // end constructor

    // Creates all card objects and adds them to m_cards array
    private void BuildDeck() {
        m_deckOfCards.Clear();    // Ensure there are no cards in deck

        // Create and add all cards to the m_cards array
        for (int i = 0; i < NUMBER_OF_CARDS; i++) {
            m_deckOfCards.Add(new Card(CARD_RANKS[i % 13], CARD_COLORS[i / 26], CARD_SUITS[i / 13], CARD_VALUES[i % 13]));
        } // end for
    } // end method

    // Shuffles the array of cards
    public void Shuffle(int numberOfShuffles = 5) {
        Random rnd = new Random();
        Card tempCard;
        int randomIndex;

        // Shuffle a specified number of times (default is 5)
        for (int i = 0; i < numberOfShuffles; i++) {
            // Fisher-Yates shuffling algorithm
            for (int j = m_deckOfCards.Count - 1; j > 0; j--) {
                randomIndex = rnd.Next(0, j + 1);

                tempCard = m_deckOfCards[j];
                m_deckOfCards[j] = m_deckOfCards[randomIndex];
                m_deckOfCards[randomIndex] = tempCard;
            } // end for
        } // end for
    } // end method

    // Returns "top" cards of deck
    public Card DealCard() {
        // If there are no cards remaining in the deck...
        if (m_deckOfCards.Count == 0) {
            throw new System.Exception("There are no more cards in the deck.");
        } else {
            Card topCard = m_deckOfCards[m_deckOfCards.Count - 1];  // Gets top card in deck
            m_deckOfCards.Remove(topCard);                          // Remove top card from deck

            return topCard;
        } // end if      
    } // end method

    // Overridden ToString() method
    public override string ToString() => $"There are {this.NumCardsInDeck} remaining in the deck.";
} // end class