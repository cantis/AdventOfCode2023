namespace AdventOfCode4;

/// <summary>
/// Represents a card with a card number, winning numbers and target numbers.
/// </summary>
public class Card
{
    public int CardNumber { get; set; }
    public List<int> WinningNumbers { get; set; } = [];
    public List<int> TargetNumbers { get; set; } = [];
    public int Score { get; set; }
}