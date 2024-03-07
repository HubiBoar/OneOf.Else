using FluentAssertions;
using OneOf.Types;

namespace OneOf.Else.Tests.Unit;

public class OneOfElse2Tests
{
    private const string SuccessMessage = "success_message";
    private const string ErrorMessage = "error_message";
    
    [Fact]
    public void IsT0_ShouldReturnTrue_WhenOneOfIsT0()
    {
        //Arrange
        var getSuccess = GetSuccess();
        
        //Act
        var isSuccess = (bool)getSuccess.Is(out Success<string> success);
        var isError = (bool)getSuccess.Is(out Error<string> error);

        //Assert
        isSuccess.Should().Be(true);
        success.Value.Should().Be(SuccessMessage);
        
        isError.Should().Be(false);
        error.Value.Should().NotBe(ErrorMessage);
    }
    
    [Fact]
    public void IsT0Else_ShouldReturnTrue_WhenOneOfIsT0()
    {
        //Arrange
        var getSuccess = GetSuccess();
        
        //Act
        var isSuccess = getSuccess.Is(out Success<string> success).Else(out Error<string> error);
        var isError = getSuccess.Is(out Error<string> error2).Else(out Success<string> success2);

        //Assert
        isSuccess.Should().Be(true);
        success.Value.Should().Be(SuccessMessage);
        error.Value.Should().NotBe(ErrorMessage);
        
        isError.Should().Be(false);
        success2.Value.Should().Be(SuccessMessage);
        error2.Value.Should().NotBe(ErrorMessage);
    }
    
    [Fact]
    public void IsT1_ShouldReturnTrue_WhenOneOfIsT1()
    {
        //Arrange
        var getSuccess = GetError();
        
        //Act
        var isSuccess = (bool)getSuccess.Is(out Success<string> success);
        var isError = (bool)getSuccess.Is(out Error<string> error);

        //Assert
        isSuccess.Should().Be(false);
        success.Value.Should().NotBe(SuccessMessage);
        
        isError.Should().Be(true);
        error.Value.Should().Be(ErrorMessage);
    }
    
    [Fact]
    public void IsT1Else_ShouldReturnTrue_WhenOneOfIsT1()
    {
        //Arrange
        var getSuccess = GetError();
        
        //Act
        var isSuccess = getSuccess.Is(out Success<string> success).Else(out Error<string> error);
        var isError = getSuccess.Is(out Error<string> error2).Else(out Success<string> success2);

        //Assert
        isSuccess.Should().Be(false);
        success.Value.Should().NotBe(SuccessMessage);
        error.Value.Should().Be(ErrorMessage);
        
        isError.Should().Be(true);
        success2.Value.Should().NotBe(SuccessMessage);
        error2.Value.Should().Be(ErrorMessage);
    }
    
    private static OneOf<Success<string>, Error<string>> GetSuccess() => new Success<string>(SuccessMessage);
    private static OneOf<Success<string>, Error<string>> GetError() => new Error<string>(ErrorMessage);
}