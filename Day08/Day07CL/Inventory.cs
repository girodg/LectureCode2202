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
        private List<string> _items;

        public int Capacity
        {
            get { return _capacity; }
            set { if(value > 0) _capacity = value; }
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public List<string> Items
        {
            get { return _items; }
            private set { _items = value; }
        }

        public Inventory(int capacity, List<string> items)
        {
            //capacity = Capacity;//BACKWARDS!
            Capacity = capacity;
            Items = items;//will NOT clone
            Items = new List<string>(items);//will clone
            Items = items.ToList();//will clone too!
        }

        public void AddItem(string item)
        {
            if (Capacity == Count)
                throw new Exception("Inventory is full!");

            _items.Add(item);
        }
    }
}
