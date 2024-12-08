using System.Text;
using Minta_ZH_4.Enums;

namespace Minta_ZH_4;

public class ECar
{
    // fields
    private string _plateNum;
    private TeslaModel _model;
    private int _year;
    private double _batteryCapacity;
    private int _kms;
    private int _range;
    private string _color;
    private readonly Random _rand;

    // constructors
    public ECar(string line)
    {
        string[] arr = line.Split(',');
        _plateNum = arr[0];
        _model = (TeslaModel)int.Parse(arr[1]);
        _year = int.Parse(arr[2]);
        _batteryCapacity = double.Parse(arr[3].Replace('.', ','));
        _kms = int.Parse(arr[4]);
        _range = int.Parse(arr[5]);
        _color = arr[6];
        _rand = new Random();
    }

    // methods
    public void GeneratePlate()
    {
        int plateNum = _rand.Next(0, 1000);
        string plateStr = $"{GeneratePlateStr()} {plateNum}";
        _plateNum = plateStr.ToUpper();
    }

    // todo | refactor this
    private char GenerateChar()
    {
        return (char)_rand.Next((int)'a', (int)'z' + 1);
    }

    private string GeneratePlateStr()
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < 4; i++)
        {
            sb.Append(GenerateChar());

            if (i == 1)
                sb.Append(' ');
        }

        return sb.ToString();
    }

    public override string ToString()
    {
        return $"{_model} - {_plateNum}";
    }

    // properties
    public int Age => DateTime.Now.Year - _year;

    public string PlateNum => _plateNum;

    public TeslaModel Model => _model;

    public int Year => _year;

    public double BatteryCapacity => _batteryCapacity;

    public int Kms
    {
        get { return _kms; }
        set
        {
            if (value > _kms)
                _kms = value;
        }
    }

    public int Range
    {
        get { return _range; }
        set
        {
            if (value <= _range)
                _range = value;
        }
    }

    public string Color => _color;
}
