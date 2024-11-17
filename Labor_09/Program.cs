using Labor_09.Enums;

namespace Labor_09;

internal class Program
{
    public static void Main(string[] args)
    {
        // teszt-1
        // Position p1 = new Position(1, 1);
        // Position p2 = new Position(2, 2);
        //
        // Position sum = Position.Add(p1, p2);
        // double distance = Position.Distance(p1, p2);
        // ;
        //
        // // teszt-2
        // ConsoleSprite sprite = new ConsoleSprite(ConsoleColor.Cyan, ConsoleColor.DarkRed, 'Q');
        // Console.BackgroundColor = sprite.Background;
        // Console.ForegroundColor = sprite.Foreground;
        // Console.WriteLine(sprite.Glyph);
        // ;
        //
        // Console.ResetColor();
        // Console.Clear();
        //
        // // teszt-3
        // Player player = new Player(2, 3);
        // Console.BackgroundColor = player.Sprite.Background;
        // Console.ForegroundColor = player.Sprite.Foreground;
        // Console.SetCursorPosition(player.Pos.X, player.Pos.Y);
        // Console.Write(player.Sprite.Glyph);
        // ;

        Console.WriteLine(Console.WindowHeight);
        Console.WriteLine(Console.WindowWidth);
        // Console.Read();

        Game game = new Game();
        game.Run();
    }
}
