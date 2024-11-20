using Labor_07.Enums;

namespace Labor_07;

public class ExamResult
{
    // fields
    private string _neptunKey = string.Empty;
    private int _score;
    private readonly Random _rand;

    // constructors
    public ExamResult(string key, int score)
    {
        NeptunKey = key;
        Score = score;
        _rand = new Random();
    }

    public ExamResult()
    {
        _rand = new Random();
        NeptunKey = GenerateKey();
        Score = _rand.Next(101);
    }

    // methods
    private bool IsNeptunKeyValid(string key)
    {
        return Char.IsDigit(key[0]) && key.Length == 6;
    }

    private string GenerateKey()
    {
        string result = string.Empty;

        while (result.Length != 6)
        {
            result += GenerateRandChar();
            if (!Char.IsDigit(result[0]))
                result = string.Empty;
        }

        return result.ToUpper();
    }

    private char GenerateRandChar()
    {
        // a-z-ig intervallumból generálunk
        char result = (char)_rand.Next('a', 'z' + 1);

        // int átalakítása char típusra
        // hozzá kell adni a '0' értékét, mert
        // így egyezik az Unicode értékével
        if (_rand.Next(2) == 0)
            result = (char)(_rand.Next(10) + '0');

        return result;
    }

    public GradeItem Grade(int[] scores)
    {
        if (_score < scores[1])
            return GradeItem.Elegtelen;

        if (_score < scores[2])
            return GradeItem.Elegseges;

        if (_score < scores[3])
            return GradeItem.Kozepes;

        if (_score < scores[4])
            return GradeItem.Jo;

        return GradeItem.Jeles;
    }

    // properties
    public bool Passed => _score >= 50;

    public string NeptunKey
    {
        get => _neptunKey;
        set => _neptunKey = IsNeptunKeyValid(value) ? value : string.Empty;
    }

    public int Score
    {
        get => _score;
        set => _score = value is >= 0 and <= 100 ? value : 0;
    }
}
