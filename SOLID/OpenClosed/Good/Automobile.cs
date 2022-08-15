namespace GoodPractices.SOLID.OpenClosed.Good;

public class Automobile
{
    public string LicensePlate { get; }
    public string Brand { get; }
    public int FuelInLiters { get; private set; }
    
    public Automobile(string licensePlate, string brand)
    {
        LicensePlate = licensePlate;
        Brand = brand;
    }

    public void AddFuel(int liters)
    {
        FuelInLiters += liters;
    }
}