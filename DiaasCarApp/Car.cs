using System.Security.Cryptography.X509Certificates;

namespace DiaasCarApp;
public class Car
{
    public string Brand
    {
        get; set;
    }
    public string Model
    {
        get; set;
    }
    public int year
    {
        get; set;
    }
    public string LicensePlate
    {
        get; set;
    }
    public int Odometer
    {
        get; set;
    }
    public bool isEngineOn
    {
        get; set;
    }
    public void StartEngine()
    {
        isEngineOn = true;
        Console.WriteLine("Engine started.");
    }
    public void StopEngine()
    {
        isEngineOn = false;
        Console.WriteLine("Engine stopped.");
    }
    public virtual void Drive(double distance)
    {

    }
    public void UpdateOdometer(double distance)
    {
        if (distance > 0)
        {
            Odometer += (int)distance;
            Console.WriteLine($"Odometer updated to {Odometer} km.");
        }
        else
        {
            Console.WriteLine("Invalid distance.");
        }
    }
        public Car(string brand, string model, string licensePlate)
    {
        Brand = brand;
        Model = model;
        LicensePlate = licensePlate;
    }
}
