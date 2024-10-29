namespace Labor_08;
using Labor_08.Enums;

public class Player
{
    // fields
    private string _name;
    private Position _pos;
    
    // constructors
    public Player(string name, Position pos)
    {
        _name = name;
        _pos = pos;
    }
    
    // methods
    public override string ToString()
    {
        return $"{_name} - {_pos}";
    }
    
    // properties
    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Position Pos
    {
        get => _pos;
        set => _pos = value;
    }
}