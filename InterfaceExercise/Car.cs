using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {

        }
        public bool hasTrunk { get; set; } = true;
        public bool hasSunRoof { get; set; } = true;
        public double EngineSize { get; set; } = 4.2;
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Camry";
        public string CompanyName { get; set; }
        public string Motto { get; set; }
        public int SeatCount { get; set; } = 4;
        public bool HasChangedGears { get; set; }

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

