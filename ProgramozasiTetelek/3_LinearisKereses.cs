namespace ProgramozasiTetelek;

public class LinearisKereses
{
    public void RunExample()
    {
        Console.WriteLine("3. tétel - Lineáris keresés");

        ElsoPelda();
        MasodikPelda();

        Console.WriteLine();
    }

    // (2.7) Van-e páros száma a tömbben, ha igen hol az első ilyen szám?
    public void ElsoPelda()
    {
        int[] x = { 1, 1, 3, 1, 5, 6, 7, 8 };

        int i = 0;

        while (i < x.Length && !ParosSzam(x[i]))
            i++;

        bool van = i < x.Length;

        if (van)
            Console.WriteLine($"A tömbben az első páros szám ({x[i]}) a {i}. indexen található.");
        else
            Console.WriteLine("A tömbben nincsen páros szám.");
    }

    // (2.8) Konkrét érték keresése
    public void MasodikPelda()
    {
        int[] x = { 1, 5, 7, 5, 9, 4, 8 };
        int keresett = 8;

        int i = 0;

        while (i < x.Length && x[i] != keresett)
            i++;

        bool van = i < x.Length;

        if (van)
            Console.WriteLine($"A tömmben a keresett ({keresett}) érték a {i}. indexen található.");
        else
            Console.WriteLine($"A tömbben nem szerepel a keresett ({keresett}) érték.");
    }

    // P logikai függvény
    private bool ParosSzam(int szam) => szam % 2 == 0;
}
