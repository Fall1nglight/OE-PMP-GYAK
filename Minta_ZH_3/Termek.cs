using Minta_ZH_3.Enums;

namespace Minta_ZH_3;

public class Termek
{
    // fields
    private string _name;
    private TermekTipus _prodType;
    private int _price;

    // constructors
    public Termek(string name, TermekTipus prodType, int price)
    {
        _name = name;
        _prodType = prodType;
        _price = price;
    }

    // methods
    public override string ToString()
    {
        return $"{_name} ({_prodType}) {_price} Ft";
    }

    // propeties
    public string Name => _name;

    public TermekTipus ProdType => _prodType;

    public int Price => _price;
}
