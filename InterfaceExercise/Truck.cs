using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {

        }

        public bool hasTrunk { get; set; } = true;
        public double EngineSize { get; set; } = 4.6;
        public string Make { get; set; } = "Jeep";
        public string Model { get; set; } = "Cherokee";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; }
        public string Motto { get; set; }
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; }

        public void Park()
        {
            if (HasChangedGears == true)
            {

                Console.WriteLine($"{GetType().Name} now parking . . . . . . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park until we change gears");
            }
        }
        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward . . . .");
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing . . . . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }
        }

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

    }
}