using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace spore
{
    internal class mobilityevolutionmanager
    {
        private Dictionary<String, int> mobilityevolves = new Dictionary<String, int>();
        public mobilityevolutionmanager() {
            
               foreach(var evo in constants.abilities){
                if (!mobilityevolves.ContainsKey(evo.name))
                {
                    mobilityevolves.Add(evo.name, 0);

                }
                
            }
        }

        public List<mobilityevolution_ability> can_do_ability(List<mobilityevolution_ability> lst)
        {
            return lst.Where(x => x.count <= mobilityevolves[x.name]).ToList();
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
