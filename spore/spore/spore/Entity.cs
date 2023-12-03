using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spore
{
    internal class Entity
    {
        private mobilitymanager mobilitymanager { get; set; }
        private attackmanager attackmanager { get; set; }
        private defensemanager defensemanager { get; set; } 
       
        public Entity(int location)
        {
            Random random = new Random();
            this.mobilitymanager = new mobilitymanager(location,random);
            this.attackmanager = new attackmanager();
            this.defensemanager = new defensemanager(random);
        }

        public int attack()
        {
            return attackmanager.get_dmgoutput();
        }
        public Boolean take_a_hit(int damage)
        {
            return defensemanager.take_dmg(damage);
        }
        public void move()
        {
            mobilitymanager.optimal_move();
        }
        public int get_location()
        {
            return mobilitymanager.get_location();
        }

        public Boolean has_stamina()
        {
            return mobilitymanager.has_stamina();
        }

        public int gethealth()
        {
            return defensemanager.gethealth();
        }

        
    }
}
