namespace GoodPractices.SOLID.OpenClosed.Good;

public class Truck : Automobile
{
    public double CapacityInKg { get; private set; }
    
    public Truck(string licensePlate, string brand, double capacityInKg) : base(licensePlate, brand)
    {
        CapacityInKg = capacityInKg;
    }

    public void AddBox(double boxWeight)
    {
        if (CapacityInKg - boxWeight >= 0)
            CapacityInKg -= boxWeight;
        else
            throw new Exception("Max capacity");
    }
}