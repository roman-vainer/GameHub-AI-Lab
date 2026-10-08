namespace GameHub;

public class ConsoleGame : Game
{
    private string _console = string.Empty;

    public string Console
    {
        get => _console;
        set => _console = value ?? string.Empty;
    }

    public override void ShowInfo()
    {
        System.Console.WriteLine($"Id: {Id}");
        System.Console.WriteLine($"Title: {Title}");
        System.Console.WriteLine($"Genre: {Genre}");
        System.Console.WriteLine($"Price: {Price}");
        System.Console.WriteLine($"Playtime: {Playtime}");
        System.Console.WriteLine($"Console: {Console}");
    }
}
