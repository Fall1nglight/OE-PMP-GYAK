namespace Labor_07;

internal class Program
{
    public static void Main(string[] args)
    {
        #region 1. feladat

        Console.WriteLine("1. feladat");

        Mole mole = new Mole();
        mole.Hide(1, 10);

        Console.Write("Tippelj, hogy hol helyezkedik a vakond: ");
        int inputPos = int.Parse(Console.ReadLine()!);

        mole.TurnUp();

        Console.WriteLine($"{(mole.Pos == inputPos ? "Helyes" : "Helytelen")} volt a tipped.");
        Console.WriteLine($"A vakond a {mole.Pos} pozíción volt.");
        Console.ReadLine();

        #endregion

        #region 2. feladat

        Console.Clear();
        Console.WriteLine("2. feladat");

        GroundControl gc = new GroundControl();
        DateTime now = DateTime.Now;
        Flight f1 = new Flight("LH1337", "France", now.AddMinutes(5));
        Flight f2 = new Flight("W62221", "Amsterdam", now.AddHours(1));
        Flight f3 = new Flight("FR3586", "China", now.AddHours(5));

        // tesztelés céljából
        // f1.SetDelay(13);
        // f2.Cancel();
        // f3.SetDelay(10);

        gc.AddFlight(f1);
        gc.AddFlight(f2);
        gc.AddFlight(f3);

        gc.DisplayFlightData();
        Console.ReadLine();

        #endregion

        #region 3. feladat

        Console.Clear();
        Console.WriteLine("3. feladat");

        Console.Write("Dolgozatok száma: ");
        int inputNumOfExams = int.Parse(Console.ReadLine()!);
        List<ExamResult> exams = new List<ExamResult>();

        for (int i = 0; i < inputNumOfExams; i++)
            exams.Add(new ExamResult());

        // int sum = exams.Sum(e => e.Score);
        // double avg = exams.Average(e => e.Score);
        // var maxScore = exams.MaxBy(e => e.Score);

        int sumOfScore = 0;
        ExamResult maxScore = exams[0];

        foreach (ExamResult exam in exams)
        {
            if (exam.Passed)
                Console.WriteLine($"{exam.NeptunKey}");

            if (exam.Score > maxScore.Score)
                maxScore = exam;

            sumOfScore += exam.Score;
        }

        double avgScore = (double)sumOfScore / exams.Count;
        double roundedScore = Math.Round(avgScore, 2);

        Console.WriteLine($"A dolgozatok átlag pontszáma: {roundedScore}");
        Console.WriteLine($"A legmagasabb pontot {maxScore.NeptunKey} érte el ({maxScore.Score})");

        #endregion
    }
}
