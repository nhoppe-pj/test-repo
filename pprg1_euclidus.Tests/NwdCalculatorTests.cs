using Xunit;

namespace pprg1_euclidus.Tests;

public class NwdCalculatorTests
{
    [Theory]
    [InlineData(48, 18, 6)]
    [InlineData(18, 48, 6)]
    [InlineData(21, 21, 21)]
    [InlineData(17, 13, 1)]
    [InlineData(100, 25, 25)]
    public void Nwd_ReturnsGreatestCommonDivisor(int a, int b, int expected)
    {
        Assert.Equal(expected, NwdCalculator.Nwd(a, b));
    }

    [Theory]
    [InlineData(0, 5)]
    [InlineData(5, 0)]
    [InlineData(-5, 10)]
    [InlineData(10, -5)]
    public void Nwd_ThrowsWhenEitherNumberIsNotPositive(int a, int b)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => NwdCalculator.Nwd(a, b));
    }
}
