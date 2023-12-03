using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spore
{
    internal class defensemanager
    {
        private int health { get; set; }
        public defensemanager(Random random)
        {
            this.health = random.Next(50, 101);

        }
        public int gethealth()
        {
            return health;
        }
        public Boolean take_dmg(int dmg)
        {
            if(health <= dmg)
            {
                return false;
            }
            health -= dmg;
            return true;
        }
    }
}
