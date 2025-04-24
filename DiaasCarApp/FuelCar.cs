using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DiaasCarApp
{
    public class FuelCar : Car, IEnergy
    {
        public double FuelTankCapacity; // i liter
        public double FuelConsumption; // i liter/km
        public double CurrentFuel; // i liter
        public double tripConsumption;
        public double EnergyLevel { get; est}
        public double MaxEnergy { get; }
        public FuelCar(string brand, string model, string licensePlate, double EnergyLevel, double MaxEnergy) : base(brand, model, licensePlate)
        {
            EnergyLevel = CurrentFuel;
            MaxEnergy = FuelTankCapacity;
        }

        public void Refill(double amount)
        {
            if (amount > 0)
            {
                CurrentFuel += amount;
                if (CurrentFuel > FuelTankCapacity)
                {
                    CurrentFuel = FuelTankCapacity; // Maksimal kapacitet
                }
            }
            else
            {
                Console.WriteLine("Invalid refuel amount.");
            }
        }
        public void UseEnergy(double distance)
        {
            CurrentFuel = CurrentFuel - tripConsumption;
            double Odometer =+ distance;
        }

        public override void Drive(double distance)
        {
            double Tripdistance = distance / FuelConsumption;

            if (CurrentFuel >= Tripdistance)
            {
                Console.WriteLine("Driving the fuel car.");
                CurrentFuel -= FuelConsumption; // Forbrug pr. km
                UpdateOdometer(distance);
            }
            else
            {
                Console.WriteLine("Fuel tank is empty. Cannot drive.");
            }
        }

        public override bool CanDrive(double distance)
        {
            return (CurrentFuel - CalculateConsumption(distance)) >= 0; // Check if the car can drive the given distance

            /*if ((CurrentFuel - CalculateConsumption(distance)) >= 0)
            {
                return true;
            }*/
        }

        public override double CalculateConsumption(double distance)
        {
            tripConsumption = distance / FuelConsumption;
            return tripConsumption;
        }
    }
    }

