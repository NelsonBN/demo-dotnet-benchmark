using Xunit;

namespace Demo.Benchmarks.Tests;

public class HelperTests
{
    [Fact]
    public void Using_StringJoin_when_pass_two_words_should_return_concatenated_with_space()
    {
        // Arrange
        var left = "Hello";
        var right = "World";


        // Act
        var act = Helper.StringJoin(left, right);


        // Assert
        Assert.Equal("Hello World", act);
    }

    [Fact]
    public void Using_StringConcat_when_pass_two_words_should_return_concatenated_with_space()
    {
        // Arrange
        var left = "Hello";
        var right = "World";


        // Act
        var act = Helper.StringConcat(left, right);


        // Assert
        Assert.Equal("Hello World", act);
    }
}
