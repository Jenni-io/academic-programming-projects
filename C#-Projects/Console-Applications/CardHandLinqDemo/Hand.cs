using System;
using System.Linq;
using System.Collections.Generic;

class Hand {  
    // Private member variables
    private List<Card> m_handOfCards;   // List to hold Card objects

    // Property returns number of cards remaining in deck
    public int NumCardsInHand {
        get {
            return m_handOfCards.Count;
        } // end get
    } // end property

    // Default constructor
    public Hand() {
        m_handOfCards = new List<Card>();
    } // end constructor

    // Method adds a card to the hand
    public void AddCard(Card card) {
        m_handOfCards.Add(card);     // Add passed-in card to the list object

        this.SortHand();    // Sort cards in hand
    } // end method

    // Method returns a list of all cards in hand
    public List<Card> GetCards() {
        this.SortHand();    // Sort cards in hand

        return m_handOfCards;
    } // end method

    // Method sorts the cards in hand
    private void SortHand() {
        m_handOfCards = m_handOfCards.OrderBy(card => card.Value).ThenBy(card => card.Suit).ToList();
    } // end method

    // Method returns string representation of all cards in hand
    public override string ToString() {
        this.SortHand();    // Sort cards in hand

        string returnString = "";

        for (int i = 0; i < m_handOfCards.Count; i++) {
            returnString += $"{m_handOfCards[i]}\n";
        } // end for
       
        return returnString;
    } // end method
} // end class