namespace Labor_02;

internal class Program
{
    public static void Main(string[] args)
    {
        #region 1. feladat

        // Console.WriteLine("1. feladat");
        //
        // Console.Write("Adj meg egy pozitív egész számot: ");
        // int inputN = int.Parse(Console.ReadLine()!);
        //
        // for (int i = 1; i < inputN; i++)
        //     if (i % 2 == 0)
        //         Console.Write($"{i} ");
        //
        // Console.ReadLine();

        #endregion

        #region 2. feladat

        // Console.Clear();
        // Console.WriteLine("2. feladat");
        //
        // string pwd = "12345";
        // string inputPwd = string.Empty;
        // int tryCounter = 0;
        //
        // while (String.Compare(pwd, inputPwd, StringComparison.Ordinal) != 0)
        // {
        //     tryCounter++;
        //
        //     if (tryCounter > 3)
        //     {
        //         Console.ForegroundColor = ConsoleColor.DarkRed;
        //         Console.WriteLine("3 sikertelen próbálkozás!");
        //         Console.ResetColor();
        //         break;
        //     }
        //
        //     Console.Write($"({tryCounter}/3) Add meg a jelszavad: ");
        //     inputPwd = Console.ReadLine()!;
        // }
        //
        // if (tryCounter == 3)
        //     Console.WriteLine("Helyes jelszó!");
        //
        // Console.ReadLine();

        #endregion

        #region 3. feladat

        // Console.Clear();
        // Console.WriteLine("3. feladat");
        //
        Random rand = new Random();
        // int firstInputN = 12;
        // int randN = rand.Next(1, 1001);
        // int numOfTries = 0;
        //
        // while (randN != firstInputN)
        // {
        //     randN = rand.Next(1, 1001);
        //     numOfTries++;
        // }
        //
        // Console.WriteLine($"A szám kitalálásához {numOfTries} próba kellett.");
        //
        // Console.ReadLine();

        #endregion

        #region 4. feladat

        // Console.Clear();
        // Console.WriteLine("4. feladat");
        //
        // Console.Write("Játékosok száma: ");
        // int inputNumOfPlayers = int.Parse(Console.ReadLine()!);
        // int[] rolls = new int[inputNumOfPlayers];
        // int idx = 0;
        //
        // while (Array.IndexOf(rolls, 6) == -1)
        // {
        //     Console.WriteLine("Nyomd le az Entert a dobáshoz!");
        //     Console.ReadLine();
        //
        //     if (idx == inputNumOfPlayers)
        //     {
        //         idx = 0;
        //         Console.Clear();
        //     }
        //
        //     rolls[idx] = rand.Next(1, 7);
        //     Console.Write($"[# {idx + 1} játékos] Dobása: {rolls[idx]}");
        //     Console.WriteLine();
        //
        //     idx++;
        // }
        //
        // Console.WriteLine($"A(z) {Array.IndexOf(rolls, 6) + 1}. játékos kezdi a játékot.");
        // Console.ReadLine();

        #endregion

        #region 5. feladat

        // Console.Clear();
        // Console.WriteLine("5. feladat");
        //
        // int numToGuess = 908;
        // int numOfGuesses = 0;
        // int inputGuess = 0;
        //
        // while (inputGuess != numToGuess)
        // {
        //     numOfGuesses++;
        //
        //     Console.Write("Adj meg egy számot: ");
        //     inputGuess = int.Parse(Console.ReadLine()!);
        //
        //     if (numToGuess < inputGuess)
        //         Console.WriteLine("A gondolt szám kisebb, mint amit megadtál.");
        //     else if (numToGuess > inputGuess)
        //         Console.WriteLine("A gondolt szám nagyobb, mint amit megadtál.");
        // }
        //
        // Console.WriteLine($"Sikeresen eltaláltad! Mindössze {numOfGuesses} próbába telt.");
        // Console.ReadLine();

        #endregion

        #region 6. feladat

        // Console.Clear();
        // Console.WriteLine("6. feladat");
        //
        // Console.Write("Kéregy egy pozitív egész számot: ");
        // int inputPosN = int.Parse(Console.ReadLine()!);
        //
        // bool isEven = inputPosN % 2 == 0;
        // int numOfDividers = 0;
        //
        // for (int i = 2; i < inputPosN; i++)
        // {
        //     if (inputPosN % i == 0)
        //         numOfDividers++;
        // }
        //
        // bool isPrime = numOfDividers == 0;
        //
        // Console.WriteLine(isEven ? "A megadott szám páros." : "A megadott szám páratlan.");
        // Console.WriteLine($"A megadótt szám pozitív osztóinak száma: {numOfDividers}");
        // Console.WriteLine(isPrime ? "A megadott szám prímszám." : "A megadott szám összetett.");
        //
        // Console.ReadLine();

        #endregion

        #region 7. feladat

        // Console.Clear();
        // Console.WriteLine("7. feladat");
        //
        // Console.Write("Kérek egy pozitív egész számot: ");
        // int inputFactorialBase = int.Parse(Console.ReadLine()!);
        //
        // int factorial = 1;
        // string factorialText = String.Empty;
        //
        // for (int i = inputFactorialBase; i >= 1; i--)
        // {
        //     factorial *= i;
        //     factorialText += $"{i}{(i > 1 ? "*" : "")}";
        // }
        //
        // Console.WriteLine($"{inputFactorialBase}! = {factorialText} = {factorial}");
        // Console.ReadLine();

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
    }
}
