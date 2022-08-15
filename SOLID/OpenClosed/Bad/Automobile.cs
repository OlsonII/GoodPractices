namespace GoodPractices.SOLID.OpenClosed.Bad;

public class Automobile
{
    public string LicensePlate { get; }
    public string Brand { get; }
    public int FuelInLiters { get; private set; }
    public double CapacityInKg { get; private set; }
    
    public Automobile(string licensePlate, string brand, double capacityInKg)
    {
        LicensePlate = licensePlate;
        Brand = brand;
        CapacityInKg = capacityInKg;
    }

    public void AddFuel(int liters)
    {
        FuelInLiters += liters;
    }
    
    public void AddBox(double boxWeight)
    {
        if (CapacityInKg - boxWeight >= 0)
            CapacityInKg -= boxWeight;
        else
            throw new Exception("Max capacity");
    }
}