namespace GoodPractices.SOLID.DependencyInversion.Bad;

public class Repository : IRepository
{
    public void Save(string information)
    {
        Console.WriteLine($"Saving information: {information}");
    }
}