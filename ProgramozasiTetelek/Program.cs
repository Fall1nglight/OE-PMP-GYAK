namespace ProgramozasiTetelek;

internal class Program
{
    public static void Main(string[] args)
    {
        // 1. tétel - Sorozatszámítás
        Sorozatszamitas sorozatszamitas = new Sorozatszamitas();
        sorozatszamitas.RunExample();

        // 2. tétel - Eldöntés
        Eldontes eldontes = new Eldontes();
        eldontes.RunExample();

        // 3. télel - Lineáris keresés
        LinearisKereses linearisKereses = new LinearisKereses();
        linearisKereses.RunExample();

        // 4. tétel - Megszámlálás
        Megszamlalas megszamlalas = new Megszamlalas();
        megszamlalas.RunExample();

        // 5. tétel - Maximumkiválasztás
        Maximumkivalasztas maximumkivalasztas = new Maximumkivalasztas();
        maximumkivalasztas.RunExample();

        // 6. tétel - Másolás
        Masolas masolas = new Masolas();
        masolas.RunExample();

        // 7. tétel - Kiválogatás
        Kivalogatas kivalogatas = new Kivalogatas();
        kivalogatas.RunExample();

        // 8. tétel - Kiválogatás az eredeti tömbben (helyben)
        KivalogatasHelyben kivalogatasHelyben = new KivalogatasHelyben();
        kivalogatasHelyben.RunExample();

        // 9. tétel - Kiválogatás az eredeti tömbben az eredeti elemek megtartásával
        KivalogatasHelybenElemekMegtartasaval kivalogatasHelybenElemekMegtartasaval =
            new KivalogatasHelybenElemekMegtartasaval();

        kivalogatasHelybenElemekMegtartasaval.RunExample();

        // 10. tétel - Szétválogatás
        Szetvalogatas szetvalogatas = new Szetvalogatas();
        szetvalogatas.RunExample();
    }
}
