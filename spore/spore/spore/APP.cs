using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spore
{
    class APP
    {
        private Entity pray = new Pray();
        private Entity predator = new Predator();
        private evolution_map evo_map = new evolution_map();    
        public APP()
        {
            
        }

       
        public String fight()
        {
            while (true)
            {
                Boolean ispraydead = pray.take_a_hit(pray.attack());
                if (ispraydead)
                {
                    return "Some R-rated things have happened";
                }

                Boolean ispredatordead = predator.take_a_hit(predator.attack());
                if (ispredatordead)
                {
                    return "Pray ran into infinity";
                }
                
            }
        }
        public String play()
        {
            while (predator.has_stamina())
            {
                if(predator.get_location() >= pray.get_location())
                {
                    return fight();
                }
                move_phase();
            }
           
            return "Pray ran into infinity";
        }

        public void move_phase()
        {
            if (predator.has_stamina())
            {
                predator.move();
                int predator_loc = predator.get_location();
                if (evo_map.check_location(predator_loc))
                {
                    predator.add_evolve(evo_map.get_evolution(predator_loc));
                }
            }

            if (pray.has_stamina())
            {
                pray.move();
                int pray_loc = pray.get_location();
                if (evo_map.check_location(pray_loc))
                {
                    pray.add_evolve(evo_map.get_evolution(pray_loc));
                }
            }
        }

        public void restart_game()
        {
            pray = new Pray();
            predator = new Predator();
            evo_map.restart();
        }
    }
}
