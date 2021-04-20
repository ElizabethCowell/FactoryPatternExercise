using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires does your vehicle have?");

            var response = Console.ReadLine();

            var drive = VehicleFactory.VehicleType(response);

            drive.Drive();
        }
    }
}
