namespace Labor_07;

public class Mole
{
    // fields
    private int _pos;
    private readonly Random _rand;

    public Mole()
    {
        _rand = new Random();
    }

    // methods
    public void TurnUp()
    {
        (int x, int y) = Console.GetCursorPosition();

        Console.Clear();
        Console.SetCursorPosition(_pos, 0);
        Console.Write('M');
        Console.SetCursorPosition(x, y);
    }

    public void Hide(int min, int max)
    {
        int randN = _rand.Next(min - 1, max);
        _pos = randN >= Console.WindowWidth ? Console.WindowWidth - 1 : randN;
    }

    // properties
    public int Pos => _pos;
}
