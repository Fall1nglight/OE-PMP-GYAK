namespace ProgramozasiTetelek;

public class Eldontes
{
    public void RunExample()
    {
        Console.WriteLine("2. tétel - Eldöntés");

        ElsoPelda();
        MasodikPelda();
        HarmadikPelda();

        Console.WriteLine();
    }

    // 1. példa - Eldontes (2.2)
    private void ElsoPelda()
    {
        int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int i = 0;

        while (i < x.Length && !ParosSzam(x[i]))
            i++;

        bool van = i < x.Length;

        Console.WriteLine($"Van páros szám a tömbben? {van}");
    }

    // 2. példa - EldontesMinden (2.3)
    private void MasodikPelda()
    {
        int[] x = { 2, 2, 2, 2, 2, 6, 2, 8, 2, 10 };
        int i = 0;

        while (i < x.Length && ParosSzam(x[i]))
            i++;

        bool van = i == x.Length;

        Console.WriteLine($"Össze szám páros a tömbben? {van}");
    }

    // 3. példa - Rendezett-e (2.5)
    private void HarmadikPelda()
    {
        int[] x = { 1, 3, 6, 15, 50, 51 };
        int i = 0;

        while (i < x.Length - 1 && x[i] < x[i + 1])
            i++;

        bool rendezett = i == x.Length - 1;

        Console.WriteLine($"A tömb elemei növekvő sorrendbe vannak? {rendezett}");
    }

    // P logikai függvény
    private bool ParosSzam(int szam) => szam % 2 == 0;
}
