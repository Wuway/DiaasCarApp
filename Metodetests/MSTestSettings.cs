using DiaasCarApp;
[assembly: Parallelize(Scope = ExecutionScope.MethodLevel)]// Test FuelCar (Brand, Model, Licenseplate, TankCapacity, KmPerLiter)

FuelCar fuelCar = new FuelCar("Toyota", "Corolla", "AB12345", 50, 20, 23, 140);

fuelCar.StartEngine();

fuelCar.Drive(100);

Console.WriteLine($"FuelCar Odometer: {fuelCar.Odometer}, Fuel left: {fuelCar.CurrentFuel}");

// Test ElectricCar

ElectricCar electricCar = new ElectricCar("Tesla", "Model S", "CD67890", 100, 5, 23, 140);

electricCar.StartEngine();

electricCar.Drive(50);

Console.WriteLine($"ElectricCar Odometer: {electricCar.Odometer}, Battery left: {electricCar._currentCharge}");

Console.ReadLine();
