/* 
----------------------------------------------------------------
<Program Title> Hand class
----------------------------------------------------------------
Developer:     Jenni Morales Jeronimo
Creation date: 4/27/2025
Last modified: 5/2/2025
Email address: jamoralesjeronimo@senators.ws.edu
-----------------------------------------------------------------
Purpose: The class checks for if a set of cards are a combination of 
straight, Flush, ect.
-----------------------------------------------------------------
*/

class Hand {  
    public enum HandValue {
        HighCard = 0,
        OnePair = 1,
        TwoPair = 2,
        ThreeOfAKind = 3,
        Straight = 4,
        Flush = 5,
        FullHouse = 6,
        FourOfAKind= 7,
        StraightFlush = 8
    }// end enum


    public HandValue ValueOfHand {
        get {
           var groupCardsBySuitQuery =
             from card in this.GetCards()
             group card by card.Suit into cardSuitGroup
             orderby cardSuitGroup.Key
             select new {
                 Suit = cardSuitGroup.Key,
                 Count = cardSuitGroup.Count()
             };
            var groupCardsByFaceAndValueQuery =
             from card in this.GetCards()
             group card by new { card.Face, card.Value } into cardFaceAndValueGroup
             orderby cardFaceAndValueGroup.Key.Value
             select new {
                 Face = cardFaceAndValueGroup.Key.Face,
                 Value = cardFaceAndValueGroup.Key.Value,
                 Count = cardFaceAndValueGroup.Count(),
                 
             };

            // added this to get only the value and not face
            var groupCardsByValueQuery =
             from card in this.GetCards()
             orderby  card.Value descending
             select card.Value;

            // Ensure there are atleast one card in the hand

            if (this.NumCardsInHand > 0 ) {
                ////////////////////////////////////////////////////////////////////////////////
                /// Test for : STRAIGHT FLUSH
                /// Determine if both a straight and a flush exist in hand 
                ////////////////////////////////////////////////////////////////////////////////
                bool IsStraight = false; 
                bool isFlush = false;
                

                foreach (var rank in groupCardsBySuitQuery)
                {
                    // the LINQ already groups and counts how many cards are in the same suit so if count is 5 or greater its a flush
                    if (rank.Count >= 5) 
                    {
                        isFlush = true; // is Flush
                    }

                }
                int previousValue = 0; // contain prev value
                int count = 0; // just a counter

                foreach (var rank in groupCardsByFaceAndValueQuery)
                {
                    if (rank.Value == previousValue + 1) // ensures only 1 jump diffrence
                    {
                        count++;
                        if (count >= 5) // if it happens 5 or more time stright
                        {
                            IsStraight = true;

                        }
                    }
                    else if (rank.Value == 2 || rank.Value == 3 || rank.Value == 4 || rank.Value == 14) // if 4 num are staight
                    {                                                                                    // and one is a ace its a staight
                    
                        count++;
                        if (count >= 5)
                        {
                            IsStraight = true;
                        }

                    }
                    previousValue = rank.Value;

                }
                if (isFlush == true && IsStraight == true) { // if passes requirments to be Flush and Straight

                        return HandValue.StraightFlush; 
                    }

                

                ////////////////////////////////////////////////////////////////////////////////
                /// Test for : FOUR OF A KIND
                /// Loop through each card rank and test if there are 4 of any rank 
                ////////////////////////////////////////////////////////////////////////////////

                foreach (var rank in groupCardsByFaceAndValueQuery)
                {
                    if (rank.Count == 4)
                    {
                        return HandValue.FourOfAKind;
                    }
                }

                ////////////////////////////////////////////////////////////////////////////////
                /// Test for : FULL HOUSE
                /// Loop through each card rank and test if there are 2 and 3 of any rank
                ////////////////////////////////////////////////////////////////////////////////
                int threeOfaRank = 0;
                int pairs = 0;
                foreach (var rank in groupCardsByFaceAndValueQuery) {
                    if (rank.Count == 3)  {
                        threeOfaRank++;
                        
                    } else if (rank.Count == 2) {
                        pairs++;
                    }
                    if (threeOfaRank >= 1 && pairs >= 1) { 
                        return HandValue.FullHouse;
                    }
                }

                ////////////////////////////////////////////////////////////////////////////////
                /// Test for : FLUSH
                /// Loop through each card rank and test if there are 5 of any suit
                ////////////////////////////////////////////////////////////////////////////////
                


                foreach (var rank in groupCardsBySuitQuery)  {
                    // the LINQ already groups and counts how many cards are in the same suit so if count is 5 or greater its a flush
                    if (rank.Count >= 5) {
                        return HandValue.Flush;
                    }

                }

                ////////////////////////////////////////////////////////////////////////////////
                /// Test for : STRAIGHT
                /// Determin if there are 5 consecutive card values
                ////////////////////////////////////////////////////////////////////////////////

                previousValue = 0;
                count = 0;
                foreach (var rank in groupCardsByFaceAndValueQuery)
                {
                    if (rank.Value == previousValue + 1) { // ensures only 1 jump diffrence
                        count++;
                        if (count >= 4) {
                            
                            return HandValue.Straight;

                        }
                    } else if (rank.Value == 2 || rank.Value == 3 || rank.Value == 4 || rank.Value == 14 ) {
                        count++;
                        if (count >= 4)
                        {
                           
                            return HandValue.Straight;
                        }

                    } 
                    previousValue = rank.Value; // ensure the current card value is the next
                                                // card value previouse value

                }

                ////////////////////////////////////////////////////////////////////////////////
                /// Test for : Three OF A KIND
                /// Loop through each card rank and test if there are 3 of any rank 
                ////////////////////////////////////////////////////////////////////////////////
                foreach (var rank in groupCardsByFaceAndValueQuery)
                {
                    if (rank.Count == 3)
                    {
                        return HandValue.ThreeOfAKind;
                    }
                }
                ////////////////////////////////////////////////////////////////////////////////
                /// Test for : TWO PAIR
                /// Loop through each card rank and test if there are 2 sets of any rank 
                ////////////////////////////////////////////////////////////////////////////////
                foreach (var rank in groupCardsByFaceAndValueQuery)
                {
                    if (rank.Count == 2 && rank.Value == 2 )
                    {
                        return HandValue.TwoPair;
                    }
                }

                ////////////////////////////////////////////////////////////////////////////////
                /// Test for : ONE PAIR
                /// Loop through each card rank and test if there are 2  of any rank 
                ////////////////////////////////////////////////////////////////////////////////
                foreach (var rank in groupCardsByFaceAndValueQuery) {
                    if (rank.Count == 2) {
                        return HandValue.OnePair;
                    }
                }

                ////////////////////////////////////////////////////////////////////////////////
                /// Test for : HIGH CARD
                /// If nothing else returned to this point, return the default hand value 
                ////////////////////////////////////////////////////////////////////////////////
                
                return HandValue.HighCard;
            } else {
                throw new Exception("There are no cards in hand.");
            
            }
        }
    }

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

        returnString += "Hand value: ";

        switch (this.ValueOfHand) {
            case HandValue.HighCard: return returnString + "High card";
            case HandValue.OnePair: return returnString + "One pair";
            case HandValue.TwoPair: return returnString + "Two pair";
            case HandValue.ThreeOfAKind: return returnString + "Three of a kind";
            case HandValue.Straight: return returnString + "Stright";
            case HandValue.Flush: return returnString + "Flush";
            case HandValue.FullHouse: return returnString + "Full house";
            case HandValue.FourOfAKind: return returnString + "Four of a kind";
            case HandValue.StraightFlush: return returnString + "Straight flush";
            default: return returnString + "High card";

        }
       
    } // end method
} // end class