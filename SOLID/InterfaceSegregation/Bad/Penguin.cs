namespace GoodPractices.SOLID.InterfaceSegregation.Bad;

public class Penguin : IBird
{
    public void Fly()
    {
        throw new NotImplementedException();
    }

    public void Walk()
    {
        Console.WriteLine("I'm Walking slow");
    }
}