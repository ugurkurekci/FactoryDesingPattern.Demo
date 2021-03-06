using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Example2
{
    public class ConcreteVehicleFactory : VehicleFactory
    {
        public override IFactory GetColor(string VehicleColor)
        {
            switch (VehicleColor)
            {
                case "Scooter":
                    return new Scooter();
                case "Bike":
                    return new Bike();

                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", VehicleColor));
            }
        }

        public override IFactory GetVehicle(string Vehicle)
        {
            switch (Vehicle)
            {
                case "Scooter":
                    return new Scooter();
                case "Bike":
                    return new Bike();

                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Vehicle));
            }
        }

    }
}
