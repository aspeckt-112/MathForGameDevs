using MathLib.PartOne;

namespace MathLib.Tests.PartOne;

public class SignTests
{
    [Fact]
    public void Test_Positive()

    {
        // Arrange
        var number = 5;

        // Act
        Sign.GetSignOfNumber(number);

        // Assert
        //Assert.Equal(1, result);
    }
    
    [Fact]
    public void Test_Negative()
    {
        // Arrange
        var number = -5;

        // Act
        Sign.GetSignOfNumber(number);

        // Assert
        //Assert.Equal(-1, result);
    }
}