using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spore
{
    internal class Entity
    {
        private mobilitymanager mobilitymanager { get; set; }
        private attackmanager attackmanager { get; set; }
       
        public Entity(int location)
        {
            Random random = new Random();
            this.mobilitymanager = new mobilitymanager(location,random);
            this.attackmanager = new attackmanager(random);
        }

        
    }
}
