using Minta_ZH_4.Enums;

namespace Minta_ZH_4;

internal class Program
{
    public static void Main(string[] args)
    {
        // a, feladat
        CarFleet cf = new CarFleet(10);
        cf.Load("ecars.txt");

        // b, feladat
        bool hasBrandNewCar = cf.HasBrandNew();
        Console.WriteLine($"A flottában {(hasBrandNewCar ? "van" : "nincs")} 0 km-es autó.");

        // c, feladat
        ECar highestRangeCar = cf.GetMaxRangeCar();
        Console.WriteLine(highestRangeCar);

        // d, feladat
        cf.Visualize();
    }
}
