using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public static class CarFactory
    {
        public static Car MakeCar(string make, string model, ConsoleColor color)
        {
            //Car newCar = new Car(make,model,color);
            return new Car(make, model, color);
        }
    }
}
