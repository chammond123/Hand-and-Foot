namespace Player;
using Card;

public class Player
{
    public string Name { get; set; }
    public List<Card> Hand = [];
    public List<Card> Foot = [];
    public Dictionary<int, List<Card>> Books = new Dictionary<int, List<Card>>();
    public int GameScore = 0;
    public bool HasPlayed = false;

    public class PlayExecption : Exception 
    { 
        public PlayExecption(string messagage) : base(messagage) { }
    }

    /// <summary>
    /// Draws a card from the given list of cards to a given pile, usually a hand or foot,
    /// and sorts the pile.
    /// </summary>
    /// <param name="cards">A list of cards to draw from.</param>
    /// <param name="pile">A list of cards to draw to.</param>
    public void DrawCard(List<Card> cards, List<Card> pile)
    {
        Card card = cards[0];
        cards.RemoveAt(0);
        pile.Add(card);
        pile.Sort();
    }

    /// <summary>
    /// Draws cards for the given hand size to the players hand and foot.
    /// </summary>
    /// <param name="cards">A list of cards to draw from.</param>
    /// <param name="handSize">The ammount of cards to draw.</param>
    public void DrawHandAndFoot(List<Card> cards, int handSize)
    {
        for (int i = 0; i < handSize; i++)
        {
            DrawCard(cards, Hand);
            DrawCard(cards, Foot);
        }
    }

    /// <summary>
    /// Takes the top card from a discard pile.
    /// </summary>
    /// <param name="discard">A stack of discarded cards to take from.</param>
    /// <param name="pile">The pile to put the taken card from.</param>
    public void TakeDiscard(Stack<Card> discard, List<Card> pile)
    {
        pile.Add(discard.Pop());
        pile.Sort();
    }

    /// <summary>
    /// Gets the players hand.
    /// </summary>
    /// <returns>A list of the cards in a players hand.</returns>
    public List<Card> GetHand()
    {
        return Hand;
    }
    /// <summary>
    /// Gets a players foot.
    /// </summary>
    /// <returns>A list of the cards in a players foot.</returns>
    public List<Card> GetFoot()
    {
        return Foot;
    }

    /// <summary>
    /// Puts a players foot into their hand if their hand is empty.
    /// </summary>
    public void DrawFootToHand()
    {
        if (Hand.Count == 0 && Foot.Count != 0)
        {
            Hand = Foot;
        }
    }
    
    public void PlayCard(Card card)
    {
        if (Books.ContainsKey(card.CardValue))
        {
            foreach (Card handCard in Hand)
            {
                if (handCard == card)
                {
                    Books[handCard.CardValue].Add(card);
                    Hand.Remove(handCard);
                }
            }
        }
        else
        {
            throw new PlayExecption("No book exists to play this card on.");
        }
    }

    /// <summary>
    /// If a player meets the point requirement and their partner hasn't made an initial play,
    /// this make thier initial play.
    /// </summary>
    /// <param name="partner">A player object, the partner of the player.</param>
    /// <param name="currentPlayCost"></param>
    public void InitialPlay(Player partner, int currentPlayCost)
    {
        Dictionary<Card, int> matchedCards = MatchCards(Hand);
        int handValue = GetHandValue(matchedCards);
        if (handValue >= currentPlayCost && 
            !HasPlayed && 
            !partner.HasPlayed)
        {
            foreach (Card card in matchedCards.Keys)
            {
                PlayBook(card);
            }
        }
        else
        {
            PlayExecption exception = partner.HasPlayed || HasPlayed ? new PlayExecption("Player or partner has made intial play.") : 
                                                                       new PlayExecption("You do not meet current play cost.");
            throw exception;
        }
    }

    /// <summary>
    /// Matches the similar cards in a players hands.
    /// </summary>
    /// <param name="cards">A list of cards to check through.</param>
    public Dictionary<Card, int> MatchCards(List<Card> cards)
    {
        Dictionary<Card, int> matchedCards = new Dictionary<Card, int>();
        Card? firstInstance = null;
        bool firstLoop = true;
        int cardCount = 0;
        foreach (Card card in cards)
        {
            if (firstLoop)
            {
                firstInstance = card;
                cardCount++;
                firstLoop = false;
            }
            else if (card == firstInstance!)
            {
                cardCount++;
            }
            else
            {
                matchedCards.Add(firstInstance!, cardCount);
                firstInstance = card;
                cardCount = 0;
            }
        }
        cardCount++;
        matchedCards.Add(firstInstance!, cardCount);
        foreach(Card card in matchedCards.Keys)
        {
            if (matchedCards[card] < 3)
            {
                matchedCards.Remove(card);
            }
        }
        return matchedCards;
    }

    public void PlayBook(Card card)
    {
        List<Card> cards = new List<Card>();
        foreach (Card handCard in Hand)
        {
            if (handCard == card)
            {
                cards.Add(handCard);
                Hand.Remove(handCard);
            }
        }
        Books.Add(card.CardValue, cards);
    }

    public int GetGameScore()
    {
        foreach (int book in Books.Keys)
        {
            Books[book]
        }
    }

    private int GetHandValue(Dictionary<Card, int> cards)
    {
        int totalPoints = 0;

        foreach (Card card in cards.Keys)
        {
            totalPoints += card.GetPointValue() * cards[card];
        }
        return totalPoints;
    }
}
