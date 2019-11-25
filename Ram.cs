using System;

namespace InterfacesIntro
{
    public class Ram : IVehicle, IGasVehicle
    {
        public int FuelCapacity { get; set ; }
        public int FuelLevel { get; set; }

        public void Drive()
        {
            Console.WriteLine("VROOOOOOOM");
        }

        public void RefuelTank()
        {
            FuelLevel = FuelCapacity;
        }
    }
}