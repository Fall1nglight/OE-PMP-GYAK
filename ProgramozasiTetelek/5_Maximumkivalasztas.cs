namespace ProgramozasiTetelek;

public class Maximumkivalasztas
{
    public void RunExample()
    {
        Console.WriteLine("5. tétel - Maximumkiválasztás");
        ElsoPelda();

        Console.WriteLine();
    }

    // (2.10)
    private void ElsoPelda()
    {
        int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int max = 0;

        for (int i = 1; i < x.Length; i++)
        {
            if (x[i] > x[max])
                max = i;
        }

        Console.WriteLine($"A tömbben a legnagyobb elem ({x[max]}) a {max}. indexen található.");
    }
}
