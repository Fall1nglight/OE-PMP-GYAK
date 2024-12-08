namespace Labor_05;

internal class Program
{
    private static readonly Random Rand = new Random();

    public static void Main(string[] args)
    {
        #region 1. feladat

        Console.WriteLine("1. feladat");

        string[] lines = File.ReadAllLines("colorem_ipsum.txt");

        for (int i = 0; i < lines.Length; i++)
        {
            string[] arr = lines[i].Split('#');
            Console.ForegroundColor = Enum.Parse<ConsoleColor>(arr[0]);
            Console.WriteLine(arr[1]);
        }

        Console.ResetColor();
        Console.ReadLine();

        #endregion

        #region 2. feladat
        Console.Clear();
        Console.WriteLine("2. feladat");

        char usrInput;
        StreamWriter writer = new StreamWriter("lottery_simulation.txt");
        DateTime dt = DateTime.Today;

        do
        {
            List<int> choosenNumbers = new List<int>();

            while (choosenNumbers.Count != 5)
            {
                int randNum = Rand.Next(1, 91);

                if (!choosenNumbers.Contains(randNum))
                    choosenNumbers.Add(randNum);
            }

            string line = $"On {dt:yy-MM-dd} numbers were: {string.Join(' ', choosenNumbers)}";

            Console.WriteLine(line);
            Console.Write("Another week? [y/n] ");

            usrInput = Console.ReadKey().KeyChar;
            dt = dt.AddDays(7);

            writer.WriteLine(line);
            Console.WriteLine();
        } while (usrInput != 'n');

        writer.Close();
        Console.ReadLine();

        #endregion
    }
}
