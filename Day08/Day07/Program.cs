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
            Truck cyber = new Truck(1000, 10000, "Tesla", "Cybertruck", ConsoleColor.Gray);

            //call the get on the property
            Console.WriteLine(myRide.Make);
            Console.WriteLine(myRide.Color);
            myRide.Color = ConsoleColor.DarkCyan;
            Console.WriteLine(myRide.Color);

            batmobile.CarDetails();//pass in batmobile as "this"
            myRide.CarDetails();

            Inventory backpack = new Inventory(5, new List<FantasyWeapon>());
            //backpack.AddItem("sword");
            //backpack.AddItem("staff");
            //backpack.AddItem("bow");
            //backpack.AddItem("potion");
            //backpack.AddItem("arrows");
            //try
            //{
            //    backpack.AddItem("cloak");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            FantasyWeapon sword = new FantasyWeapon(WeaponRarity.Legendary, 100, 5000, 100000);
            int damage = sword.DoDamage();
            Console.WriteLine($"I swing my sword (swish) and do {damage} points of damage to the rat.");

            FantasyWeapon fw = WeaponFactory.MakeWeapon(WeaponRarity.Rare, 20, 500, 10000);
            backpack.AddItem(sword);
            backpack.AddItem(fw);
            backpack.AddItem(new BowWeapon(10, 20, WeaponRarity.Common, 2, 20, 5));
            backpack.PrintInventory();

            int number = 5;
            float dNumber = number;//implicit casting
            number = (int)dNumber;//explicit casting

            Car tesla = myRide;
            //UPCASTING
            //always safe
            //car    truck
            myRide = cyber;//upcasting. from Truck to Car

            //DOWNCASTING
            //NOT SAFE!!
            //truck  car
            try
            {
                //explicit cast
                cyber = (Truck)batmobile;
            }
            catch (Exception ex)
            {
                Console.WriteLine("NOT A TRUCK!");
            }

            //use the "as" keyword
            //will set cyber to null if batmobile is not a truck
            cyber = batmobile as Truck;//will not throw an exception
            if(cyber != null)
                Console.WriteLine(cyber.TowingCapacity);

            //use pattern matching with the "is"
            if (batmobile is Truck trucky)
                Console.WriteLine(trucky.TowingCapacity);
        }
    }
}
