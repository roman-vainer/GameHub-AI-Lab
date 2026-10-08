namespace GameHub;

public class PCGame : Game
{
    private string _launcher = string.Empty;

    public string Launcher
    {
        get => _launcher;
        set => _launcher = value ?? string.Empty;
    }

    public override void ShowInfo()
    {
        System.Console.WriteLine($"Id: {Id}");
        System.Console.WriteLine($"Title: {Title}");
        System.Console.WriteLine($"Genre: {Genre}");
        System.Console.WriteLine($"Price: {Price}");
        System.Console.WriteLine($"Playtime: {Playtime}");
        System.Console.WriteLine($"Launcher: {Launcher}");
    }
}
