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

        Console.WriteLine($"Korod: {age}, egy év múlva: {age + 1}.");
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
        Console.ReadLine();

        #endregion

        #region 7. feladat

        Console.Clear();
        Console.WriteLine("7. feladat");

        Console.Write("Add meg a jelszavad: ");
        string inputFirstPwd = Console.ReadLine()!;

        Console.Write("Add meg a jelszavad megint: ");
        string inputSecondPwd = Console.ReadLine()!;

        if (string.Compare(inputFirstPwd, inputSecondPwd, StringComparison.Ordinal) == 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("A jelszavak megegyeznek!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("A jelszavak nem egyeznek meg!");
        }

        Console.ResetColor();
        Console.ReadLine();

        #endregion

        #region 8. feladat

        Console.Clear();
        Console.WriteLine("8. feladat");

        ConsoleKeyInfo inputKey;
        string inputSecretPwd = string.Empty;

        do
        {
            Console.Clear();
            Console.Write($"Add meg a jelszavadat: {new string('*', inputSecretPwd.Length)}");
            inputKey = Console.ReadKey();

            if (inputKey.Key == ConsoleKey.Backspace)
            {
                if (inputSecretPwd.Length > 0)
                    inputSecretPwd = inputSecretPwd.Substring(0, inputSecretPwd.Length - 1);

                continue;
            }

            inputSecretPwd += inputKey.KeyChar;
        } while (inputKey.Key != ConsoleKey.Enter);

        Console.WriteLine();
        Console.WriteLine($"A jelszavad: {inputSecretPwd}");
        Console.ReadLine();

        #endregion

        #region 9. feladat

        Console.Clear();
        Console.WriteLine("9. feladat");

        Console.Write("Add meg az első számot: ");
        int inputFirstNum = int.Parse(Console.ReadLine()!);

        Console.Write("Add meg a második számot: ");
        int inputSecondNum = int.Parse(Console.ReadLine()!);

        Console.Write("Add meg a műveletet: ");
        char inputOperation = Console.ReadKey().KeyChar;

        double calcResult = 0.0;

        switch (inputOperation)
        {
            case '+':
            {
                calcResult = inputFirstNum + inputSecondNum;
                break;
            }

            case '-':
            {
                calcResult = inputFirstNum - inputSecondNum;
                break;
            }

            case '*':
            {
                calcResult = inputFirstNum * inputSecondNum;
                break;
            }

            default:
            {
                calcResult = (double)inputFirstNum / inputSecondNum;
                break;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"{inputFirstNum} {inputOperation} {inputSecondNum} = {calcResult}");
        Console.ReadLine();

        #endregion

        #region 10. feladat
        // todo
        #endregion

        #region 11. feladat

        Console.Clear();
        Console.WriteLine("11. feladat");

        Console.Write("Adj meg egy számot: ");
        int inputNumber = int.Parse(Console.ReadLine()!);
        string numToText = string.Empty;

        switch (inputNumber)
        {
            case 0:
            {
                numToText = "nulla";
                break;
            }

            case 1:
            {
                numToText = "egy";
                break;
            }

            case 2:
            {
                numToText = "kettő";
                break;
            }

            case 3:
            {
                numToText = "három";
                break;
            }

            case 4:
            {
                numToText = "négy";
                break;
            }

            case 5:
            {
                numToText = "öt";
                break;
            }

            case 6:
            {
                numToText = "hat";
                break;
            }

            case 7:
            {
                numToText = "hét";
                break;
            }

            case 8:
            {
                numToText = "nyolc";
                break;
            }

            case 9:
            {
                numToText = "kilenc";
                break;
            }
        }

        if (string.IsNullOrEmpty(numToText))
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("A tartományon kívül adtál meg számot!");

            Console.ResetColor();
        }
        else
        {
            Console.WriteLine($"Az általad megadott szám: {numToText}");
        }

        Console.ReadLine();

        #endregion

        #region 12. feladat

        Console.Clear();
        Console.WriteLine("12. feladat");

        Console.Write("Adj meg egy betűt: ");
        char inputLetter = Console.ReadKey().KeyChar;
        Console.WriteLine();

        // magánhangzók
        List<char> vowels = new List<char>
        {
            'a',
            'á',
            'e',
            'é',
            'i',
            'í',
            'o',
            'ó',
            'ö',
            'ő',
            'u',
            'ú',
            'ü',
            'ű',
        };

        bool isVowel = vowels.Contains(inputLetter);
        Console.WriteLine(
            isVowel
                ? "Az általad megadott betű magánhangzó."
                : "Az általad megadott betű mássalhangzó."
        );

        Console.ReadLine();

        #endregion

        #region 13. feladat

        Console.Clear();
        Console.WriteLine("13. feladat");

        Console.Write("V = ");
        int inputV = int.Parse(Console.ReadLine()!);

        Console.Write("R1 = ");
        int inputR1 = int.Parse(Console.ReadLine()!);

        Console.Write("R2 = ");
        int inputR2 = int.Parse(Console.ReadLine()!);

        Console.Write("T = ");
        double inputT = double.Parse(Console.ReadLine()!);

        double finalV = inputT * (inputR1 + inputR2);
        double percentage = (double)finalV / inputV * 100;
        double roundedPercentage = Math.Round(percentage, 2);

        if (roundedPercentage <= 100)
        {
            Console.WriteLine($"--> A tartály {roundedPercentage}%-ban lesz tele.");
        }
        else
        {
            double overflow = finalV - inputV;
            Console.WriteLine($"--> A tartály {overflow} m3-rel lesz túltöltve.");
        }

        #endregion
    }
}
