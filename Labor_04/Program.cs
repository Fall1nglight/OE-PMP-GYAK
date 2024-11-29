namespace Labor_04;

internal class Program
{
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
            if (Char.IsLetter(c))
                count[0]++;

            // számjegyek száma
            if (Char.IsDigit(c))
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

        bool isPalindrome = String.CompareOrdinal(testInputTwo, reversedInputTwo) == 0;

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
            string tmp = plate.Replace(" ", String.Empty).Replace("-", String.Empty);
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
            Random rand = new Random();
            string result = string.Empty;

            for (int i = 0; i < 4; i++)
                result += Char.ToUpper((char)rand.Next('a', 'z' + 1));

            result += rand.Next(100, 1000);

            return result.Insert(2, " ").Insert(5, "-");
        }

        for (int i = 0; i < 50; i++)
            Console.WriteLine(GeneratePlate());

        Console.ReadLine();

        #endregion

        #region 5. feladat

        // todo

        #endregion

        #region 6. feladat

        Console.Clear();
        Console.WriteLine("6. feladat");

        Console.ReadLine();

        #endregion
    }
}
