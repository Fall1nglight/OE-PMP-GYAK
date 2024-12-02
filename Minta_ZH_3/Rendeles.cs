using System.Text;
using Minta_ZH_3.Enums;

namespace Minta_ZH_3;

public class Rendeles
{
    // fields
    private string _customerName;
    private string _administratorName;
    private int _taxKey;
    private List<Termek> _products;

    // constructors
    public Rendeles(string customerName, string administratorName, int taxKey, string fileName)
    {
        _customerName = customerName;
        _administratorName = administratorName;
        _taxKey = taxKey;
        _products = new List<Termek>();

        string[] lines = File.ReadAllLines(fileName);

        for (int i = 0; i < lines.Length; i++)
        {
            _products.Add(SzovegbolTermek(lines[i]));
        }
    }

    // methods
    private Termek SzovegbolTermek(string line)
    {
        string[] arr = line.Split(';');
        string prodName = arr[0];
        int prodPrice = int.Parse(arr[1]);
        TermekTipus prodType = Enum.Parse<TermekTipus>(arr[2]);
        return new Termek(prodName, prodType, prodPrice);
    }

    private int SzamlaOsszeg()
    {
        int osszeg = 0;

        foreach (Termek product in _products)
        {
            osszeg += product.Price;
        }

        return osszeg;
    }

    public string SzamlaGeneral()
    {
        StringBuilder sb = new StringBuilder(
            $"Megrendelő: {_customerName} ({_products.Count} tétel)"
        );

        sb.AppendLine($"\nÜgyintéző: {_administratorName}");
        sb.AppendLine("");

        for (int i = 0; i < _products.Count; i++)
        {
            sb.AppendLine($"{i + 1}. {_products[i]}");
        }

        sb.AppendLine("---");
        sb.AppendLine(
            $"Fizetendő: {SzamlaOsszeg()} Ft (nettó) + 27% ÁFA = {SzamlaOsszeg() * 1.27} Ft."
        );

        return sb.ToString();
    }

    public void SzamlaMentese(string fileName)
    {
        File.WriteAllText(fileName, SzamlaGeneral());
    }
}
