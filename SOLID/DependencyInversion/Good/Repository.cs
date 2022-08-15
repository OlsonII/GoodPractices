namespace GoodPractices.SOLID.DependencyInversion.Good;

public class Repository : IRepository
{
    public void Save(string information)
    {
        Console.WriteLine($"Saving information: {information}");
    }
}