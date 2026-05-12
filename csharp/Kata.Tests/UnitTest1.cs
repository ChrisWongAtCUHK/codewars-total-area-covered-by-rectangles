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

    [Test, Order(3)]
    public void OneRectangleV2()
    {
        Assert.That(Kata.Calculate(new[] { new[] { 0, 4, 11, 6 } }), Is.EqualTo(22));
    }

    [Test, Order(4)]
    public void TwoRectangles()
    {
        Assert.That(Kata.Calculate(new[] { new[] { 0, 0, 1, 1 }, new[] { 1, 1, 2, 2 } }), Is.EqualTo(2));
    }

    [Test, Order(5)]
    public void TwoRectanglesV2()
    {
        Assert.That(Kata.Calculate(new[] { new[] { 0, 0, 1, 1 }, new[] { 0, 0, 2, 2 } }), Is.EqualTo(4));
    }
}
