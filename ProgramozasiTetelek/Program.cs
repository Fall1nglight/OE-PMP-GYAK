namespace ProgramozasiTetelek;

internal class Program
{
    public static void Main(string[] args)
    {
        // 1. tétel - Sorozatszámítás
        Sorozatszamitas sorozatszamitas = new Sorozatszamitas();
        sorozatszamitas.RunExample();

        Console.WriteLine();

        // 2. tétel - Eldöntés
        Eldontes eldontes = new Eldontes();
        eldontes.RunExample();
    }
}
