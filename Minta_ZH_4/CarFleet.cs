using Minta_ZH_4.Enums;

namespace Minta_ZH_4;

public class CarFleet
{
    // fields
    private List<ECar> _cars;
    private DateTime _createDate;
    private int _value;

    // constructors
    public CarFleet(int value)
    {
        _cars = new List<ECar>();
        _createDate = DateTime.Today;
        _value = value;
    }

    // methods
    public void Load(string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);

        for (int i = 1; i < lines.Length; i++)
        {
            _cars.Add(new ECar(lines[i]));
        }
    }

    public bool HasBrandNew()
    {
        int idx = 0;

        while (idx < _cars.Count && _cars[idx].Kms != 0)
            idx++;

        return idx < _cars.Count;
    }

    public int CountCarsByAge(int age)
    {
        int count = 0;

        for (int i = 0; i < _cars.Count; i++)
        {
            if (_cars[i].Age == age)
                count++;
        }

        return count;
    }

    public ECar GetMaxRangeCar()
    {
        int idx = 0;

        for (int i = 1; i < _cars.Count; i++)
        {
            if (_cars[i].Range > _cars[idx].Range)
                idx = i;
        }

        return _cars[idx];
    }

    public ECar FindFirstByColor(string color)
    {
        int idx = 0;

        for (int i = 1; i < _cars.Count; i++)
        {
            if (string.Compare(_cars[i].Color, color, StringComparison.Ordinal) == 0)
            {
                idx = i;
                break;
            }
        }

        return _cars[idx];
    }

    public void Visualize()
    {
        Dictionary<TeslaModel, int> dict = new Dictionary<TeslaModel, int>();
        int numOfCars = 0;

        for (int i = 0; i < _cars.Count; i++)
        {
            dict.TryGetValue(_cars[i].Model, out int count);
            dict[_cars[i].Model] = count + 1;
            numOfCars++;
        }

        int colorCode = 0;

        foreach (KeyValuePair<TeslaModel, int> kvp in dict)
        {
            Console.WriteLine($"{kvp.Key} - {kvp.Value} db");
            double percentage = (double)kvp.Value / numOfCars * 100;
            double roundedPercentage = Math.Round(percentage, 2);

            double widthPercentage = roundedPercentage / Console.WindowWidth * 100;
            int roundedWidthPercentage = (int)Math.Round(widthPercentage);

            for (int i = 0; i < roundedWidthPercentage; i++)
            {
                ConsoleColor color = (ConsoleColor)colorCode;

                // elkerüljük a fehér és fekete színeket
                while (color == ConsoleColor.White || color == ConsoleColor.Black)
                    color = (ConsoleColor)colorCode++;

                Console.BackgroundColor = (ConsoleColor)colorCode;
                Console.Write(' ');
                Console.ResetColor();
            }

            Console.WriteLine();

            colorCode++;
        }
    }
}
