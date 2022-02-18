using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Player
    {
        public FantasyWeapon Weapon { get; set; }
        public Inventory Backpack { get; set; }

        public void Attack()
        {
            if (Weapon is BowWeapon bow)
            {
                //if (Weapon is BowWeapon bow)//downcast
                {
                    bow.Shoot();
                }
            }
        }
    }
}
