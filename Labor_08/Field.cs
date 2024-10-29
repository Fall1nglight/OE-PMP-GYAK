namespace Labor_08;

public class Field
{
    // fields
    private int _m;

    // 6x6os mező

    // constructors
    public Field(int m)
    {
        _m = m;
    }

    // methods
    public bool AllowedPosition(int x, int y)
    {
        if (x > TargetX || y > TargetY)
            return false;

        return true;
    }

    public void Show()
    {
        Console.WriteLine(new string('-', _m + 2));

        for (int i = 0; i < _m; i++)
        {
            Console.WriteLine($"|{new string(' ', _m)}|");
        }

        Console.WriteLine(new string('-', _m + 2));
    }

    // properties
    public int M
    {
        get => _m;
        set => _m = value;
    }

    public int TargetX => _m - 1;

    public int TargetY => _m - 1;
}
