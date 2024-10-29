namespace Labor_08;

public class Game
{
    // fields
    private readonly Field _field;
    private List<Buffalo> _buffaloes = new List<Buffalo>();

    // constructors
    public Game(int fieldSize, int numOfBuffaloes)
    {
        _field = new Field(fieldSize);

        for (int i = 0; i < numOfBuffaloes; i++)
        {
            _buffaloes.Add(new Buffalo());
        }
    }

    // methods
    private void VisualizeElements()
    {
        Console.Clear();
        _field.Show();

        foreach (Buffalo buffalo in _buffaloes)
        {
            buffalo.Show();
            buffalo.Move(_field);
        }
    }

    private void Shoot()
    {
        Console.Write("cords [x,y]: ");
        string[] inputCords = Console.ReadLine()!.Split(',');
        int inputX = int.Parse(inputCords[0]);
        int inputY = int.Parse(inputCords[1]);

        foreach (Buffalo buffalo in _buffaloes)
        {
            if (buffalo.X == inputX && buffalo.Y == inputY)
            {
                buffalo.Deactivate();
            }
        }
    }

    private bool IsOver()
    {
        int numOfHits = 0;

        foreach (Buffalo buffalo in _buffaloes)
        {
            if (!buffalo.Status)
                numOfHits++;

            if (buffalo.X == _field.TargetX && buffalo.Y == _field.TargetY)
            {
                VisualizeElements();
                Console.WriteLine("Vesztettél, legalább egy bőlény beért a célba!");
                return true;
            }
        }

        if (numOfHits == _buffaloes.Count)
        {
            Console.WriteLine("Lelőttél minden bölényt.");
            return true;
        }

        return false;
    }

    public void Run()
    {
        while (!IsOver())
        {
            VisualizeElements();
            Shoot();
        }
    }

    // properties
}
