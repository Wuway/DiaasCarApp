using DiaasCarApp;
[assembly: Parallelize(Scope = ExecutionScope.MethodLevel)]// Test FuelCar (Brand, Model, Licenseplate, TankCapacity, KmPerLiter)

/* FuelCar fuelCar = new FuelCar("Toyota", "Corolla", "AB12345", 50, 20);

fuelCar.StartEngine();

fuelCar.Drive(100);

Console.WriteLine($"FuelCar Odometer: {fuelCar.Odometer}, Fuel left: {fuelCar.CurrentFuel}");

// Test ElectricCar

ElectricCar electricCar = new ElectricCar("Tesla", "Model S", "CD67890", 100, 5, 231);

electricCar.StartEngine();

electricCar.Drive(50);

Console.WriteLine($"ElectricCar Odometer: {electricCar.Odometer}, Battery left: {electricCar._currentCharge}");

Console.ReadLine(); */

// Test taxi-funktionaliteten

void TestTaxi(Taxi fuelTaxi)

{

    taxi.StartEngine();

    taxi.StartMeter();

    taxi.Drive(10);

    double fare = taxi.CalculateFare(10, 15);

    taxi.StopMeter();

    taxi.StopEngine();

    Console.WriteLine($"Taxi ride complete. Total fare: {fare:C2}");

    Console.WriteLine($"Energy level: {taxi.EnergyLevel:F2}\n");

}

// Test begge taxi-typer

Console.WriteLine("Testing Fuel Taxi:");

TestTaxi(fuelTaxi);

Console.WriteLine("Testing Electric Taxi:");

TestTaxi(electricTaxi);

