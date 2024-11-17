using Labor_09.Enums;

namespace Labor_09;

public class GameItem
{
    // fields
    private Position _pos;
    private ConsoleSprite _sprite;
    private ItemType _type;
    private double _fillingRatio;
    private bool _available;

    // constructors
    public GameItem(int x, int y, ItemType type)
    {
        _pos = new Position(x, y);
        _type = type;
        _available = true;
        SetInitialProperties();
    }

    // methods
    private void SetInitialProperties()
    {
        switch (_type)
        {
            case ItemType.Ammo:
            {
                _fillingRatio = 0.0;
                _sprite = new ConsoleSprite(ConsoleColor.DarkRed, ConsoleColor.Yellow, 'A');
                break;
            }

            case ItemType.BFGCell:
            {
                _fillingRatio = 0.0;
                _sprite = new ConsoleSprite(ConsoleColor.Green, ConsoleColor.White, 'B');
                break;
            }

            case ItemType.Door:
            {
                // Zárt ajtó esetén
                _fillingRatio = 1.0;
                _sprite = new ConsoleSprite(ConsoleColor.DarkGray, ConsoleColor.Red, '/');
                break;
            }

            case ItemType.LevelExit:
            {
                _fillingRatio = 1.0;
                _sprite = new ConsoleSprite(ConsoleColor.Blue, ConsoleColor.Black, 'E');
                break;
            }

            case ItemType.Medikit:
            {
                _fillingRatio = 0.0;
                _sprite = new ConsoleSprite(ConsoleColor.Gray, ConsoleColor.DarkRed, '+');
                break;
            }

            case ItemType.ToxicWaste:
            {
                _fillingRatio = 0.0;
                _sprite = new ConsoleSprite(ConsoleColor.Green, ConsoleColor.DarkGreen, ':');
                break;
            }

            case ItemType.Wall:
            {
                _fillingRatio = 1.0;
                _sprite = new ConsoleSprite(ConsoleColor.DarkGray, ConsoleColor.DarkGray, ' ');
                break;
            }

            default:
                throw new ArgumentException("Ismeretlen ItemType");
        }
    }

    public void Interact()
    {
        if (_type == ItemType.Ammo || _type == ItemType.BFGCell || _type == ItemType.Medikit)
            _available = false;

        if (_type == ItemType.Door)
        {
            if (_fillingRatio == 1.0)
            {
                _fillingRatio = 0.0;
                _sprite = new ConsoleSprite(ConsoleColor.DarkGray, ConsoleColor.Green, '/');
            }
            else
            {
                _fillingRatio = 1.0;
                _sprite = new ConsoleSprite(ConsoleColor.DarkGray, ConsoleColor.Red, '/');
            }

            // Játékelemek tárolása, megjelenítése és törlése
        }
    }

    // properties
    public Position Positon => _pos;

    public ConsoleSprite Sprite => _sprite;

    public ItemType Type => _type;

    public double FillingRatio => _fillingRatio;

    public bool Available => _available;
}
