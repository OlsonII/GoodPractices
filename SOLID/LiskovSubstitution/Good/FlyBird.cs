namespace GoodPractices.SOLID.LiskovSubstitution.Good;

public class FlyBird : Bird
{
    public void Fly()
    {
        Console.WriteLine("I'm flying");
    }
}