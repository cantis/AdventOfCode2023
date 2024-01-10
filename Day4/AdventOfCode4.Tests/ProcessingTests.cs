using AdventOfCode4.Services;

namespace AdventOfCode4.Tests;

public class ProcessingTests
{
    [Fact]
    public void ParseLine_CardNumber_EqualOne()
    {
        // Arrange
        const string sampleLine = "Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53";
        
        // Act
        var processing = new Processing();
        var result = processing.ParseLine(sampleLine);

        // Assert
        Assert.Equal(1, result.CardNumber);
    }

    [Fact]
    public void ParseLine_WinningNumbers_Ok()
    {
        // Arrange
        const string sampleLine = "Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53";
        
        // Act
        var processing = new Processing();
        var result = processing.ParseLine(sampleLine);

        // Assert
        Assert.Equal(41, result.WinningNumbers[0]);
        Assert.Equal(48, result.WinningNumbers[1]);
        Assert.Equal(83, result.WinningNumbers[2]);
        Assert.Equal(86, result.WinningNumbers[3]);
        Assert.Equal(17, result.WinningNumbers[4]);
    }

    [Fact]
    public void ParseLine_TargetNumbers_Ok()
    {
        // Arrange
        const string sampleLine = "Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53";
        
        // Act
        var processing = new Processing();
        var result = processing.ParseLine(sampleLine);

        // Assert
        Assert.Equal(83, result.TargetNumbers[0]);
        Assert.Equal(86, result.TargetNumbers[1]);
        Assert.Equal(6, result.TargetNumbers[2]);
        Assert.Equal(31, result.TargetNumbers[3]);
        Assert.Equal(17, result.TargetNumbers[4]);
        Assert.Equal(9, result.TargetNumbers[5]);
        Assert.Equal(48, result.TargetNumbers[6]);
        Assert.Equal(53, result.TargetNumbers[7]);
    }

    [Fact]
    public void ParseLine_Score_Ok()
    {
        // Arrange
        var sampleCard = new Card
        {
            CardNumber = 1,
            WinningNumbers = new() {41, 48, 83, 86, 17},
            TargetNumbers = new() {83, 86, 6, 31, 17, 9, 48, 53}
        };

        // Act
        var processing = new Processing();
        var result = processing.ScoreCard(sampleCard);

        // Assert

        Assert.Equal(8, result.Score);
    }

    [Theory]
    [ClassData(typeof(CardTestData))]
    public void ParseLines_Ok(string testLine, int expectedScore)
    {
        // Arrange
        var processing = new Processing();

        // Act
        var parsedLine = processing.ParseLine(testLine);
        var result = processing.ScoreCard(parsedLine);

        // Assert
        Assert.Equal(expectedScore, result.Score);
    }
}

public class CardTestData : TheoryData<string, int>
{
    public CardTestData()
    {
        Add("Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53", 8);
        Add("Card 2: 13 32 20 16 61 | 61 30 68 82 17 32 24 19", 2);
        Add("Card 3:  1 21 53 59 44 | 69 82 63 72 16 21 14  1", 2);
        Add("Card 4: 41 92 73 84 69 | 59 84 76 51 58  5 54 83", 1);
        Add("Card 5: 87 83 26 28 32 | 88 30 70 12 93 22 82 36", 0);
        Add("Card 6: 31 18 13 56 72 | 74 77 10 23 35 67 36 11", 0);
    }
}