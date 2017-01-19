using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullshitRPG
{
    class Hero : Creature
    {
        public int Attack()
        {
            int damage = rndm.Next(1, 20);
            int critical = rndm.Next(10);

            if (critical >= 9)
            {
                damage *= 2;
                report = "CRITICAL!!! Hero attacked monster for " + damage + " damage!\r\n";
            }
            else
                report = "Hero attacked monster for " + damage + " damage!\r\n";

            return damage;
        }

        public void Heal()
        {
            int heal = rndm.Next(1,20);

            if ((hitPoints + heal) < 100)
            {
                hitPoints += heal + 1;
                report = "Hero was healed for " + heal + ".\r\n";
            }
            else
            { 
                hitPoints = 100;
                report = "Hero was healed to full health\r\n";
            }
        }
        public string Report()
        {
            return report;
        }
    }
}
