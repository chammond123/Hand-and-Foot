namespace Card;

public class Card
{
    private string Suit { get; set; }
    private int CardValue { get; set; }

    /// <summary>
    /// Constructor for the card class.
    /// </summary>
    /// <param name="suit">The given suit of the card</param>
    /// <param name="cardValue">The given value of the card 1-15</param>
    public Card(int cardValue, string suit)
    {
        this.Suit = suit.ToLower();
        this.CardValue = cardValue;
    }

    /// <summary>
    /// Equals operater overload, based on card value.
    /// </summary>
    /// <param name="c1">An instance of the card class</param>
    /// <param name="c2">An instance of the card class</param>
    /// <returns>True if the cards are equal, false otherwise.</returns>
    public static bool operator ==(Card c1, Card c2)
    {
        if (c1.CardValue.Equals(c2.CardValue))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Not equals operater overload, based on card value.
    /// </summary>
    /// <param name="c1">An instance of the card class</param>
    /// <param name="c2">An instance of the card class</param>
    /// <returns>True if the cards are not equal, false otherwise.</returns>
    public static bool operator !=(Card c1, Card c2)
    {
        if (!c1.CardValue.Equals(c2.CardValue))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Lessthan operater overload, based on card value.
    /// </summary>
    /// <param name="c1">An instance of the card class</param>
    /// <param name="c2">An instance of the card class</param>
    /// <returns>True c1 is less than c2, false otherwise.</returns>
    public static bool operator <(Card c1, Card c2)
    {
        if (c1.CardValue < c2.CardValue)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Greaterthan operater overload, based on card value.
    /// </summary>
    /// <param name="c1">An instance of the card class</param>
    /// <param name="c2">An instance of the card class</param>
    /// <returns>True c1 is greater than c2, false otherwise.</returns>
    public static bool operator >(Card c1, Card c2)
    {
        if (c1.CardValue > c2.CardValue)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Gets the name of a card.
    /// </summary>
    /// <returns>A string containg the name of the card in the form "Name" of "Suit".</returns>
    public string GetName()
    {
        string name = string.Empty;


        if (CardValue == 11)
        {
            name = "Jack";
        }
        else if (CardValue == 12)
        {
            name = "Queen";
        }
        else if (CardValue == 13)
        {
            name = "King";
        }
        else if (CardValue == 14)
        {
            name = "Joker";
        }
        else if (CardValue == 1)
        {
            name = "Ace";
        }
        else
        {
            name = CardValue.ToString();
        }

        return $"{name} of {Suit}";
    }

    /// <summary>
    /// Gets the point value of a card.
    /// </summary>
    /// <returns>The point value of a card.</returns>
    public int GetPointValue()
    {
        if (CardValue == 2)
        {
            return 25;
        }
        else if (CardValue == 3 && (Suit == "spades" || Suit == "clubs"))
        {
            return 300;
        }
        else if (CardValue == 3 && (Suit == "hearts" || Suit == "diamonds"))
        {
            return 150;
        }
        else if (CardValue > 8)
        {
            return 10;
        }
        else
        {
            return 5;
        }
    }
}
