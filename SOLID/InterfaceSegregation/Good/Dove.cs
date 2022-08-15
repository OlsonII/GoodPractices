namespace GoodPractices.SOLID.InterfaceSegregation.Good;

public class Dove : IAirBird
{
    public void Fly()
    {
        Console.WriteLine("I'm flying");
    }

    public void Walk()
    {
        Console.WriteLine("I'm Walking");
    }
}