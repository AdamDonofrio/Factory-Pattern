using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ThreeWheeler : IVehicle
    {

        public ThreeWheeler() 
        {
            
        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("Let's get going on three wheel drive");
        }
    }
}
