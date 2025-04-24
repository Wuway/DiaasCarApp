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
        double IEnergy.EnergyLevel { get; }
        double IEnergy.MaxEnergy { get; }
        public FuelCar(string brand, string model, string licensePlate, double fuelTankCapacity, double fuelConsumption, double EnergyLevel, double MaxEnergy) : base(brand, model, licensePlate)
        {
            this.FuelTankCapacity = fuelTankCapacity;
            this.FuelConsumption = fuelConsumption;
            EnergyLevel = CurrentFuel;
            MaxEnergy = FuelTankCapacity;
        }

        void IEnergy.Refill(double amount)
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
        void IEnergy.UseEnergy(double distance)
        {
            CurrentFuel = CurrentFuel - tripConsumption;
            double Odometer =+ distance;
        }

        public void refuel(double amount)
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
            if ((CurrentFuel - CalculateConsumption(distance)) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void UpdateEnergyLevel(double distance)
        {
            CurrentFuel = CurrentFuel - tripConsumption;
            double Odometer =+ distance;
        }

        public override double CalculateConsumption(double distance)
        {
            tripConsumption = distance / FuelConsumption;
            return tripConsumption;
        }
    }
    }

