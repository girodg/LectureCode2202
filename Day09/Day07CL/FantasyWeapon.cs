using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class FantasyWeapon
    {
        public WeaponRarity Rarity { get; set; }
        public int Level { get; set; }
        public int MaxDamage { get; set; }
        public int Cost { get; set; }

        //public int DoDamage()
        //{
        //    Random random = new Random();
        //    return (int)(MaxDamage * random.NextDouble());
        //}
        public int DoDamage(int enchantment = 0)
        {
            Random random = new Random();
            return (int)((MaxDamage+enchantment) * random.NextDouble());
        }

        public FantasyWeapon(WeaponRarity rarity, int level, int maxDamage, int cost)
        {
            Rarity = rarity;
            Level = level;
            MaxDamage = maxDamage;
            Cost = cost;
        }

        public virtual void Display()
        {
            Console.WriteLine($"I have a {Rarity} level {Level} weapon that can do {MaxDamage} damage and costs {Cost}");

        }
    }
}
