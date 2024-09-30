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

        Assert.AreEqual("Jack of Hearts", card.GetName());
    }

    /// <summary>
    /// Creates a new card with 11, and "Heards" and checks that the vale is correct.
    /// </summary>
    [TestMethod]
    public void Card_CreateCardValue_True()
    {
        Card card = new Card(11, "Hearts");

        Assert.AreEqual(10)
    }
}