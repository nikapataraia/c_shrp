using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spore
{
    internal class evolutionmanager
    {
        private Dictionary<evolutions, int> body = new Dictionary<evolutions, int>
    {
        { evolutions.leg, 0 },
        { evolutions.wing, 0 },
        { evolutions.claw, 0 },
        { evolutions.teeth, 0 }
    };

        public Dictionary<evolutions, int> getevolutions()
        {
            return body;
        }

        public void addevolution(evolutions evolutionType)
        {
            if (body.ContainsKey(evolutionType))
            {
                body[evolutionType]++;
            }
            else
            {
                Console.WriteLine("Unknown evolution type");
            }
        }
    }
}
