using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task.Properties.Vehicle;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.StartEngine();
            car.Accelerate();

            Truck truck = new Truck();
            truck.StartEngine();
            truck.Accelerate();
        }
    }
}
