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

        //        public FuelCar(string brand, string model, string licensePlate, double EnergyLevel, double MaxEnergy) : base(brand, model, licensePlate)

        FuelCar car = new FuelCar("Mercedes", "E-Klasse", "AB99432", 50, 200);

        //       public Taxi(IEnergy Car, string brand, string model, string licensePlate, double EnergyLevel, double MaxEnergy, double startPrice, double pricePerKm, double pricePerMinute) : base(brand, model, licensePlate)

        Taxi fuelTaxi = new Taxi(car, "Mercedes", "E-Klasse", "AB99432", 50, 200, 35, 2.5, 1.7);

        ElectricCar eCar = new ElectricCar("Tesla", "Model S", "CD98890", 100, 5, 231);

        Taxi electricTaxi = new Taxi(eCar, "Tesla", "Model S", "CD98890", 100, 5, 231, 35, 1.7);
    }
}