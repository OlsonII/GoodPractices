namespace GoodPractices.SOLID.InterfaceSegregation.Good;

public class Penguin : ITerrestrialBird
{
    public void Walk()
    {
        Console.WriteLine("I'm Walking");
    }
}