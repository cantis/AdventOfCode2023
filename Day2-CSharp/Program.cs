// See https://aka.ms/new-console-template for more information

namespace Day2;

public class Main
{
    static void process()
    {
        Console.WriteLine("Hello, World!");

        var redCubes = 12;
        var greenCubes = 13;
        var blueCubes = 14;

        var play1 = "1 red, 2 green, 6 blue";
        var play2 = "3 blue, 4 red";

        // create an instance of the Play class

    }
}

public class Play
{
    public int Red { get; set; }
    public int Green { get; set; }
    public int Blue { get; set; }

    public static Play ParsePlay(string playString)
    {
        var play = new Play();
        var colors = playString.Split(',');

        foreach (var color in colors)
        {
            var parts = color.Trim().Split(' ');
            var count = int.Parse(parts[0]);
            var colorName = parts[1].ToLower();

            switch (colorName)
            {
                case "red":
                    play.Red = count;
                    break;
                case "green":
                    play.Green = count;
                    break;
                case "blue":
                    play.Blue = count;
                    break;
                default:
                    throw new ArgumentException($"Invalid color: {colorName}");
            }
        }

        return play;
    }

}

