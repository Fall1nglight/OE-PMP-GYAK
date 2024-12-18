namespace ProgramozasiTetelek;

public class Megszamlalas
{
    public void RunExample()
    {
        Console.WriteLine("4. tétel - Megszámlálás");
        ElsoPelda();

        Console.WriteLine();
    }

    // (2.9)
    private void ElsoPelda()
    {
        int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int db = 0;

        for (int i = 0; i < x.Length; i++)
        {
            if (ParosSzam(x[i]))
                db++;
        }

        Console.WriteLine($"A tömbben {db} darab páros szám van.");
    }

    // P logikai függvény
    private bool ParosSzam(int szam) => szam % 2 == 0;
}
