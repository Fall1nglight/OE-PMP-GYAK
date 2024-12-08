namespace Labor_04;

internal class Program
{
    // változók
    static Random _rand = new Random();

    public static void Main(string[] args)
    {
        #region 1. feladat

        Console.WriteLine("1. feladat");
        char[] vowels = new char[]
        {
            'a',
            'á',
            'e',
            'é',
            'i',
            'í',
            'o',
            'ó',
            'ö',
            'ő',
            'u',
            'ú',
            'ü',
            'ű',
        };

        int[] count = new int[3];

        string testInputOne =
            "Írjunk programot, amely meghatározza egy szövegben a betűk, a számjegyek és a magánhangzók számát kategóriánként.";

        foreach (char c in testInputOne)
        {
            // betűk száma
            if (char.IsLetter(c))
                count[0]++;

            // számjegyek száma
            if (char.IsDigit(c))
                count[1]++;

            // magánhangzók száma
            if (Array.IndexOf(vowels, c) != -1)
                count[2]++;
        }

        Console.WriteLine($"Bemenet: {testInputOne}");
        Console.WriteLine($"Betűk száma: {count[0]} db");
        Console.WriteLine($"Számjegyek száma: {count[1]} db");
        Console.WriteLine($"Magánhangzók száma: {count[2]} db");
        Console.ReadLine();

        #endregion

        #region 2. feladat

        Console.Clear();
        Console.WriteLine($"2. feladat");

        char[] toRemove = new char[] { ' ', '.', ',', '!', '?' };
        string testInputTwo = "Géza, kék az ég.";
        testInputTwo = testInputTwo.ToLower();

        foreach (char c in toRemove)
            if (testInputTwo.IndexOf(c) != -1)
                testInputTwo = testInputTwo.Replace(c.ToString(), string.Empty);

        char[] rvArr = testInputTwo.ToCharArray();
        Array.Reverse(rvArr);
        string reversedInputTwo = new string(rvArr);

        bool isPalindrome = string.CompareOrdinal(testInputTwo, reversedInputTwo) == 0;

        Console.WriteLine(
            isPalindrome ? "A szöveg palindróm volt." : "A szöveg nem volt palindróm."
        );
        Console.ReadLine();

        #endregion

        #region 3. feladat

        Console.Clear();
        Console.WriteLine("3. feladat");

        List<string> cases = new List<string>
        {
            "aabc 123",
            "a a BC123",
            "a a B c 1 2 3",
            "AABc-123",
        };

        foreach (string plate in cases)
        {
            string tmp = plate.Replace(" ", string.Empty).Replace("-", string.Empty);
            string letters = tmp.Substring(0, 4).Insert(2, " ").ToUpper();
            string numbers = tmp.Substring(4, 3);
            string formattedPlate = $"{letters}-{numbers}";
            Console.WriteLine(formattedPlate);
        }

        Console.ReadLine();

        #endregion

        #region 4. feladat

        Console.Clear();
        Console.WriteLine("4. feladat");

        static string GeneratePlate()
        {
            string result = string.Empty;

            for (int i = 0; i < 4; i++)
                result += char.ToUpper((char)_rand.Next('a', 'z' + 1));

            result += _rand.Next(100, 1000);

            return result.Insert(2, " ").Insert(5, "-");
        }

        Console.WriteLine(GeneratePlate());
        Console.ReadLine();

        #endregion

        #region 5. feladat

        // todo

        #endregion

        #region 6. feladat

        Console.Clear();
        Console.WriteLine("6. feladat");

        Console.WriteLine($"Véletlenszerűen generált Neptunk-kód: {GenerateNeptunKey()}");

        static string GenerateNeptunKey()
        {
            string result = string.Empty;

            while (result.Length != 6)
            {
                result += GenerateCharOrDigit();

                if (!char.IsLetter(result[0]))
                    result = string.Empty;
            }

            return result.ToUpper();
        }

        // 0-9 és a-z-ig ad vissza karaktert
        static char GenerateCharOrDigit()
        {
            if (_rand.Next(2) == 0)
                return (char)_rand.Next('0', '9' + 1);

            return (char)_rand.Next('a', 'z' + 1);
        }

        Console.ReadLine();

        #endregion

        #region 7. feladat
        Console.Clear();
        Console.WriteLine("7. feladat");

        string spongeCaseInput = "Well, a Big Mac's a Big Mac, but they call it le Big-Mac.";

        Console.WriteLine(spongeCaseInput);
        Console.WriteLine(FormatToSpongeCase(spongeCaseInput));

        static string FormatToSpongeCase(string input)
        {
            string result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                result += ((i + 1) % 2 != 0) ? char.ToUpper(input[i]) : char.ToLower(input[i]);
            }

            return result;
        }

        Console.ReadLine();

        #endregion

        #region 8. feladat
        Console.Clear();
        Console.WriteLine("8. feladat");

        string strToMatrixInput =
            "Vincent;Vega;Vince\nMarsellus;Wallace;Big Man\nWinston;Wolf;The Wolf";

        string[,] strToMatrixOutput = StrToMatrix(strToMatrixInput);

        for (var i = 0; i < strToMatrixOutput.GetLength(0); i++)
        {
            for (var j = 0; j < strToMatrixOutput.GetLength(1); j++)
            {
                Console.Write(strToMatrixOutput[i, j] + " ");
            }

            Console.WriteLine();
        }

        static string[,] StrToMatrix(string input)
        {
            int numOfRows = 0;
            string[] lines = input.Split('\n');

            for (int i = 0; i < lines.Length; i++)
            {
                string[] rows = lines[i].Split(';');

                if (rows.Length > numOfRows)
                    numOfRows = rows.Length;
            }

            string[,] result = new string[lines.Length, numOfRows];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] rows = lines[i].Split(';');

                for (int j = 0; j < rows.Length; j++)
                {
                    result[i, j] = rows[j];
                }
            }

            return result;
        }

        Console.ReadLine();

        #endregion
    }
}
