using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spore
{
    internal class attackevolutionmanager
    {
        private Dictionary<String, int> attackevolves = new Dictionary<String, int>();
        public attackevolutionmanager()
        {
            foreach (var evo in constants.abilities)
            {
                attackevolves.Add(evo.name, 0);
            }
            attackevolves["claw"] += 1;
        }

        public int clawpower()
        {
            return attackevolves["claw"];
        }

        public int teethpower()
        {
            return attackevolves["teeth"] * 3;
        }

        public void addevolve(String evo)
        {
            if (attackevolves.ContainsKey(evo))
            {
                attackevolves[evo] += 1;
            }
        }
    }
}
