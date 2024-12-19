namespace ProgramozasiTetelek;

public class Masolas
{
    public void RunExample()
    {
        Console.WriteLine("6. tétel - Másolás");

        ElsoPelda();

        Console.WriteLine();
    }

    // (2.11)
    private void ElsoPelda()
    {
        int[] x = { -2, 3, -1, 0 };
        int[] y = new int[x.Length];

        for (int i = 0; i < x.Length; i++)
        {
            y[i] = Math.Abs(x[i]);
        }

        Console.WriteLine($"Eredeti tömb elemei: {string.Join(", ", x)}");
        Console.WriteLine($"Másolt tömb elemei: {string.Join(", ", y)}");
    }
}
