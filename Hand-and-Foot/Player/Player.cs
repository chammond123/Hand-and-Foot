namespace Player;
using Card;
public class Player
{
    public string Name { get; set; }
    public List<Card> hand = [];
    public List<Card> foot = [];
    public Dictionary<string, List<Card>> layedPiles = new Dictionary<string, List<Card>>();

    public Player(string name)
    {
        Name = name;
    }

    public void DrawCard(List<Card> cards)
    {
        Card card = cards[0];
        cards.RemoveAt(0);
        hand.Add(card);
        hand.Sort();
    }

    public void DrawHandAndFoot(List<Card> cards, int handSize)
    {
        for (int i = 0; i < handSize; i++)
        {
            DrawCard(cards);
            Card card = cards[0];
            cards.RemoveAt(0);
            foot.Add(card);
        }
        hand.Sort();
        foot.Sort();
    }

    public void TakeDiscard(Stack<Card> discard)
    {
        hand.Add(discard.Pop());
        hand.Sort();
    }

    public List <Card> GetHand()
    {
        return hand;
    }
    public List <Card> GetFoot()
    {
        return foot;
    }
}
