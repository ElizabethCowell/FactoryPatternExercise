using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    static class VehicleFactory
    {
        public static IVehicle VehicleType(string numberOfTires)
        {
            switch (numberOfTires)
            {
                case "4":
                case "four":
                    return new Car();
                case "2":
                case "two":
                    return new Motorcycle();
                default:
                    return new Empty();
            }
        }
    }
}
