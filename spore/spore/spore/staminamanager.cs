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
            this.stamina = random.Next(50, 101);
        }
        public int getstamina()
        {
            return stamina;
        }

    }
}
