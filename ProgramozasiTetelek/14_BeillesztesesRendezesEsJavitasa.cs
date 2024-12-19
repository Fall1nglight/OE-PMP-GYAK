namespace ProgramozasiTetelek;

public class BeillesztesesRendezesEsJavitasa
{
    public void RunExample()
    {
        Console.WriteLine("14. tétel - Beillesztéses rendezés és javítása");

        ElsoPelda();
        MasodikPelda();

        Console.WriteLine();
    }

    // (3.6)
    private void ElsoPelda()
    {
        int[] x = { 11, 1, 5, 2, 9, -1, 3, 7, 0 };

        Console.WriteLine("Eredeti algoritmus:");
        Console.WriteLine($"Eredeti tömb: {string.Join(",", x)}");

        BeillesztesesRendezes(ref x);

        Console.WriteLine($"Rendezett tömb: {string.Join(",", x)}");
    }

    // (3.7)
    private void MasodikPelda()
    {
        int[] x = { 11, 1, 5, 2, 9, -1, 3, 7, 0 };

        Console.WriteLine("Javított algoritmus:");
        Console.WriteLine($"Eredeti tömb: {string.Join(",", x)}");

        BeillesztesesRendezesJavitott(ref x);

        Console.WriteLine($"Rendezett tömb: {string.Join(",", x)}");
    }

    private void BeillesztesesRendezes(ref int[] x)
    {
        for (int i = 1; i < x.Length; i++)
        {
            int j = i - 1;

            while (j >= 0 && x[j] > x[j + 1])
            {
                int seged = x[j];
                x[j] = x[j + 1];
                x[j + 1] = seged;

                j--;
            }
        }
    }

    private void BeillesztesesRendezesJavitott(ref int[] x)
    {
        for (int i = 1; i < x.Length; i++)
        {
            int j = i - 1;
            int seged = x[i];

            while (j >= 0 && x[j] > seged)
            {
                x[j + 1] = x[j];
                j--;
            }

            x[j + 1] = seged;
        }
    }
}
