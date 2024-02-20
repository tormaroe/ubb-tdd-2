using Ubb.Calculator;

namespace Ubb.Calculator.Test;

public class CalculatorTests
{
    [Fact]
    public void Should_returnZero_emptyInput()
    {
        new Calculator().Add(string.Empty).Should().Be(0);
    }
    [Fact]
    public void Should_returnSingleInteger()
    {
        new Calculator().Add("15").Should().Be(15);
    }
    [Fact]
    public void Should_returnSum_ofTwoNumbers()
    {
        new Calculator().Add("2,3").Should().Be(5);
    }
}