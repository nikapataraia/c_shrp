using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spore
{
    internal class mobilityevolutionmanager
    {
        private Dictionary<String, int> mobilityevolves = new Dictionary<String, int>();
        public mobilityevolutionmanager() {
               foreach(var evo in constants.mobilityEvolutions){
                mobilityevolves.Add(evo, 0);
            }
        }

        public Boolean can_hop()
        {
            return mobilityevolves["leg"] >= 1;
        }
        public Boolean can_walk_or_run()
        {
            return mobilityevolves["leg"] >= 2;
        }
        public Boolean can_fly()
        {
            return mobilityevolves["wing"] >= 2;
        }

        public void addevolve(String evo)
        {
            if (mobilityevolves.ContainsKey(evo)) 
            { 
                mobilityevolves[evo] += 1; 
            }
        }

    }
}
