namespace GoodPractices.SOLID.LiskovSubstitution.Bad;

public class Bird
{
    public void Fly()
    {
        Console.WriteLine("I'm flying");
    }
    
    public void Walk()
    {
        Console.WriteLine("I'm walking");
    }
}