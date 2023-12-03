using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spore
{
    internal class mobilitymanager
    {
        private int location;
        private staminamanager staminamanager { get; set; } = new staminamanager(); 
        private mobilityevolutionmanager mobilityevolutionmanager { get; set; } = new mobilityevolutionmanager();

        
        public mobilitymanager(int location,Random random)
        {
            this.location = location;
           
        }
        public int get_location()
        {
            return location;
        }
        public Boolean has_stamina()
        {
            return staminamanager.getstamina() > 0;
        }

        public void optimal_move()
        {
            if(mobilityevolutionmanager.can_fly() && staminamanager.can_fly())
            {
                staminamanager.fly();
                location += 8;
                return;
            }
            if(mobilityevolutionmanager.can_walk_or_run() && staminamanager.can_run())
            {
                staminamanager.run();
                location += 6;
                return;
            }
            if(mobilityevolutionmanager.can_walk_or_run() && staminamanager.can_walk())
            {
                staminamanager.walk();
                location += 4;
                return;
            }
            if(mobilityevolutionmanager.can_hop() && staminamanager.can_hop())
            {
                staminamanager.hop();
                location += 3;
                return;
            }
            if (staminamanager.can_crawl())
            {
                staminamanager.crawl();
                location += 1;
                return;
            }
        }
       
    }
}
