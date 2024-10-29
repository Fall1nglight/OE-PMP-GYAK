namespace Labor_08;

using Enums;

internal class Program
{
    public static void Main(string[] args)
    {
        #region 1. feladat

        // Console.WriteLine("1. feladat");
        // Team team = new Team();
        // Player?[] players = RandomPlayers(25);
        //
        // while (!team.IsFull())
        // {
        //     Console.Clear();
        //     Console.WriteLine($"A csapatban lévő játékosok száma: {team.NumberOfPlayers}");
        //
        //     DisplayPlayers(players);
        //
        //     Console.Write("Választott játkos száma: ");
        //     int inputPlayerId = int.Parse(Console.ReadLine()!);
        //
        //     if (inputPlayerId >= players.Length)
        //     {
        //         Console.WriteLine("Helytelen bemenet.");
        //         Console.ReadLine();
        //         continue;
        //     }
        //
        //     Player? selectedPlayer = players[inputPlayerId];
        //
        //     if (selectedPlayer == null)
        //     {
        //         Console.WriteLine("Hiba történt a választás során!");
        //         Console.ReadLine();
        //         continue;
        //     }
        //
        //     if (team.IsIncluded(selectedPlayer))
        //     {
        //         Console.WriteLine("A választott játékos már szerepel a csapatban!");
        //         Console.ReadLine();
        //         continue;
        //     }
        //
        //     // should be IsPosAvailable
        //     if (!team.IsAvailable(selectedPlayer))
        //     {
        //         Console.WriteLine("A választott játékos szerepe betelt a csapatban!");
        //         Console.ReadLine();
        //         continue;
        //     }
        //
        //     team.Include(selectedPlayer);
        //
        //     Console.WriteLine($"Sikeresen hozzáadtad a csapathoz a következő játékost:");
        //     Console.WriteLine($"\t{selectedPlayer}");
        //     Console.ReadLine();
        // }
        //
        // // display team
        // for (int i = 0; i < team.Players.Length; i++)
        // {
        //     Console.WriteLine(team.Players[i]);
        // }
        //
        // Console.ReadLine();

        #endregion

        #region 2. feladat

        Game game = new Game(15, 4);
        game.Run();

        Console.ReadLine();

        #endregion
    }

    private static void DisplayPlayers(Player?[] players)
    {
        Console.WriteLine("Játékosok:");

        for (int i = 0; i < players.Length; i++)
        {
            Player? tmpPlayer = players[i];
            Console.WriteLine($"\t[{i}] {tmpPlayer}");
        }
    }

    private static Player[] RandomPlayers(int amount)
    {
        Player[] result = new Player[amount];
        Random rand = new Random();
        Array positions = Enum.GetValues(typeof(Position));
        string[] names = new string[]
        {
            "Szabolcs",
            "Máté",
            "Milán",
            "Ákos",
            "Derek",
            "Márk",
            "Lajos",
            "Csaba",
            "Péter",
            "Balázs",
            "László",
            "Dani",
        };

        for (int i = 0; i < amount; i++)
        {
            int randomNameIdx = rand.Next(names.Length);
            int randomPositionIdx = rand.Next(positions.Length);
            Position randomPosition = (Position)positions.GetValue(randomPositionIdx)!;
            Player player = new Player(names[randomNameIdx], randomPosition);
            result[i] = player;
        }

        return result;
    }
}
