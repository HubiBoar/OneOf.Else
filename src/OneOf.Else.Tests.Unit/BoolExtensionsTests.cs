using FluentAssertions;

namespace OneOf.Else.Tests.Unit;

public class BoolExtensionsTests
{
    private const string First = "first";
    private const string Second = "second";
    
    [Fact]
    public void Match_ShouldRunFirstMethod_WhenTrue()
    {
        //Arrange
        var value = true;
        var firstCalls = 0;
        var secondCalls = 0;

        //Act
        var returnValue = value.Match(
            () =>
            {
                firstCalls++;
                return First;
            },
            () => 
            {
                secondCalls++;
                return Second;
            }
        );

        //Assert
        returnValue.Should().Be(First);

        firstCalls.Should().Be(1);
        secondCalls.Should().Be(0);
    }
    
    [Fact]
    public void Match_ShouldRunFirstMethod_WhenFalse()
    {
        //Arrange
        var value = false;
        var firstCalls = 0;
        var secondCalls = 0;

        //Act
        var returnValue = value.Match(
            () =>
            {
                firstCalls++;
                return First;
            },
            () => 
            {
                secondCalls++;
                return Second;
            }
        );

        //Assert
        returnValue.Should().Be(Second);

        firstCalls.Should().Be(0);
        secondCalls.Should().Be(1);
    }
    
    [Fact]
    public void Switch_ShouldRunFirstMethod_WhenTrue()
    {
        //Arrange
        var value = true;
        var firstCalls = 0;
        var secondCalls = 0;

        //Act
        value.Switch(
            () => firstCalls++,
            () => secondCalls++
        );

        //Assert
        firstCalls.Should().Be(1);
        secondCalls.Should().Be(0);
    }
    
    [Fact]
    public void Switch_ShouldRunFirstMethod_WhenFalse()
    {
        //Arrange
        var value = false;
        var firstCalls = 0;
        var secondCalls = 0;

        //Act
        value.Switch(
            () => firstCalls++,
            () => secondCalls++
        );

        //Assert
        firstCalls.Should().Be(0);
        secondCalls.Should().Be(1);
    }
}