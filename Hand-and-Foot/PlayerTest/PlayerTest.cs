namespace PlayerTest;
using Player;
using Game;
using Card;
using System.Diagnostics;

[TestClass]
public class PlayerTest
{
    /// <summary>
    /// Tests that the players hand is correctly drawn.
    /// </summary>
    [TestMethod]
    public void Player_Drawhand_True()
    {
        Game game1 = new Game(4);
        game1.InitializeCards();
        game1.players[0].DrawHandAndFoot(game1.cards, 11);
        foreach (Card icard in game1.players[0].GetHand())
        {
            Debug.WriteLine(icard.GetName());
        }
    }
    [TestMethod]
    public void Player_Drawfoot_True()
    {
        Game game1 = new Game(4);
        game1.InitializeCards();
        game1.players[0].DrawHandAndFoot(game1.cards, 11);
        foreach (Card icard in game1.players[0].GetHand())
        {
            Debug.WriteLine(icard.GetName());
        }
    }
}
