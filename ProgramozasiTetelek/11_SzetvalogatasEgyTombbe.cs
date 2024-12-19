namespace ProgramozasiTetelek;

public class SzetvalogatasEgyTombbe
{
    public void RunExample()
    {
        Console.WriteLine("11. tétel");

        ElsoPelda();

        Console.WriteLine();
    }

    // (2.16)
    private void ElsoPelda()
    {
        int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        int[] y = new int[x.Length];
        int db = 0;
        int jobb = x.Length - 1;

        for (int i = 0; i < x.Length; i++)
        {
            if (ParosSzam(x[i]))
            {
                y[db] = x[i];
                db++;
            }
            else
            {
                y[jobb] = x[i];
                jobb--;
            }
        }

        Console.WriteLine($"Eredeti tömb: {string.Join(", ", x)}");
        Console.WriteLine($"Szétválogatott tömb: {string.Join(", ", y)}");
        Console.WriteLine($"Páros számok ({db} db): 0 és {db} index között találhatóak.");
        Console.WriteLine(
            $"Páratlak számok ({x.Length - db} db): {db} és {x.Length} index között találhatóak."
        );
    }

    // P logikai függvény
    private bool ParosSzam(int szam) => szam % 2 == 0;
}
