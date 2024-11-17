namespace Labor_10;

internal class Program
{
    public static void Main(string[] args)
    {
        #region Fájl beolvasás, feldolgozás

        // fájl beolvasás
        List<string> fileContent = new List<string>(File.ReadAllLines("NHANES_1999-2018.csv"));
        List<Survey> surveys = new List<Survey>();

        // fejléc törlése
        fileContent.RemoveAt(0);

        // objektumok létrehozása a file tartalmából
        foreach (string line in fileContent)
        {
            surveys.Add(new Survey(line));
        }

        // kiválasztunk egy időszakot és kiválogatjuk
        // őket egy új listába
        string choosenPeriod = surveys[0].Period;
        List<Survey> filteredSurvey = new List<Survey>();

        foreach (Survey s in surveys)
        {
            if (String.Compare(s.Period, choosenPeriod, StringComparison.Ordinal) == 0)
            {
                filteredSurvey.Add(s);
            }
        }

        #endregion

        #region 5/1. feladat

        int numOfMales = 0;
        int numofFemales = 0;
        double sumOfMaleBmi = 0.0;
        double sumOfFemaleBmi = 0.0;

        foreach (Survey s in filteredSurvey)
        {
            if (s.IsMale())
            {
                numOfMales++;
                sumOfMaleBmi += s.Bmxbmi;
            }
            else
            {
                numofFemales++;
                sumOfFemaleBmi += s.Bmxbmi;
            }
        }

        double avgMaleBmi = sumOfMaleBmi / numOfMales;
        double avgFemaleBmi = sumOfFemaleBmi / numofFemales;

        Console.WriteLine("\n5/1. feladat");
        Console.WriteLine(
            $"A {choosenPeriod} időszakban a férfiak átlagos BMI-je: {avgMaleBmi}, a hölgyek átlagos BMI-je: {avgFemaleBmi}."
        );

        #endregion

        #region 5/2. feladat

        int numOfFatPeople = 0;

        foreach (Survey s in filteredSurvey)
        {
            if (s.IsFat())
            {
                numOfFatPeople++;
            }
        }

        double percentageOfFatPeople = (double)numOfFatPeople / filteredSurvey.Count * 100;
        double roundedPercOfFatPeople = Math.Round(percentageOfFatPeople, 2);

        Console.WriteLine("\n5/2. feladat");
        Console.WriteLine(
            $"A {choosenPeriod} időszakban 5.6-nál magasabb vércukorszint százaléka: {roundedPercOfFatPeople} %."
        );

        #endregion

        #region 5/3. feladat

        Survey maxBmiSurvey = surveys[0];

        foreach (Survey s in surveys)
        {
            if (s.Bmxbmi > maxBmiSurvey.Bmxbmi)
                maxBmiSurvey = s;
        }

        Console.WriteLine("\n5/3. feladat");
        Console.WriteLine(
            $"Egy max BMI-s ({maxBmiSurvey.Bmxbmi}) alany vércukorszintje: {maxBmiSurvey.Lbdglusi}."
        );

        #endregion

        #region 5/4. feladat

        int numberOfFatPeople = 0;
        int sumOfAge = 0;

        foreach (Survey s in surveys)
        {
            if (s.IsHighBmi())
            {
                numberOfFatPeople++;
                sumOfAge += (int)s.Ridageyr;
            }
        }

        double avgAge = (double)sumOfAge / numberOfFatPeople;
        double roundedAvgAge = Math.Round(avgAge, 2);

        Console.WriteLine("\n5/4. feladat");
        Console.WriteLine($"A teljes adathalmazban a túlsúlyosak átlagéletkora: {roundedAvgAge}.");

        #endregion
    }
}
