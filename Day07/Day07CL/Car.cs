using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Car
    {
        //private: ONLY this class can use it
        //public: EVERYONE can use it
        //protected: this class and all my child classes, grandchild, etc
        #region Fields
        private ConsoleColor _color = ConsoleColor.Black; 
        #endregion

        #region Properties
        //a FULL property. It has a backing field
        public ConsoleColor Color
        {
            //same as: public ConsoleColor GetColor() {return _color;}
            get { return _color; }

            //same as: public void SetColor(ConsoleColor value) 
            //          { _color = value;}
            set
            {
                if (value != ConsoleColor.DarkYellow)
                    _color = value;
            }
        }

        //an auto-property. no backing field (the compiler gives us one)
        public string Make { get; private set; } = "Tesla";
        public string Model { get; set; }
        #endregion

        #region ctors
        public Car(string make, string model, ConsoleColor color)
        {
            Make = make;
            Model = model;
            Color = color;
        }
        #endregion

        //an INSTANCE method (non-static)
        public void CarDetails()//hidden parameter called "this"  (Car this)
        {
            ConsoleColor carColor = this._color;
            Console.WriteLine(carColor);
        }
    }
}
