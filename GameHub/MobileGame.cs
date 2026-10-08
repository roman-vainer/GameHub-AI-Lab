namespace GameHub;

public class MobileGame : Game
{
    private string _operatingSystem = string.Empty;

    public string OperatingSystem
    {
        get => _operatingSystem;
        set => _operatingSystem = value ?? string.Empty;
    }

    public override void ShowInfo()
    {
        System.Console.WriteLine($"Id: {Id}");
        System.Console.WriteLine($"Title: {Title}");
        System.Console.WriteLine($"Genre: {Genre}");
        System.Console.WriteLine($"Price: {Price}");
        System.Console.WriteLine($"Playtime: {Playtime}");
        System.Console.WriteLine($"OperatingSystem: {OperatingSystem}");
    }
}
