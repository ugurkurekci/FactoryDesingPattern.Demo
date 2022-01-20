using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Example2
{
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string Vehicle);
        public abstract IFactory GetColor(string VehicleColor);
    }
}
