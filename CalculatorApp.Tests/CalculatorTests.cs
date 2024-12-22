namespace CalculatorApp.Tests;

[TestFixture]
public class CalculatorTests
{
    private Calculator _calculator;

    [SetUp]
    public void SetUp()
    {
        _calculator = new();
    }

    [Test]
    public void Add_ShouldReturnCorrectSum()
    {
        double result = _calculator.Add(2, 3);
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Subtract_ShouldReturnCorrectDifference()
    {
        double result = _calculator.Subtract(5, 3);
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void Multiply_ShouldReturnCorrectProduct()
    {
        double result = _calculator.Multiply(4, 3);
        Assert.That(result, Is.EqualTo(12));
    }

    [Test]
    public void Divide_ShouldReturnCorrectQuotient()
    {
        double result = _calculator.Divide(10, 2);
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Divide_ShouldThrowDivideByZeroException_WhenDividingByZero()
    {
        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
    }
}