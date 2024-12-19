namespace ProgramozasiTetelek;

public class BuborekRendezesEsJavitasa
{
    public void RunExample()
    {
        Console.WriteLine("13. tétel - Buborékrendezés és javítása");

        ElsoPelda();
        MasodikPelda();

        Console.WriteLine();
    }

    // (3.4)
    private void ElsoPelda()
    {
        int[] x = { 11, 5, 2, 9, 3, 7, 0 };

        Console.WriteLine("Eredeti algoritmus:");
        Console.WriteLine($"Eredeti tömb: {string.Join(",", x)}");

        BuborekRendezes(ref x);

        Console.WriteLine($"Rendezett tömb: {string.Join(",", x)}");
    }

    // (3.5)
    private void MasodikPelda()
    {
        Console.WriteLine("\nJavított algoritmus:");

        int[] x = { 11, 5, 2, 9, 3, 7, 0 };

        Console.WriteLine($"Eredeti tömb: {string.Join(",", x)}");

        BuborekRendezesJavitott(ref x);

        Console.WriteLine($"Rendezett tömb: {string.Join(",", x)}");
    }

    private void BuborekRendezes(ref int[] x)
    {
        for (int i = x.Length - 1; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (x[j] > x[j + 1])
                {
                    int seged = x[j];
                    x[j] = x[j + 1];
                    x[j + 1] = seged;
                }
            }
        }
    }

    private void BuborekRendezesJavitott(ref int[] x)
    {
        int i = x.Length - 1;

        while (i >= 1)
        {
            int idx = 0;

            for (int j = 0; j < i; j++)
            {
                if (x[j] > x[j + 1])
                {
                    int seged = x[j];
                    x[j] = x[j + 1];
                    x[j + 1] = seged;
                    idx = j;
                }
            }
            i = idx;
        }
    }
}
