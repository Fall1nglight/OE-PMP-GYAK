namespace Labor_03;

internal class Program
{
    public static void Main(string[] args)
    {
        #region 1. feladat

        string[] suits = new string[] { "Kőr", "Káró", "Treff", "Pikk" };
        string[] ranks = new string[]
        {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Jumbó",
            "Dáma",
            "Király",
            "Ász",
        };
        string[] cards = new string[suits.Length * ranks.Length];

        for (int i = 0; i < suits.Length; i++)
        {
            for (int j = 0; j < ranks.Length; j++)
            {
                int idx = i * ranks.Length + j;
                cards[idx] = $"{suits[i]} {ranks[j]}";
            }
        }

        #endregion


        #region 2. feladat

        static void SortCards(ref string[] deck)
        {
            Random rand = new Random();
            for (int i = 0; i < deck.Length; i++)
            {
                int j = rand.Next(i, deck.Length);
                (deck[i], deck[j]) = (deck[j], deck[i]);
            }
        }
        SortCards(ref cards);

        #endregion

        #region 3. feladat

        int numOfWords = 2;
        string[] words = new string[2];

        for (int i = 0; i < numOfWords; i++)
        {
            Console.Write($"{i + 1}. szó: ");
            words[i] = Console.ReadLine()!;
        }

        Console.Write("Keresett szó: ");
        string inputWord = Console.ReadLine()!;

        int idxOfWord = Array.IndexOf(words, inputWord);

        Console.WriteLine(
            $"A keresett szó {(idxOfWord == -1 ? "nem szerepel" : "szerepel")} a tömbben."
        );

        if (idxOfWord != -1)
            Console.WriteLine($"A keresett szó előszőr a(z) {idxOfWord}. indexen található.");

        #endregion

        #region 4. feladat

        List<string> words2 = new List<string>();
        string inputWord2 = string.Empty;

        while (String.CompareOrdinal(inputWord2, "STOP") != 0)
        {
            Console.Write("Adj hozzá egy szót a listához: ");
            inputWord2 = Console.ReadLine()!;
            words2.Add(inputWord2);
        }

        Console.Write("Keresett szó: ");
        inputWord2 = Console.ReadLine()!;

        Console.WriteLine(
            $"A keresett szó {(words2.Contains(inputWord2) ? "szerepel" : "nem szerepel")} a listában."
        );

        if (words2.Contains(inputWord2))
            Console.WriteLine(
                $"A keresett szó előszőr a(z) {words2.IndexOf(inputWord2)}. indexen található."
            );

        Console.WriteLine();

        #endregion

        #region 5. feladat

        List<string> names = new List<string>();
        List<int> ages = new List<int>();
        List<bool> experiences = new List<bool>();

        string inputName;

        do
        {
            Console.Write("Név: ");
            inputName = Console.ReadLine()!;

            if (String.IsNullOrEmpty(inputName))
                break;

            Console.Write("Életkor: ");
            int inputAge = int.Parse(Console.ReadLine()!);

            Console.Write("Tapasztalat [y/n]: ");
            bool experience = Console.ReadKey().KeyChar == 'y';

            Console.WriteLine();

            names.Add(inputName);
            ages.Add(inputAge);
            experiences.Add(experience);
        } while (!String.IsNullOrEmpty(inputName));

        // Mi az átlagéletkor a teljes adathalmazban?
        int sumAge = 0;

        foreach (int age in ages)
            sumAge += age;

        double avgAge = (double)sumAge / ages.Count;
        double roundedAvgAge = Math.Round(avgAge, 2);

        Console.WriteLine($"Átlagos életkor: {roundedAvgAge}");

        // Mi az átlagéletkor a programozói tapasztalat nélküli személyek között?
        int sumUnprofAge = 0;
        int countUnprof = 0;

        for (int i = 0; i < experiences.Count; i++)
        {
            if (experiences[i])
                continue;

            countUnprof++;
            sumUnprofAge += ages[i];
        }

        double avgUnprofAge = (double)sumUnprofAge / countUnprof;
        double roundedAvgUnprofAge = Math.Round(avgUnprofAge, 2);

        Console.WriteLine($"Tapasztalat nélküli átlag életkor: {roundedAvgUnprofAge}");

        // Hány éves a legidősebb, programozó tapasztalattal rendelkező személy és mi a neve?
        int max = ages[0];
        int maxIdx = 0;

        for (int i = 1; i < ages.Count; i++)
        {
            if (ages[i] > max && experiences[i])
            {
                max = ages[i];
                maxIdx = i;
            }
        }

        Console.WriteLine(
            $"A legidősebb tapasztalt programozó neve: {names[maxIdx]}, életkor: {max}"
        );

        #endregion

        #region 6. feladat

        int n = 3;
        int m = 3;
        int[,] matrix = new int[n, m];
        Random rand = new Random();

        // feltöltés véletlen számokkal
        // és kiiratás
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = rand.Next(10);
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        // transzponálás
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < m; j++)
            {
                (matrix[i, j], matrix[j, i]) = (matrix[j, i], matrix[i, j]);
            }
        }

        // kiiratás
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();

        #endregion

        #region 7. feladat

        int s = 5;
        int t = 5;
        int[,] result = new int[s, t];

        // 3. feladat
        int[] types = new int[t];

        // 4. feladat
        int maxCatch = 0;
        int maxCatchIdx = 0;

        // 5. feladat
        bool isNullCatchPresent = false;

        for (int i = 0; i < s; i++)
        {
            int tempMax = 0;

            for (int j = 0; j < t; j++)
            {
                result[i, j] = rand.Next(10);
                Console.Write($"{result[i, j]} ");
                types[j] += result[i, j];
                tempMax += result[i, j];
            }

            Console.WriteLine();

            if (tempMax == 0)
                isNullCatchPresent = true;

            if (tempMax <= maxCatch)
                continue;

            maxCatch = tempMax;
            maxCatchIdx = i;
        }

        for (int i = 0; i < types.Length; i++)
        {
            Console.WriteLine($"faj: {i} - {types[i]}db");
        }

        Console.WriteLine();

        Console.WriteLine(
            $"A legtöbb halat a(z) {maxCatchIdx + 1}. versenyző fogta, összesen: {max}db."
        );

        Console.WriteLine(
            $"{(isNullCatchPresent ? "Volt" : "Nem volt")} olyan horgász, aki egy halat se fogott."
        );

        #endregion

        #region 8. feladat

        int inputListItem = 30;
        List<int> list = new List<int>();
        list.Add(inputListItem);
        int k = list[^1];

        int tries = 0;

        while (k != 1)
        {
            if (k % 2 == 0)
            {
                list.Add(k / 2);
            }
            else
            {
                list.Add(3 * k + 1);
            }

            k = list[^1];
            tries++;
        }

        Console.WriteLine();
        Console.WriteLine($"Próbák száma: {tries} db");

        #endregion

        #region 9. feladat

        int[] x = { 1, 2, 3, 4, 5, 6, 7, 8 };

        for (int i = 0; i < x.Length / 2; i++)
        {
            int tmp = x[i];
            x[i] = x[x.Length - i - 1];
            x[^(i + 1)] = tmp;
        }

        Console.WriteLine();

        for (int i = 0; i < x.Length; i++)
        {
            Console.Write(x[i]);
        }

        Console.WriteLine();

        #endregion

        #region 10. feladat

        int randSize = rand.Next(35);
        int[] arr = new int[randSize];
        int[] firstArr = new int[randSize / 2];

        for (int i = 0; i < randSize; i++)
        {
            arr[i] = rand.Next(1, 10);

            // Válogassuk ki a gyűjtemény minden második elemét egy új gyűjteménybe.
            if ((i + 1) % 2 == 0)
                firstArr[i / 2] = arr[i];
        }

        // Fordítsuk meg a gyűjtemény elemeinek sorrendjét
        for (int i = 0; i < randSize / 2; i++)
            (arr[i], arr[^(i + 1)]) = (arr[^(i + 1)], arr[i]);

        // Rendezzük a lehető legkisebb négyzetes mátrixba a gyűjtemény elemeit
        int squareSize = (int)Math.Ceiling(Math.Sqrt(randSize));
        int[,] square = new int[squareSize, squareSize];

        for (int i = 0; i < squareSize; i++)
        {
            for (int j = 0; j < squareSize; j++)
            {
                int calcIdx = i * squareSize + j;

                if (calcIdx >= arr.Length)
                    continue;

                square[i, j] = arr[calcIdx];
            }
        }

        #endregion

        #region 11. feladat

        // lényegében ugyan az mint a előző feladat

        #endregion

        // todo | ezt befejezni
        #region 12. feladat

        int randRows = rand.Next(1, 11);
        int randCols = rand.Next(1, 11);
        bool[,] maze = new bool[randRows, randCols];

        // feltöltés véletlen igaz/hamis értékekkel
        for (int i = 0; i < randRows; i++)
        {
            for (int j = 0; j < randCols; j++)
            {
                maze[i, j] = rand.Next(2) != 0;
                Console.Write($"{(maze[i, j] ? "T" : "F")} ");
            }

            Console.WriteLine();
        }

        //
        int xCord = rand.Next(randRows);
        int yCord = rand.Next(randCols);

        maze[xCord, yCord] = true;
        maze[randRows - 1, randCols - 1] = true;

        for (int i = 0; i < randRows; i++)
        {
            for (int j = 0; j < randCols; j++) { }
        }

        #endregion
    }
}
