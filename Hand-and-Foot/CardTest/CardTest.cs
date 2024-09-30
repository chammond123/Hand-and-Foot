namespace CardTest;
using Card;
using NuGet.Frameworks;

[TestClass]
public class CardTest
{
    /// <summary>
    /// Creates a new card with 11, and "Hearts" and checks that the card is properly created.
    /// </summary>
    [TestMethod]
    public void Card_CreateCardName_True()
    {
        Card card = new Card(11,"Hearts");

        Assert.AreEqual("Jack of hearts", card.GetName());
    }

    /// <summary>
    /// Creates a new card with 11, and "Hearts" and checks that the vale is correct.
    /// </summary>
    [TestMethod]
    public void Card_CreateCardValue_True()
    {
        Card card = new Card(11, "hearts");

        Assert.AreEqual(10, card.GetPointValue());
    }

    /// <summary>
    /// Creates a new card with 3, and "Hearts" and checks that the vale is correct.
    /// </summary>
    [TestMethod]
    public void Card_CheckCardValueRed3_True()
    {
        Card card = new Card(3, "hearts");

        Assert.AreEqual(150, card.GetPointValue());
    }

    /// <summary>
    /// Creates a new card with 3, and "spades" and checks that the vale is correct.
    /// </summary>
    [TestMethod]
    public void Card_CheckCardValueBlack3_True()
    {
        Card card = new Card(3, "spades");

        Assert.AreEqual(300, card.GetPointValue());
    }

    /// <summary>
    /// Tests that the equals overload for the card class properly checks equality based on the card
    /// </summary>
    [TestMethod]
    public void Card_EqualsOverload_True()
    {
        Card card1 = new Card(11, "Hearts");
        Card card2 = new Card(11, "Hearts");
        Assert.IsTrue(card1 == card2);
    }

    /// <summary>
    /// Tests that the notequals overload for the card class properly checks equality based on the card
    /// </summary>
    [TestMethod]
    public void Card_NotEqualsOverload_True()
    {
        Card card1 = new Card(11, "Hearts");
        Card card2 = new Card(10, "Hearts");
        Assert.IsTrue(card1 != card2);
    }

    /// <summary>
    /// Tests that the greaterthan overload for the card class properly checks equality based on the card
    /// </summary>
    [TestMethod]
    public void Card_GreaterthanOverload_True()
    {
        Card card1 = new Card(11, "Hearts");
        Card card2 = new Card(10, "Hearts");
        Assert.IsTrue(card1 > card2);
    }

    /// <summary>
    /// Tests that the lessthan overload for the card class properly checks equality based on the card
    /// </summary>
    [TestMethod]
    public void Card_LessthanOverload_True()
    {
        Card card1 = new Card(11, "Hearts");
        Card card2 = new Card(10, "Hearts");
        Assert.IsTrue(card2 < card1);
    }
}