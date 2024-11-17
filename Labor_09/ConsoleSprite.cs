namespace Labor_09;

public class ConsoleSprite
{
    // fields
    private ConsoleColor _background;
    private ConsoleColor _foreground;
    private char _glyph;

    // constructors
    public ConsoleSprite(ConsoleColor background, ConsoleColor foreground, char glyph)
    {
        _background = background;
        _foreground = foreground;
        _glyph = glyph;
    }

    // methods
    public ConsoleColor Background => _background;

    public ConsoleColor Foreground => _foreground;

    public char Glyph => _glyph;
}
