namespace Labor_01;

 internal class Program
{
    public static void Main(string[] args)
    {
        #region 1. feladat

        Console.WriteLine("1. feladat");
        Console.WriteLine("Hello, World!");
        Console.ReadLine();

        #endregion

        #region 2. feladat

        Console.Clear();
        Console.WriteLine("2. feladat");
        
        Console.BackgroundColor = ConsoleColor.DarkGray;
        
        Console.WriteLine("Hello, World!");
        Console.ResetColor();
        Console.ReadLine();

        #endregion

        #region 3. feladat
        
        Console.Clear();
        Console.WriteLine("3. feladat");
        
        Console.Write("Add meg a neved: ");
        
        string inputName = Console.ReadLine()!;

        Console.WriteLine($"Üdv, {inputName}!");
        Console.ReadLine();
        
        #endregion

        #region 4. feladat

        Console.Clear();
        Console.WriteLine("4. feladat");

        Console.Write("Add meg a születési éved: ");
        
        int inputBirthYear = int.Parse(Console.ReadLine()!);
        int age = DateTime.Now.Year - inputBirthYear;

        Console.WriteLine($"Korod: {age}, egy év múlva: {age+1}.");
        Console.ReadLine();

        #endregion

        #region 5. feladat

        Console.Clear();
        Console.WriteLine("5. feladat");

        Console.Write("Add meg a magasságod (méterben): ");
        double inputHeight = double.Parse(Console.ReadLine()!);
        
        Console.Write("Add meg a testtömeged (kilógrammban): ");
        double inputWeight = double.Parse(Console.ReadLine()!);

        double bmi = (double)inputWeight / Math.Pow(inputHeight, 2);

        Console.WriteLine($"A kiszámított BMI értéke: {bmi}");
        Console.ReadLine();

        #endregion

        #region 6. feladat

        Console.Clear();
        Console.WriteLine("6. feladat");
        
        Console.Write("Adj meg egy időtartamot (másodpercben): ");
        int inputSeconds = int.Parse(Console.ReadLine()!);

        int minutes = inputSeconds / 60;
        int seconds = inputSeconds % 60;
        
        Console.WriteLine($"Az időtartam formázva: {minutes}:{seconds:00}");

        #endregion
    }
}