namespace ProgramozasiTetelek;

public class MinimumkivalasztasosRendezes
{
    public void RunExample()
    {
        Console.WriteLine("12. tétel - Minimumkiválasztásos rendezés");

        ElsoPelda();

        Console.WriteLine();
    }

    // (3.3)
    private void ElsoPelda()
    {
        int[] x = { 4, 3, 7, 6, 1 };

        Console.WriteLine($"Eredeti tömb: {string.Join(", ", x)}");

        Algoritmus(ref x);

        Console.WriteLine($"Rendezett tömb: {string.Join(", ", x)}");
    }

    private void Algoritmus(ref int[] x)
    {
        for (int i = 0; i < x.Length - 1; i++)
        {
            int min = i;

            for (int j = i + 1; j < x.Length; j++)
            {
                if (x[min] > x[j])
                {
                    min = j;
                }
            }

            int seged = x[i];
            x[i] = x[min];
            x[min] = seged;
        }
    }
}
