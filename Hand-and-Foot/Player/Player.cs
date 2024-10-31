namespace Player;
using Card;
public class Player
{
    public string Name { get; set; }
    public List<Card> hand = [];
    public List<Card> foot = [];
    public Dictionary<string, List<Card>> books = new Dictionary<string, List<Card>>();
    public int HandScore = 0;
    public int GameScore = 0;
    public bool HasPlayed = false;

    public void DrawCard(List<Card> cards, List<Card> pile)
    {
        Card card = cards[0];
        cards.RemoveAt(0);
        pile.Add(card);
        pile.Sort();
    }

    public void DrawHandAndFoot(List<Card> cards, int handSize)
    {
        for (int i = 0; i < handSize; i++)
        {
            DrawCard(cards, hand);
            DrawCard(cards, foot);
        }
    }

    public void TakeDiscard(Stack<Card> discard, List<Card> pile)
    {
        pile.Add(discard.Pop());
        pile.Sort();
    }

    public List<Card> GetHand()
    {
        return hand;
    }
    public List<Card> GetFoot()
    {
        return foot;
    }
    public void DrawFootToHand()
    {
        if (hand.Count == 0 && foot.Count != 0)
        {
            hand = foot;
        }
    }
    public void InitialPlay(Player partner, int currentPlayCost)
    {
        foreach
    }

    private void MatchCards(List<string> cards)
    {
        List<string> matchedCards = new List<string>();
        string firstInstance = string.Empty;
        string prevNode = string.Empty;
        string currentNode = string.Empty;
        int count = 0;

        foreach(string card in cards)
        {
            if (count == 0)
            {
                firstInstance = card;
            }
        }
    }
}
