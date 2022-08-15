namespace GoodPractices.SOLID.SingleResposibility.Good;

public class Car
{
    public string LicensePlate { get; }
    public string Brand { get; }
    public int Doors { get; }
    public List<Passenger> Passengers { get; }
    
    public Car(int doors, string brand, string licensePlate)
    {
        Doors = doors;
        Brand = brand;
        LicensePlate = licensePlate;
        Passengers = new List<Passenger>();
    }

    public void RegisterPassenger(Passenger passenger)
    {
        Passengers.Add(passenger);
    }

    public void RemovePassenger(Passenger passenger)
    {
        Passengers.Remove(passenger);
    }
}