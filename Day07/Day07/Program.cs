using Day07CL;
using System;
using System.Collections.Generic;

namespace Day07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myRide = new Car("Tesla", "Model 3", ConsoleColor.White);
            Car batmobile = new Car("Mach", "1", ConsoleColor.Black);
            //call the set on the property
            myRide.Color = ConsoleColor.DarkYellow;

            //call the get on the property
            Console.WriteLine(myRide.Make);
            Console.WriteLine(myRide.Color);
            myRide.Color = ConsoleColor.DarkCyan;
            Console.WriteLine(myRide.Color);

            batmobile.CarDetails();//pass in batmobile as "this"
            myRide.CarDetails();

            Inventory backpack = new Inventory(5, new List<string>());
            backpack.AddItem("sword");
            backpack.AddItem("staff");
            backpack.AddItem("bow");
            backpack.AddItem("potion");
            backpack.AddItem("arrows");
            try
            {
                backpack.AddItem("cloak");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            FantasyWeapon sword = new FantasyWeapon(WeaponRarity.Legendary, 100, 5000, 100000);
            int damage = sword.DoDamage();
            Console.WriteLine($"I swing my sword (swish) and do {damage} points of damage to the rat.");
        }
    }
}
