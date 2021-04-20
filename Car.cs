using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("You drive a Car");
        }
    }
}
