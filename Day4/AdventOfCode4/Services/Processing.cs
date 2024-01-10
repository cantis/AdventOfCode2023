namespace AdventOfCode4.Services;

public class Processing
{
    public int ProcessCards()
    {
        var lines = File.ReadAllLines("""C:\Workbench\AdventOfCode2023\Day4\AdventOfCode4\Input.txt""");
        var total = 0;
        foreach (var line in lines)
        {
            var card = ParseLine(line);
            var score = ScoreCard(card).Score;
            total += score;
        }

        return total;
    }

    public Card ParseLine(string line)
    {
        var result = new Card();

        // change the '|' to a : so we can split on it
        line = line.Replace("|", ":");

        var cardSegments = line.Split(":")[0].Split(" ").Where(segment => !string.IsNullOrEmpty(segment)).ToArray();
        result.CardNumber = int.Parse(cardSegments[1]);

        var winningSegment = line.Split(":")[1].Trim().Split(" ").Where(segment => !string.IsNullOrEmpty(segment)).ToArray();
        result.WinningNumbers = winningSegment.Select(int.Parse).ToArray().ToList();

        var targetSegment = line.Split(":")[2].Trim().Split(" ").Where(segment => !string.IsNullOrEmpty(segment)).ToArray();
        result.TargetNumbers = targetSegment.Select(int.Parse).ToArray().ToList();

        return result;
    }

    public Card ScoreCard(Card card)
    {
        var result = new Card();

        var matches = card.WinningNumbers.Intersect(card.TargetNumbers).Count();

        switch (matches)
        {
            case 0:
                result.Score = 0;
                break;
            case 1:
                result.Score = 1;
                break;
            case >= 2:
            {
                var i = 1;
                result.Score = 1;
                while (i < matches)
                {
                    result.Score *= 2;
                    i++;
                }
                break;
            }
        }
        return result;
    }
}

