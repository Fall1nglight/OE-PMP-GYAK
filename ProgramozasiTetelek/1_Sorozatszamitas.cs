namespace ProgramozasiTetelek;

public class Sorozatszamitas
{
    public void RunExample()
    {
        Console.WriteLine("1. tétel - Sorozatszámítás");

        ElsoPelda();
        MasodikPelda();
        HarmadikPelda();

        Console.WriteLine();
    }

    // 1. példa - számok összeadása (2.1)
    private void ElsoPelda()
    {
        int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int ertek = 0;

        for (int i = 0; i < x.Length; i++)
        {
            ertek += x[i];
        }

        Console.WriteLine($"Kiszámított érték (összeadás): {ertek}");
    }

    // 2. példa - számok összeszorzása
    private void MasodikPelda()
    {
        int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int ertek = 1;

        for (int i = 0; i < x.Length; i++)
        {
            ertek *= x[i];
        }

        Console.WriteLine($"Kiszámított érték (összeszorzás): {ertek}");
    }

    // 3. példa - karakterláncok összefűzése
    private void HarmadikPelda()
    {
        string[] x = { "Ez", " ", "egy", " ", "példa", " ", "mondat", "." };
        string ertek = string.Empty;

        for (int i = 0; i < x.Length; i++)
        {
            ertek += x[i];
        }

        Console.WriteLine($"Kiszámított érték (összefűzés): {ertek}");
    }
}
