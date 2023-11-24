using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spore
{
    internal class mobilitymanager
    {
        private int location { get; set; }
        private staminamanager staminamanager { get; set; } = new staminamanager();
        public mobilitymanager(int location,Random random)
        {
            this.location = location;
        }
        public mobilitymanager(Random random)
        {
            this.location = 0;
        }
       
    }
}
