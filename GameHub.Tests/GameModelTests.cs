using GameHub;

namespace GameHub.Tests;

public class GameModelTests
{
    [Fact]
    public void Price_Negative_Throws()
    {
        var game = new PCGame();
        Assert.Throws<ArgumentOutOfRangeException>(() => game.Price = -0.01m);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(59.99)]
    public void Price_NonNegative_IsStored(double value)
    {
        var game = new PCGame { Price = (decimal)value };
        Assert.Equal((decimal)value, game.Price);
    }

    [Fact]
    public void Playtime_Negative_Throws()
    {
        var game = new PCGame();
        Assert.Throws<ArgumentOutOfRangeException>(() => game.Playtime = -1);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(25)]
    public void Playtime_NonNegative_IsStored(int value)
    {
        var game = new PCGame { Playtime = value };
        Assert.Equal(value, game.Playtime);
    }

    [Fact]
    public void Title_Null_BecomesEmpty()
    {
        var game = new PCGame { Title = "Doom" };
        game.Title = null!;
        Assert.Equal(string.Empty, game.Title);
    }

    [Fact]
    public void Genre_Null_BecomesEmpty()
    {
        var game = new PCGame { Genre = "Shooter" };
        game.Genre = null!;
        Assert.Equal(string.Empty, game.Genre);
    }

    [Fact]
    public void PCGame_Launcher_Null_BecomesEmpty()
    {
        var game = new PCGame { Launcher = "Steam" };
        game.Launcher = null!;
        Assert.Equal(string.Empty, game.Launcher);
    }

    [Fact]
    public void ConsoleGame_Console_Null_BecomesEmpty()
    {
        var game = new ConsoleGame { Console = "PS5" };
        game.Console = null!;
        Assert.Equal(string.Empty, game.Console);
    }

    [Fact]
    public void MobileGame_OperatingSystem_Null_BecomesEmpty()
    {
        var game = new MobileGame { OperatingSystem = "Android" };
        game.OperatingSystem = null!;
        Assert.Equal(string.Empty, game.OperatingSystem);
    }

    [Fact]
    public void ConcreteGames_InheritFromGame()
    {
        Assert.IsAssignableFrom<Game>(new PCGame());
        Assert.IsAssignableFrom<Game>(new ConsoleGame());
        Assert.IsAssignableFrom<Game>(new MobileGame());
    }

    public static TheoryData<Game> AllGames() => new()
    {
        new PCGame { Id = 1, Title = "A", Genre = "G", Price = 1m, Playtime = 2, Launcher = "Steam" },
        new ConsoleGame { Id = 2, Title = "B", Genre = "G", Price = 1m, Playtime = 2, Console = "PS5" },
        new MobileGame { Id = 3, Title = "C", Genre = "G", Price = 1m, Playtime = 2, OperatingSystem = "iOS" },
    };

    [Theory]
    [MemberData(nameof(AllGames))]
    public void ShowInfo_Succeeds_AndWritesOutput(Game game)
    {
        var original = Console.Out;
        var writer = new StringWriter();
        Console.SetOut(writer);
        try
        {
            var ex = Record.Exception(game.ShowInfo);
            Assert.Null(ex);
        }
        finally
        {
            Console.SetOut(original);
        }
        Assert.Contains($"Title: {game.Title}", writer.ToString());
    }
}
