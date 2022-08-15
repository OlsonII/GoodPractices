namespace GoodPractices.SOLID.LiskovSubstitution.Good;

public abstract class Bird
{
    public void Walk()
    {
        Console.WriteLine("I'm walking slow");
    }
}