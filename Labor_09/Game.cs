using Labor_09.Enums;

namespace Labor_09;

public class Game
{
    // fields
    private Player _player;
    private bool _exited;
    private List<GameItem> _items;

    // constructors
    public Game()
    {
        _player = new Player(0, 0);
        _items = new List<GameItem>();

        // tesztelés idejére csak
        _items.Add(new GameItem(3, 9, ItemType.Door));
        _items.Add(new GameItem(5, 8, ItemType.ToxicWaste));
        _items.Add(new GameItem(6, 10, ItemType.Medikit));
        _items.Add(new GameItem(7, 11, ItemType.Wall));
    }

    // methods
    private void RenderSingleSprite(Position pos, ConsoleSprite sprite)
    {
        // Ellenőrzi, hogy a pozíció az aktuális képernyőn belül van-e
        if (pos.X >= Console.WindowWidth || pos.Y >= Console.WindowHeight || pos.X < 0 || pos.Y < 0)
        {
            //     Console.WriteLine($"pozX{pos.X}");
            //     Console.WriteLine($"pozY{pos.Y}");
            //     Console.ReadLine();
            //     _exited = true;
            return;
        }

        Console.BackgroundColor = sprite.Background;
        Console.ForegroundColor = sprite.Foreground;
        Console.SetCursorPosition(pos.X, pos.Y);
        Console.Write(sprite.Glyph);
    }

    private void RenderGame()
    {
        Console.CursorVisible = false;
        Console.ResetColor();
        Console.Clear();

        for (int i = 0; i < _items.Count; i++)
        {
            GameItem tmpItem = _items[i];
            RenderSingleSprite(tmpItem.Positon, tmpItem.Sprite);
        }

        RenderSingleSprite(_player.Pos, _player.Sprite);
    }

    private void CleanUpGameItems()
    {
        List<GameItem> toRemove = new List<GameItem>();

        foreach (GameItem item in _items)
            if (!item.Available)
                toRemove.Add(item);

        foreach (GameItem item in toRemove)
            _items.Remove(item);
    }

    private void UserAction()
    {
        if (!Console.KeyAvailable)
            return;

        ConsoleKeyInfo pressed = Console.ReadKey(true);

        // Dictionary<ConsoleKey, Position> dict = new Dictionary<ConsoleKey, Position>()
        // {
        //     { ConsoleKey.UpArrow, Position.Add(_player.Pos, new Position(0, -1)) },
        //     { ConsoleKey.DownArrow, Position.Add(_player.Pos, new Position(0, 1)) },
        //     { ConsoleKey.RightArrow, Position.Add(_player.Pos, new Position(1, 0)) },
        //     { ConsoleKey.LeftArrow, Position.Add(_player.Pos, new Position(-1, 0)) },
        // };
        //
        // if (dict.Keys.Contains(pressed.Key))
        // {
        //     Move(_player, dict[pressed.Key]);
        // }

        switch (pressed.Key)
        {
            case ConsoleKey.Escape:
                _exited = true;
                break;

            case ConsoleKey.UpArrow:
            {
                Position vector = new Position(0, -1);
                Position newPos = Position.Add(_player.Pos, vector);
                Move(_player, newPos);
                break;
            }

            case ConsoleKey.DownArrow:
            {
                Position vector = new Position(0, 1);
                Position newPos = Position.Add(_player.Pos, vector);
                Move(_player, newPos);
                break;
            }

            case ConsoleKey.RightArrow:
            {
                Position vector = new Position(1, 0);
                Position newPos = Position.Add(_player.Pos, vector);
                Move(_player, newPos);
                break;
            }

            case ConsoleKey.LeftArrow:
            {
                Position vector = new Position(-1, 0);
                Position newPos = Position.Add(_player.Pos, vector);
                Move(_player, newPos);
                break;
            }

            case ConsoleKey.D:
            {
                foreach (GameItem item in _items)
                    item.Interact();

                // todo | ezt lehet át kell helyezni a Run()-ba
                CleanUpGameItems();

                break;
            }
        }
    }

    private List<GameItem> GetGameItemsWithinDistance(Position pos, double distance)
    {
        List<GameItem> itemsWithinDistance = new List<GameItem>();

        foreach (GameItem item in _items)
        {
            if (Position.Distance(pos, item.Positon) <= distance)
                itemsWithinDistance.Add(item);
        }

        return itemsWithinDistance;
    }

    private double GetTotalFillingRatio(Position pos)
    {
        double result = 0.0;

        foreach (GameItem item in GetGameItemsWithinDistance(pos, 0))
        {
            result += item.FillingRatio;
        }

        return result;
    }

    private void Move(Player player, Position pos)
    {
        double sum = GetTotalFillingRatio(pos) + player.FillingRatio;

        if (!pos.IsInMap())
            return;

        if (sum <= 1.0)
            player.Pos.SetPosition(pos);
    }

    public void Run()
    {
        while (!_exited)
        {
            RenderGame();
            UserAction();
            Thread.Sleep(25);
        }
    }

    // properties
    public bool Exited
    {
        get => _exited;
        set => _exited = value;
    }
}
