using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DiaasCarApp
{
    public class Taxi : Car, IEnergy
    {
        double StartPrice {get; set; }
        double PricePerKm {get; set; }
        double PricePerMinute {get; set; }
        bool MeterStarted {get; set; }
        double IEnergy.EnergyLevel { get; }
        double IEnergy.MaxEnergy { get; }

        void IEnergy.Refill(double amount)
        { }
        void IEnergy.UseEnergy(double amount)
        { }

        public Taxi(string brand, string model, string licensePlate, double startPrice, double pricePerKm, double pricePerMinute) : base(brand, model, licensePlate)
        {
            StartPrice = startPrice;
            PricePerKm = pricePerKm;
            PricePerMinute = pricePerMinute;
        }

        public override void Drive(double distance)
        {
            if (isEngineOn)
            {
                Console.WriteLine("Du kan godt køre.");
            }
        }

        public void StartMeter()
        {
            MeterStarted = true;
        }

        public void StopMeter()
        {
            MeterStarted = false;
        }

        public double CalculateFare(double distance, double minutes)
        {
            return (distance * PricePerKm) + (minutes * PricePerMinute);
        }

        public override bool CanDrive(double distance)
        {
            return true;
        }

        public override void UpdateEnergyLevel(double distance)
        {
        }

        public override double CalculateConsumption(double distance)
        {
            return 0;
        }

    }
}
