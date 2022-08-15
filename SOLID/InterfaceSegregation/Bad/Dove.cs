
namespace GoodPractices.SOLID.InterfaceSegregation.Bad;

public class Dove : IBird
{
    public void Fly()
    {
        Console.WriteLine("I'm flying slow");
    }

    public void Walk()
    {
        Console.WriteLine("I'm Walking fast");
    }
}