namespace ProgramozasiTetelek;

public class Szetvalogatas
{
    public void RunExample()
    {
        Console.WriteLine("10. tétel - Szétválogatás");
        ElsoPelda();

        Console.WriteLine();
    }

    private void ElsoPelda()
    {
        int[] x = { 4, 1, 3, 8, 2, 7 };
        int[] y1 = new int[x.Length];
        int[] y2 = new int[x.Length];
        int db1 = 0;
        int db2 = 0;

        for (int i = 0; i < x.Length; i++)
        {
            if (ParosSzam(x[i]))
            {
                y1[db1] = x[i];
                db1++;
            }
            else
            {
                y2[db2] = x[i];
                db2++;
            }
        }

        Console.WriteLine($"Eredeti tömb: {string.Join(", ", x)}");
        Console.Write($"Az y1 tömb elemei (páros számok - {db1} db): ");

        for (int i = 0; i < db1; i++)
            Console.Write($"{y1[i]} ");

        Console.WriteLine();

        Console.Write($"Az y2 tömb elemei (páros számok - {db2} db): ");

        for (int i = 0; i < db2; i++)
            Console.Write($"{y2[i]} ");
    }

    // P logikai függvény
    private bool ParosSzam(int szam) => szam % 2 == 0;
}
