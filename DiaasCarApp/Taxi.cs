using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaasCarApp
{
    public class Taxi : Car
    {
        double StartPrice {get; set; }
        double PricePerKm {get; set; }
        double PricePerMinute {get; set; }
        bool MeterStarted {get; set; }
        
        public void StartMeter()
        {
        }

        public void StopMeter()
        {
        }

        public double CalculateFare(double distance, double minutes)
        {
            return = 0;
        }

        public override bool CanDrive()
        {
            return true;
        }

        public override void UpdateEnergyLevel(double distance)
        {
        }

        public override double CalculateConsumption(double distance)
        {
            return ;
        }

    }
}
