namespace Labor_05;

internal class Program
{
    private static readonly Random Rand = new Random();

    public static void Main(string[] args)
    {
        #region 1. feladat

        Console.WriteLine("1. feladat");

        string[] lines = File.ReadAllLines("colorem_ipsum.txt");

        for (int i = 0; i < lines.Length; i++)
        {
            string[] arr = lines[i].Split('#');
            Console.ForegroundColor = Enum.Parse<ConsoleColor>(arr[0]);
            Console.WriteLine(arr[1]);
        }

        Console.ResetColor();
        Console.ReadLine();

        #endregion

        #region 2. feladat
        Console.Clear();
        Console.WriteLine("2. feladat");

        char usrInput;
        StreamWriter writer = new StreamWriter("lottery_simulation.txt");
        DateTime dt = DateTime.Today;

        do
        {
            List<int> choosenNumbers = new List<int>();

            while (choosenNumbers.Count != 5)
            {
                int randNum = Rand.Next(1, 91);

                if (!choosenNumbers.Contains(randNum))
                    choosenNumbers.Add(randNum);
            }

            string line = $"On {dt:yy-MM-dd} numbers were: {string.Join(' ', choosenNumbers)}";

            Console.WriteLine(line);
            Console.Write("Another week? [y/n] ");

            usrInput = Console.ReadKey().KeyChar;
            dt = dt.AddDays(7);

            writer.WriteLine(line);
            Console.WriteLine();
        } while (usrInput != 'n');

        writer.Close();
        Console.ReadLine();

        #endregion


        #region 4. feladat
        Console.Clear();
        Console.WriteLine("4. feladat");

        string[] nhanesLines = File.ReadAllLines("NHANES_1999-2018.csv");

        List<int> seqn = new List<int>();
        List<string> survey = new List<string>();
        List<double> riagendr = new List<double>();
        List<double> ridageyr = new List<double>();
        List<double> bmxbmi = new List<double>();
        List<double> lbdglusi = new List<double>();

        for (int i = 1; i < nhanesLines.Length; i++)
        {
            string currLine = nhanesLines[i];
            string[] currArr = currLine.Split(',');
            seqn.Add(int.Parse(currArr[0]));
            survey.Add(currArr[1]);
            riagendr.Add(double.Parse(currArr[2].Replace('.', ',')));
            ridageyr.Add(double.Parse(currArr[3].Replace('.', ',')));
            bmxbmi.Add(double.Parse(currArr[4].Replace('.', ',')));
            lbdglusi.Add(double.Parse(currArr[5].Replace('.', ',')));
        }

        string choosenSurvey = survey[0];

        // 1. feladat
        int numOfMales = 0;
        int numOfFemales = 0;
        double sumOfMaleBmi = 0.0;
        double sumOfFemaleBmi = 0.0;

        for (int i = 0; i < survey.Count; i++)
        {
            if (string.Compare(survey[i], choosenSurvey, StringComparison.Ordinal) != 0)
                continue;

            if (riagendr[i] == 1.0)
            {
                numOfMales++;
                sumOfMaleBmi += bmxbmi[i];
            }
            else
            {
                numOfFemales++;
                sumOfFemaleBmi += bmxbmi[i];
            }
        }

        double avgOfMaleBmi = Math.Round(sumOfMaleBmi / numOfMales, 2);
        double avgOfFemaleBmi = Math.Round(sumOfFemaleBmi / numOfFemales, 2);

        Console.WriteLine(
            $"A {choosenSurvey} időszakban a férfiak átlagos testtömeg indexe: {avgOfMaleBmi}, a nőké pedig: {avgOfFemaleBmi}."
        );

        // 2. feladat
        int peopleCount = 0;
        int fatCount = 0;

        for (int i = 0; i < survey.Count; i++)
        {
            if (string.Compare(survey[i], choosenSurvey, StringComparison.Ordinal) != 0)
                continue;

            peopleCount++;

            if (lbdglusi[i] > 5.6)
                fatCount++;
        }

        double fatPeoplePercentage = Math.Round((double)fatCount / peopleCount * 100, 2);

        Console.WriteLine(
            $"A {choosenSurvey} időszakban az alanyok {fatPeoplePercentage}%-ának volt 5.6-nál magasabb a vércukorszintje."
        );

        // 3. feladat
        int maxBmiIdx = 0;

        for (int i = 1; i < survey.Count; i++)
        {
            if (bmxbmi[i] > bmxbmi[maxBmiIdx])
                maxBmiIdx = i;
        }

        Console.WriteLine(
            $"Egy maximális BMI-vel ({bmxbmi[maxBmiIdx]}) rendelkező alany vércukorszintje: {lbdglusi[maxBmiIdx]}."
        );

        // 4. feladat
        fatCount = 0;
        double sumOfAge = 0.0;

        for (int i = 0; i < survey.Count; i++)
        {
            if (bmxbmi[i] < 30.0)
                continue;

            fatCount++;
            sumOfAge += ridageyr[i];
        }

        double avgOfAgeOfFatPeople = Math.Round(sumOfAge / fatCount, 2);

        Console.WriteLine(
            $"A teljes adathalmazban a túlsúlyos emberek átlagos életkora {avgOfAgeOfFatPeople} év."
        );

        #endregion
    }
}
