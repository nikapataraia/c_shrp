using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spore
{
    internal class staminamanager
    {
        private int stamina { get; set; }
        public staminamanager() {
            Random random = new Random();
            this.stamina = random.Next(50, 151);
        }
        public int getstamina()
        {
            return stamina;
        }

        public List<mobilityevolution_ability> can_do_ability(List<mobilityevolution_ability> lst)
        {
            return lst.Where(x => x.stamina_requirment < stamina).ToList();
        }
        public void do_ability(int stm)
        {
            stamina -= stm;
        }
    }
}
