namespace Labor_10;

public class Survey
{
    // adatmezők
    private int _seqn;
    private string _period = string.Empty;
    private double _riagendr;
    private double _ridageyr;
    private double _bmxbmi;
    private double _lbdglusi;

    // konstruktor
    public Survey(string line)
    {
        string[] details = line.Split(',');
        Seqn = int.Parse(details[0]);
        Period = details[1];
        Riagendr = double.Parse(details[2].Replace('.', ','));
        Ridageyr = double.Parse(details[3].Replace('.', ','));
        Bmxbmi = double.Parse(details[4].Replace('.', ','));
        Lbdglusi = double.Parse(details[5].Replace('.', ','));
    }

    // metódusok
    public bool IsMale()
    {
        return Riagendr == 1;
    }

    public bool IsFat()
    {
        return Lbdglusi > 5.6;
    }

    public bool IsHighBmi()
    {
        return Bmxbmi > 30.0;
    }

    // getterek, setterek
    public int Seqn
    {
        get => _seqn;
        set => _seqn = value;
    }
    public string Period
    {
        get => _period;
        set => _period = value;
    }
    public double Riagendr
    {
        get => _riagendr;
        set => _riagendr = value;
    }
    public double Ridageyr
    {
        get => _ridageyr;
        set => _ridageyr = value;
    }
    public double Bmxbmi
    {
        get => _bmxbmi;
        set => _bmxbmi = value;
    }
    public double Lbdglusi
    {
        get => _lbdglusi;
        set => _lbdglusi = value;
    }
}
