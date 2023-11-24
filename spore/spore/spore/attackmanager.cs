using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spore
{
    internal class attackmanager
    {
        private int health { get; set; }
        public attackmanager(Random random)
        {
            this.health = random.Next(50, 101);

        }
    }
}
