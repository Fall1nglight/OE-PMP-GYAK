namespace Labor_09;

public class Position
{
    // fields
    private int _x;
    private int _y;

    // constructors
    public Position(int x, int y)
    {
        _x = x;
        _y = y;
    }

    // methods
    public static Position Add(Position p1, Position p2)
    {
        int sumX = p1.X + p2.X;
        int sumY = p1.Y + p2.Y;
        return new Position(sumX, sumY);
    }

    public static double Distance(Position p1, Position p2)
    {
        double distance = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        return distance;
    }

    public void SetPosition(Position pos)
    {
        X = pos.X;
        Y = pos.Y;
    }

    // if (_x < 0)
    //     pos.X = 0;
    //
    // if (pos.X >= Console.WindowWidth)
    // pos.X = Console.WindowWidth - 1;
    //
    // if (pos.Y < 0)
    //     pos.Y = 0;
    //
    // if (pos.Y >= Console.WindowHeight)
    // pos.Y = Console.WindowHeight - 1 * 2 + 1;

    public bool IsInMap()
    {
        if (_x < 0 || _y < 0 || _x >= Console.WindowWidth || _y >= Console.WindowWidth)
            return false;

        return true;
    }

    // properties
    public int X
    {
        get => _x;
        set => _x = value;
    }

    public int Y
    {
        get => _y;
        set => _y = value;
    }
}
