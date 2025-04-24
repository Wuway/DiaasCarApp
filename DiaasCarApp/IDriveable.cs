using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaasCarApp
{
    public interface IDriveable
    {
        public void StartEngine();
        public void StopEngine();
        public void Drive(double distance);
        public void CanDrive(double distance);
    }
}
