namespace AdventOfCode4.Services;

public class Processing
{
    public List<Card> LoadCards()
    {
        var cards = new List<Card>();
        var lines = File.ReadAllLines("""C:\\Workbench\\AdventOfCode4\\AdventOfCode4\\Input.txt""");
        foreach (var line in lines)
        {
            var card = ParseLine(line);
            cards.Add(card);
        }

        return cards;
    }

    public Card ParseLine(string line)
    {
        var result = new Card();

        // change the '|' to a : so we can split on it
        line = line.Replace("|", ":");

        var cardSegments = line.Split(":")[0].Split(" ");
        result.CardNumber = int.Parse(cardSegments[1]);

        var winningSegment = line.Split(":")[1].Trim().Split(" ").Where(segment => !string.IsNullOrEmpty(segment)).ToArray();
        result.WinningNumbers = winningSegment.Select(int.Parse).ToArray().ToList();

        var targetSegment = line.Split(":")[2].Trim().Split(" ").Where(segment => !string.IsNullOrEmpty(segment)).ToArray();
        result.TargetNumbers = targetSegment.Select(int.Parse).ToArray().ToList();

        return result;
    }

    public Card ScoreCard(Card card)
    {
        var result = 0;

        // how many numbers in the winning numbers are in the target numbers?
        var count = card.WinningNumbers.Count(number => card.TargetNumbers.Contains(number));
        if (count == 0)
        {
            result = 0;
        }

        





        card.Score = result;
        return card;
    }
}

