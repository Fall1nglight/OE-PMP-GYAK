namespace ProgramozasiTetelek;

public class Faktorialis
{
    public void RunExample()
    {
        Console.WriteLine("15. tétel - Faktoriális iteratív és rekurzív kiszámítása");

        ElsoPelda();
        MasodikPelda();

        Console.WriteLine();
    }

    // (4.1)
    private void ElsoPelda()
    {
        Console.WriteLine($"10! (iteratívan) = {FaktorialisIterativ(10)}");
    }

    // (4.2)
    private void MasodikPelda()
    {
        Console.WriteLine($"6! (rekurzívan) = {FaktorialisRekurziv(6)}");
    }

    private int FaktorialisIterativ(int n)
    {
        int ertek = 1;

        for (int i = 2; i <= n; i++)
        {
            ertek *= i;
        }

        return ertek;
    }

    private int FaktorialisRekurziv(int n)
    {
        if (n == 0)
            return 1;

        return n * FaktorialisRekurziv(n - 1);
    }
}
