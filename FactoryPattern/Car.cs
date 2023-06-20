using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Car : IVehicle
    {

    

        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The Car is driving!");
        }
    }
}
