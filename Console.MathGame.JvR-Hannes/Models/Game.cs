namespace MathGame.JvR_Hannes.Models;

internal class Game
{
    public DateTime Date { get; set; }
    public int Score { get; set; }
    public string Type { get; set; }
}

internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division,
}
