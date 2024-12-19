namespace ProgramozasiTetelek;

public class KivalogatasHelybenElemekMegtartasaval
{
    public void RunExample()
    {
        Console.WriteLine(
            "9. tétel - Kiválogatás az eredeti tömbben az eredeti elemek megtartásával"
        );

        ElsoPelda();

        Console.WriteLine();
    }

    // (2.14)
    private void ElsoPelda()
    {
        int[] x = { 4, 1, 3, 8, 2, 7 };

        Console.WriteLine($"Eredeti tömb: {string.Join(", ", x)}");

        Algoritmus(ref x);
    }

    private void Algoritmus(ref int[] x)
    {
        int db = 0;

        for (int i = 0; i < x.Length; i++)
        {
            if (ParosSzam(x[i]))
            {
                int seged = x[i];
                x[i] = x[db];
                x[db] = seged;
                db++;
            }
        }

        if (db > 0)
        {
            Console.WriteLine($"Szétválogatott tömb: {string.Join(", ", x)}");

            Console.WriteLine(
                $"A tömbben 0 és {db} indexek között {db} darab P tulajdonságú elem van."
            );

            Console.WriteLine(
                $"A tömbben {db} és {x.Length} indexek között {x.Length - db} nem P tulajdonságú elem van."
            );
        }
    }

    // P logikai függvény
    private bool ParosSzam(int szam) => szam % 2 == 0;
}
