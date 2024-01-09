using Xunit;
using Day2; // Replace with the namespace of your Play class

public class PlayTests
{
    [Fact]
    public void TestParsePlay()
    {
        string play1 = "2 red, 3 green, 4 blue"; // Replace with your actual play string

        Play result = Play.ParsePlay(play1);

        Assert.Equal(2, result.Red);
        Assert.Equal(3, result.Green);
        Assert.Equal(4, result.Blue);
    }
}