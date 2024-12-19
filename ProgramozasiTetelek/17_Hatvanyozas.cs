namespace ProgramozasiTetelek;

public class Hatvanyozas
{
    public void RunExample()
    {
        Console.WriteLine("17. tétel a^N rekurzív meghatározása lineáris futásidővel");

        ElsoPelda();

        Console.WriteLine();
    }

    // (4.7)
    private void ElsoPelda()
    {
        Console.WriteLine($"2^10 = {HatvanyozasRekurziv(2, 10)}");
    }

    private int HatvanyozasRekurziv(int alap, int n)
    {
        if (n == 1)
            return alap;

        return alap * HatvanyozasRekurziv(alap, n - 1);
    }
}
