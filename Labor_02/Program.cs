namespace Labor_02;

internal class Program
{
    public static void Main(string[] args)
    {
        #region 1. feladat

        Console.WriteLine("1. feladat");

        Console.Write("Adj meg egy pozitív egész számot: ");
        int inputN = int.Parse(Console.ReadLine()!);

        for (int i = 1; i < inputN; i++)
            if (i % 2 == 0)
                Console.Write($"{i} ");

        Console.ReadLine();

        #endregion

        #region 2. feladat

        Console.Clear();
        Console.WriteLine("2. feladat");

        string pwd = "12345";
        string inputPwd = string.Empty;
        int tryCounter = 0;

        while (String.Compare(pwd, inputPwd, StringComparison.Ordinal) != 0)
        {
            tryCounter++;

            if (tryCounter > 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("3 sikertelen próbálkozás!");
                Console.ResetColor();
                break;
            }

            Console.Write($"({tryCounter}/3) Add meg a jelszavad: ");
            inputPwd = Console.ReadLine()!;
        }

        if (tryCounter == 3)
            Console.WriteLine("Helyes jelszó!");

        Console.ReadLine();

        #endregion

        #region 3. feladat

        Console.Clear();
        Console.WriteLine("3. feladat");

        Random rand = new Random();
        int firstInputN = 12;
        int randN = rand.Next(1, 1001);
        int numOfTries = 0;

        while (randN != firstInputN)
        {
            randN = rand.Next(1, 1001);
            numOfTries++;
        }

        Console.WriteLine($"A szám kitalálásához {numOfTries} próba kellett.");

        Console.ReadLine();

        #endregion

        #region 4. feladat

        Console.Clear();
        Console.WriteLine("4. feladat");

        Console.Write("Játékosok száma: ");
        int inputNumOfPlayers = int.Parse(Console.ReadLine()!);
        int[] rolls = new int[inputNumOfPlayers];
        int idx = 0;

        while (Array.IndexOf(rolls, 6) == -1)
        {
            Console.WriteLine("Nyomd le az Entert a dobáshoz!");
            Console.ReadLine();

            if (idx == inputNumOfPlayers)
            {
                idx = 0;
                Console.Clear();
            }

            rolls[idx] = rand.Next(1, 7);
            Console.Write($"[# {idx + 1} játékos] Dobása: {rolls[idx]}");
            Console.WriteLine();

            idx++;
        }

        Console.WriteLine($"A(z) {Array.IndexOf(rolls, 6) + 1}. játékos kezdi a játékot.");
        Console.ReadLine();

        #endregion

        #region 5. feladat

        Console.Clear();
        Console.WriteLine("5. feladat");

        int numToGuess = 908;
        int numOfGuesses = 0;
        int inputGuess = 0;

        while (inputGuess != numToGuess)
        {
            numOfGuesses++;

            Console.Write("Adj meg egy számot: ");
            inputGuess = int.Parse(Console.ReadLine()!);

            if (numToGuess < inputGuess)
                Console.WriteLine("A gondolt szám kisebb, mint amit megadtál.");
            else if (numToGuess > inputGuess)
                Console.WriteLine("A gondolt szám nagyobb, mint amit megadtál.");
        }

        Console.WriteLine($"Sikeresen eltaláltad! Mindössze {numOfGuesses} próbába telt.");
        Console.ReadLine();

        #endregion

        #region 6. feladat

        Console.Clear();
        Console.WriteLine("6. feladat");

        Console.Write("Kéregy egy pozitív egész számot: ");
        int inputPosN = int.Parse(Console.ReadLine()!);

        bool isEven = inputPosN % 2 == 0;
        int numOfDividers = 0;

        for (int i = 2; i < inputPosN; i++)
        {
            if (inputPosN % i == 0)
                numOfDividers++;
        }

        bool isPrime = numOfDividers == 0;

        Console.WriteLine(isEven ? "A megadott szám páros." : "A megadott szám páratlan.");
        Console.WriteLine($"A megadótt szám pozitív osztóinak száma: {numOfDividers}");
        Console.WriteLine(isPrime ? "A megadott szám prímszám." : "A megadott szám összetett.");

        Console.ReadLine();

        #endregion

        #region 7. feladat

        Console.Clear();
        Console.WriteLine("7. feladat");

        Console.Write("Kérek egy pozitív egész számot: ");
        int inputFactorialBase = int.Parse(Console.ReadLine()!);

        int factorial = 1;
        string factorialText = String.Empty;

        for (int i = inputFactorialBase; i >= 1; i--)
        {
            factorial *= i;
            factorialText += $"{i}{(i > 1 ? "*" : "")}";
        }

        Console.WriteLine($"{inputFactorialBase}! = {factorialText} = {factorial}");
        Console.ReadLine();

        #endregion

        #region 8. feladat

        Console.Clear();
        Console.WriteLine("8. feladat");

        for (int i = 1; i < 10; i++)
        {
            if (i == 1)
                Console.Write($"{i} | ");

            for (int j = 1; j < 10; j++)
            {
                if (j == 1)
                    Console.Write($"{j} | ");

                Console.Write($"{i * j} | ");
            }

            Console.WriteLine();
        }

        Console.ReadLine();

        #endregion

        #region 9. feladat

        Console.Clear();
        Console.WriteLine("9. feladat");

        Console.Write("Időtartam másodpercben: ");
        int inputSeconds = int.Parse(Console.ReadLine()!);

        while (inputSeconds >= 0)
        {
            int seconds = inputSeconds % 60;
            int minutes = inputSeconds / 60;

            Console.Clear();

            if (inputSeconds == 0)
                Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine($"{minutes:00}:{seconds:00}");

            System.Threading.Thread.Sleep(1000);
            inputSeconds--;
        }

        Console.ResetColor();
        Console.ReadLine();

        #endregion

        #region 10. feladat

        Console.Clear();
        Console.WriteLine("10. feladat");

        Console.Write("32 bites szám: ");
        uint inputNumToConvert = uint.Parse(Console.ReadLine()!);

        // string binary = ConvertIntToBinary(inputNumToConvert);
        string binary = Convert.ToString(inputNumToConvert, 2);
        string extendedBinary = ExtendToSize(binary, 32);
        string formattedBinary = FormatBinary(extendedBinary);

        Console.WriteLine($"{inputNumToConvert} (10) = {formattedBinary} (2)");
        Console.ReadLine();

        static string ExtendToSize(string s, int size)
        {
            string result = new string('0', size - s.Length);
            return result + s;
        }

        static string FormatBinary(string s)
        {
            string result = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                if (i % 8 == 0)
                    result += ' ';

                result += s[i];
            }

            return result;
        }

