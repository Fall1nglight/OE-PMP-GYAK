namespace Labor_08;

public class Buffalo
{
    // fields
    private int _x;
    private int _y;
    private bool _status;
    private readonly Random _rand = new Random();

    public Buffalo()
    {
        _status = true;
    }

    // methods
    public void Move(Field field)
    {
        if (!_status)
            return;

        int stepX = 0;
        int stepY = 0;

        while (stepX + stepY == 0)
        {
            stepX = _rand.Next(2);
            stepY = _rand.Next(2);
        }

        if (!field.AllowedPosition(_x + stepX, _y + stepY))
            return;

        _x += stepX;
        _y += stepY;
    }

    public void Deactivate()
    {
        _status = false;
    }

    public void Show()
    {
        (int, int) oriCursorPos = Console.GetCursorPosition();

        Console.ForegroundColor = _status ? ConsoleColor.Green : ConsoleColor.DarkRed;
        Console.SetCursorPosition(_x + 1, _y + 1);
        Console.Write('B');

        Console.SetCursorPosition(oriCursorPos.Item1, oriCursorPos.Item2);
        Console.ResetColor();
        // Console.WriteLine();
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

    public bool Status
    {
        get => _status;
        set => _status = value;
    }
}
