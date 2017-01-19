using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullshitRPG
{
    class Monster : Creature
    {
        public int Attack()
        {
            int damage = rndm.Next(1, 20);
            int multiStrike = rndm.Next(5);

            if (multiStrike == 4)
                while (multiStrike == 4)
                {
                    damage += damage;
                    multiStrike = rndm.Next(5);
                    report += "Monster attacked hero for " + damage + " damage!\r\n";
                    return damage;
                }
            else
                report = "Monster attacked hero for " + damage + " damage!\r\n";
                return damage;
        }

        public int Heal()
        {
            Random healRand = new Random();
            int getHealed = healRand.Next(2);

            if (getHealed == 1)
            {
                int heal = rndm.Next(1,10);
                if ((hitPoints + heal) < 100)
                {
                    hitPoints += heal;
                    report = "Monster was healed for " + heal + ".\r\n";
                }
                else
                {
                    hitPoints = 100;
                    report = "Monster was healed to full health\r\n";
                }
                return 0;
            }
            else
            {
                return Attack() + 1;
            }

        }

        public string Report()
        {
            return report;
        }
    }
}
