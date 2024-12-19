namespace ProgramozasiTetelek;

public class Fibonacci
{
    public void RunExample()
    {
        Console.WriteLine(
            "16. tétel - Fibonacci sorozat N-edik elemének rekurzív és iteratív meghatározása"
        );

        ElsoPelda();
        MasodikPelda();

        Console.WriteLine();
    }

    // (4.4)
    private void ElsoPelda()
    {
        Console.WriteLine($"Fibonacci 7. eleme (iteratívan) = {FibonacciIterativ(7)}");
    }

    // (4.3)
    private void MasodikPelda()
    {
        Console.WriteLine($"Fibonacci 7. eleme (rekurzívan) = {FibonacciRekurziv(7)}");
    }

    private int FibonacciIterativ(int n)
    {
        int aktualis = 1;
        int elozo = 1;

        for (int i = 0; i < n - 1; i++)
        {
            int atmeneti = aktualis + elozo;
            elozo = aktualis;
            aktualis = atmeneti;
        }

        return aktualis;
    }

    private int FibonacciRekurziv(int n)
    {
        if (n == 0 || n == 1)
            return 1;

        return FibonacciRekurziv(n - 2) + FibonacciRekurziv(n - 1);
    }
}
