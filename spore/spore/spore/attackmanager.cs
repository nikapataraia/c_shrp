using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spore
{
    internal class attackmanager
    {
        private attackevolutionmanager attackevolutionmanager = new attackevolutionmanager();
        
        public attackmanager()
        {
            
        }

        public void addevolve(String evo)
        {
            attackevolutionmanager.addevolve(evo);
        }
        public int get_dmgoutput()
        {
            return (attackevolutionmanager.teethpower() + 1) * attackevolutionmanager.clawpower();
        }
    }
}
