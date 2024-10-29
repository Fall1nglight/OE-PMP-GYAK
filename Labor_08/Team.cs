using Labor_08.Enums;

namespace Labor_08;

public class Team
{
    // fields
    private Player?[] _players;
    private int _numberOfPlayers;

    // constructors
    public Team()
    {
        _players = new Player[5];
        _numberOfPlayers = 0;
    }

    // methods
    public bool IsFull()
    {
        return _numberOfPlayers == 5;
    }

    public bool IsIncluded(Player player)
    {
        bool result = false;

        for (int i = 0; i < _players.Length; i++)
        {
            Player? tmpPlayer = _players[i];

            if (tmpPlayer == player)
            {
                result = true;
                break;
            }
        }

        return result;
    }

    public bool IsAvailable(Player player)
    {
        bool result = true;
        int numOfWingers = 0;

        for (int i = 0; i < _players.Length; i++)
        {
            Player? tmpPlayer = _players[i];

            if (tmpPlayer == null)
                continue;

            if (player.Pos == Position.Winger)
            {
                if (tmpPlayer!.Pos == Position.Winger)
                    numOfWingers++;

                if (numOfWingers == 2)
                {
                    result = false;
                    break;
                }
                continue;
            }

            if (player.Pos == tmpPlayer!.Pos)
            {
                result = false;
                break;
            }
        }

        return result;
    }

    public void Include(Player player)
    {
        int actualNumberOfPlayers = 0;

        for (int i = 0; i < _players.Length; i++)
        {
            Player? tmpPlayer = _players[i];
            actualNumberOfPlayers = i + 1;

            if (tmpPlayer == null)
            {
                _players[i] = player;
                break;
            }
        }

        _numberOfPlayers = actualNumberOfPlayers;
    }

    // properties
    public Player?[] Players
    {
        get => _players;
        set => _players = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int NumberOfPlayers
    {
        get => _numberOfPlayers;
        set => _numberOfPlayers = value;
    }
}
