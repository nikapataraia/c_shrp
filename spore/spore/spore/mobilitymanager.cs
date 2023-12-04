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

        public mobilityevolution_ability optimal_move()
        {
            List<mobilityevolution_ability> mobilityEvolutions = constants.abilities.OfType<mobilityevolution_ability>().ToList();
            List<mobilityevolution_ability> av_moves = available_moves(mobilityEvolutions);
            return av_moves.OrderByDescending(m => m.speed).FirstOrDefault();
            
        }

        public List<mobilityevolution_ability> available_moves(List<mobilityevolution_ability> mobilityevolutions)
        {
            List<mobilityevolution_ability> enough_stamina_for = staminamanager.can_do_ability(mobilityevolutions);
            List<mobilityevolution_ability> available_moves = mobilityevolutionmanager.can_do_ability(enough_stamina_for);
            return available_moves;
        }

        public void make_optimal_move()
        {
            mobilityevolution_ability chosen_move = optimal_move();
            staminamanager.do_ability(chosen_move.stamina_cost);
            location += chosen_move.speed;
        }
       
    }
}
