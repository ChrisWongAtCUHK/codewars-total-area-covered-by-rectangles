namespace Kata.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test, Order(1)]
    public void ZeroRectangles()
    {
        Assert.That(Kata.Calculate(Enumerable.Empty<int[]>()), Is.EqualTo(0));
    }
}
