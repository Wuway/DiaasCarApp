using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaasCarApp
{
    public interface IEnergy
    {
        double EnergyLevel { get; }
        double MaxEnergy { get; }
        void Refill(double amount);
        void UseEnergy(double amount);
    }
}
