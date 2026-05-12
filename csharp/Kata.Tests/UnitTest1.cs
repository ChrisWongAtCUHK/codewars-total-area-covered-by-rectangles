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

    [Test, Order(2)]
    public void OneRectangle()
    {
        Assert.That(Kata.Calculate(new[] { new[] { 0, 0, 1, 1 } }), Is.EqualTo(1));
    }
}
