namespace Card;

public class Card : IComparable<Card>
{
    private string Suit { get; set; }
    public int CardValue { get; set; }

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
    /// Implement IComparable interface to compare cards based on CardValue.
    /// </summary>
    /// <param name="other">Another card to compare to</param>
    /// <returns>-1 if this is less than other, 1 if this is greater, 0 if they are equal.</returns>
    public int CompareTo(Card other)
    {
        return this.CardValue.CompareTo(other.CardValue);
    }

    /// <summary>
    /// Overloaded equals operator, compares on card value.
    /// </summary>
    /// <param name="c1">An instance of a card object.</param>
    /// <param name="c2">An instance of a card object.</param>
    /// <returns></returns>
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
    /// Overloaded not equals operator, compares on card value.
    /// </summary>
    /// <param name="c1">An instance of a card object.</param>
    /// <param name="c2">An instance of a card object.</param>
    /// <returns></returns>
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
    /// Lessthan operator overlaod.  Compares on card value.
    /// </summary>
    /// <param name="c1">An instance of the card class.</param>
    /// <param name="c2">An instance of the card class.</param>
    /// <returns></returns>
    public static bool operator <(Card c1, Card c2)
    {
        return c1.CardValue < c2.CardValue;
    }

    /// <summary>
    /// Greaterthan operator overload.  Compares on card value.
    /// </summary>
    /// <param name="c1">An instance of the card class.</param>
    /// <param name="c2">An instance of the card class.</param>
    /// <returns></returns>
    public static bool operator >(Card c1, Card c2)
    {
        return c1.CardValue > c2.CardValue;
    }

    /// <summary>
    /// Gets the name of a card.
    /// </summary>
    /// <returns>A string containing the name of the card in the form "Name" of "Suit".</returns>
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
