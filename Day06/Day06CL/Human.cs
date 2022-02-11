using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06CL
{
    public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Eat(string food)
        {

        }
        public void BlowStuffUp()
        {

        }

        public Human(string name, int age)
        {
            NumberOfHumans++;
            Name = name;
            Age = age;
        }

        public static Human Birth()
        {
            return new Human("Bruce Wayne", 35);
        }

        public static int NumberOfHumans { get; set; }
    }
}
