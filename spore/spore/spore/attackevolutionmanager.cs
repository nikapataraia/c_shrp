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
                if(evo is attackevolution_ability) {
                    attackevolves.Add(evo.name, 0);
                }
            }
        }

        public int mult_power()
        {
            List<attackevolution_mult_ability> mult_abilities = constants.abilities.OfType<attackevolution_mult_ability>().ToList();
            List<int> multies = new List<int>();
            foreach(var element in attackevolves)
            {
                if(element.Value > 0)
                {
                    List<attackevolution_mult_ability> selected = mult_abilities.Where(x => x.name == element.Key).ToList();
                    var selectedElement = selected.OrderByDescending(x => x.count).FirstOrDefault(x => x.count == element.Value);

                    if (selectedElement == null)
                    {
                        selectedElement = selected.OrderByDescending(x => x.count).FirstOrDefault();
                    }
                    multies.Add(selectedElement.improvement);
                }
                
            }
            if (multies == null || !multies.Any())
            {
                return 1; 
            }
            return multies.Aggregate(1, (result, x) => result * x);

        }

        public int add_power()
        {
            List<attackevolution_add_ability> add_abilities = constants.abilities.OfType<attackevolution_add_ability>().ToList();
            List<int> additions = new List<int>();

            foreach (var element in attackevolves)
            {
                if (element.Value > 0)
                {
                    List<attackevolution_add_ability> selected = add_abilities.Where(x => x.name == element.Key).ToList();
                    var selectedElement = selected.OrderByDescending(x => x.count).FirstOrDefault(x => x.count == element.Value);

                    if (selectedElement == null)
                    {
                        selectedElement = selected.OrderByDescending(x => x.count).FirstOrDefault();
                    }

                    additions.Add(selectedElement.improvement);
                }
            }
            if (additions == null || !additions.Any())
            {
                return 0;
            }
            return additions.Sum();
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
