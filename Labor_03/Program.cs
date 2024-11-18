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
                int idx = i * 13 + j;
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
    }
}
