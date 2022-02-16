using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Inventory
    {
        private int _capacity = 10;
        private List<FantasyWeapon> _items;

        public int Capacity
        {
            get { return _capacity; }
            set { if(value > 0) _capacity = value; }
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public List<FantasyWeapon> Items
        {
            get { return _items; }
            private set { _items = value; }
        }

        public Inventory(int capacity, List<FantasyWeapon> items)
        {
            //capacity = Capacity;//BACKWARDS!
            Capacity = capacity;
            Items = items;//will NOT clone
            Items = new List<FantasyWeapon>(items);//will clone
            Items = items.ToList();//will clone too!
        }

        public void AddItem(FantasyWeapon item)
        {
            if (Capacity == Count)
                throw new Exception("Inventory is full!");

            _items.Add(item);
        }

        public void PrintInventory()
        {
            foreach (FantasyWeapon weapon in _items)
            {
                Console.WriteLine($"I have a {weapon.Rarity} level {weapon.Level} weapon that can do {weapon.MaxDamage} damage and costs {weapon.Cost}");
                if (weapon is BowWeapon bow)
                    Console.WriteLine($"\tIt has {bow.ArrowCount} and can hold {bow.ArrowCapacity} arrows.");
            }
        }
    }
}
