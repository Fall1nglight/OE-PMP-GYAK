namespace ProgramozasiTetelek;

public class Kivalogatas
{
    public void RunExample()
    {
        Console.WriteLine("7. tétel - Kiválogatás");
        ElsoPelda();

        Console.WriteLine('\n');
    }

    // (2.12)
    private void ElsoPelda()
    {
        int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        int[] y = new int[x.Length];
        int db = 0;

        for (int i = 0; i < x.Length; i++)
        {
            if (ParosSzam(x[i]))
            {
                y[db] = x[i];
                db++;
            }
        }

        if (db > 0)
        {
            Console.WriteLine(
                $"Az x tömbből {db} darab P tulajdonságú elemet válogattunk ki y tömbbe."
            );

            Console.Write($"Kiválogatott elemek: ");

            for (int i = 0; i < db; i++)
                Console.Write($"{y[i]} ");
        }
        else
        {
            Console.WriteLine("Az x tömbben nem volt P tulajdonságú elem.");
        }
    }

    // P logikai függvény
    private bool ParosSzam(int szam) => szam % 2 == 0;
}
