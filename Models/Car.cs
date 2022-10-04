using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Car
    {
        public Car()
        {

        }
        public Car(int enginePower, int doors, int wheels, int trunkCapacity, int seats, int windows)
        {
            EnginePower = enginePower;
            Doors = doors;
            Wheels = wheels;
            TrunkCapacity = trunkCapacity;
            Seats = seats;
            Windows = windows;
        }

        public int EnginePower { get; set; }
        public int Doors { get; set; }
        public int Wheels { get; set; }
        public int TrunkCapacity { get; set; }
        public int Seats { get; set; }
        public int Windows { get; set; }
    }
}
