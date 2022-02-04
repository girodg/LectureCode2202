using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Day03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TKey - string
            //TValue - float
            var menu = new Dictionary<string, float>()
            {
                {"Burger", 2.99F },//key-value pair
                {"Cheesy Burger", 3.49F }
            };

            //Add method
            //  if the key is already in the dictionary, throws an exception
            menu.Add("Fries", 1.99F);
            //Ctrl+K,S to surround
            try
            {
                menu.Add("Fries", 1.99F);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //[ ]
            //  if the key is already in the dictionary, does NOT throw an exception
            //      it will overwrite the value
            menu["Shake"] = 5.99F;
            //Console.OutputEncoding = Encoding.Unicode;
            //Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("de-DE");
            //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de-De");
            foreach (KeyValuePair<string,float> item in menu)
            {
                Console.WriteLine($"{item.Value,7:C2} {item.Key}");
            }




            Random randy = new();
            Dictionary<string, double> pg2 = new()
            {
                {"Mikhel", randy.NextDouble() * 100 },
                { "Ethan", randy.NextDouble() * 100 },
                { "Brandon", randy.NextDouble() * 100 },
                { "Terry", randy.NextDouble() * 100 }
            };
            pg2.Add("Damien", randy.NextDouble() * 100);
            pg2.Add("Christian", randy.NextDouble() * 100);
            pg2.Add("Stetson", randy.NextDouble() * 100);
            pg2.Add("Carter", randy.NextDouble() * 100);

            pg2["Logan"] = randy.NextDouble() * 100;
            pg2["Matthew"] = randy.NextDouble() * 100;
            pg2["Chase"] = randy.NextDouble() * 100;
            pg2["Tim"] = randy.NextDouble() * 100;
            pg2["Jacobo"] = randy.NextDouble() * 100;

            pg2["Brenden"] = randy.NextDouble() * 100;
            pg2["Riley"] = randy.NextDouble() * 100;
            pg2["Estela"] = randy.NextDouble() * 100;
            pg2["Jonathan"] = randy.NextDouble() * 100;
            pg2["Chi Hang"] = randy.NextDouble() * 100;
            pg2["Gabriel"] = randy.NextDouble() * 100;
            pg2["Kurtis"] = randy.NextDouble() * 100;
            pg2["Giovanny"] = randy.NextDouble() * 100;
            pg2["Austin"] = randy.NextDouble() * 100;
            pg2["EthanN"] = randy.NextDouble() * 100;
            pg2["Raymond"] = randy.NextDouble() * 100;
            pg2["Ryan"] = randy.NextDouble() * 100;

            PrintGrades(pg2);
            //looping
        }

        private static void PrintGrades(Dictionary<string, double> grades)
        {
            Console.WriteLine("-------------GRADES-----------");
            foreach (var student in grades)
            {
                string name = student.Key;
                double grade = student.Value;
                Console.Write($"{name,10} ");
                Console.ForegroundColor = (grade < 59.5) ? ConsoleColor.Red :
                                          (grade < 69.5) ? ConsoleColor.DarkYellow :
                                          (grade < 79.5) ? ConsoleColor.Yellow :
                                          (grade < 89.5) ? ConsoleColor.DarkGreen :
                                          ConsoleColor.Green;
                Console.WriteLine($"{grade,7:N2}");

                Console.ResetColor();
            }
        }
    }
}
