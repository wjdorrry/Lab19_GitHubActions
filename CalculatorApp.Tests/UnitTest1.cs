using CalculatorApp;

namespace CalculatorApp.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_ReturnsCorrectSum()
    {
        var calculator = new Calculator();

        var result = calculator.Add(2, 3);

        Assert.Equal(5, result);
    }

    [Fact]
    public void Subtract_ReturnsCorrectDifference()
    {
        var calculator = new Calculator();

        var result = calculator.Subtract(10, 4);

        Assert.Equal(6, result);
    }

    [Fact]
    public void Multiply_ReturnsCorrectProduct()
    {
        var calculator = new Calculator();

        var result = calculator.Multiply(3, 4);

        Assert.Equal(12, result);
    }
}