        static string ConvertIntToBinary(uint input)
        {
            string result = String.Empty;
            uint value = input;

            while (value != 0)
            {
                if (value % 2 == 0)
                {
                    result += '0';
                    value = value / 2;
                }
                else
                {
                    result += '1';
                    value -= 1;
                    value = value / 2;
                }
            }

            char[] rvArr = result.ToCharArray();
            Array.Reverse(rvArr);
            string reversed = new string(rvArr);

            return $"{reversed}";
        }

        #endregion

        #region 11. feladat

        Console.Clear();
        Console.WriteLine("11. feladat");

        static void DisplayStartData(int c, int w)
        {
            Console.WriteLine($"Kreditjeid: {c}");
            Console.WriteLine($"Jelenlegi tét: {w}");
        }

        static Tuple<String, int> GetWinAmount(int w)
        {
            Random rand = new Random();
            int numF = rand.Next(0, 10);
            int numS = rand.Next(0, 10);
            int numT = rand.Next(0, 10);
            string rolledNumbers = $"Pörgetett számok: {numF}, {numS}, {numT}";

            Tuple<String, int> result = new Tuple<string, int>(
                $"{rolledNumbers}\nEgy szám se egyezik meg!\nVesztettél {w} kreditet!",
                1
            );

            // 10x
            if (numF == numS || numS == numT || numT == numF)
                result = new Tuple<string, int>(
                    $"{rolledNumbers}\nKét szám megegyezik!\nNyertél {w * 10} kreditet!",
                    w * 10
                );

            // 50x
            if (numF == numS && numS == numT)
            {
                result = new Tuple<string, int>(
                    $"{rolledNumbers}\nHárom szám megegyezik!\nNyertél {w * 50} kreditet!",
                    w * 50
                );
            }

            return result;
        }

        ConsoleKey key;
        int credit = 100;
        int wage = 1;

        do
        {
            Console.Clear();
            DisplayStartData(credit, wage);
            key = Console.ReadKey().Key;

            if (key == ConsoleKey.DownArrow && wage > 1)
                wage--;

            if (key == ConsoleKey.UpArrow && wage < credit)
                wage++;

            if (key == ConsoleKey.Spacebar)
            {
                if (wage > credit)
                {
                    wage = credit;
                    continue;
                }

                Tuple<string, int> result = GetWinAmount(wage);
                Console.WriteLine(result.Item1);
                credit += result.Item2;
                System.Threading.Thread.Sleep(1000);
            }
        } while (key != ConsoleKey.Escape && credit >= 1);

        Console.WriteLine($"A játéknak vége.");
        Console.ReadLine();

        #endregion

        #region 12. feladat

        // todo | lényegében ugyan az mint a 11. feladat
        // véletlen szám helyett véletlenszerűen választunk
        // az ASCII art elemeket tartalmazó listából / tömbből

        #endregion

        #region 13. feladat

        Console.Clear();
        Console.WriteLine("13. feladat");

        static double CalcPt(int rounds, double basePt, double r, double a)
        {
            rounds = rounds > 0 ? rounds : 1;
            Random rand = new Random();

            for (int i = 0; i < rounds; i++)
            {
                double e = -a + (rand.NextDouble() * (2 * a));
                basePt = r * basePt + e;
            }

            return basePt;
        }

        Console.Write("Kérek egy megadott óraszámot: ");
        int rounds = int.Parse(Console.ReadLine()!);

        double basePt = 1.0;

        double simulationOne = CalcPt(rounds, basePt, 1.47, 3.5);
        double simulationTwo = CalcPt(rounds, basePt, 1.77, 3.5);
        double simulationThree = CalcPt(rounds, basePt, 1.47, 3.9);
        double simulationFour = CalcPt(rounds, basePt, 2.53, 10);

        Console.WriteLine($"Simulation one: {simulationOne}");
        Console.WriteLine($"Simulation two: {simulationTwo}");
        Console.WriteLine($"Simulation three: {simulationThree}");
        Console.WriteLine($"Simulation four: {simulationFour}");
        Console.ReadLine();

        #endregion
    }
}
