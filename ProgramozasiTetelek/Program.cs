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

        // 11. tétel - Szétválogatás egyetlen új tömbbe
        SzetvalogatasEgyTombbe szetvalogatasEgyTombbe = new SzetvalogatasEgyTombbe();
        szetvalogatasEgyTombbe.RunExample();

        // 12. tétel - Minimumkiválasztásos rendezés
        MinimumkivalasztasosRendezes minimumkivalasztasosRendezes =
            new MinimumkivalasztasosRendezes();

        minimumkivalasztasosRendezes.RunExample();

        // 13. tétel - Buborékrendezés és javítása
        BuborekRendezesEsJavitasa buborekRendezesEsJavitasa = new BuborekRendezesEsJavitasa();
        buborekRendezesEsJavitasa.RunExample();

        // 14. tétel - Beillesztéses rendezés és javítása
        BeillesztesesRendezesEsJavitasa beillesztesesRendezesEsJavitasa =
            new BeillesztesesRendezesEsJavitasa();

        beillesztesesRendezesEsJavitasa.RunExample();

        // 15. tétel - Faktoriális iteratív és rekurzív kiszámítása
        Faktorialis faktorialis = new Faktorialis();
        faktorialis.RunExample();

        // 16. tétel - Fibonacci sorozat N-edik elemének rekurzív és iteratív meghatározása
        Fibonacci fibonacci = new Fibonacci();
        fibonacci.RunExample();

        // 17. tétel - a^N rekurzív meghatározása lineáris futásidővel
        Hatvanyozas hatvanyozas = new Hatvanyozas();
        hatvanyozas.RunExample();

        // 18. tétel - a^N felezéses elvű rekurzív meghatározása
        HatvanyozasFelezes hatvanyozasFelezes = new HatvanyozasFelezes();
        hatvanyozasFelezes.RunExample();
    }
}
