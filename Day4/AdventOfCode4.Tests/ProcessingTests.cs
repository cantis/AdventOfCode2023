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
            WinningNumbers = [41, 48, 83, 86, 17],
            TargetNumbers = [83, 86, 6, 31, 17, 9, 48, 53]
        };

        // Act
        var processing = new Processing();
        var result = processing.ScoreCard(sampleCard);

        // Assert

        Assert.Equal(8, result.Score);
    }
}
