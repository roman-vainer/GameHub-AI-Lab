namespace GameHub;

public abstract class Game
{
    private string _title = string.Empty;
    private string _genre = string.Empty;
    private decimal _price;
    private int _playtime;

    public int Id { get; set; }

    public string Title
    {
        get => _title;
        set => _title = value ?? string.Empty;
    }

    public string Genre
    {
        get => _genre;
        set => _genre = value ?? string.Empty;
    }

    public decimal Price
    {
        get => _price;
        set
        {
            ArgumentOutOfRangeException.ThrowIfNegative(value);
            _price = value;
        }
    }

    public int Playtime
    {
        get => _playtime;
        set
        {
            ArgumentOutOfRangeException.ThrowIfNegative(value);
            _playtime = value;
        }
    }

    public abstract void ShowInfo();
}
