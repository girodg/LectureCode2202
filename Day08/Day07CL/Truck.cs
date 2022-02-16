using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    //derived : base
    public class Truck : Car
    {
        public int BedSize { get; set; }
        public int TowingCapacity { get; set; }
        //my constructor needs to call a base constructor
        public Truck(int bedSize, int towingCapacity, string make, string model, ConsoleColor color) : 
            base(make,model,color)
        {
            BedSize = bedSize;
            TowingCapacity = towingCapacity;
            Console.WriteLine("\tTruck constructed");
        }
    }
}
