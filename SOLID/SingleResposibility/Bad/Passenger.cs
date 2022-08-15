namespace GoodPractices.SOLID.SingleResposibility.Bad;

public class Passenger
{
    public string Name { get; }
    
    public Passenger(string name)
    {
        Name = name;
    }
}