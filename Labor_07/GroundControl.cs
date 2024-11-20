using Labor_07.Enums;

namespace Labor_07;

public class GroundControl
{
    // fields
    private DateTime _now;
    private List<Flight> _flights;

    // constructors
    public GroundControl()
    {
        _now = DateTime.Now;
        _flights = new List<Flight>();
    }

    private double AverageDelay()
    {
        int sumOfDelay = 0;
        int numOfFlights = 0;

        foreach (Flight flight in _flights)
        {
            if (flight.Status == FlightStatus.Canceled)
                continue;

            sumOfDelay += flight.Delay;
            numOfFlights++;
        }

        double avgOfDelay = (double)sumOfDelay / numOfFlights;
        double roundedAvgOfDelay = Math.Round(avgOfDelay, 2);
        return roundedAvgOfDelay;
    }

    public void DisplayFlightData()
    {
        Console.WriteLine("Elérhető járatok: ");

        foreach (Flight flight in _flights)
        {
            Console.WriteLine(flight.AllData);
        }
        Console.WriteLine($"Average delay is {AverageDelay()} minutes.");
    }

    // methods
    public void AddFlight(Flight flight)
    {
        _flights.Add(flight);
    }
}
