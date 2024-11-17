namespace Labor_09;

public class Player
{
    // fields
    private Position _pos;
    private ConsoleSprite _sprite;
    private double _fillingRatio;

    // constructors
    public Player(int x, int y)
    {
        _pos = new Position(x, y);
        _sprite = new ConsoleSprite(ConsoleColor.Black, ConsoleColor.DarkGreen, 'O');
        _fillingRatio = 0.5;
    }

    // propeties
    public Position Pos
    {
        get => _pos;
        set => _pos = value ?? throw new ArgumentNullException(nameof(value));
    }

    public ConsoleSprite Sprite => _sprite;

    public double FillingRatio => _fillingRatio;
}
