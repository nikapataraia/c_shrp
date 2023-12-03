using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spore
{
    internal class APP
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
                Boolean ispredatordead = predator.take_a_hit(predator.attack());
                if(ispraydead && ispredatordead)
                {
                    return "both died";
                }
                if (ispraydead)
                {
                    return "Some R-rated things have happened";
                }
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
                predator.move();
                pray.move();
            }
           
            return "Pray ran into infinity";
        }

        public void restart_game()
        {
            pray = new Pray();
            predator = new Predator();
        }
    }
}
