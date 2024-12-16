using Minta_ZH_2.Enums;

namespace Minta_ZH_2;

public class User
{
    // fields
    private int _id;
    private SubscriptionType _subType;
    private int _subPrice;
    private DateTime _joinDate;
    private DateTime _lastPayment;
    private CountryName _country;
    private int _age;
    private DeviceType _deviceType;

    // constructors
    public User(string line)
    {
        // 1528,Standard,12,2022-09-10,2023-07-07,UnitedKingdom,45,SmartT
        string[] data = line.Split(',');
        _id = int.Parse(data[0]);
        _subType = Enum.Parse<SubscriptionType>(data[1]);
        _subPrice = int.Parse(data[2]);
        _joinDate = DateTime.Parse(data[3]);
        _lastPayment = DateTime.Parse(data[4]);
        _country = Enum.Parse<CountryName>(data[5]);
        _age = int.Parse(data[6]);
        _deviceType = Enum.Parse<DeviceType>(data[7]);
    }

    // methods

    public int SubscriptionInDays()
    {
        TimeSpan period = DateTime.Now - _joinDate;
        return period.Days;
    }

    public int DaysSinceLastPayment()
    {
        TimeSpan period = DateTime.Now - _lastPayment;
        return period.Days;
    }

    public string DataAsText()
    {
        return $"User ID: {_id} ({_country}, {_subType}, {_deviceType}). Subscription: {SubscriptionInDays()} days, last payment: {DaysSinceLastPayment()} days.";
    }

    // properties
    public int Id => _id;

    public SubscriptionType SubType => _subType;

    public int SubPrice => _subPrice;

    public DateTime JoinDate => _joinDate;

    public DateTime LastPayment => _lastPayment;

    public CountryName Country => _country;

    public int Age => _age;

    public DeviceType DeviceType => _deviceType;
}
