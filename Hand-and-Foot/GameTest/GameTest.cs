namespace GameTest;
using Game;
using Card;
using System.Diagnostics;

[TestClass]
public class GameTest
{
    [TestMethod]
    public void Game_TestInitializeCards_True()
    {
        Game game = new Game(4);
        game.InitializeCards();
        foreach (Card icard in game.cards)
        {
            Debug.WriteLine(icard.GetName());
        }
    }
}