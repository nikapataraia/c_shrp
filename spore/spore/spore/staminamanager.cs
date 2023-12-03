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

        public Boolean can_crawl()
        {
            return stamina >= 1;
        }
        public Boolean can_hop()
        {
            return stamina >= 20;
        }
        public Boolean can_walk()
        {
            return stamina >= 40;
        }
        public Boolean can_run()
        {
            return stamina >= 60;
        }
        public Boolean can_fly()
        {
            return stamina >= 80;
        }
        public void crawl()
        {
            stamina -= 1;
        }
        public void hop()
        {
            stamina -= 2;
        }
        public void walk()
        {
            stamina -= 2;
        }
        public void run()
        {
            stamina -= 4;
        }
        public void fly()
        {
            stamina -= 4;
        }
    }
}
