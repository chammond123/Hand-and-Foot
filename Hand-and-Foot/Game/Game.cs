namespace Game;
using Card;
using Player;
using System;
using System.Collections.Generic;


public class Game
{
    public List<Player> players = [];
    public List<Card> cards = [];
    public Stack<Card> discard = new Stack<Card>();

    public Game(int numPlayers)
    {
        for (int i = 0; i < numPlayers; i++)
        {
            // TODO: Fixme
            Player player = new Player("Test");
            players.Add(player);
        }
    }

    /// <summary>
    /// Fills a list of cards with card objects for each card in a deck * the number of players.
    /// </summary>
    public void InitializeCards()
    {
        List<string> suits = ["hearts", "diamonds", "clubs", "spades"];
        foreach (Player iplayer in players)
        {
            foreach (var suit in suits)
            {
                for (int i = 1; i < 15; i++)
                {
                    Card card = new Card(i, suit);
                    cards.Add(card);
                }
            }
        }
        Random rng = new Random();
        Shuffle(cards, rng);

    }
    public static void Shuffle<T>(IList<T> list, Random rng)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }

    }
}
