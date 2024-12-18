namespace ProgramozasiTetelek;

public class KivalogatasHelyben
{
    public void RunExample()
    {
        Console.WriteLine("8. tétel - Kiválogatás az eredeti tömbbe (helyben)");
        ElsoPelda();

        Console.WriteLine('\n');
    }

    private void ElsoPelda()
    {
        int[] x = { 4, 1, 3, 8, 2, 7 };

        Console.WriteLine($"Eredeti tömb: {string.Join(", ", x)}");
        Algoritmus(ref x);
    }

    // (2.13)
    private void Algoritmus(ref int[] x)
    {
        int db = 0;

        for (int i = 0; i < x.Length; i++)
        {
            if (ParosSzam(x[i]))
            {
                x[db] = x[i];
                db++;
            }
        }

        if (db > 0)
        {
            Console.WriteLine($"Módosított tömb: {string.Join(", ", x)}");
            Console.WriteLine(
                $"Az x tömbben {db} darab P tulajdonságú elemet válogattunk ki helyben."
            );
        }
        else
        {
            Console.WriteLine("Az x tömbben nem volt P tulajdonságú elem.");
        }
    }

    // P logikai függvény
    private bool ParosSzam(int szam) => szam % 2 == 0;
}
