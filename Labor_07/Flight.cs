using Labor_07.Enums;

namespace Labor_07;

public class Flight
{
    // fields
    private string _id;
    private string _dest;
    private DateTime _std;
    private int _delay;
    private FlightStatus _status;

    // constructors
    public Flight(string id, string dest, int delay)
    {
        _id = id;
        _dest = dest;
        _delay = delay;
    }

    public Flight(string id, string dest, DateTime std)
    {
        _id = id;
        _dest = dest;
        _std = std;
        _delay = 0;
    }

    // methods
    public void SetDelay(int delay)
    {
        _delay = delay;
        UpdateStatus();
    }

    public void Cancel()
    {
        _status = FlightStatus.Canceled;
    }

    private void UpdateStatus(FlightStatus status)
    {
        _status = status;
    }

    private void UpdateStatus()
    {
        _status = _delay > 0 ? FlightStatus.Delayed : FlightStatus.Scheduled;
    }

    private DateTime EstimatedDeparture()
    {
        return _std.AddMinutes(_delay);
    }

    // properties
    public String AllData
    {
        get
        {
            string result = $"Flight {_id} is ";

            if (_status == FlightStatus.Scheduled)
                result += $"on time. (STD {_std.GetDateTimeFormats()[7]})";

            if (_status == FlightStatus.Delayed)
            {
                DateTime etd = EstimatedDeparture();
                result += $"delayed by {_delay} minutes. (ETD {etd.GetDateTimeFormats()[7]})";
            }

            if (_status == FlightStatus.Canceled)
                result += $"canceled.";

            return result;
        }
    }

    public string Id => _id;

    public string Dest => _dest;

    public int Delay => _delay;

    public FlightStatus Status => _status;
}
