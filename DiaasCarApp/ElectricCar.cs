using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaasCarApp
{
    public class ElectricCar : Car, IEnergy
    {
        public double _batteryCapacity; // i kWh
        public double kWHPerKm; // i kWh/km
        public double _currentCharge; // i kWh
        public double tripConsumption;
        public double distance;
        double IEnergy.EnergyLevel { get; }
        double IEnergy.MaxEnergy { get; }
        public ElectricCar(string brand, string model, string licensePlate, double batteryCapacity, double kWHPerKm, double EnergyLevel, double MaxEnergy) : base(brand, model, licensePlate)
        {
            _batteryCapacity = batteryCapacity;
            this.kWHPerKm = kWHPerKm;
            EnergyLevel = _currentCharge;
            MaxEnergy = _batteryCapacity;
        }

        void IEnergy.Refill(double amount)
        {
            if (amount > 0)
            {
                _currentCharge += amount;
                if (_currentCharge > _batteryCapacity)
                {
                    _currentCharge = _batteryCapacity; // Maksimal kapacitet
                }
            }
            else
            {
                Console.WriteLine("Invalid charge amount.");
            }
        }

        void IEnergy.UseEnergy(double amount)
            {
                _currentCharge = _currentCharge - tripConsumption;
            }

        public void Charge(double amount)
        {
            if (amount > 0)
            {
                _currentCharge += amount;
                if (_currentCharge > _batteryCapacity)
                {
                    _currentCharge = _batteryCapacity; // Maksimal kapacitet
                }
            }
            else
            {
                Console.WriteLine("Invalid charge amount.");
            }
        }
    public override void Drive(double distance)
        {
            if (_currentCharge > 0)
            {
                Console.WriteLine("Driving the electric car.");
                _currentCharge -= kWHPerKm; // Forbrug pr. km
                UpdateOdometer(distance);
            }
            else
            {
                Console.WriteLine("Battery is empty. Cannot drive.");
            }
        }
        public override bool CanDrive(double distance)
        {
            if ((_currentCharge - CalculateConsumption(distance)) >= 0)
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
            _currentCharge = _currentCharge - tripConsumption;
        }

        public override double CalculateConsumption(double distance)
        {
            tripConsumption = distance * kWHPerKm;
            return tripConsumption;
        }



    }
}
