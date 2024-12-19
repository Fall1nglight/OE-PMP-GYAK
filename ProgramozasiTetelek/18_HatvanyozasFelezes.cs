namespace ProgramozasiTetelek;

public class HatvanyozasFelezes
{
    public void RunExample()
    {
        Console.WriteLine("18. tétel - a^N felezéses elvű rekurzív meghatározása");

        ElsoPelda();

        Console.WriteLine();
    }

    // (4.8)
    private void ElsoPelda()
    {
        Console.WriteLine($"2^10 = {HatvanyFelezo(2, 10)}");
    }

    private int HatvanyFelezo(int alap, int n)
    {
        if (n == 1)
            return alap;

        if (n % 2 == 0)
        {
            int seged = HatvanyFelezo(alap, n / 2);
            return seged * seged;
        }
        else
        {
            int seged = HatvanyFelezo(alap, (n - 1) / 2);
            return alap * seged * seged;
        }
    }
}
