using DiaasCarApp;

internal class Program
{
    static void Main()
    {
        /* // Test FuelCar

         FuelCar fuelCar = new FuelCar("Toyota", "Corolla", "AB12345", 50, 20, 23, 140);

         fuelCar.StartEngine();

         fuelCar.Drive(100);

         Console.WriteLine($"FuelCar Odometer: {fuelCar.Odometer}, Fuel left: {fuelCar.CurrentFuel}");


         // Test ElectricCar

         ElectricCar electricCar = new ElectricCar("Tesla", "Model S", "CD67890", 100, 5, 23, 140);

         electricCar.StartEngine();

         electricCar.Drive(50);

         Console.WriteLine($"ElectricCar Odometer: {electricCar.Odometer}, Battery left: {electricCar._currentCharge}");


         // Test Taxi

         Taxi taxi = new Taxi("Mercedes", "E-Class", "TX11223", 49.0, 12.3, 7.5);

         taxi.StartEngine();

         taxi.StartMeter();

         taxi.Drive(20);

         double fare = taxi.CalculateFare(20, 30); // 20 km og 30 minutter

         taxi.StopMeter();

         Console.WriteLine($"Taxi Odometer: {taxi.Odometer}, Fare: {fare} kr.");

         Console.ReadKey(); */

        Car car = new FuelCar("Toyota", "Corolla", "AB12345", 50, 20, 23, 140);
        Taxi taxi = new Taxi("Mercedes", "E-Class", "TX11223", 49.0, 12.3, 7.5);
    }
}