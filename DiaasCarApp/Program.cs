namespace DiaasCarApp
{
    internal class Program
    {
        // Klasseniveau variabel til at gemme biler

        private static List<Car> cars = new List<Car>();
        static void Main(string[] args)
        {
            // Vis menu
            while (true)
            {
                Console.WriteLine("\n--- Car System Menu ---");
                Console.WriteLine("1. Add a Car");
                Console.WriteLine("2. Add a Trip to a Car");
                Console.WriteLine("3. Print Car Details");
                Console.WriteLine("4. Print All Trips for a Car");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddCar();
                        break;
                    case "2":
                        int carIndexForTrip = ChooseCar();
                        if (carIndexForTrip != -1) // Hvis en gyldig bil er valgt
                        {
                            AddTrip(carIndexForTrip);
                        }
                        break;
                    case "3":
                        int carIndexForDetails = ChooseCar();
                        if (carIndexForDetails != -1) // Hvis en gyldig bil er valgt
                        {
                            PrintCarDetails(carIndexForDetails);
                        }
                        break;
                    case "4":
                        int carIndexForTrips = ChooseCar();
                        if (carIndexForTrips != -1) // Hvis en gyldig bil er valgt
                        {
                            PrintAllTrips(carIndexForTrips);
                        }
                        break;
                    case "5":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
        // Metode til at tilføje en bil
        static void AddCar()
        {
            Console.WriteLine("\n--- Add a Car ---");
            Console.Write("Enter brand: ");
            string brand = Console.ReadLine();
            Console.Write("Enter model: ");
            string model = Console.ReadLine();
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter color: ");
            string color = Console.ReadLine();
            Console.Write("Enter license plate: ");
            string licensePlate = Console.ReadLine();
            Console.Write("Enter fuel type (Petrol, Diesel, Electric, Hybrid): ");
            FuelType fuelType = Enum.Parse<FuelType>(Console.ReadLine(), true);
            Console.Write("Enter first registration date (yyyy-MM-dd): ");
            DateTime firstRegistrationDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter gear type (Manual, Automatic): ");
            GearType gearType = Enum.Parse<GearType>(Console.ReadLine(), true);
            Console.Write("Enter km per liter: ");
            double kmPerLiter = double.Parse(Console.ReadLine());
            Car car = new Car(brand, model, year, color, licensePlate, fuelType, firstRegistrationDate,
           gearType, kmPerLiter);
            cars.Add(car);
            Console.WriteLine("Car added successfully!");
        }
        // Metode til at vælge en bil
        static int ChooseCar()
        {
            if (cars.Count == 0)
            {
                Console.WriteLine("No cars available. Please add a car first.");
                return -1; // Returner -1 for at indikere, at ingen bil er valgt
            }
            Console.WriteLine("\n--- Choose a Car ---");
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {cars[i].GetCarDetails()}");
            }
            Console.Write("Enter car number: ");
            int carIndex = int.Parse(Console.ReadLine()) - 1;
            if (carIndex < 0 || carIndex >= cars.Count)
            {
                Console.WriteLine("Invalid car selection.");
                return -1; // Returner -1 for at indikere, at ingen bil er valgt
            }
            return carIndex; // Returner det valgte bilindeks
        }
        // Metode til at tilføje en tur til en bil
        static void AddTrip(int carIndex)
        {
            Console.WriteLine("\n--- Add a Trip ---");
            Console.Write("Enter distance (km): ");
            double distance = double.Parse(Console.ReadLine());
            Console.Write("Enter trip date (yyyy-MM-dd): ");
            DateTime tripDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter start time (HH:mm): ");
            DateTime startTime = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter end time (HH:mm): ");
            DateTime endTime = DateTime.Parse(Console.ReadLine());
            Trip trip = new Trip(distance, tripDate, startTime, endTime);
            cars[carIndex].Drive(trip);
            Console.WriteLine("Trip added successfully!");
        }
        // Metode til at udskrive biloplysninger
        static void PrintCarDetails(int carIndex)
        {
            Console.WriteLine("\n--- Car Details ---");
            Console.WriteLine(cars[carIndex].GetCarDetails());
        }
        // Metode til at udskrive alle ture for en bil
        static void PrintAllTrips(int carIndex)
        {
            var trips = cars[carIndex].GetAllTrips();
            if (trips.Count == 0)
            {
                Console.WriteLine("No trips available for this car.");
                return;
            }
            Console.WriteLine($"\nTrips for car {cars[carIndex].GetCarDetails()}:");
            foreach (var trip in trips)
            {
                Console.WriteLine(trip.GetTripDetails());
            }
        }
    }
}
