using System.Text;
using Minta_ZH_2.Enums;

namespace Minta_ZH_2;

public class Dataset
{
    // fields
    private List<User> _users;

    // constructors

    public Dataset()
    {
        _users = new List<User>();
    }

    public Dataset(string fileName)
    {
        _users = new List<User>();
        string[] lines = File.ReadAllLines(fileName);

        for (int i = 1; i < lines.Length; i++)
        {
            _users.Add(new User(lines[i]));
        }
    }

    // methods
    public double AverageMonthlyRevenue(SubscriptionType subType)
    {
        int sumOfRevenue = 0;
        int numOfUsers = 0;

        for (var i = 0; i < _users.Count; i++)
        {
            if (_users[i].SubType == subType)
            {
                sumOfRevenue += _users[i].SubPrice;
                numOfUsers++;
            }
        }

        double avgRevenue = (double)sumOfRevenue / numOfUsers;
        double roundedRevenue = Math.Round(avgRevenue, 2);
        return roundedRevenue;
    }

    public User[] CollectNonPayers(int deadline)
    {
        List<int> idx = new List<int>();

        for (var i = 0; i < _users.Count; i++)
        {
            if (_users[i].DaysSinceLastPayment() >= deadline)
                idx.Add(i);
        }

        User[] result = new User[idx.Count];

        for (var i = 0; i < idx.Count; i++)
        {
            result[i] = _users[idx[i]];
        }

        return result;
    }

    public string MaximalAgeData()
    {
        User maxUser = _users[0];

        for (int i = 1; i < _users.Count; i++)
        {
            if (_users[i].Age > maxUser.Age)
            {
                maxUser = _users[i];
            }
        }

        return maxUser.DataAsText();
    }

    public string DistributionOfDeviceType(DeviceType deviceType)
    {
        StringBuilder result = new StringBuilder($"-- Distribution of {deviceType} --");
        Dictionary<CountryName, int> dict = new Dictionary<CountryName, int>();
        int numOfDevices = 0;

        for (int i = 0; i < _users.Count; i++)
        {
            User user = _users[i];

            if (user.DeviceType == deviceType)
            {
                numOfDevices++;
                dict.TryGetValue(user.Country, out int count);
                dict[user.Country] = count + 1;
            }
        }

        foreach (KeyValuePair<CountryName, int> kvp in dict)
        {
            double dist = (double)kvp.Value / numOfDevices * 100;
            double roundedDist = Math.Round(dist, 2);
            result.Append($"\n{kvp.Key}: {roundedDist}%");
        }

        return result.ToString();
    }

    // properties
    public int NumOfUsers => _users.Count;
}
