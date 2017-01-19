using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullshitRPG
{
    class Creature
    {
        public int hitPoints = 100;
        public string report = "";

        public Random rndm = new Random(DateTime.Now.Millisecond);

        public void TakeDamage(int damage)
        {

            if ((hitPoints -= damage) <= 0)
                hitPoints = 0;
            else
                hitPoints -= damage;
        }

        public string CurrentHP()
        {
            string currentHitPoints;

            currentHitPoints = hitPoints.ToString();

            return currentHitPoints;
        }

    }
}
