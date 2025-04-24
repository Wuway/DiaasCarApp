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
        public IEnergy car { get; set; }
        double StartPrice { get; set; }
        double PricePerKm { get; set; }
        double PricePerMinute { get; set; }
        bool MeterStarted { get; set; }
        public double EnergyLevel { get; set; }
        public double MaxEnergy { get; set; }

        public void Refill(double amount)
        {
            car.Refill(amount);
        }
        public void UseEnergy(double amount)
        {
            car.UseEnergy(amount);
        }

        public Taxi(/*double EnergyLevel, double MaxEnergy, */ IEnergy energy, double startPrice, double pricePerKm, double pricePerMinute) : base((energy as Car).Brand, (energy as Car).Model, (energy as Car).LicensePlate)
        {

            /*EnergyLevel = Car.EnergyLevel;
            MaxEnergy = Car.MaxEnergy;*/
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

       /* public override void UpdateEnergyLevel(double distance)
        {
        } */

        public override double CalculateConsumption(double distance)
        {
            return 0;
        }

    }
}
